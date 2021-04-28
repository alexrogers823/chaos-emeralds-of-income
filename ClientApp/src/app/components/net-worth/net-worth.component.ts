import { Component } from "@angular/core";

@Component({
  selector: 'net-worth',
  templateUrl: './net-worth.component.html'
})
export class NetWorthComponent {
  assets:any[] = [
    { name: 'asset 1', amount: 200 },
    { name: 'asset 2', amount: 175 },
    { name: 'asset 3', amount: 350 }
  ]

  liabilities:any[] = [
    { name: 'liability 1', amount: 200 },
    { name: 'liability 2', amount: 175 },
    { name: 'liability 3', amount: 350 }
  ]

  calculateTotal(items:any[]): number {
    return items.reduce((acc, item) => acc + item.amount, 0);
  }

  calculateNetWorth(): number {
    const totalAssets = this.calculateTotal(this.assets);
    const totalLiabilities = this.calculateTotal(this.liabilities);

    return totalAssets - totalLiabilities;
  }

}