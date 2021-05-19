import { Component, OnInit } from "@angular/core";
import { RentalIncomeService } from "src/app/services/rental-income.service";
import { Emerald } from "src/app/shared/emerald.model";
import { RentalIncome } from "./interfaces/rental-income.model";

@Component({
  selector: 'rental-income',
  templateUrl: './rental-income.component.html'
})
export class RentalIncomeComponent implements OnInit {
  rentalIncome:RentalIncome[] = this.rentalIncomeService.getRentalIncome();
  
  rentalIncomeEmerald:Emerald = {
    id: 4,
    title: "Rental Income",
    quote: "'Test Quote'",
    author: "'Test Author'",
    goal: "30% net income from rental properties",
    emeraldImageUrl: 'assets/lightblue-emerald.png',
    resources: [
      {name: 'resource 10'},
      {name: 'resource 11'},
      {name: 'resource 12'}
    ]
  }

  constructor(private rentalIncomeService:RentalIncomeService) {}

  ngOnInit() {}
}