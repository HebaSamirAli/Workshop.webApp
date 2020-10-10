import { Component } from '@angular/core';
import { FormControl } from '@angular/forms';
import { WorkshopDetails } from '../workshopdetails.component/workshopdetails.component';
import { ApiWorkshopService } from '../../services/api.workshop.service';

@Component({
    selector : 'Workshops',
    templateUrl : 'workshops.html',
    styleUrls : ['workshops.styles.css']
})
export class Workshops{
    allWorkshops = [];
    
    constructor(private api: ApiWorkshopService){}
    ngOnInit(){
        this.api.getWorkshops().subscribe(res =>{
            this.allWorkshops = res["Result"] ;
            console.log(this.allWorkshops[0]);
        });
        
    }

    title = 'Workshops List'
    nn = "";
    choosedWorkshop = [];

    
    onClicked(w){
        this.choosedWorkshop = [
                    w.WorkshopId,
                    w.WorkshopName,
                    w.Lecturer,
                    w.WorkshopAddress,
                    w.StartDate,
                    w.EndDate,
                    w.StartTime,
                    w.EndTime];
    }

    /*
    workshops = [
        {
            'id':1,
            'name':'workshop1',
            'instructor':'ins1',
            'address':'add',
            'startDate':'',
            'endDate':'',
            'startTime':'',
            'endTime':''
        },
        {
            'id':2,
            'name':'workshop2',
            'instructor':'ins2',
            'address':'add',
            'startDate':'',
            'endDate':'',
            'starTtime':'',
            'endTime':''
        },
        {
            'id':3,
            'name':'workshop3',
            'instructor':'ins3',
            'address':'add',
            'startDate':'',
            'endDate':'',
            'startTime':'',
            'endTime':''
        },
        {
            'id':4,
            'name':'workshop4',
            'instructor':'ins1',
            'address':'add',
            'startDate':'',
            'endDate':'',
            'startTime':'',
            'endTime':''
        },
        {
            'id':5,
            'name':'workshop5',
            'instructor':'ins2',
            'address':'add',
            'startDate':'12:2:20',
            'endDate':'',
            'startTime':'11',
            'endTime':'12'
        },
        {
            'id':6,
            'name':'workshop6',
            'instructor':'ins3',
            'address':'add',
            'startDate':'1:1:1',
            'endDate':'',
            'startTime':'12',
            'endTime':'11'
        }
    ]
    */
}