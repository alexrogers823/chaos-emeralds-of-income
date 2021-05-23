import { Component } from "@angular/core";

@Component({
  selector: 'main',
  templateUrl: './main-page.component.html'
})
export class MainPageComponent {
  allEmeralds:any[] = [
    { source: 'Earned Income', imageLink: 'assets/green-emerald.png' },
    { source: 'Interest Income', imageLink: 'assets/purple-emerald.png' },
    { source: 'Capital Gains', imageLink: 'assets/yellow-emerald.png' },
    { source: 'Dividend Income', imageLink: 'assets/blue-emerald.png' },
    { source: 'Rental Income', imageLink: 'assets/lightblue-emerald.png' },
    { source: 'Business Income', imageLink: 'assets/red-emerald.png' },
    { source: 'Royalty Income', imageLink: 'assets/white-emerald.png' }
  ]
}