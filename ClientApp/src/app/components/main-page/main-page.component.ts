import { Component } from "@angular/core";

@Component({
  selector: 'main',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.css']
})
export class MainPageComponent {
  allEmeralds:any[] = [
    { source: 'Earned Income', pageLink: '/earned-income', imageLink: 'assets/green-emerald.png' },
    { source: 'Interest Income', pageLink: '/interest-income', imageLink: 'assets/purple-emerald.png' },
    { source: 'Capital Gains', pageLink: '/capital-gains', imageLink: 'assets/yellow-emerald.png' },
    { source: 'Dividend Income', pageLink: '/dividend-income', imageLink: 'assets/blue-emerald.png' },
    { source: 'Rental Income', pageLink: '/rental-income', imageLink: 'assets/lightblue-emerald.png' },
    { source: 'Business Income', pageLink: '/business-income', imageLink: 'assets/red-emerald.png' },
    { source: 'Royalty Income', pageLink: '/royalty-income', imageLink: 'assets/white-emerald.png' }
  ]
}