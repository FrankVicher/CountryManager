import { CountryEditComponent } from './country-edit/country-edit.component';
import { CountryDetailComponent } from './country-detail/country-detail.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CountryComponentComponent } from './country-component/country-component.component';

const routes: Routes = [
  {path: '', component: CountryComponentComponent},
  {path: 'countryDetail/:id', component: CountryDetailComponent},
  {path: 'countryNew', component: CountryEditComponent},
  {path: 'countryEdit/:id', component: CountryEditComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
