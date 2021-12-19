import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators} from '@angular/forms';
import { StockExchange } from 'src/app/Models/stock-exchange';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-add-exchange',
  templateUrl: './add-exchange.component.html',
  styleUrls: ['./add-exchange.component.css']
})
export class AddExchangeComponent implements OnInit {
  exchangeForm: FormGroup;
  submitted = false;
exchange:StockExchange;
  constructor(private formBuilder: FormBuilder,private adminService:AdminService) {
    this.exchange=new StockExchange();
   }

  ngOnInit(): void {
    this.exchangeForm = this.formBuilder.group({
      id: ['', Validators.required],
      stockexchangename: ['', Validators.required],
      brief: ['', [Validators.required]],
      contactaddress:['', [Validators.required]],
      remarks: ['', [Validators.required]]

  });
  }
  onSubmit() {
    this.submitted = true;
    if (this.exchangeForm.valid) {
      this.exchange.id=this.exchangeForm.value["id"]
      this.exchange.stockExchangeName=this.exchangeForm.value["stockexchangename"]
      this.exchange.brief=(this.exchangeForm.value["brief"])
      this.exchange.contactAddress=this.exchangeForm.value["contactaddress"]
      this.exchange.remarks=this.exchangeForm.value["remarks"]
     
      this.adminService.AddExchange(this.exchange).subscribe(response=>{
      })
}
}

onReset() {
    this.submitted = false;
    this.exchangeForm.reset();
}
}
