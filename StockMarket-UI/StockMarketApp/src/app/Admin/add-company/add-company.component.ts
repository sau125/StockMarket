import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators} from '@angular/forms';
import { Company } from 'src/app/Models/company';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-add-company',
  templateUrl: './add-company.component.html',
  styleUrls: ['./add-company.component.css']
})
export class AddCompanyComponent implements OnInit {
  companyForm: FormGroup;
  submitted = false;
company:Company;
  constructor(private formBuilder: FormBuilder,private adminService:AdminService) {
    this.company=new Company();
   }

  ngOnInit(): void {
    this.companyForm = this.formBuilder.group({
      companyname: ['', Validators.required],
      turnover: ['', [Validators.required]],
      boardofdirectors:['', [Validators.required]],
      listedinexchanges: ['', [Validators.required]],
      brief:['',[Validators.required]],
      ceo:['',[Validators.required]],
      sectorid:['',[Validators.required]],
      companycode:['',[Validators.required]]
  });
  }
  onSubmit() {
       this.submitted = true;
       if (this.companyForm.valid) {
         this.company.companyName=this.companyForm.value["companyname"]
         this.company.turnover=this.companyForm.value["turnover"]
         this.company.listedInStockExchanges=(this.companyForm.value["listedinexchanges"])
         this.company.companyBrief=this.companyForm.value["brief"]
         this.company.ceo=this.companyForm.value["ceo"]
         this.company.sectorID=this.companyForm.value["sectorid"]
         this.company.companyCode=this.companyForm.value["companycode"]
         this.company.boardOfDirectors=this.companyForm.value["boardofdirectors"]
        
         this.adminService.AddCompany(this.company).subscribe(response=>{
         })
   }
 }
 
   onReset() {
       this.submitted = false;
       this.companyForm.reset();
   }

}
