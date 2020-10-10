import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class ApiWorkshopService {
    constructor(private http: HttpClient){}

    getWorkshops(){
        
        return this.http.get('https://localhost:44385/api/WorkshopsList/getall')
    }
}