import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ColorLigth } from '../models/color-ligth';

@Injectable({
  providedIn: 'root'
})
export class ColorLigthService {
  private urlApi = "";

  constructor(private http: HttpClient) {
    this.urlApi = environment.apiUrl + '/api';
  }

  getTraffics(): Observable<ColorLigth[]> {
    return this.http.get<ColorLigth[]>(`${this.urlApi}/colorlight`, this.httpOptions());
  }

  setTraffic(traffic: ColorLigth): Observable<any> {
    return this.http.post<any>(`${this.urlApi}/colorlight`, traffic, this.httpOptions());
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
