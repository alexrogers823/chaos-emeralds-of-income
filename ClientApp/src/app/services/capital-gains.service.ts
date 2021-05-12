import { Injectable } from "@angular/core";
import { CapitalGains } from "../components/capital-gains/interfaces/capital-gains.model";

@Injectable()
export class CapitalGainsService {
  getCapitalGains() {
    return capitalGains_sample;
  }
}

const capitalGains_sample:CapitalGains[] = [
  { investment: 'QQQ', value: 1000 },
  { investment: 'MSFT', value: 250 },
  { investment: 'SPGRX', value: 325 }
]