import { Component, Input } from "@angular/core";
import { UserService } from "src/app/services/user.service";

@Component({
  selector: 'login',
  templateUrl: 'login.component.html'
})
export class LoginComponent {
  private user;
  @Input() demoDisabled:boolean = true;

  constructor(private userService:UserService) {}

  getUser() {
    return this.userService.loginUser();
  }

  enableDemo() {
    this.demoDisabled = false;
  } 
}