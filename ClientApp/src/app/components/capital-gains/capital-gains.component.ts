import { Component, OnInit } from "@angular/core";
import { from } from "rxjs";
import { mergeScan, scan } from "rxjs/operators";
import { CapitalGainsService } from "src/app/services/capital-gains.service";
import { Emerald } from "src/app/shared/emerald.model";
import { CapitalGains } from "./interfaces/capital-gains.model";

@Component({
  selector: 'capital-gains',
  templateUrl: './capital-gains.component.html'
})
export class CapitalGainsComponent implements OnInit {
  private totalInvestmentValue:number;
  capitalGainsEmerald:Emerald = {
    id: 5,
    title: 'Capital Gains',
    quote: '"One basic myth is that rich people get wealthy by earning income. But that\'s not how most get rich. Most of the gains of the rich people since 1945 have been capital gains"',
    author: 'Michael Hudson',
    goal: '30% increase in share value on average',
    emeraldImageUrl: 'assets/yellow-emerald.png',
    resources: [
      {name: 'resource 19'},
      {name: 'resource 20'},
      {name: 'resource 21'}
    ]
  }

  constructor(private capitalGainsService:CapitalGainsService) {}

  ngOnInit() {
    this.capitalGainsTotal$.subscribe(value => {
      this.totalInvestmentValue = value;
    });
  }

  capitalGains$ = this.capitalGainsService.capitalGains$;

  capitalGainsTotal$ = this.capitalGainsService.capitalGains$
    .pipe(
      mergeScan((acc:number, curr:CapitalGains[]) => {
        return from(curr)
          .pipe(
            scan((start:number, investment:CapitalGains) => start + investment.currentValue, 0)
          )
      }, 0)
    );
  
}