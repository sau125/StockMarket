import { Component, OnInit } from '@angular/core';
import { IpoDetails } from 'src/app/Models/ipo-details';
import { UserService } from 'src/app/services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-ipos',
  templateUrl: './ipos.component.html',
  styleUrls: ['./ipos.component.css']
})
export class IPOsComponent implements OnInit {

  ipoDetails:IpoDetails[];
  constructor(private userService:UserService,private router:Router) {
    this.userService.GetAllIpos().subscribe(response=>{
      this.ipoDetails=response;
    });
    
   }

  ngOnInit(): void {
  }

}
