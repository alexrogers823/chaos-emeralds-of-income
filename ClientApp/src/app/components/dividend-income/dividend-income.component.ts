import { Component } from "@angular/core";
import { Emerald } from "src/app/shared/emerald.model";

@Component({
  selector: 'dividend-income',
  templateUrl: './dividend-income.component.html'
})
export class DividendIncomeComponent {
  private goalDividendIncome = 1000;
  dividendIncomeEmerald:Emerald = {
    id: 6,
    title: 'Dividend Income',
    quote: 'test quote',
    author: 'test author',
    goal: `$${this.goalDividendIncome}/mo from dividends`,
    emeraldImageUrl: 'assets/blue-emerald.png',
    resources: [
      {name: 'resource 13'},
      {name: 'resource 14'},
      {name: 'resource 15'}
    ]
  }

  hasDividendIncomeEmerald() {
    return 500 > this.goalDividendIncome;
  }
}