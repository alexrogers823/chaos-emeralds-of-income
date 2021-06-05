import { Component } from "@angular/core";
import { CapitalGainsService } from "src/app/services/capital-gains.service";
import { Emerald } from "src/app/shared/emerald.model";

@Component({
  selector: 'capital-gains',
  templateUrl: './capital-gains.component.html'
})
export class CapitalGainsComponent {
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

  capitalGains$ = this.capitalGainsService.capitalGains$;
  
}