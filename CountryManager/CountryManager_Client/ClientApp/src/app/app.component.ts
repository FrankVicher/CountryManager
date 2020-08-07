import { Component } from '@angular/core';
import { CountryServiceService } from './country-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ClientApp';
  constructor(private countryService: CountryServiceService){ }

}
