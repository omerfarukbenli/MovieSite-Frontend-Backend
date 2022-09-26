import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Oscar } from 'src/app/models/Oscar';
import { HomeService } from 'src/app/services/home.service';

@Component({
  selector: 'app-oscar',
  templateUrl: './oscar.component.html',
  styleUrls: ['./oscar.component.css']
})
export class OscarComponent implements OnInit {

  constructor(private homeService:HomeService, private route:ActivatedRoute) { }
  oscar:Oscar| undefined;
  ngOnInit(): void {


    this.route.paramMap.subscribe(
      params => {
        const id = params.get('id');
        if(id){
          this.homeService.getAllOscarById(id)
          .subscribe(
            response => {
              this.oscar = response;

            }
          )
        }
      }
    );
  }

}
