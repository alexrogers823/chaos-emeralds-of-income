import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { of } from "rxjs";
import { InterestIncome } from "../components/interest-income/interfaces/interest-income.model";

@Injectable({
  providedIn: 'root'
})
export class InterestIncomeService {
  constructor(private http: HttpClient) {}

  interestIncome$ = of(interestIncome_sample);
}

const interestIncome_sample:InterestIncome[] = [
  {
    name: "Wells Fargo",
    interestPercent: 0.002,
    interestDollar: 150
  },
  {
    name: "Ally",
    interestPercent: 0.005,
    interestDollar: 375
  },
  {
    name: "Fidelity",
    interestPercent: 0.038,
    interestDollar: 1500
  },
  {
    name: "Loan to Brad",
    interestPercent: 0.07,
    interestDollar: 1000
  },
  {
    name: "Mortgage from Dave",
    interestPercent: 0.055,
    interestDollar: 2700
  },
];