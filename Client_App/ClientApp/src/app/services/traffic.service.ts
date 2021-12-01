import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Traffic } from '../models/traffic';

@Injectable({
  providedIn: 'root'
})
export class TrafficService {
  private urlApi = "";

  constructor(private http: HttpClient) {
    this.urlApi = environment.apiUrl + '/api';
  }

  getTraffics(): Observable<Traffic[]> {
    return this.http.get<Traffic[]>(`${this.urlApi}/traffic`, this.httpOptions());
  }

  setTraffic(traffic: Traffic): Observable<any> {
    return this.http.post<any>(`${this.urlApi}/traffic`, traffic, this.httpOptions());
  }

  private httpOptions() {
    return {
      headers: new HttpHeaders({
        'Content-Type': 'application/json',
        'Authorization': '' + localStorage.getItem("token")
      })
    }
  }
}
