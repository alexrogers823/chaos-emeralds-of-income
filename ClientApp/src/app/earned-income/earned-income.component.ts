import { Component } from "@angular/core";

@Component({
  selector: 'app-earned-income',
  templateUrl: './earned-income.component.html',
  styleUrls: ['./earned-income.component.css']
})
export class EarnedIncomeComponent {
  isEditing:boolean = false
  goalIncome = 5000
  
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
    currentIncome: 6000,
    articles: ['Article 1', 'Article 2', 'Article 3']
  }
  
  quote = {
    quote: '"When you work on something that only has the capacity to make you 5 dollars, it does not matter how much harder you work – the most you will make is 5 dollars."',
    author: 'Idowu Koyenikan'
  }
  
  hasEmerald:boolean = this.earned.currentIncome > this.goalIncome
  
  editSalary() {
    this.isEditing = true
  }
}
