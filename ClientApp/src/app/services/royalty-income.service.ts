import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { RoyaltyIncome } from "../components/royalty-income/interfaces/royalty-income.model";

@Injectable()
export class RoyaltyIncomeService {
  constructor(private http: HttpClient) {}

  getRoyaltyIncome() {
    return royaltyIncome_sample;
  }
}

const royaltyIncome_sample:RoyaltyIncome[] = [
  { title: "Horror Audiobook", frequency: "monthly", amount: 25.50 },
  { title: "Evolv", frequency: "monthly", amount: 15.25 },
  { title: "Wrong Side of Heaven", frequency: "monthly", amount: 14 }
]