import { Component } from "@angular/core";
import { UserService } from "src/app/services/user.service";

@Component({
  selector: 'login',
  templateUrl: 'login.component.html'
})
export class LoginComponent {
  private user;

  constructor(private userService:UserService) {}

  getUser() {
    return this.userService.loginUser();
  }
}