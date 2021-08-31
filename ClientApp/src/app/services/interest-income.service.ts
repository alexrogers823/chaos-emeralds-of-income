import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, of } from "rxjs";
import { tap } from "rxjs/operators";
import { InterestIncome } from "../components/interest-income/interfaces/interest-income.model";

@Injectable({
  providedIn: 'root'
})
export class InterestIncomeService {
  _baseUrl = 'api/InterestIncome';

  constructor(private http: HttpClient) {}

  interestIncome$:Observable<InterestIncome[]> = this.http.get<InterestIncome[]>(this._baseUrl)
    .pipe(
      tap(obj => console.log('fetching interest income...', obj))
    )

  addInterestIncome(incomeObj:InterestIncome): Observable<InterestIncome> {
    return this.http.post<InterestIncome>(this._baseUrl, incomeObj)
      .pipe(
        tap(obj => console.log('added interest income', obj))
      );
  }

  archiveInterestIncome(incomeObj:InterestIncome) {
    console.log('attempting archive...')
  }
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