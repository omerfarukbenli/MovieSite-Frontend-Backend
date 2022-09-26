import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Seri } from 'src/app/models/Seri';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-seri2',
  templateUrl: './seri2.component.html',
  styleUrls: ['./seri2.component.css']
})
export class Seri2Component implements OnInit {

  constructor(private homeService:Home1Service, private route:ActivatedRoute) { }
  seri:Seri | undefined;

  ngOnInit(): void {


    this.route.paramMap.subscribe(
      params => {
        const id = params.get('id');
        if(id){
          this.homeService.getAllSeriById(id)
          .subscribe(
            response => {
              this.seri = response;

            }
          )
        }
      }
    );
  }

}
