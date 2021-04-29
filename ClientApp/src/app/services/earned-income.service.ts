import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { EarnedIncome } from "../components/earned-income/interfaces/earned-income.model";

@Injectable({
  providedIn: 'root'
})
export class EarnedIncomeService {
  _baseUrl: string = "api/EarnedIncome";

  constructor(private http: HttpClient) {

  }

  // getEarnedIncome() {
  //   return this.http.get<EarnedIncome[]>(`${this._baseUrl}/GetEarnedIncome`);
  // }

  getEarnedIncome() {
    return earnedIncome_sample;
  }
}

const earnedIncome_sample:EarnedIncome[] = [
  {
    userId: 823,
    incomeTitle: 'Carpenter',
    incomeAmount: 2000,
    frequency: 'annual',
    isCurrent: true
  },
  {
    userId: 823,
    incomeTitle: 'Plumber',
    incomeAmount: 3000,
    frequency: 'annual',
    isCurrent: true
  },
  {
    userId: 823,
    incomeTitle: 'Writer',
    incomeAmount: 2250,
    frequency: 'annual',
    isCurrent: true
  },
]