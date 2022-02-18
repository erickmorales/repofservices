import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';
import { NuevoUsuarioComponent } from './components/nuevo-usuario/nuevo-usuario.component';
import { NuevoLibroComponent } from './components/nuevo-libro/nuevo-libro.component';

@NgModule({
  declarations: [
    AppComponent,
    NuevoUsuarioComponent,
    NuevoLibroComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [], 
  bootstrap: [AppComponent]
})
export class AppModule { }
