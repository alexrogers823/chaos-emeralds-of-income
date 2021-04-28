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

  getEarnedIncome() {
    return this.http.get<EarnedIncome[]>(`${this._baseUrl}/GetEarnedIncome`);
  }
}