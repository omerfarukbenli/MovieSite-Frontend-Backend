import { Component, OnInit } from '@angular/core';
import { Anasayfa } from 'src/app/models/Anasayfa';
import { Animasyon } from 'src/app/models/Animasyon';
import { Avrupa } from 'src/app/models/Avrupa';
import { Dizi } from 'src/app/models/Dizi';
import { Hollywood } from 'src/app/models/Hollywood';
import { Olmeden } from 'src/app/models/Olmeden';
import { Oscar } from 'src/app/models/Oscar';
import { Seri } from 'src/app/models/Seri';
import { HomeService } from 'src/app/services/home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private homeService:HomeService) { }




  anasayfas:Anasayfa[] = [];
  anasayfa:Anasayfa |undefined;

  animasyons:Animasyon[] = [];
  animasyon:Animasyon |undefined;

  avrupas:Avrupa[] = [];
  avrupa:Avrupa |undefined;

  dizis:Dizi[] = [];
  dizi:Dizi |undefined;

  hollywoods:Hollywood[] = [];
  hollywood:Hollywood |undefined;

  olmedens:Olmeden[] = [];
  olmeden:Olmeden |undefined;

  oscars:Oscar[] = [];
  oscar:Oscar |undefined;

  seris:Seri[] = [];
  seri:Seri |undefined;




  ngOnInit(): void {

    this.homeService.getAllAnasayfa()
    .subscribe(
      response => {
     this.anasayfas = response;
     this.anasayfa = this.anasayfas[0];
      }
    ),


    this.homeService.getAllAnimasyon()
    .subscribe(
      response => {
     this.animasyons = response;
     this.animasyon = this.animasyons[0];
      }


    ),
    this.homeService.getAllAvrupa()
    .subscribe(
      response => {
     this.avrupas = response;
     this.avrupa = this.avrupas[0];
      }
    ),



    this.homeService.getAllDizi()
    .subscribe(
      response => {
     this.dizis = response;
     this.dizi = this.dizis[0];
      }
    ),


    this.homeService.getAllHollywood()
    .subscribe(
      response => {
     this.hollywoods = response;
     this.hollywood = this.hollywoods[0];
      }
    ),


    this.homeService.getAllOlmeden()
    .subscribe(
      response => {
     this.olmedens = response;
     this.olmeden = this.olmedens[0];
      }
    ),



    this.homeService.getAllOscar()
    .subscribe(
      response => {
     this.oscars = response;
     this.oscar = this.oscars[0];
      }
    ),


    this.homeService.getAllSeri()
    .subscribe(
      response => {
     this.seris = response;
     this.seri = this.seris[0];
      }
    )









  }


}
