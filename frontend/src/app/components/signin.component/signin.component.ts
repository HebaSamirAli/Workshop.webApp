import { Component } from '@angular/core';
import { FormControl } from '@angular/forms';
import {MatCardModule} from '@angular/material/card';

@Component({
    selector : 'SignInForm',
    templateUrl : 'signin.html',
    styleUrls : ['signin.styles.css']
})
export class SignInForm{
    title = 'Sign In Component'
}