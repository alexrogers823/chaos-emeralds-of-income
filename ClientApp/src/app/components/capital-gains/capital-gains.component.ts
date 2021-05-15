import { Component } from "@angular/core";
import { Emerald } from "src/app/shared/emerald.model";

@Component({
  selector: 'capital-gains',
  templateUrl: './capital-gains.component.html'
})
export class CapitalGainsComponent {
  capitalGainsEmerald:Emerald = {
    id: 5,
    title: 'Capital Gains',
    quote: 'Test Quote',
    author: 'Test Author',
    goal: '30% increase in share value on average',
    emeraldImageUrl: 'capitalgains.com',
    resources: [
      'resource 19',
      'resource 20',
      'resource 21'
    ]
  }
}