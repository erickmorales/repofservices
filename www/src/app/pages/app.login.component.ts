import { Component } from '@angular/core';
import { Router } from '@angular/router';

import { LoginService } from '../login.service';


@Component({
  selector: 'app-login',
  templateUrl: './app.login.component.html',
})
export class AppLoginComponent {
  username: string =""
  password: string =""


  constructor(private _LoginService:LoginService, 
    private _router:Router){

  }
  login(){
    this._LoginService.login(this.username, this.password).subscribe(data=> {
      console.log(data)
      if (data )
      {
        this._router.navigate(["/reserva"])
      }
      else{
        console.log("No existe el usuario")
      }
    })
    
  }


}
