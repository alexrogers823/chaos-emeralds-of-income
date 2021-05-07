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

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    NetWorthComponent,
    EmeraldComponent,
    EarnedIncomeComponent,
    InterestIncomeComponent,
    RoyaltyIncomeComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'net-worth', component: NetWorthComponent },
      { path: 'earned-income', component: EarnedIncomeComponent },
      { path: 'interest-income', component: InterestIncomeComponent},
      { path: 'royalty-income', component: RoyaltyIncomeComponent}
    ])
  ],
  providers: [
    EarnedIncomeService,
    InterestIncomeService,
    RoyaltyIncomeService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
