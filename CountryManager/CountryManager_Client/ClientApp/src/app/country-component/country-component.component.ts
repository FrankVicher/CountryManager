import { element } from "protractor";
import { CountryServiceService } from "./../country-service.service";
import { Component, OnInit, Input } from "@angular/core";
import { Country } from "../country";

@Component({
  selector: "app-country-component",
  templateUrl: "./country-component.component.html",
  styleUrls: ["./country-component.component.css"],
})
export class CountryComponentComponent implements OnInit {
  countries: Country[] = [];
  filteredCountries: Country[] = [];

  @Input() shortName: string;
  @Input() alpha2Code: string;
  private alpha3Code: string;

  @Input private numericCode: string;
  private isIndependent: boolean;

  constructor(private countryService: CountryServiceService) {}

  ngOnInit() {
    this.getCountries();
  }

  getCountries() {
    this.countryService.getAll().subscribe((c) => this.countries.push(...c));
    this.filteredCountries = this.countries;
  }

  filter() {
    console.log(this.countries);
    this.filteredCountries = this.countries.filter((c) => {
      console.log(c);
      let elementName = c.shortName;
      let elementCode = c.alpha2Code;
      let compareName = this.shortName == null ? "" : this.shortName;
      let compareCode = this.alpha2Code == null ? "" : this.alpha2Code;

      let result: Boolean =
        elementName
          .toLocaleLowerCase()
          .includes(compareName.toLocaleLowerCase()) &&
        elementCode
          .toLocaleLowerCase()
          .includes(compareCode.toLocaleLowerCase());
      return result;
    });
  }

  restore() {
    this.filteredCountries = this.countries;
  }
}
