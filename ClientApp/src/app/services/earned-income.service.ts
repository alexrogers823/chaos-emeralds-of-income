import { HttpClient, HttpErrorResponse, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { from, Observable, of, throwError } from "rxjs";
import { catchError, tap } from "rxjs/operators";
import { EarnedIncome } from "../components/earned-income/interfaces/earned-income.model";

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    Authorization: 'my-auth-token'
  })
}

@Injectable({
  providedIn: 'root'
})
export class EarnedIncomeService {
  _baseUrl:string = "api/EarnedIncome";

  constructor(private http: HttpClient) {

  }

  earnedIncome$:Observable<EarnedIncome[]> = this.http.get<EarnedIncome[]>(this._baseUrl)
    .pipe(
      tap(obj => console.log('fetched earned income', obj))
    );

  addEarnedIncome(incomeObj:EarnedIncome): Observable<EarnedIncome> {
    console.log(incomeObj)
    return this.http.post<EarnedIncome>(this._baseUrl, incomeObj, httpOptions)
      .pipe(
        catchError(this.handleError)
      );
  }

  editEarnedIncome(incomeObj:EarnedIncome): Observable<EarnedIncome> {
    console.log(incomeObj)
    // search for put or patch request on angular side 
    return this.http.post<EarnedIncome>(this._baseUrl, incomeObj, httpOptions)
      .pipe(
        catchError(this.handleError)
      );
  }

  private handleError(error:HttpErrorResponse) {
    if (error.status === 0) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error('An error occurred:', error.error);
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong.
      console.error(
        `Backend returned code ${error.status}, body was: `, error.error);
    }
    // Return an observable with a user-facing error message.
    return throwError(
      'Something bad happened; please try again later.');
  }

}



const earnedIncome_sample:EarnedIncome[] = [
  {
    userId: 823,
    incomeTitle: 'Carpenter',
    incomeAmount: 2000,
    frequency: 'annual',
    isCurrent: true
  },
  {
    userId: 823,
    incomeTitle: 'Plumber',
    incomeAmount: 3000,
    frequency: 'annual',
    isCurrent: true
  },
  {
    userId: 823,
    incomeTitle: 'Writer',
    incomeAmount: 2250,
    frequency: 'annual',
    isCurrent: true
  },
]