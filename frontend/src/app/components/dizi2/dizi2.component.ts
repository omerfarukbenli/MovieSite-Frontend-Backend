import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Dizi } from 'src/app/models/Dizi';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-dizi2',
  templateUrl: './dizi2.component.html',
  styleUrls: ['./dizi2.component.css']
})
export class Dizi2Component implements OnInit {

  constructor(private homeService:Home1Service, private route:ActivatedRoute) { }
  dizi:Dizi | undefined;
  ngOnInit(): void {


    this.route.paramMap.subscribe(
      params => {
        const id = params.get('id');
        if(id){
          this.homeService.getAllDiziById(id)
          .subscribe(
            response => {
              this.dizi = response;

            }
          )
        }
      }
    );
  }
  }


