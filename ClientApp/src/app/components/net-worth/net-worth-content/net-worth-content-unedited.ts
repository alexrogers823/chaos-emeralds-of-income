import { Component } from '@angular/core'

@Component({
  selector: 'net-worth-content-unedited',
  template: `
    <div>
      <span>Assets: </span>
      <span>{{ assets }}</span>
    </div>
    <div>
      <span>Liabilities: </span>
      <span>{{ liabilities }}</span>
    </div>
    <div>
      <span>Net Worth: </span>
      <span>{{ netWorth }}</span>
    </div>
  `
})
export class NetWorthContentUnedited {
  assets = 5000
  liabilities = 2000
}
