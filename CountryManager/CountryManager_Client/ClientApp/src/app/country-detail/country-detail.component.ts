import { SubdivisionService } from "./../subdivision.service";
import { Country } from "./../country";
import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { CountryServiceService } from "../country-service.service";

@Component({
  selector: "app-country-detail",
  templateUrl: "./country-detail.component.html",
  styleUrls: ["./country-detail.component.css"],
})
export class CountryDetailComponent implements OnInit {
  private countryId: number;
  private country: any;
  constructor(
    private route: ActivatedRoute,
    private service: CountryServiceService,
    private subdivisionService: SubdivisionService
  ) {
    this.countryId = route.snapshot.params.id;
  }

  async ngOnInit() {
    await this.getCountry();
    await this.getCountrySubdivisions();
  }

  async getCountry() {
    let _this = this;
    await this.service
      .getById(_this.countryId)
      .toPromise()
      .then((r: {}) => {
        this.country = r;
      });
  }
  async getCountrySubdivisions() {
    const _this = this;
    await _this.subdivisionService
      .getByCountryId(_this.countryId)
      .toPromise()
      .then((d: {}) => {
        _this.country.subdivisions = d;
      });
  }
}
