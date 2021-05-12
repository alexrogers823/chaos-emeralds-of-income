import { Component, OnInit } from "@angular/core";
import { CapitalGainsService } from "src/app/services/capital-gains.service";
import { CapitalGains } from "./interfaces/capital-gains.model";

Component({
  selector: 'capital-gains',
  templateUrl: './capital-gains.component.html'
})
export class CapitalGainsComponent implements OnInit {
  investments:CapitalGains[] = this.capitalGainsService.getCapitalGains()

  constructor(private capitalGainsService:CapitalGainsService) {}

  ngOnInit() {}
}