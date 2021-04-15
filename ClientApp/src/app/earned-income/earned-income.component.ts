import { Component } from "@angular/core";

@Component({
  selector: 'app-earned-income',
  templateUrl: './earned-income.component.html',
  styleUrls: ['./earned-income.component.css']
})
export class EarnedIncomeComponent {
  isEditing:boolean = false

  earned = {
    jobs: [
      {
        title: 'Job 1',
        salary: '$5,000'
      },
      {
        title: 'Job 2',
        salary: '$5,000'
      }
    ],
    currentIncome: '$6,000',
    articles: ['Article 1', 'Article 2', 'Article 3']
  }

  editSalary() {
    isEditing = true
  }
}
