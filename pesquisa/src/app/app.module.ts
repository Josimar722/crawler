import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PesquisarDadosComponent } from './pesquisar-dados/pesquisar-dados.component';

// import { ModelComponent } from './model/model.component';

@NgModule({
  declarations: [			
    AppComponent,
    PesquisarDadosComponent,
    // ModelComponent
     
    
   ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
