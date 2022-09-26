import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AddAnasayfaRequest } from '../models/add-anasayfa.model';
import { AddAnimasyonRequest } from '../models/add-animasyon.model';
import { AddAvrupaRequest } from '../models/add-Avrupa.model';
import { AddDiziRequest } from '../models/add-dizi.model';
import { AddHollywoodRequest } from '../models/add-hollywood.model';
import { AddOlmedenRequest } from '../models/add-olmeden.model';
import { AddOscarRequest } from '../models/add-oscar.model';
import { AddSeriRequest } from '../models/add-seri.model';
import { Anasayfa } from '../models/Anasayfa';
import { Animasyon } from '../models/Animasyon';
import { Avrupa } from '../models/Avrupa';
import { Dizi } from '../models/Dizi';
import { Hollywood } from '../models/Hollywood';
import { Olmeden } from '../models/Olmeden';
import { Oscar } from '../models/Oscar';
import { Seri } from '../models/Seri';
import { UpdateAnasayfaRequest } from '../models/update-anasayfa.model';
import { UpdateAnimasyonRequest } from '../models/update-animasyon.model';
import { UpdateAvrupaRequest } from '../models/update-avrupa.model';
import { UpdateDiziRequest } from '../models/update-dizi.model';
import { UpdateHollywoodRequest } from '../models/update-hollywood.model';
import { UpdateOlmedenRequest } from '../models/update-olmeden.model';
import { UpdateOscarRequest } from '../models/update-oscar.model';
import { UpdateSeriRequest } from '../models/update-seri.model';

@Injectable({
  providedIn: 'root'
})
export class Home1Service {

  constructor(private http:HttpClient) { }
  //Anasayfa//
  getAllAnasayfa(): Observable<Anasayfa[]>{
    return this.http.get<Anasayfa[]>('http://localhost:5222/api/Anasayfa1');
  }


  getAllAnasayfaById(id:string): Observable<Anasayfa>{
    return this.http.get<Anasayfa>('http://localhost:5222/api/Anasayfa1/' + id); //id olmayabilir
  }


  updatedAnasayfa(id:string | undefined, updateAnasayfaRequest:UpdateAnasayfaRequest): Observable<Anasayfa>{
    return this.http.put<Anasayfa>('http://localhost:5222/api/Anasayfa1/' + id, updateAnasayfaRequest); //id olmayabilir
  }



  addAnasayfa(addAnasayfaRequest:AddAnasayfaRequest): Observable<Anasayfa>{
    return this.http.post<Anasayfa>('http://localhost:5222/api/Anasayfa1', addAnasayfaRequest);
  }


  deleteAnasayfa(id:string | undefined): Observable<Anasayfa>{
    return this.http.delete<Anasayfa>('http://localhost:5222/api/Anasayfa1/' + id );
  }


  //Animasyon//
  getAllAnimasyon(): Observable<Animasyon[]>{
    return this.http.get<Animasyon[]>('http://localhost:5222/api/Animasyon1');
  }


  getAllAnimasyonById(id:string): Observable<Animasyon>{
    return this.http.get<Animasyon>('http://localhost:5222/api/Animasyon1/' + id); //id olmayabilir
  }


  updatedAnimasyon(id:string | undefined, updateAniasyonRequest:UpdateAnimasyonRequest): Observable<Animasyon>{
    return this.http.put<Animasyon>('http://localhost:5222/api/Animasyon1/' + id, updateAniasyonRequest); //id olmayabilir
  }



  addAnimasyon(addAnimasyonRequest:AddAnimasyonRequest): Observable<Animasyon>{
    return this.http.post<Animasyon>('http://localhost:5222/api/Animasyon1', addAnimasyonRequest);
  }


  deleteAnimasyon(id:string | undefined): Observable<Animasyon>{
    return this.http.delete<Animasyon>('http://localhost:5222/api/Animasyon1/' + id );
  }


  //Avrupa//
  getAllAvrupa(): Observable<Avrupa[]>{
    return this.http.get<Avrupa[]>('http://localhost:5222/api/Avrupa1');
  }


  getAllAvrupaById(id:string): Observable<Avrupa>{
    return this.http.get<Avrupa>('http://localhost:5222/api/Avrupa1/' + id); //id olmayabilir
  }


  updatedAvrupa(id:string | undefined, updateAvrupaRequest:UpdateAvrupaRequest): Observable<Avrupa>{
    return this.http.put<Avrupa>('http://localhost:5222/api/Avrupa1/' + id, updateAvrupaRequest); //id olmayabilir
  }



  addAvrupa(addAvrupaRequest:AddAvrupaRequest): Observable<Avrupa>{
    return this.http.post<Avrupa>('http://localhost:5222/api/Avrupa1', addAvrupaRequest);
  }


  deleteAvrupa(id:string | undefined): Observable<Avrupa>{
    return this.http.delete<Avrupa>('http://localhost:5222/api/Avrupa1/' + id );
  }


  //Dizi//
  getAllDizi(): Observable<Dizi[]>{
    return this.http.get<Dizi[]>('http://localhost:5222/api/Dizi1');
  }


  getAllDiziById(id:string): Observable<Dizi>{
    return this.http.get<Dizi>('http://localhost:5222/api/Dizi1/' + id); //id olmayabilir
  }


  updatedDizi(id:string | undefined, updateDiziRequest:UpdateDiziRequest): Observable<Dizi>{
    return this.http.put<Dizi>('http://localhost:5222/api/Dizi1/' + id, updateDiziRequest); //id olmayabilir
  }



  addDizi(addDiziRequest:AddDiziRequest): Observable<Dizi>{
    return this.http.post<Dizi>('http://localhost:5222/api/Dizi1', addDiziRequest);
  }


  deleteDizi(id:string | undefined): Observable<Dizi>{
    return this.http.delete<Dizi>('http://localhost:5222/api/Dizi1/' + id );
  }


  //Hollywood//
  getAllHollywood(): Observable<Hollywood[]>{
    return this.http.get<Hollywood[]>('http://localhost:5222/api/Hollywood1');
  }


  getAllHollywoodById(id:string): Observable<Hollywood>{
    return this.http.get<Hollywood>('http://localhost:5222/api/Hollywood1/' + id); //id olmayabilir
  }


  updatedHollywood(id:string | undefined, updateHollywoodRequest:UpdateHollywoodRequest): Observable<Hollywood>{
    return this.http.put<Hollywood>('http://localhost:5222/api/Hollywood1/' + id, updateHollywoodRequest); //id olmayabilir
  }



  addHollywood(addHollywoodRequest:AddHollywoodRequest): Observable<Hollywood>{
    return this.http.post<Hollywood>('http://localhost:5222/api/Hollywood1', addHollywoodRequest);
  }


  deleteHollywood(id:string | undefined): Observable<Hollywood>{
    return this.http.delete<Hollywood>('http://localhost:5222/api/Hollywood1/' + id );
  }


  //Olmeden//
  getAllOlmeden(): Observable<Olmeden[]>{
    return this.http.get<Olmeden[]>('http://localhost:5222/api/Olmeden1');
  }


  getAllOlmedenById(id:string): Observable<Olmeden>{
    return this.http.get<Olmeden>('http://localhost:5222/api/Olmeden1/' + id); //id olmayabilir
  }


  updatedOlmeden(id:string | undefined, updateOlmedenRequest:UpdateOlmedenRequest): Observable<Olmeden>{
    return this.http.put<Olmeden>('http://localhost:5222/api/Olmeden1/' + id, updateOlmedenRequest); //id olmayabilir
  }



  addOlmeden(addOlmedenRequest:AddOlmedenRequest): Observable<Olmeden>{
    return this.http.post<Olmeden>('http://localhost:5222/api/Olmeden1', addOlmedenRequest);
  }


  deleteOlmeden(id:string | undefined): Observable<Olmeden>{
    return this.http.delete<Olmeden>('http://localhost:5222/api/Olmeden1/' + id );
  }


  //Oscar//
  getAllOscar(): Observable<Oscar[]>{
    return this.http.get<Oscar[]>('http://localhost:5222/api/Oscar1');
  }


  getAllOscarById(id:string): Observable<Oscar>{
    return this.http.get<Oscar>('http://localhost:5222/api/Oscar1/' + id); //id olmayabilir
  }


  updatedOscar(id:string | undefined, updateOscarRequest:UpdateOscarRequest): Observable<Oscar>{
    return this.http.put<Oscar>('http://localhost:5222/api/Oscar1/' + id, updateOscarRequest); //id olmayabilir
  }



  addOscar(addOscarRequest:AddOscarRequest): Observable<Oscar>{
    return this.http.post<Oscar>('http://localhost:5222/api/Oscar1', addOscarRequest);
  }


  deleteOscar(id:string | undefined): Observable<Oscar>{
    return this.http.delete<Oscar>('http://localhost:5222/api/Oscar1/' + id );
  }


  //Seri//
  getAllSeri(): Observable<Seri[]>{
    return this.http.get<Seri[]>('http://localhost:5222/api/Seri1');
  }


  getAllSeriById(id:string): Observable<Seri>{
    return this.http.get<Seri>('http://localhost:5222/api/Seri1/' + id); //id olmayabilir
  }


  updatedSeri(id:string | undefined, updateSeriRequest:UpdateSeriRequest): Observable<Seri>{
    return this.http.put<Seri>('http://localhost:5222/api/Seri1/' + id, updateSeriRequest); //id olmayabilir
  }



  addSeri(addSeriRequest:AddSeriRequest): Observable<Seri>{
    return this.http.post<Seri>('http://localhost:5222/api/Seri1', addSeriRequest);
  }


  deleteSeri(id:string | undefined): Observable<Seri>{
    return this.http.delete<Seri>('http://localhost:5222/api/Seri1/' + id );
  }
}
