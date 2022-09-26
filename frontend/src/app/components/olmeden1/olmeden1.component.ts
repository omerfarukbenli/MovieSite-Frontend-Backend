import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Olmeden } from 'src/app/models/Olmeden';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-olmeden1',
  templateUrl: './olmeden1.component.html',
  styleUrls: ['./olmeden1.component.css']
})
export class Olmeden1Component implements OnInit {

  constructor(private homeService:Home1Service, private route:ActivatedRoute) { }
  olmedens:Olmeden[] = [];
  olmeden:Olmeden |undefined;



  ngOnInit(): void {


    this.homeService.getAllOlmeden()
    .subscribe(
      response => {
     this.olmedens = response;
     this.olmeden = this.olmedens[0];
      }


    )}}
