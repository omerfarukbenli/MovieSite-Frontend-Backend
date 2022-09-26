import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Avrupa } from 'src/app/models/Avrupa';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-avrupa1',
  templateUrl: './avrupa1.component.html',
  styleUrls: ['./avrupa1.component.css']
})
export class Avrupa1Component implements OnInit {

  constructor(private homeService:Home1Service, private route:ActivatedRoute) { }
  avrupa:Avrupa | undefined;
  avrupas:Avrupa[] = [];

  ngOnInit(): void {

    this.homeService.getAllAvrupa()
    .subscribe(
      response => {
     this.avrupas = response;
     this.avrupa = this.avrupas[0];
      }


    )}}
