import { Component, OnInit } from '@angular/core';
import { Property } from '../models/property.model';
import { PropertiesService } from './properties.service';

@Component({
  selector: 'app-properties',
  templateUrl: './properties.component.html',
  styleUrls: ['./properties.component.css'],
  providers: [PropertiesService]
})
export class PropertiesComponent implements OnInit {

  
  editField: string;
  propertiesList: Property[]
  constructor( private PropertiesService: PropertiesService) { }

  ngOnInit() {
    this.PropertiesService.getAll().subscribe(data=>{this.propertiesList = data})
  }

}
