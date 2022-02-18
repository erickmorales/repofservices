import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core'; 
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class NuevousuarioService {

  public url:string;

  constructor(public httpClient: HttpClient ) { 
    this.url ='http://localhost:54966/api/Users/Create'
  }

  public save(nuevousuario:NuevousuarioService):Observable<any>{
    return this.httpClient.post(this.url, nuevousuario)
  }
}
