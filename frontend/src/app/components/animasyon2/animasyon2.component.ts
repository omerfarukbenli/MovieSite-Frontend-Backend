import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Animasyon } from 'src/app/models/Animasyon';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-animasyon2',
  templateUrl: './animasyon2.component.html',
  styleUrls: ['./animasyon2.component.css']
})
export class Animasyon2Component implements OnInit {

  constructor(private homeService:Home1Service, private route:ActivatedRoute) { }
  animasyon:Animasyon | undefined;

  ngOnInit(): void {


    this.route.paramMap.subscribe(
      params => {
        const id = params.get('id');
        if(id){
          this.homeService.getAllAnimasyonById(id)
          .subscribe(
            response => {
              this.animasyon = response;

            }
          )
        }
      }
    );
  }

}
