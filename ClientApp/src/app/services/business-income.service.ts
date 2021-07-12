import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class BusinessIncomeService {
  _baseUrl = "api/BusinessIncome"

  constructor(private http:HttpClient) {}

  // $businessIncome = this.http.get<>(this._baseUrl) // add business income model
}