import { Component, OnInit } from '@angular/core';
import { StockExchange } from 'src/app/Models/stock-exchange';
import { AdminService } from 'src/app/services/admin.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-exchanges',
  templateUrl: './exchanges.component.html',
  styleUrls: ['./exchanges.component.css']
})
export class ExchangesComponent implements OnInit {
  
  exchanges:StockExchange[];
  constructor(private adminService:AdminService,private router:Router) {
    this.adminService.GetAllExchanges().subscribe(response=>{
      this.exchanges=response;
    });
    
   }

  ngOnInit(): void {
  }
  GetExchange(Name:string)
  {
    localStorage['stockExchangeName']=Name;
    console.log(Name);
    this.router.navigateByUrl('/edit-exchange');
  }
  DeleteExchange(name:string)
  {
    console.log(name);
    this.adminService.DeleteExchange(name).subscribe(response=>{

    });
    this.router.navigateByUrl('/viewallexchanges')
  }
}
