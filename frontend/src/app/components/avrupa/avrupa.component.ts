import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Avrupa } from 'src/app/models/Avrupa';
import { HomeService } from 'src/app/services/home.service';

@Component({
  selector: 'app-avrupa',
  templateUrl: './avrupa.component.html',
  styleUrls: ['./avrupa.component.css']
})
export class AvrupaComponent implements OnInit {

  constructor(private homeService:HomeService, private route:ActivatedRoute) { }
  avrupa:Avrupa | undefined;
  ngOnInit(): void {


    this.route.paramMap.subscribe(
      params => {
        const id = params.get('id');
        if(id){
          this.homeService.getAllAvrupaById(id)
          .subscribe(
            response => {
              this.avrupa = response;

            }
          )
        }
      }
    );
  }

}
