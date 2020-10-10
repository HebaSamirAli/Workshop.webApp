import { Component , Input} from '@angular/core';
import { FormControl } from '@angular/forms';

@Component({
    selector : 'WorkshopDetails',
    templateUrl : 'workshopdetails.html',
    styleUrls : ['workshopdetails.styles.css']
})
export class WorkshopDetails{
    title = 'Workshop Details'
    @Input() workshop = [];
    
}