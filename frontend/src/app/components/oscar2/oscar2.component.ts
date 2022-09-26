import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Oscar } from 'src/app/models/Oscar';
import { Home1Service } from 'src/app/services/home1.service';

@Component({
  selector: 'app-oscar2',
  templateUrl: './oscar2.component.html',
  styleUrls: ['./oscar2.component.css'],
})
export class Oscar2Component implements OnInit {
  constructor(
    private homeService: Home1Service,
    private route: ActivatedRoute
  ) {}
  oscar: Oscar | undefined;
  ngOnInit(): void {
    this.route.paramMap.subscribe((params) => {
      const id = params.get('id');
      if (id) {
        this.homeService.getAllOscarById(id).subscribe((response) => {
          this.oscar = response;
        });
      }
    });
  }
}
