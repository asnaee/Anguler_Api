import { Component } from '@angular/core';
import { DATAService } from 'src/app/Service/data.service';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent {
  da:any;
  constructor(private SERV:DATAService){}
 ngOnInit(){
  this.showEmp();
 }
 showEmp(){
  this.SERV.getEmp().subscribe(j=>{
    console.log(j);
    this.da=j;
  });
 }
}
