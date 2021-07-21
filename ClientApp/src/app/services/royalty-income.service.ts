import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { of } from "rxjs";
import { tap } from "rxjs/operators";
import { RoyaltyIncome } from "../components/royalty-income/interfaces/royalty-income.model";

@Injectable()
export class RoyaltyIncomeService {
  _baseUrl = "api/RoyaltyIncome";

  constructor(private http: HttpClient) {}

  royaltyIncome$ = this.http.get<RoyaltyIncome[]>(this._baseUrl)
    .pipe(
      tap(obj => console.log('fetched royalty income', obj))
    );

  // getRoyaltyIncome() {
  //   return royaltyIncome_sample;
  // }

  // royaltyIncome$ = of(royaltyIncome_sample);
}

const royaltyIncome_sample:RoyaltyIncome[] = [
  { title: "Horror Audiobook", frequency: "monthly", amount: 25.50 },
  { title: "Evolv", frequency: "monthly", amount: 15.25 },
  { title: "Wrong Side of Heaven", frequency: "monthly", amount: 14 }
]