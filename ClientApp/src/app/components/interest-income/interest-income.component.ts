import { Component } from "@angular/core";
import { Emerald } from "../../shared/emerald.model";
import { InterestIncome } from "./interfaces/interest-income.model";

@Component({
  selector: 'interest-income',
  templateUrl: './interest-income.component.html'
})
export class InterestIncomeComponent {
  private goalInterest:number = 100
  interestIncomeEmerald:Emerald = {
    id: 2,
    title: 'Interest Income',
    quote: '"It all comes down to interest rates. As an investor, all you\'re doing is putting up a lump-sum payment for a future cash flow."',
    author: 'Ray Dalio',
    goal: `\$${this.goalInterest}/mo in interest`,
    emeraldImageUrl: 'fake.com',
    resources: [
      'resource 4',
      'resource 5',
      'resource 6'
    ]
  }

  accounts:InterestIncome[] = [
    { name: 'Account 1', interestPercent: 0.0225, interestDollar: 6},
    { name: 'Account 2', interestPercent: 0.015, interestDollar: 4.5},
    { name: 'Account 3', interestPercent: 0.025, interestDollar: 5},
  ]

  calculateInterestSummary(): number {
    return this.accounts.reduce((acc, account) => acc + account.interestDollar, 0);
  }

  hasInterestIncomeEmerald(): boolean {
    const currentInterest = this.calculateInterestSummary();
    return currentInterest >= this.goalInterest;
  }
}