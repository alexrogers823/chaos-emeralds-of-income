import { Component, OnInit } from "@angular/core";
import { FormControl, NgForm } from "@angular/forms";
import { from, of } from "rxjs";
import { map, mergeScan, scan, shareReplay, tap } from "rxjs/operators";
import { EarnedIncomeService } from "src/app/services/earned-income.service";
import { Emerald } from "../../shared/emerald.model";
import { EarnedIncome } from "./interfaces/earned-income.model";

@Component({
  selector: 'app-earned-income',
  templateUrl: './earned-income.component.html',
  // templateUrl: './earned-income.edit.component.html',
  styleUrls: ['./earned-income.component.css']
})
export class EarnedIncomeComponent implements OnInit {
  isEditing:boolean = false;
  private goalIncome:number = 5000;
  private currentIncome:number;

  // earnedIncome$ = this.earnedIncomeService.earnedIncome$
  //   .pipe(
  //     tap(job => console.log('job posted', job)),
  //     shareReplay(1) //not working. fix this
  //   );

  earnedIncome$ = this.earnedIncomeService.earnedIncome$

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
    goal: `$${this.goalIncome}/yr`,
    emeraldImageUrl: 'assets/green-emerald.png',
    resources: [
      {name: 'resource 1'},
      {name: 'resource 2'},
      {name: 'resource 3'}
    ],
    notes: [
      'test note 1',
      'test note 2'
    ]
  };

  constructor(private earnedIncomeService: EarnedIncomeService) { }

  ngOnInit() {
    this.earnedIncomeTotal$.subscribe(income => {
      this.currentIncome = income;
    });
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
    return this.currentIncome >= this.goalIncome;
  }

  addEarnedIncome(earnedIncome: NgForm) {
    this.earnedIncomeService
      .addEarnedIncome(earnedIncome.value);
  }

  editEarnedIncome(earnedIncome: NgForm) {
    this.earnedIncomeService.editEarnedIncome(earnedIncome.value);
  }
}
