import { Injectable } from '@angular/core';
import { HttpClient,HttpErrorResponse,HttpParams,HttpHeaders } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class HomeserviceService {
rootUrl="http://localhost:63744/api/Eshopping/GetAllProduct"
  constructor(public http:HttpClient ) { }
  GetAllData(){
     return this.http.get(this.rootUrl).toPromise();

  }
}
