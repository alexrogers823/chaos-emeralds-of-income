import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { tap } from "rxjs/operators";
import { DividendIncome } from "../components/dividend-income/interfaces/dividend-income.model";

@Injectable()
export class DividendIncomeService {
  _baseUrl = 'api/DividendIncome';

  constructor(private http: HttpClient) {}

  dividendIncome$:Observable<DividendIncome[]> = this.http.get<DividendIncome[]>(this._baseUrl)
    .pipe(
      tap(obj => console.log('fetching interest income...', obj))
    )
}