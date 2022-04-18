import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AppService {

  readonly rootURL = 'https://localhost:44397';

  constructor(private http: HttpClient) { }
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }
  CalcularCdb(formData) {
    return this.http.post(this.rootURL + '/CalculoCdb', formData);
  }

}
