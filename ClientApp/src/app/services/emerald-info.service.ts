import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Emerald } from "../shared/emerald.model";

@Injectable({
  providedIn: 'root'
})
export class EmeraldInfoService {
  _baseUrl: string = "api/EmeraldInfo";

  constructor(private http: HttpClient) { }

  getAllEmeralds() {
    return this.http.get<Emerald[]>(`${this._baseUrl}/GetEmeralds`);
  }

  // getEmeraldById(id: number) {

  // }
}