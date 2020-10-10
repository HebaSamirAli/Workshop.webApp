import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomePage } from './pages/homepage/homepage';
import { SignPage } from './pages/signpage/signpage';
import { UserPage } from './pages/userpage/userpage';
import { WorkshopPage } from './pages/workshoppage/workshoppage';


const routes: Routes = [
  { path: 'home', component: HomePage },
  { path:'sign', component: SignPage },
  { path: 'user', component: UserPage},
  { path: 'workshops', component: WorkshopPage},
  { path: '', redirectTo:'/home', pathMatch: 'full' },
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
