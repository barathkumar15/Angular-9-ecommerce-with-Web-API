import { Component, OnInit, Input } from '@angular/core';
import { MatDialog ,MatDialogConfig, MatDialogRef} from '@angular/material/dialog';
import { ProductDetailPageComponent } from '../product-detail-page/product-detail-page.component';
import { HomeserviceService } from '../homeservice.service';
import { HomeModel} from'../model/homemodel.model'
import { NgForm,FormControl,FormGroup,Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent implements OnInit {
 locallyStoring;
 count;
 @Input() SearchTab; message:string;
src1="https://assets.ajio.com/medias/sys_master/root/h46/hce/15216780148766/ausk_blue_crew_crew-neck_t-shirt_with_contrast_stripes.jpg" ;
  constructor(private dailog:MatDialog,private router: Router,
    public service:HomeserviceService,private currentRouter:ActivatedRoute,
    ) {

  }

  ngOnInit(): void {

    this.ShowAllProduct();
    let searchbe=this.currentRouter.snapshot.paramMap.get('SearchTab');
    console.log("curn",this.SearchTab);

   }

  ShowAllProduct(){
    this.service.GetAllData().then(data=>{
      console.log("daa",data);
      this.locallyStoring=data;
      console.log("locallyStoring",this.locallyStoring);

    })
  }
  //AdIndex,Booking_Id
  OpenPopup(list){

    const dailogConfig = new MatDialogConfig();
    dailogConfig.autoFocus=true;
    dailogConfig.disableClose=true;
    dailogConfig.width="70%";
    dailogConfig.data={ selectedBookingNo : list};

    this.dailog.open(ProductDetailPageComponent,dailogConfig);
  }
}
