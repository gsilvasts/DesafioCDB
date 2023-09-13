import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class InvestmentService {
  private apiUrl = 'https://localhost:5001/api/cdb';

  constructor(private http: HttpClient) { }

  calculateInvestment(initialInvestment: number, months: number): Observable<any>{
    return this.http.get(`${this.apiUrl}/${initialInvestment}/${months}`);
  }
}
