import { Component } from '@angular/core';
import {  Router } from '@angular/router';
import { EMP } from 'src/app/Class/emp';
import { DATAService } from 'src/app/Service/data.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent {
  da: any;
  empfr: EMP = {
    employeeId: undefined,
    employeeName: '',
    age: 0,
    joindate: undefined,
    ismarrid: false,
    addres: ''
    //all EMP Class Fild Nullble Kore Dete Hobe??
  }
  constructor(private SERV: DATAService,private rt:Router) { }
  ngOnInit() {
    this.showEmp();
  }
  showEmp() {
    this.SERV.getEmp().subscribe(j => {
      console.log(j);
      this.da = j;
    });
  }
  InsertDa() {
    if (this.empfr.employeeId === undefined) {
      this.SERV.postEmp(this.empfr).subscribe(x => {
        console.log(x);
        this.rt.navigate(['/CR']);
        this.showEmp();
        this.empfr = {
          employeeId: undefined,
          employeeName: '',
          age: undefined,
          joindate: undefined,
          ismarrid: undefined,
          addres: ''
        }
      });
    }
    else
    {
      this.Onupemp(this.empfr);
      this.empfr = {
        employeeId: undefined,
        employeeName: '',
        age: undefined,
        joindate: undefined,
        ismarrid: undefined,
        addres: ''
      }
    }
   
  }
  onDEL(id:number) {
    this.SERV.deiEmp(id).subscribe(x => {
      this.rt.navigate(['/CR']);
      this.showEmp();
    })
  }
  datapopulat(emp:EMP) {
    this.empfr = emp;
  }
  Onupemp(dat:EMP) {
    this.SERV.UpdEmp(dat).subscribe(f => {
      this.showEmp();
    })
  }
}
