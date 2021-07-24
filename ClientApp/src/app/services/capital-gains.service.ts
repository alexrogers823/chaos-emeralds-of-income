import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { tap } from "rxjs/operators";
import { CapitalGains } from "../components/capital-gains/interfaces/capital-gains.model";

@Injectable()
export class CapitalGainsService {
  _baseUrl = "api/CapitalGains";

  constructor(private http:HttpClient) {}

  capitalGains$:Observable<CapitalGains[]> = this.http.get<CapitalGains[]>(this._baseUrl)
    .pipe(
      tap(obj => console.log('fetched capital gains...', obj))
    )
}