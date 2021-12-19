import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Company } from '../Models/company';
import { StockExchange } from '../Models/stock-exchange';
import {IpoDetails} from '../Models/ipo-details';

@Injectable({
  providedIn: 'root'
})
export class AdminService {

  url:string=environment.stock_url
  constructor(private service:HttpClient) { }
  //Get All Project
  public GetAllCompanies():Observable<Company[]>
  {
    return this.service.get<Company[]>(this.url+'GetAllCompanies');
  }
  public GetCompanyByName(name:string):Observable<Company>
  {
    return this.service.get<Company>(this.url+'GetCompany/'+name);
  }
  public AddCompany(company:Company):Observable<any>//Add 
  {
    console.log(company)
    return this.service.post(this.url+'AddCompany/',company);
  }
  public UpdateCompany(company:Company):Observable<any> //Update 
  {
    return this.service.put(this.url+'UpdateCompany/',company);
  }
  public DeleteCompany(companyName:string):Observable<any>//DeleteItem
  {
    return this.service.delete(this.url+'DeleteCompany/'+companyName);
  }
  public GetAllExchanges():Observable<StockExchange[]>
  {
    return this.service.get<StockExchange[]>(this.url+'GetAllStockExchanges');
  }
  public GetExchangeByName(name:string):Observable<StockExchange>
  {
    return this.service.get<StockExchange>(this.url+'GetStockExchange/'+name);
  }
  public AddExchange(exchange:StockExchange):Observable<any>//Add 
  {
    console.log(exchange)
    return this.service.post(this.url+'AddStockExchange/',exchange);
  }
  public UpdateExchange(exchange:StockExchange):Observable<any> //Update 
  {
    return this.service.put(this.url+'EditStockExchange/',exchange);
  }
  public DeleteExchange(id:string):Observable<any>//Delete
  {
    return this.service.delete(this.url+'deleteStockExchange/'+id);
  }
  public AddIpo(ipo:IpoDetails):Observable<any>//Add 
  {
    console.log(ipo)
    return this.service.post(this.url+'AddIPO/',ipo);
  }
}
