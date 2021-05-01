import { Component, OnInit } from "@angular/core";
import { from, of } from "rxjs";
import { map, mergeScan, scan, tap } from "rxjs/operators";
import { EarnedIncomeService } from "src/app/services/earned-income.service";
import { Emerald } from "../../shared/emerald.model";
import { EarnedIncome } from "./interfaces/earned-income.model";

@Component({
  selector: 'app-earned-income',
  templateUrl: './earned-income.component.html',
  styleUrls: ['./earned-income.component.css']
})
export class EarnedIncomeComponent implements OnInit {
  isEditing:boolean = false;
  private goalIncome:number = 5000;

  earnedIncome$ = this.earnedIncomeService.earnedIncome$
    .pipe(
      tap(job => console.log('job posted', job))
    );

  earnedIncomeTotal$ = this.earnedIncomeService.earnedIncome$
    .pipe(
      mergeScan((acc:number, curr:EarnedIncome[]) => {
        return from(curr)
          .pipe(
            scan((start:number, job:EarnedIncome) => start + job.incomeAmount, 0)
          )
      }, 0),
      tap(output => console.log('total', output))
    );


  earnedIncomeEmerald:Emerald = {
    id: 1,
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

  constructor(private earnedIncomeService: EarnedIncomeService) { }

  ngOnInit() {
    // this.service.getEarnedIncome().subscribe(data => {
    //   this.jobs = data;
    // })
  }

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
