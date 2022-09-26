import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Anasayfa } from 'src/app/models/Anasayfa';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-post1',
  templateUrl: './post1.component.html',
  styleUrls: ['./post1.component.css']
})
export class Post1Component implements OnInit {

  constructor(private homeService:Home1Service, private route:ActivatedRoute) { }


  anasayfas:Anasayfa[] = [];
  anasayfa:Anasayfa |undefined;
  ngOnInit(): void {


    this.homeService.getAllAnasayfa()
    .subscribe(
      response => {
     this.anasayfas = response;
     this.anasayfa = this.anasayfas[0];
      }


    )}}
