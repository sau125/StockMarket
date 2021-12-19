import { Component, OnInit } from '@angular/core';
import { StockExchange } from 'src/app/Models/stock-exchange';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-update-exchange',
  templateUrl: './update-exchange.component.html',
  styleUrls: ['./update-exchange.component.css']
})
export class UpdateExchangeComponent implements OnInit {

  exchange:StockExchange;
  constructor(private adminService:AdminService) {
    this.exchange=new StockExchange();
    let exchangeName=localStorage['stockExchangeName'];
    this.adminService.GetExchangeByName(exchangeName).subscribe(response=>{
      this.exchange=response;
      console.log(this.exchange);
  });

   }

  ngOnInit(): void {
  }
  Edit(){
    console.log(this.exchange);
    this.adminService.UpdateExchange(this.exchange).subscribe(response=>{

    });
  }
}
