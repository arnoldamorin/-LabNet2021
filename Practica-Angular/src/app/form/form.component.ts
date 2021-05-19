import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Shippers } from '../models/shippers';
import { ShippersService } from '../services/shippers.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss']
})
export class FormComponent implements OnInit {
 
  shipperEdit: Shippers;
  form: FormGroup;
  public id: number;


  get companyNameCtrl(): AbstractControl {
    return this.form.get('companyName')!;
  }
  get phoneCtrl(): AbstractControl {
    return this.form.get('phone')!;
  }
  constructor(private readonly fb: FormBuilder,
    private shippersService: ShippersService,
    private router:Router
  ) {

  }
  loadShippers() {
    this.shippersService.getShippers();
  }
  ngOnInit(): void {
    this.form = this.fb.group({
      companyName: ['', Validators.required],
      phone: ['', Validators.required]
    });
    this.shippersService.shipper$.subscribe(shippers => {
      this.companyNameCtrl.setValue(shippers.CompanyName),
        this.phoneCtrl.setValue(shippers.Phone),
        this.id = shippers.ShipperID
    });
  }

  onSubmit(form:Shippers): void {   
    if (this.id > 0) {
      form.ShipperID=this.id      
      this.shippersService.updateShippers(form).subscribe()
    } else {
      this.shippersService.addShippers(form).subscribe()
    }    
    this.form.reset();    
  }
  onClickLimpiar(): void {
    if (this.companyNameCtrl) {
      this.companyNameCtrl.setValue('');
    }
    if (this.phoneCtrl) {
      this.phoneCtrl.setValue('');
    }
  }
}
