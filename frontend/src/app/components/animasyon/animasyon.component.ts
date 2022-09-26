import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Animasyon } from 'src/app/models/Animasyon';
import { HomeService } from 'src/app/services/home.service';

@Component({
  selector: 'app-animasyon',
  templateUrl: './animasyon.component.html',
  styleUrls: ['./animasyon.component.css']
})
export class AnimasyonComponent implements OnInit {

  constructor(private homeService:HomeService, private route:ActivatedRoute) { }
  
  animasyons:Animasyon[] = [];
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


