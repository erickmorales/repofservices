import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  public url: string;

  constructor(public httpClient: HttpClient ) { 
    this.url = './assets/MOCK_DATA.json';
  }

  public getAll():Observable<any>{
    return this.httpClient.get(this.url);
  }
}
