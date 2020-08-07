import { CountryServiceService } from './country-service.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CountryComponentComponent } from './country-component/country-component.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { CountryDetailComponent } from './country-detail/country-detail.component';
import { CountryEditComponent } from './country-edit/country-edit.component';

@NgModule({
  declarations: [
    AppComponent,
    CountryComponentComponent,
    CountryDetailComponent,
    CountryEditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [CountryServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
