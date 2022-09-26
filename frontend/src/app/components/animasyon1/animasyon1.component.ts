import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Animasyon } from 'src/app/models/Animasyon';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-animasyon1',
  templateUrl: './animasyon1.component.html',
  styleUrls: ['./animasyon1.component.css']
})
export class Animasyon1Component implements OnInit {

  constructor(private homeService:Home1Service, private route:ActivatedRoute) { }
  animasyons:Animasyon[] = [];
  animasyon:Animasyon | undefined;

  ngOnInit(): void {


    this.homeService.getAllAnimasyon()
    .subscribe(
      response => {
     this.animasyons = response;
     this.animasyon = this.animasyons[0];
      }


    )}}
