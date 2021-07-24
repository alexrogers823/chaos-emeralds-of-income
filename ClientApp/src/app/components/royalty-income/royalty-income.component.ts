import { Component, OnInit } from "@angular/core";
import { from } from "rxjs";
import { mergeScan, scan } from "rxjs/operators";
import { RoyaltyIncomeService } from "src/app/services/royalty-income.service";
import { Emerald } from "src/app/shared/emerald.model";
import { RoyaltyIncome } from "./interfaces/royalty-income.model";

@Component({
	selector: 'royalty-income',
	templateUrl: './royalty-income.component.html',
})
export class RoyaltyIncomeComponent implements OnInit {
  royaltyIncome:RoyaltyIncome[];
  private royaltyIncomeGoal:number = 50;
  private currentMonthlyRoyalties;

  royaltyIncomeEmerald:Emerald = {
    id: 3,
    title: "Royalty Income",
    quote: "'The royalty checks each quarter pay the utilities on this big house'",
    author: "Stan Perkins",
    goal: `Receive $${this.royaltyIncomeGoal}/mo in royalties`,
    emeraldImageUrl: 'assets/white-emerald.png',
    resources: [
      {name: 'resource 7'},
      {name: 'resource 8'},
      {name: 'resource 9'}
    ]
  }

  royaltyIncome$ = this.royaltyIncomeService.royaltyIncome$

  royaltyIncomeTotal$ = this.royaltyIncomeService.royaltyIncome$
    .pipe(
      mergeScan((acc:number, curr:RoyaltyIncome[]) => {
        return from(curr)
          .pipe(
            scan((start:number, royalty:RoyaltyIncome) => start + royalty.amount, 0)
          )
      }, 0)
    )

  constructor(private royaltyIncomeService:RoyaltyIncomeService) { }

  ngOnInit() {
    this.royaltyIncomeTotal$.subscribe(royalty => {
      this.currentMonthlyRoyalties = royalty;
    })
  }

  hasRoyaltyIncomeEmerald() {
    return this.currentMonthlyRoyalties >= this.royaltyIncomeGoal;
  }

}