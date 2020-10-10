import { Component }  from '@angular/core';
import { SignInForm } from '../../components/signin.component/signin.component';
import { SignUpForm } from '../../components/signup.component/signup.component';

@Component({
    selector : 'SignPage',
    templateUrl : 'signpage.html',
    styleUrls : ['signpage.styles.css']
})
export class SignPage{
    title = 'Sign Page'
}