import { Component } from "@angular/core";
import { IEmerald } from "../shared/emerald.model";

@Component({
  selector: 'app-earned-income',
  templateUrl: './earned-income.component.html',
  styleUrls: ['./earned-income.component.css']
})
export class EarnedIncomeComponent {
  isEditing:boolean = false;
  private goalIncome:number = 5000;
  earnedIncomeEmerald:IEmerald = {
    title: 'Earned Income',
    quote: '"When you work on something that only has the capacity to make you 5 dollars, it does not matter how much harder you work – the most you will make is 5 dollars."',
    author: 'Idowu Koyenikan',
    goal: this.goalIncome.toString(),
    emeraldImageUrl: 'placeholder-emerald.jpg',
    resources: [
      'resource 1',
      'resource 2',
      'resource 3'
    ]
  };

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
  }
  
  editSalary() {
    this.isEditing = true
  }

  hasEarnedIncomeEmerald() {
    return this.earned.currentIncome >= this.goalIncome;
  }
}
