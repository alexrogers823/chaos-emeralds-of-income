import { Component } from "@angular/core";
import { 
  businessIncomeLink, 
  capitalGainsLink, 
  dividendIncomeLink, 
  earnedIncomeLink, 
  interestIncomeLink, 
  rentalIncomeLink, 
  royaltyIncomeLink 
} from "src/app/urls";

@Component({
  selector: 'main',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.css']
})
export class MainPageComponent {
  allEmeralds:any[] = [
    { source: 'Earned Income', pageLink: `/${earnedIncomeLink}`, imageLink: 'assets/green-emerald.png' },
    { source: 'Interest Income', pageLink: `/${interestIncomeLink}`, imageLink: 'assets/purple-emerald.png' },
    { source: 'Capital Gains', pageLink: `/${capitalGainsLink}`, imageLink: 'assets/yellow-emerald.png' },
    { source: 'Dividend Income', pageLink: `/${dividendIncomeLink}`, imageLink: 'assets/blue-emerald.png' },
    { source: 'Rental Income', pageLink: `/${rentalIncomeLink}`, imageLink: 'assets/lightblue-emerald.png' },
    { source: 'Business Income', pageLink: `/${businessIncomeLink}`, imageLink: 'assets/red-emerald.png' },
    { source: 'Royalty Income', pageLink: `/${royaltyIncomeLink}`, imageLink: 'assets/white-emerald.png' }
  ]
}