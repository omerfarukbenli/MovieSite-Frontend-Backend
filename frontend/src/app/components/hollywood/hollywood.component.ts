import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Hollywood } from 'src/app/models/Hollywood';
import { HomeService } from 'src/app/services/home.service';

@Component({
  selector: 'app-hollywood',
  templateUrl: './hollywood.component.html',
  styleUrls: ['./hollywood.component.css']
})
export class HollywoodComponent implements OnInit {

  constructor(private homeService:HomeService, private route:ActivatedRoute) { }
  hollywood:Hollywood| undefined;



  ngOnInit(): void {


    this.route.paramMap.subscribe(
      params => {
        const id = params.get('id');
        if(id){
          this.homeService.getAllHollywoodById(id)
          .subscribe(
            response => {
              this.hollywood = response;

            }
          )
        }
      }
    );
  }

}
