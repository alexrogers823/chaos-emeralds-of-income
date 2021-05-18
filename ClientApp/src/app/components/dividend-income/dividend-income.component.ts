import { Component } from "@angular/core";
import { Emerald } from "src/app/shared/emerald.model";

@Component({
  selector: 'dividend-income',
  templateUrl: './dividend-income.component.html'
})
export class DividendIncomeComponent {
  dividendIncomeEmerald:Emerald = {
    id: 6,
    title: 'Dividend Income',
    quote: 'test quote',
    author: 'test author',
    goal: '$1000/mo from dividends',
    emeraldImageUrl: 'assets/blue-emerald.png',
    resources: [
      'resource 13',
      'resource 14',
      'resource 15'
    ]
  }
}