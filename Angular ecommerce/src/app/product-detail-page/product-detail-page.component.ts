import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-product-detail-page',
  templateUrl: './product-detail-page.component.html',
  styleUrls: ['./product-detail-page.component.css']
})
export class ProductDetailPageComponent implements OnInit {
  src1="https://assets.ajio.com/medias/sys_master/root/h46/hce/15216780148766/ausk_blue_crew_crew-neck_t-shirt_with_contrast_stripes.jpg" ;

  constructor(@Inject(MAT_DIALOG_DATA) public data,
  public dialogRef:MatDialogRef<ProductDetailPageComponent>,
  public toastr:ToastrService) { }

  ngOnInit(): void {
    console.log("inpop",this.data.selectedBookingNo.ImageUrl);
  }
  dailogclosebutton(){

    this.dialogRef.close();
   }
OnAddCart(){
  this.toastr.success('Added into bag','E-SHOPPING');
}
   OnbuyNow(){
    this.toastr.success('Booking successfull','E-SHOPPING');
    this.dialogRef.close();
  }

}
