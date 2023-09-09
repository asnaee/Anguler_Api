import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { EMP } from '../Class/emp';

@Injectable({
  providedIn: 'root'
})
export class DATAService {

  constructor(private htt:HttpClient) { }
  getEmp():Observable<any>{
    return this.htt.get<any>("http://localhost:5004/api/EM");
  }
  postEmp(data:EMP):Observable<EMP>{
    return this.htt.post<EMP>("http://localhost:5004/api/EM",data)
  }

  deiEmp(id:number):Observable<any>{
    return this.htt.delete<any>("http://localhost:5004/api/EM/"+id);
  }
  UpdEmp(data: EMP): Observable<EMP> {
    return this.htt.put<EMP>("http://localhost:5004/api/EM/" + data.employeeId, data);
  }
}
