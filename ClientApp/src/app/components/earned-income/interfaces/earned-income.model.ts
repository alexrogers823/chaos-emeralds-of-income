export interface EarnedIncome {
  userId:number
  incomeTitle:string 
  incomeAmount:number 
  frequency:string 
  isCurrent:boolean 
  lastEdited?:Date
}