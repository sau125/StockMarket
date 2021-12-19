import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IpoDetails } from '../Models/ipo-details';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  url:string=environment.stock_url
  constructor(private service:HttpClient) { }
  public GetAllIpos():Observable<IpoDetails[]>
  {
    return this.service.get<IpoDetails[]>(this.url+'GetAllIPO');
  }
}
