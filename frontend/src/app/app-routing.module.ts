import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AnimasyonComponent } from './components/animasyon/animasyon.component';
import { Animasyon1Component } from './components/animasyon1/animasyon1.component';
import { Animasyon2Component } from './components/animasyon2/animasyon2.component';
import { AvrupaComponent } from './components/avrupa/avrupa.component';
import { Avrupa1Component } from './components/avrupa1/avrupa1.component';
import { Avrupa2Component } from './components/avrupa2/avrupa2.component';
import { DiziComponent } from './components/dizi/dizi.component';
import { Dizi1Component } from './components/dizi1/dizi1.component';
import { Dizi2Component } from './components/dizi2/dizi2.component';
import { HollywoodComponent } from './components/hollywood/hollywood.component';
import { Hollywood1Component } from './components/hollywood1/hollywood1.component';
import { Hollywood2Component } from './components/hollywood2/hollywood2.component';
import { HomeComponent } from './components/home/home.component';
import { InfoComponent } from './components/info/info.component';
import { OlmedenComponent } from './components/olmeden/olmeden.component';
import { Olmeden1Component } from './components/olmeden1/olmeden1.component';
import { Olmeden2Component } from './components/olmeden2/olmeden2.component';
import { OscarComponent } from './components/oscar/oscar.component';
import { Oscar1Component } from './components/oscar1/oscar1.component';
import { Oscar2Component } from './components/oscar2/oscar2.component';
import { PostComponent } from './components/post/post.component';
import { Post1Component } from './components/post1/post1.component';
import { Post2Component } from './components/post2/post2.component';
import { SeriComponent } from './components/seri/seri.component';
import { Seri1Component } from './components/seri1/seri1.component';
import { Seri2Component } from './components/seri2/seri2.component';

const routes: Routes = [
  {path:'', component:HomeComponent},
  {path:'post/:id', component:PostComponent}, //anasayfa
  {path:'animasyon/:id', component:AnimasyonComponent},
  {path:'avrupa/:id', component:AvrupaComponent},
  {path:'hollywood/:id', component:HollywoodComponent},
  {path:'olmeden/:id', component:OlmedenComponent},
  {path:'oscar/:id', component:OscarComponent},
  {path:'seri/:id', component:SeriComponent},
  {path:'dizi/:id', component:DiziComponent},


  {path:'animasyon1', component:Animasyon1Component},
  {path:'avrupa1', component:Avrupa1Component},
  {path:'hollywood1', component:Hollywood1Component},
  {path:'olmeden1', component:Olmeden1Component},
  {path:'oscar1', component:Oscar1Component},
  {path:'seri1', component:Seri1Component},
  {path:'dizi1', component:Dizi1Component},
  {path:'post1', component:Post1Component},
  {path:'info', component:InfoComponent},

  {path:'animasyon2/:id', component:Animasyon2Component},
  {path:'avrupa2/:id', component:Avrupa2Component},
  {path:'hollywood2/:id', component:Hollywood2Component},
  {path:'olmeden2/:id', component:Olmeden2Component},
  {path:'oscar2/:id', component:Oscar2Component},
  {path:'seri2/:id', component:Seri2Component},
  {path:'dizi2/:id', component:Dizi2Component},
  {path:'post2/:id', component:Post2Component},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
