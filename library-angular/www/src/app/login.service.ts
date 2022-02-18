import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class LoginService {
urlbase="http://localhost:54966/api/Users/"

  constructor(private http : HttpClient) { }

   httpHeaders = new HttpHeaders({
    'Content-Type': 'application/json'
});
  
  login(userName: string, password: string): Observable<any> {

    
  
      return this.http.get(this.urlbase  + 'Login/' + userName + '/' + password, {headers: this.httpHeaders })
      .pipe(
        map((resp: any) => {
          return resp;
        }),
        catchError(err => {
          console.log('Error.', err.error.exception.Message);
            return Observable.throw(err);
        })
      );
    }
}
