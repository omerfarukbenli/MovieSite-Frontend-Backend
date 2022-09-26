import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Oscar } from 'src/app/models/Oscar';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-oscar1',
  templateUrl: './oscar1.component.html',
  styleUrls: ['./oscar1.component.css']
})
export class Oscar1Component implements OnInit {

  constructor(private homeService:Home1Service, private route:ActivatedRoute) { }
  oscars:Oscar[] = [];
  oscar:Oscar |undefined;
  ngOnInit(): void {

    this.homeService.getAllOscar()
    .subscribe(
      response => {
     this.oscars = response;
     this.oscar = this.oscars[0];
      }


    )}}
