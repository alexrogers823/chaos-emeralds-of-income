import { Component, OnInit } from "@angular/core";
import { from } from "rxjs";
import { mergeScan, scan } from "rxjs/operators";
import { RentalIncomeService } from "src/app/services/rental-income.service";
import { Emerald } from "src/app/shared/emerald.model";
import { RentalIncome } from "./interfaces/rental-income.model";

@Component({
  selector: 'rental-income',
  templateUrl: './rental-income.component.html'
})
export class RentalIncomeComponent implements OnInit {
  targetRentalNetIncome:number = 0.3;
  actualRent:number;
  actualMortgage:number;
  rentalIncomeEmerald:Emerald = {
    id: 4,
    title: "Rental Income",
    quote: "Ninety percent of all millionaries become so through owning real estate",
    author: "Andrew Carnegie",
    goal: "30% net income from rental properties",
    emeraldImageUrl: 'assets/lightblue-emerald.png',
    resources: [
      {name: 'resource 10'},
      {name: 'resource 11'},
      {name: 'resource 12'}
    ]
  }

  rentalIncome$ = this.rentalIncomeService.rentalIncome$;

  totalMortgage$ = this.rentalIncomeService.rentalIncome$
    .pipe(
      mergeScan((acc:number, curr:RentalIncome[]) => {
        return from(curr)
          .pipe(
            scan((start:number, rental:RentalIncome) => start + rental.mortgage, 0)
          )
      }, 0)
    );

  totalRent$ = this.rentalIncomeService.rentalIncome$
    .pipe(
      mergeScan((acc:number, curr:RentalIncome[]) => {
        return from(curr)
          .pipe(
            scan((start:number, rental:RentalIncome) => start + rental.rent, 0)
          )
      }, 0)
    );

  constructor(private rentalIncomeService:RentalIncomeService) {}

  ngOnInit() {
    this.totalRent$.subscribe(rent => {
      this.actualRent = rent;
    });
  
    this.totalMortgage$.subscribe(mortgage => {
      this.actualMortgage = mortgage;
    });
  }

  hasRentalIncomeEmerald() {
    return (this.actualRent / this.actualMortgage) >= this.targetRentalNetIncome;
  }
}