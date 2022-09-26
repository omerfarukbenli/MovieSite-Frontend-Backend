import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Hollywood } from 'src/app/models/Hollywood';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-hollywood1',
  templateUrl: './hollywood1.component.html',
  styleUrls: ['./hollywood1.component.css']
})
export class Hollywood1Component implements OnInit {

  constructor(private homeService:Home1Service, private route:ActivatedRoute) { }
  hollywoods:Hollywood[] = [];
  hollywood:Hollywood |undefined;



  ngOnInit(): void {

    this.homeService.getAllHollywood()
    .subscribe(
      response => {
     this.hollywoods = response;
     this.hollywood = this.hollywoods[0];
      }


    )}}
