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
import { CapitalGainsComponent } from './components/capital-gains/capital-gains.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    NetWorthComponent,
    // CapitalGainsComponent,
    EmeraldComponent,
    EarnedIncomeComponent,
    InterestIncomeComponent,
    RoyaltyIncomeComponent,
    RentalIncomeComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'net-worth', component: NetWorthComponent },
      { path: 'earned-income', component: EarnedIncomeComponent },
      { path: 'interest-income', component: InterestIncomeComponent },
      { path: 'royalty-income', component: RoyaltyIncomeComponent },
      { path: 'rental-income', component: RentalIncomeComponent },
      { path: 'capital-gains', component: CapitalGainsComponent }
    ])
  ],
  providers: [
    EarnedIncomeService,
    InterestIncomeService,
    RoyaltyIncomeService,
    RentalIncomeService,
    CapitalGainsService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
