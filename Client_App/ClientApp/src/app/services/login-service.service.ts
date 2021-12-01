import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { User } from '../models/user';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  private urlApi = "";

  constructor(private http: HttpClient) {
    this.urlApi = environment.apiUrl + '/api';
  }

  loginUser(user: User): Observable<string> {
    return this.http.post<string>(`${this.urlApi}/login`, user, this.httpOptions());
  }

  private httpOptions() {
    return {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    }
  }
}
