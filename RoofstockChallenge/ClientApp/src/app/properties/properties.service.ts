import { Injectable } from '@angular/core';
import { ApiService } from '../api.service';
import { Observable } from 'rxjs';

import { map } from 'rxjs/operators';
import { Property } from '../models/property.model';

@Injectable({
  providedIn: 'root'
})
export class PropertiesService {
  constructor (
    private apiService: ApiService
  ) {}

  getAll(): Observable<Property[]> {
    return this.apiService.get('/Property')
          .pipe(map(data => data));
  }
}
