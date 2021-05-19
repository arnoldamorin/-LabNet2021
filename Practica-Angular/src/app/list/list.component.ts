
import { Component, OnInit, Output } from '@angular/core';
import * as EventEmitter from 'events';
import { Shippers } from '../models/shippers';
import { ShippersService } from '../services/shippers.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {  

  public shippersList : any = []

  public shippers: Shippers; 

  constructor( private shippersService:ShippersService ) {}
  ngOnInit(): void {
    this.shippersService.getShippers()
    .subscribe(resp => {this.shippersList = resp})
  }
  Edit(shipper:Shippers){
    this.shippersService.sendShipper(shipper);
    this.ngOnInit();
  } 
  Delete(shipperID:number){
    this.shippersService.deleteId(shipperID).subscribe(
      data=> {
        console.log(data)
        this.ngOnInit();
      }
    );
    
  }
}
