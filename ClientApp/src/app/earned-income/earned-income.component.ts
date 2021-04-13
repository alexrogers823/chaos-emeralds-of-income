import { Component } from "@angular/core";

@Component({
  selector: 'app-earned-income',
  templateUrl: './earned-income.component.html',
  styleUrls: ['./earned-income.component.css']
})
export class EarnedIncomeComponent {
  earned = {
    job1: '$5,000',
    job2: '$1,000',
    currentIncome: '$6,000',
    articles: 'Article 1'
  }
}
