import { Component, OnInit } from "@angular/core";
import { RoyaltyIncomeService } from "src/app/services/royalty-income.service";
import { RoyaltyIncome } from "./interfaces/royalty-income.model";

@Component({
	selector: 'royalty-income',
	templateUrl: './royalty-income.component.html',
})
export class RoyaltyIncomeComponent implements OnInit {
  royaltyIncome:RoyaltyIncome[];

  ngOnInit() {}

  constructor(private royaltyIncomeService:RoyaltyIncomeService) {
    this.royaltyIncome = royaltyIncomeService.getRoyaltyIncome();
  }

}