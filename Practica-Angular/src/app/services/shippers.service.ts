import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { environment } from 'src/environments/environment';
import { BehaviorSubject, Observable } from 'rxjs';
import { Shippers } from '../models/shippers';

@Injectable({
  providedIn: 'root'
})
export class ShippersService {
  private shipper = new BehaviorSubject<Shippers>(new Shippers);
  public shipper$ = this.shipper.asObservable();
_url = environment.apiURL
  constructor(
    private http:HttpClient
  ) { }
  sendShipper(shippers:Shippers){
    this.shipper.next(shippers)
  }
   getShippers():Observable<Shippers>{ 
     let header = new HttpHeaders()
     .set('Type-content','aplication/json')

     return this.http.get<Shippers>(this._url,{
       headers: header
     });
   }
   addShippers(shipper:Shippers):Observable<Shippers>{
     return this.http.post<Shippers>(this._url,shipper)
   }
   updateShippers(shipper:Shippers):Observable<Shippers>{     
     return this.http.put<Shippers>(this._url+"/"+shipper.ShipperID,shipper)
   }  
   deleteId(id:number){
     return this.http.delete<Shippers>(this._url+"/"+id)
   }
   
}
