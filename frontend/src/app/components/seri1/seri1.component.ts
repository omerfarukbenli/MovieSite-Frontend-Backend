import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Seri } from 'src/app/models/Seri';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-seri1',
  templateUrl: './seri1.component.html',
  styleUrls: ['./seri1.component.css']
})
export class Seri1Component implements OnInit {

  constructor(private homeService:Home1Service, private route:ActivatedRoute) { }
  seris:Seri[] = [];
  seri:Seri |undefined;



  ngOnInit(): void {

    this.homeService.getAllSeri()
    .subscribe(
      response => {
     this.seris = response;
     this.seri = this.seris[0];
      }


    )}}
