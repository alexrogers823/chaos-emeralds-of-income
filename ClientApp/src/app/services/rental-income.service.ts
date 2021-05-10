import { Injectable } from "@angular/core";
import { RentalIncome } from "../components/rental-income/interfaces/rental-income.model";

@Injectable()
export class RentalIncomeService {
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