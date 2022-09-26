import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Seri } from 'src/app/models/Seri';
import { HomeService } from 'src/app/services/home.service';

@Component({
  selector: 'app-seri',
  templateUrl: './seri.component.html',
  styleUrls: ['./seri.component.css']
})
export class SeriComponent implements OnInit {

  constructor(private homeService:HomeService, private route:ActivatedRoute) { }
  seri:Seri| undefined;



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
