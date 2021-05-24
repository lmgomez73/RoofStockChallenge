import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';

import { Property } from '../models/property.model';
import { PropertyService } from '../property.service';

const USER_INFO = [
  {"name": "John Smith", "occupation": "Advisor", "dateOfBirth": "1984-05-05", "age": 36},
  {"name": "Muhi Masri", "occupation": "Developer", "dateOfBirth": "1992-02-02", "age": 28},
  {"name": "Peter Adams", "occupation": "HR", "dateOfBirth": "2000-01-01", "age": 20},
  {"name": "Lora Bay", "occupation": "Marketing", "dateOfBirth": "1977-03-03", "age": 43},
];

const USER_SCHEMA : any  = {
  "name": "text",
  "occupation": "text",
  "age": "number",
}
@Component({
  selector: 'app-properties-list',
  templateUrl: './properties-list.component.html',
  styleUrls: ['./properties-list.component.scss']
})
export class PropertiesListComponent implements OnInit {

  displayedColumns: string[] = ['address', 'yearBuilt', 'listPrice','monthlyRent', 'grossYield', '$$edit'];
  
  dataSchema = USER_SCHEMA;
  dataSource: MatTableDataSource<Property>;
  cacheData: Property[];
  constructor( private PropertiesService: PropertyService) { 
    this.dataSource=new MatTableDataSource([] as Property[]);
    this.cacheData = [] as Property[];
  }

  ngOnInit() {
    this.PropertiesService.getAll().subscribe(data=>{
      this.cacheData = data;
      this.dataSource = new MatTableDataSource(this.cacheData);
    });
  }

  cancel(element : any){
    if(element.isNew){
      this.cacheData.pop();
    }
    this.dataSource = new MatTableDataSource(this.cacheData);
    element.isEdit= !element.isEdit;
  }

  update(element: any){
    if(element.isNew){
        this.PropertiesService.add(element).subscribe();
    }
    else{
      this.PropertiesService.update(element).subscribe();

    }
    element.isEdit= !element.isEdit;
  }

  addRow(){
    const newRow = {} as any;
    newRow.isEdit = true;
    newRow.isNew = true;
    this.cacheData.push(newRow);
    this.dataSource = new MatTableDataSource(this.cacheData);
  }

  
}
