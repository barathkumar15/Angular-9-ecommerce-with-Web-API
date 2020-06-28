import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.css']
})
export class SidenavComponent implements OnInit {
  SearchTab;
  message:string;
  constructor(private router:Router,
    ) { }

  ngOnInit(): void {

  }
  searchrouting(SearchTab1){
    this.SearchTab=SearchTab1;
   // this.router.navigate(['/homepage/'+SearchTab]);

    console.log("routesearch",this.SearchTab);
  }

}
