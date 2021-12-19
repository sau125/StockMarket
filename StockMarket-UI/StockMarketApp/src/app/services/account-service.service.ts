import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { User } from '../Models/user';
import { Login } from '../Models/login';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AccountServiceService {
 // account_url=environment.account_url;
 account_url='http://localhost:49734/api/Account/';
  constructor(private http:HttpClient) { }
  public Register(user:User):Observable<any>
  {
    //console.log(this.account_url);

    return this.http.post(this.account_url+"Register",user);
  }
  public Login(login:Login):Observable<any>
  {
    return this.http.post(this.account_url+"Login",login);
    
  }
  public saveToken(token){
    localStorage.setItem("token", token);
    return true;
  }
}
