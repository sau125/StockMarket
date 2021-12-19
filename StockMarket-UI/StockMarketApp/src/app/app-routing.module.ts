import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './Account/login/login.component';
import { RegisterComponent } from './Account/register/register.component';
import {AdmingDashboardComponent} from './Admin/adming-dashboard/adming-dashboard.component';
import {UserDashboardComponent} from './User/user-dashboard/user-dashboard.component';
import {CompaniesComponent} from './Admin/companies/companies.component';
import {AddCompanyComponent} from './Admin/add-company/add-company.component';
import {UpdateCompanyComponent} from './Admin/update-company/update-company.component';
import {ExchangesComponent} from './Admin/exchanges/exchanges.component';
import {AddExchangeComponent} from './Admin/add-exchange/add-exchange.component';
import {UpdateExchangeComponent} from './Admin/update-exchange/update-exchange.component';
import {IPOsComponent} from './User/ipos/ipos.component';
import {AddIpoComponent} from './Admin/add-ipo/add-ipo.component';
import { ImportDataComponent } from './Admin/import-data/import-data.component';
import {CompanyChartComponent} from './User/company-chart/company-chart.component';
const routes: Routes = [
  {path:'login',component:LoginComponent},
  {path:'register',component:RegisterComponent},
  {path:'admin',component:AdmingDashboardComponent},
  {path:'user',component:UserDashboardComponent},
  {path:'viewallcompanies',component:CompaniesComponent},
  {path:'add-company',component:AddCompanyComponent},
  {path:'edit-company',component:UpdateCompanyComponent},
  {path:'logout',component:LoginComponent},
  {path:'viewallexchanges',component:ExchangesComponent},
  {path:'add-exchange',component:AddExchangeComponent},
  {path:'edit-exchange',component:UpdateExchangeComponent},
  {path:'viewallipos',component:IPOsComponent},
  {path:'add-ipo',component:AddIpoComponent},
  {path:'import-data',component:ImportDataComponent},
  {path:'company-chart',component:CompanyChartComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
