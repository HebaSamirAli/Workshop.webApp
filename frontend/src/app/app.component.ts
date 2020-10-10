import { Component } from '@angular/core';
import { Header } from './components/header.component/header.component';
import { HomePage } from './pages/homepage/homepage';
import { SignPage } from './pages/signpage/signpage';
import { UserPage } from './pages/userpage/userpage';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'frontend';
}

