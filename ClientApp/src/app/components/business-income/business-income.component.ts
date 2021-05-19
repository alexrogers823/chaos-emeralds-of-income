import { Component } from "@angular/core";
import { Emerald } from "src/app/shared/emerald.model";

@Component({
	selector: 'business-income',
	templateUrl: './business-income.component.html'
})
export class BusinessIncomeComponent {
	businessIncomeEmerald:Emerald = {
		id: 7,
		title: 'Business Income',
		quote: 'Test quote',
		author: 'test author',
		goal: '$10000 annual net profit',
		emeraldImageUrl: 'assets/red-emerald.png',
		resources: [
			{name: 'resource 16'},
			{name: 'resource 17'},
			{name: 'resource 18'}
		]
	}
};