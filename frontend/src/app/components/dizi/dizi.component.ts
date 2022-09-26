import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Dizi } from 'src/app/models/Dizi';
import { HomeService } from 'src/app/services/home.service';

@Component({
  selector: 'app-dizi',
  templateUrl: './dizi.component.html',
  styleUrls: ['./dizi.component.css']
})
export class DiziComponent implements OnInit {

  constructor(private homeService:HomeService, private route:ActivatedRoute) { }
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
