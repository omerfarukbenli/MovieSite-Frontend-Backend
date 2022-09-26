import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Dizi } from 'src/app/models/Dizi';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-dizi1',
  templateUrl: './dizi1.component.html',
  styleUrls: ['./dizi1.component.css']
})
export class Dizi1Component implements OnInit {

  constructor(private homeService:Home1Service, private route:ActivatedRoute) { }
  dizis:Dizi[] = [];
  dizi:Dizi |undefined;



  ngOnInit(): void {

    this.homeService.getAllDizi()
    .subscribe(
      response => {
     this.dizis = response;
     this.dizi = this.dizis[0];
      }


    )}}
