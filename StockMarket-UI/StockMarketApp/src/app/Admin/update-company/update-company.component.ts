import { Component, OnInit } from '@angular/core';
import { Company } from 'src/app/Models/company';
import { AdminService } from 'src/app/services/admin.service';

@Component({
  selector: 'app-update-company',
  templateUrl: './update-company.component.html',
  styleUrls: ['./update-company.component.css']
})
export class UpdateCompanyComponent implements OnInit {
company:Company;
  constructor(private adminService:AdminService) {
    this.company=new Company();
    let companyName=localStorage['CompanyName'];
    this.adminService.GetCompanyByName(companyName).subscribe(response=>{
      this.company=response
      console.log(this.company);
  });

   }
  

  ngOnInit(): void {
  }
  Edit(){
    console.log(this.company);
    this.adminService.UpdateCompany(this.company).subscribe(response=>{

    });
  }
}
