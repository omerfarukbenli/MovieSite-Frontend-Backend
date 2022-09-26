import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Olmeden } from 'src/app/models/Olmeden';
import { HomeService } from 'src/app/services/home.service';

@Component({
  selector: 'app-olmeden',
  templateUrl: './olmeden.component.html',
  styleUrls: ['./olmeden.component.css']
})
export class OlmedenComponent implements OnInit {

  constructor(private homeService:HomeService, private route:ActivatedRoute) { }
  olmeden:Olmeden| undefined;



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
