import { Component, Input } from "@angular/core";
import { IEmerald } from "src/app/shared/emerald.model";

@Component({
  selector: 'emerald-component',
  templateUrl: './emerald-component.component.html'
})
export class EmeraldComponent {
  @Input() emerald:IEmerald;
  @Input() hasEmerald:boolean;
}