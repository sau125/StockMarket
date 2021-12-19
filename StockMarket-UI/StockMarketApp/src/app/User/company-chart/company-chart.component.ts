import { Component, OnInit } from '@angular/core';
import { Chart } from 'chart.js';  
import { Company } from 'src/app/Models/company';
import { AdminService } from 'src/app/services/admin.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-company-chart',
  templateUrl: './company-chart.component.html',
  styleUrls: ['./company-chart.component.css']
})
export class CompanyChartComponent implements OnInit {
  
  companies:Company[];
  data: Company[];  
  companyName = [];  
  turnover = [];  
  Linechart = [];

  constructor(private adminService:AdminService,private router:Router) {
    this.adminService.GetAllCompanies().subscribe(response=>{
      this.companies=response;
    });
    
   }
  ngOnInit() {
    // this.adminService.GetAllCompanies().subscribe((result: Company[]) => {  
    //   result.forEach(x => { 
    //   if (x.listedInStockExchanges.includes('')){
    //     this.companyName.push(x.companyName);  
    //     this.turnover.push(x.turnover);  
    //   }});   
    //   this.Linechart = new Chart('canvas', {  
    //     type: 'line',  
    //     data: {  
    //       labels: this.companyName,  
  
    //       datasets: [  
    //         {  
    //           data: this.turnover,  
    //           borderColor: '#3cb371',  
    //           backgroundColor: "#0000FF",  
    //         }  
    //       ]  
    //     },  
    //     options: {  
  
    //     }  
    //   });  
    // });
  }

}
