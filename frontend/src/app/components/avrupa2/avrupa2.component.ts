import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Avrupa } from 'src/app/models/Avrupa';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-avrupa2',
  templateUrl: './avrupa2.component.html',
  styleUrls: ['./avrupa2.component.css'],
})
export class Avrupa2Component implements OnInit {
  constructor(
    private homeService: Home1Service,
    private route: ActivatedRoute
  ) {}
  avrupa: Avrupa | undefined;

  ngOnInit(): void {
    this.route.paramMap.subscribe((params) => {
      const id = params.get('id');
      if (id) {
        this.homeService.getAllAvrupaById(id).subscribe((response) => {
          this.avrupa = response;
        });
      }
    });
  }
}
