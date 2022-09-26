import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Anasayfa } from 'src/app/models/Anasayfa';


import { HomeService } from 'src/app/services/home.service';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
export class PostComponent implements OnInit {

  constructor(private homeService:HomeService, private route:ActivatedRoute) { }


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






















