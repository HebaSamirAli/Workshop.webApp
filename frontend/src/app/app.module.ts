import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

// imports from angular/material
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatCardModule} from '@angular/material/card';

// links to components ................
import { Header } from './components/header.component/header.component';

import { HomePage } from './pages/homepage/homepage';
import { SignPage } from './pages/signpage/signpage';
import { UserPage } from './pages/userpage/userpage';
import { WorkshopPage } from './pages/workshoppage/workshoppage';

import { SignInForm } from './components/signin.component/signin.component';
import { SignUpForm } from './components/signup.component/signup.component';
import { Workshops } from './components/workshops.component/workshops.component';
import { WorkshopDetails } from './components/workshopdetails.component/workshopdetails.component';

// services
import { ApiWorkshopService } from './services/api.workshop.service';


@NgModule({
  declarations: [
    AppComponent,
    HomePage,
    SignPage,
    UserPage,
    SignInForm,
    SignUpForm,
    Workshops,
    WorkshopDetails,
    Header,
    WorkshopPage,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule
  ],
  providers: [ApiWorkshopService],
  bootstrap: [AppComponent]
})
export class AppModule { }
