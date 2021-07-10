import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class UserService {
  _baseUrl = "api/User"

  constructor(private http: HttpClient) {}

  loginUser() {
    // return this.http.get<>(this._baseUrl); // TODO: Create user model
    return true
  }
}