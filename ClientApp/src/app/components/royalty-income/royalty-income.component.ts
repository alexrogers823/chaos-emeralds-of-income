import { Component, OnInit } from "@angular/core";
import { RoyaltyIncomeService } from "src/app/services/royalty-income.service";
import { Emerald } from "src/app/shared/emerald.model";
import { RoyaltyIncome } from "./interfaces/royalty-income.model";

@Component({
	selector: 'royalty-income',
	templateUrl: './royalty-income.component.html',
})
export class RoyaltyIncomeComponent implements OnInit {
  royaltyIncome:RoyaltyIncome[];
  royaltyIncomeEmerald:Emerald = {
    id: 3,
    title: "Royalty Income",
    quote: "'Test Quote'",
    author: "'Test Author'",
    goal: "Coming soon",
    emeraldImageUrl: 'assets/white-emerald.png',
    resources: [
      'resource 7',
      'resource 8',
      'resource 9'
    ]
  }

  ngOnInit() {}

  constructor(private royaltyIncomeService:RoyaltyIncomeService) {
    this.royaltyIncome = royaltyIncomeService.getRoyaltyIncome();
  }

}