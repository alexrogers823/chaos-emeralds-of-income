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
		emeraldImageUrl: 'business.com',
		resources: [
			'resource 16',
			'resource 17',
			'resource 18',
		]
	}
};