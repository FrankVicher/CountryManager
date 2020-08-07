import { Component, OnInit } from "@angular/core";
import { CountryServiceService } from "../country-service.service";
import { Country } from "../country";
import { ActivatedRoute } from "@angular/router";

@Component({
  selector: "app-country-edit",
  templateUrl: "./country-edit.component.html",
  styleUrls: ["./country-edit.component.css"],
})
export class CountryEditComponent implements OnInit {
  id: number;
  shortName: string;
  alpha2Code: string;
  alpha3Code: string;
  numericCode: string;
  isIndependent: boolean;
  constructor(
    private service: CountryServiceService,
    private route: ActivatedRoute
  ) {
    this.id = route.snapshot.params.id;
  }

  async ngOnInit() {
    if (this.id) {
      await this.getCountry(this.id);
    }
  }
  async getCountry(id) {
    let _this = this;
    await this.service
      .getById(id)
      .toPromise()
      .then((r: {}) => {
        this.id = r.id;
        this.shortName = r.shortName;
        this.alpha2Code = r.alpha2Code;
        this.alpha3Code = r.alpha3Code;
        this.numericCode = r.numericCode;
        this.isIndependent = r.isIndependent;
      });
  }

  create() {
    console.log("Entring");
    let country = new Country();

    country.id = this.id;
    country.shortName = this.shortName;
    country.alpha2Code = this.alpha2Code;
    country.alpha3Code = this.alpha3Code;
    country.numericCode = this.numericCode;
    country.isIndependent = this.isIndependent;
    console.log(country);
    if(this.id){
      this.service.update(country).subscribe((r) => {
        alert("El pais se actualizó correctamente");
        this.cancel();
      });
    }
    this.service.create(country).subscribe((r) => {
      alert("El pais se guardó correctamente");
      this.cancel();
    });
  }
  cancel() {
    this.id = 0;
    this.shortName = "";
    this.alpha2Code = "";
    this.alpha3Code = "";
    this.numericCode = "";
    this.isIndependent = false;
  }
}
