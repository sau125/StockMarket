import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AccountServiceService } from 'src/app/services/account-service.service';
import { AdminService } from 'src/app/services/admin.service';
import { UserService } from 'src/app/services/user.service';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './Account/login/login.component';
import { RegisterComponent } from './Account/register/register.component';
import { FormsModule,ReactiveFormsModule} from '@angular/forms';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import { AuthInterceptorService } from './auth-interceptor.service';
import { HttperrorinterceptorService } from './httperrorinterceptor.service';
import { AddCompanyComponent } from './Admin/add-company/add-company.component';
import { CompaniesComponent } from './Admin/companies/companies.component';
import { UpdateCompanyComponent } from './Admin/update-company/update-company.component';
import { IPOsComponent } from './User/ipos/ipos.component';
import { ExchangesComponent } from './Admin/exchanges/exchanges.component';
import { UpdateExchangeComponent } from './Admin/update-exchange/update-exchange.component';
import { AddExchangeComponent } from './Admin/add-exchange/add-exchange.component';
import { AddIpoComponent } from './Admin/add-ipo/add-ipo.component';
import { AdmingDashboardComponent } from './Admin/adming-dashboard/adming-dashboard.component';
import { UserDashboardComponent } from './User/user-dashboard/user-dashboard.component';
import { ImportDataComponent } from './Admin/import-data/import-data.component';
import { ToastrModule } from 'ngx-toastr';
import { CompanyChartComponent } from './User/company-chart/company-chart.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    AddCompanyComponent,
    CompaniesComponent,
    UpdateCompanyComponent,
    IPOsComponent,
    ExchangesComponent,
    UpdateExchangeComponent,
    AddExchangeComponent,
    AddIpoComponent,
    AdmingDashboardComponent,
    UserDashboardComponent,
    ImportDataComponent,
    CompanyChartComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
    ToastrModule.forRoot()
  ],
  providers: [
    { 
    provide: HTTP_INTERCEPTORS, 
    useClass: AuthInterceptorService, 
    multi: true 
  },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: HttperrorinterceptorService,
      multi: true
    },
    AccountServiceService,AdminService,UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
/*
providers: [],
bootstrap: [AppComponent]
})
export class AppModule { }
*/