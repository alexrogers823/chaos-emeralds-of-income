import { Component, OnInit } from "@angular/core";
import { from, Observable } from "rxjs";
import { mergeScan, scan, shareReplay, tap } from "rxjs/operators";
import { InterestIncomeService } from "src/app/services/interest-income.service";
import { Emerald } from "../../shared/emerald.model";
import { InterestIncome } from "./interfaces/interest-income.model";

@Component({
  selector: 'interest-income',
  templateUrl: './interest-income.component.html'
  // templateUrl: './interest-income.edit.component.html'
})
export class InterestIncomeComponent implements OnInit {
  private goalInterest:number = 100
  private totalInterest:number;
  interestIncomeEmerald:Emerald = {
    id: 2,
    title: 'Interest Income',
    quote: '"It all comes down to interest rates. As an investor, all you\'re doing is putting up a lump-sum payment for a future cash flow."',
    author: 'Ray Dalio',
    goal: `\$${this.goalInterest}/mo in interest`,
    emeraldImageUrl: 'assets/purple-emerald.png',
    resources: [
      {name: 'resource 4'},
      {name: 'resource 5'},
      {name: 'resource 6'}
    ]
  }

  constructor(private interestIncomeService:InterestIncomeService) {}

  ngOnInit() {
    this.interestIncomeTotal$.subscribe(total => {
      this.totalInterest = total;
    })
  }

  interestIncome$:Observable<InterestIncome[]> = this.interestIncomeService.interestIncome$

  // interestIncomeTotal$:number = this.earnedIncomeService.earnedIncome$
  //   .pipe(
  //     mergeScan((acc:number, curr:EarnedIncome[]) => {
  //       return from(curr)
  //         .pipe(
  //           scan((start:number, job:EarnedIncome) => start + job.incomeAmount, 0)
  //         )
  //     }, 0),
  //     tap(output => console.log('total', output))
  //   );

  interestIncomeTotal$ = this.interestIncomeService.interestIncome$
    .pipe(
      mergeScan((acc:number, curr:InterestIncome[]) => {
        return from(curr)
          .pipe(
            scan((start:number, account:InterestIncome) => start + account.interestDollar, 0)
          )
      }, 0),
      shareReplay(1),
      tap(output => console.log('total', output))
    );

  hasInterestIncomeEmerald(): boolean {
    return this.totalInterest >= this.goalInterest;
  }
}