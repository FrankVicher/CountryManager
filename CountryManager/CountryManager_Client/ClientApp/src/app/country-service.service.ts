import { Country } from "./country";
import { Injectable } from "@angular/core";
import {
  HttpClientModule,
  HttpHeaders,
  HttpErrorResponse,
  HttpClient,
} from "@angular/common/http";
import { Observable } from "rxjs/internal/observable";
import { url } from "inspector";

@Injectable({
  providedIn: "root",
})
export class CountryServiceService {
  update(country: Country) {
    throw new Error("Method not implemented.");
  }

  private countries: Country[] = [];

  private shortName: string;

  apiUrl: string = "https://localhost:5001/api/Country";
  headers = new HttpHeaders().set("Content-Type", "application/json");

  constructor(private http: HttpClient) {}

  getAll() {
    return this.http.get(this.apiUrl);
  }
  getById(id) {
    let url:string = `${this.apiUrl}/${id}`;
    return this.http.get(url);
  }

  create(country: any) {
    return this.http.post(this.apiUrl, country);
  }
  update(country: any){
    return this.http.put(this.apiUrl,country);
  }
}
