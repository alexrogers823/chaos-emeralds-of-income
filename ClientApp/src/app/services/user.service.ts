import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { User } from "oidc-client";

@Injectable()
export class UserService {
  _baseUrl = "api/User"

  constructor(private http: HttpClient) {}

  loginUser() {
    return this.http.get<User>(this._baseUrl);
  }
}