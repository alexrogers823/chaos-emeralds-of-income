import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './components/home/home.component';
import { EarnedIncomeComponent } from './components/earned-income/earned-income.component';
import { EmeraldComponent } from './components/common/emerald-component/emerald-component.component';
import { InterestIncomeComponent } from './components/interest-income/interest-income.component';
import { NetWorthComponent } from './components/net-worth/net-worth.component';
import { EarnedIncomeService } from './services/earned-income.service';
import { InterestIncomeService } from './services/interest-income.service';
import { RoyaltyIncomeComponent } from './components/royalty-income/royalty-income.component';
import { RoyaltyIncomeService } from './services/royalty-income.service';
import { RentalIncomeComponent } from './components/rental-income/rental-income.component';
import { RentalIncomeService } from './services/rental-income.service';
import { CapitalGainsService } from './services/capital-gains.service';
import { DividendIncomeComponent } from './components/dividend-income/dividend-income.component';
import { BusinessIncomeComponent } from './components/business-income/business-income.component';
import { CapitalGainsComponent } from './components/capital-gains/capital-gains.component';
import { MainPageComponent } from './components/main-page/main-page.component';

import {
  businessIncomeLink,
  capitalGainsLink,
  dividendIncomeLink,
  earnedIncomeLink,
  interestIncomeLink,
  mainPageLink, 
  netWorthLink, 
  rentalIncomeLink, 
  royaltyIncomeLink
} from './urls';
import { ResourcesService } from './services/resources.service';
import { NotesService } from './services/notes.service';
// import { userReducer } from './redux/reducers/user.reducer';
import { LoginComponent } from './components/login/login.component';
import { UserService } from './services/user.service';
import { BusinessIncomeService } from './services/business-income.service';

@NgModule({
  declarations: [
    AppComponent,
    MainPageComponent,
    NavMenuComponent,
    HomeComponent,
    NetWorthComponent,
    EmeraldComponent,
    EarnedIncomeComponent,
    InterestIncomeComponent,
    RoyaltyIncomeComponent,
    RentalIncomeComponent,
    DividendIncomeComponent,
    BusinessIncomeComponent,
    CapitalGainsComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    // StoreModule.forRoot({ user: userReducer }),
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'login', component: LoginComponent },
      { path: mainPageLink, component: MainPageComponent },
      { path: netWorthLink, component: NetWorthComponent },
      { path: earnedIncomeLink, component: EarnedIncomeComponent },
      { path: interestIncomeLink, component: InterestIncomeComponent },
      { path: royaltyIncomeLink, component: RoyaltyIncomeComponent },
      { path: rentalIncomeLink, component: RentalIncomeComponent },
      { path: dividendIncomeLink, component: DividendIncomeComponent },
      { path: businessIncomeLink, component: BusinessIncomeComponent },
      { path: capitalGainsLink, component: CapitalGainsComponent }
    ])
  ],
  providers: [
    EarnedIncomeService,
    InterestIncomeService,
    BusinessIncomeService,
    RoyaltyIncomeService,
    RentalIncomeService,
    CapitalGainsService,
    ResourcesService,
    NotesService,
    UserService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
