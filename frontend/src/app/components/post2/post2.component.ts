import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Anasayfa } from 'src/app/models/Anasayfa';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-post2',
  templateUrl: './post2.component.html',
  styleUrls: ['./post2.component.css']
})
export class Post2Component implements OnInit {

  constructor(private homeService:Home1Service, private route:ActivatedRoute) { }
  anasayfa:Anasayfa | undefined;
  ngOnInit(): void {


    this.route.paramMap.subscribe(
      params => {
        const id = params.get('id');
        if(id){
          this.homeService.getAllAnasayfaById(id)
          .subscribe(
            response => {
              this.anasayfa = response;

            }
          )
        }
      }
    );
  }

}
