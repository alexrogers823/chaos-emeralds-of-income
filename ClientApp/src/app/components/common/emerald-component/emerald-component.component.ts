import { Component, Input } from "@angular/core";
import { Emerald } from "src/app/shared/emerald.model";

@Component({
  selector: 'emerald-component',
  templateUrl: './emerald-component.component.html',
  styleUrls: ['./emerald-component.component.css']
})
export class EmeraldComponent {
  @Input() emerald:Emerald;
  @Input() hasEmerald:boolean;
}