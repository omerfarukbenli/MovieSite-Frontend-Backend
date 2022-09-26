import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Hollywood } from 'src/app/models/Hollywood';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-hollywood2',
  templateUrl: './hollywood2.component.html',
  styleUrls: ['./hollywood2.component.css']
})
export class Hollywood2Component implements OnInit {

  constructor(private homeService:Home1Service, private route:ActivatedRoute) { }
  hollywood:Hollywood | undefined;



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
