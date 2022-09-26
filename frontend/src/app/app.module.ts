import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { PostComponent } from './components/post/post.component';
import { AnimasyonComponent } from './components/animasyon/animasyon.component';
import { AvrupaComponent } from './components/avrupa/avrupa.component';
import { DiziComponent } from './components/dizi/dizi.component';
import { HollywoodComponent } from './components/hollywood/hollywood.component';
import { OlmedenComponent } from './components/olmeden/olmeden.component';
import { OscarComponent } from './components/oscar/oscar.component';
import { SeriComponent } from './components/seri/seri.component';
import { Animasyon1Component } from './components/animasyon1/animasyon1.component';
import { Avrupa1Component } from './components/avrupa1/avrupa1.component';
import { Dizi1Component } from './components/dizi1/dizi1.component';
import { Hollywood1Component } from './components/hollywood1/hollywood1.component';
import { Olmeden1Component } from './components/olmeden1/olmeden1.component';
import { Oscar1Component } from './components/oscar1/oscar1.component';
import { Post1Component } from './components/post1/post1.component';
import { Seri1Component } from './components/seri1/seri1.component';
import { Animasyon2Component } from './components/animasyon2/animasyon2.component';
import { Avrupa2Component } from './components/avrupa2/avrupa2.component';
import { Dizi2Component } from './components/dizi2/dizi2.component';
import { Hollywood2Component } from './components/hollywood2/hollywood2.component';
import { Olmeden2Component } from './components/olmeden2/olmeden2.component';
import { Oscar2Component } from './components/oscar2/oscar2.component';
import { Post2Component } from './components/post2/post2.component';
import { Seri2Component } from './components/seri2/seri2.component';
import { InfoComponent } from './components/info/info.component';
import { Ng2SearchPipeModule } from 'ng2-search-filter';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    PostComponent,
    AnimasyonComponent,
    AvrupaComponent,
    DiziComponent,
    HollywoodComponent,
    OlmedenComponent,
    OscarComponent,
    SeriComponent,
    Animasyon1Component,
    Avrupa1Component,
    Dizi1Component,
    Hollywood1Component,
    Olmeden1Component,
    Oscar1Component,
    Post1Component,
    Seri1Component,
    Animasyon2Component,
    Avrupa2Component,
    Dizi2Component,
    Hollywood2Component,
    Olmeden2Component,
    Oscar2Component,
    Post2Component,
    Seri2Component,
    InfoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    Ng2SearchPipeModule //



  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
