import { state } from "@angular/animations";
import { createReducer, on } from "@ngrx/store";
import { loginUser, logoutUser } from "../actions/user.actions";

export const initialState = {};

const _userReducer = createReducer(
  initialState,
  on(loginUser, state => ({ user: 'Test'})),
  on(logoutUser, state => ({}))
)

export function userReducer(state:any, action:any) {
  return _userReducer(state, action);
}