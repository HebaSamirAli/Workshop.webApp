import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

// imports from angular/material
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatCardModule} from '@angular/material/card';

// links to components ................
import { HomePage } from './pages/homepage.pages/homepage.component';
import { SignPage } from './pages/signpage.pages/signpage.component';
import { UserPage } from './pages/userpage.pages/userpage.component';


@NgModule({
  declarations: [
    AppComponent,
    HomePage,
    SignPage,
    UserPage
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
