import { Component, OnInit } from '@angular/core';
import { User } from '../models/user';
import { LoginService } from '../services/login-service.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  user: User = {};
  hide: boolean = true;
  token: string = '';

  constructor(private loginService: LoginService) { }

  ngOnInit(): void {
  }

  public login(): void {
    this.loginService.loginUser(this.user).subscribe(result => {
      this.token = result;
    }, null, () => {
      console.log(this.token);
      localStorage.setItem('token', this.token) 
    });
  }
}
