import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { tap } from "rxjs/operators";
import { BusinessIncome } from "../components/business-income/interfaces/business-income.model";

@Injectable()
export class BusinessIncomeService {
  _baseUrl = "api/BusinessIncome"

  constructor(private http:HttpClient) {}

  $businessIncome = this.http.get<BusinessIncome>(this._baseUrl)
    .pipe(
      tap(obj => console.log('getting business income...', obj))
    )
}