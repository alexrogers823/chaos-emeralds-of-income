import { Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot } from "@angular/router";
import { UserService } from "./user.service";

@Injectable()
export class LoginService implements CanActivate {
  constructor(private userService:UserService, private router:Router) {}

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    this.router.navigate(['/login'], {
      queryParams: {
        return: state.url
      }
    });
    // return false;

    // const dataExists = !!this.userService.loginUser();
    const dataExists = true;

    if (!dataExists) {
      this.router.navigate(['/404'])
    }
    return dataExists;
  }
}