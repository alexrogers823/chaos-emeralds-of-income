import { Component, OnInit } from "@angular/core";
import { from } from "rxjs";
import { mergeScan, scan, tap } from "rxjs/operators";
import { DividendIncomeService } from "src/app/services/dividend-income.service";
import { Emerald } from "src/app/shared/emerald.model";
import { DividendIncome } from "./interfaces/dividend-income.model";

@Component({
  selector: 'dividend-income',
  templateUrl: './dividend-income.component.html'
})
export class DividendIncomeComponent implements OnInit {
  private currentDividendIncome:number;
  private goalDividendIncome:number = 1000;
  dividendIncomeEmerald:Emerald = {
    id: 6,
    title: 'Dividend Income',
    quote: 'I do not own a single security anywhere that doesn\'t pay a dividend, and I formed a mutual-fund company with that very simple philosophy',
    author: 'Kevin O\'Leary',
    goal: `$${this.goalDividendIncome}/mo from dividends`,
    emeraldImageUrl: 'assets/blue-emerald.png',
    resources: [
      {name: 'resource 13'},
      {name: 'resource 14'},
      {name: 'resource 15'}
    ]
  }

  constructor(private dividendIncomeService:DividendIncomeService) {}

  dividendIncome$ = this.dividendIncomeService.dividendIncome$

  dividendIncomeTotal$ = this.dividendIncomeService.dividendIncome$
    .pipe(
      mergeScan((acc:number, curr:DividendIncome[]) => {
        return from(curr)
          .pipe(
            scan((start:number, dividend:DividendIncome) => start + dividend.dividendPayout, 0)
          )
      }, 0),
      tap(output => console.log('total', output))
    );

  ngOnInit() {
    this.dividendIncomeTotal$.subscribe(income => {
      this.currentDividendIncome = income;
    })
  }

  

  hasDividendIncomeEmerald() {
    return this.currentDividendIncome > this.goalDividendIncome;
  }
}