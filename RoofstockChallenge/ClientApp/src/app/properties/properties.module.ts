import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { PropertiesComponent } from './properties.component';
import { PropertiesService } from './properties.service';
// import { PropertyRowComponent } from './property-row/property-row.component';


const routes: Routes = [
  { path: '', component: PropertiesComponent }
];

@NgModule({
  
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ],
  providers: [
    PropertiesService
  ],
  declarations: []
})
export class PropertiesModule { }
