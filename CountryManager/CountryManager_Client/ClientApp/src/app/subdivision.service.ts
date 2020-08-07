import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SubdivisionService {

  constructor(private http: HttpClient) { }

  urlApi = 'https://localhost:5001/api/Subdivision';

  getByCountryId(countryId){
    let url: string = `${this.urlApi}/country/${countryId}`;
    return this.http.get(url);
  }
}
