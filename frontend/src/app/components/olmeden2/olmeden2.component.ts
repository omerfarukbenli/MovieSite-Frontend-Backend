import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Olmeden } from 'src/app/models/Olmeden';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-olmeden2',
  templateUrl: './olmeden2.component.html',
  styleUrls: ['./olmeden2.component.css']
})
export class Olmeden2Component implements OnInit {

  constructor(private homeService:Home1Service, private route:ActivatedRoute) { }
  olmeden:Olmeden | undefined;
  ngOnInit(): void {


    this.route.paramMap.subscribe(
      params => {
        const id = params.get('id');
        if(id){
          this.homeService.getAllOlmedenById(id)
          .subscribe(
            response => {
              this.olmeden = response;

            }
          )
        }
      }
    );
  }

}
