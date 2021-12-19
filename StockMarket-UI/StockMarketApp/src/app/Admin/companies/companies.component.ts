import { Component, OnInit } from '@angular/core';
import { Company } from 'src/app/Models/company';
import { AdminService } from 'src/app/services/admin.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-companies',
  templateUrl: './companies.component.html',
  styleUrls: ['./companies.component.css']
})
export class CompaniesComponent implements OnInit {
companies:Company[]
  constructor(private adminService:AdminService,private router:Router) {
    this.adminService.GetAllCompanies().subscribe(response=>{
      this.companies=response;
    });
    
   }

  ngOnInit(): void {
  }
  GetCompany(Name:string)
  {
    localStorage['CompanyName']=Name;
    console.log(Name);
    this.router.navigateByUrl('/edit-company');
  }
  DeleteCompany(name:string)
  {
    console.log(name);
    this.adminService.DeleteCompany(name).subscribe(response=>{

    });
    this.router.navigateByUrl('/viewallcompanies')
  }
}
