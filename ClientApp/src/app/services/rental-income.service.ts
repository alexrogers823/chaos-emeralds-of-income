import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { tap } from "rxjs/operators";
import { RentalIncome } from "../components/rental-income/interfaces/rental-income.model";

@Injectable()
export class RentalIncomeService {
  _baseUrl:string = "api/RentalIncome";

  constructor(private http:HttpClient) {}

  // earnedIncome$:Observable<EarnedIncome[]> = this.http.get<EarnedIncome[]>(this._baseUrl)
  //   .pipe(
  //     tap(obj => console.log('fetched earned income', obj))
  //   );

  rentalIncome$:Observable<RentalIncome[]> = this.http.get<RentalIncome[]>(this._baseUrl)
    .pipe(
      tap(obj => console.log('fetching rental income...', obj))
    );

  getRentalIncome() {
    return rentalIncome_sample;
  }
}

const rentalIncome_sample:RentalIncome[] = [
  { property: "Missouri House", mortgage: 500, rent: 800 },
  { property: "Arizona Loft", mortgage: 600, rent: 950 },
  { property: "Midtown Condo", mortgage: 1100, rent: 50, frequency: "daily" },
  { property: "Iowa House", mortgage: 450, rent: 600 }
]