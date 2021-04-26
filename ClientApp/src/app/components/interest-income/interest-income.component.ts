import { Component } from "@angular/core";
import { IEmerald } from "../../shared/emerald.model";

@Component({
  selector: 'interest-income',
  templateUrl: './interest-income.component.html'
})
export class InterestIncomeComponent {
  private goalInterest:number = 100
  interestIncomeEmerald:IEmerald = {
    title: 'Interest Income',
    quote: '',
    author: '',
    goal: `${this.goalInterest}/mo in interest`,
    emeraldImageUrl: 'fake.com',
    resources: [
      'resource 4',
      'resource 5',
      'resource 6'
    ]
  }

  accounts:any[] = [
    { name: 'Account 1', interestPercent: 2.25, interestDollar: 6},
    { name: 'Account 2', interestPercent: 1.5, interestDollar: 4.5},
    { name: 'Account 3', interestPercent: 2.5, interestDollar: 5},
  ]

  calculateInterestSummary(): number {
    return this.accounts.reduce((acc, account) => acc + account.interestDollar, 0);
  }

  hasInterestIncomeEmerald(): boolean {
    const currentInterest = this.calculateInterestSummary();
    return currentInterest >= this.goalInterest;
  }
}