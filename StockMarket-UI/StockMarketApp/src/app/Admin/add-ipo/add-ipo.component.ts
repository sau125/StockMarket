import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators} from '@angular/forms';
import { IpoDetails } from 'src/app/Models/ipo-details';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-add-ipo',
  templateUrl: './add-ipo.component.html',
  styleUrls: ['./add-ipo.component.css']
})
export class AddIpoComponent implements OnInit {

  ipoForm: FormGroup;
  submitted = false;
ipo:IpoDetails;
  constructor(private formBuilder: FormBuilder,private adminService:AdminService) {
    this.ipo=new IpoDetails();
   }

  ngOnInit(): void {
    this.ipoForm = this.formBuilder.group({
      id: ['', Validators.required],
      stockexchangecode: ['', Validators.required],
      pricepershare:['', [Validators.required]],
      totalshare: ['', [Validators.required]],
      companyid: ['', [Validators.required]],
      remarks: ['', [Validators.required]]

  });
  }
  onSubmit() {
    this.submitted = true;
    if (this.ipoForm.valid) {
      this.ipo.id=this.ipoForm.value["id"]
      this.ipo.stockExchangeCode=this.ipoForm.value["stockexchangecode"]
      this.ipo.pricePerShare=(this.ipoForm.value["pricepershare"])
      this.ipo.totalShare=this.ipoForm.value["totalshare"]
      this.ipo.companyId=this.ipoForm.value["companyid"]
      this.ipo.remarks=this.ipoForm.value["remarks"]
      this.adminService.AddIpo(this.ipo).subscribe(response=>{
      })
}
}

onReset() {
    this.submitted = false;
    this.ipoForm.reset();
}

}
