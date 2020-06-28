import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SidenavComponent } from './sidenav/sidenav.component';
import { HomepageComponent } from './homepage/homepage.component';



const routes: Routes = [
  {path:'',redirectTo:'homepage',pathMatch:'full'},
  {path:'homepage',component:HomepageComponent,
children:[
  {path:'',component:HomepageComponent},
  {path:'SearchTab',component:HomepageComponent}
]},
  {path:'sidenav',component:SidenavComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
