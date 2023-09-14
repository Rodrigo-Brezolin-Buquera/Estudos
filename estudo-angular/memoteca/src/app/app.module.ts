import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CabecalhoComponent } from './componentes/cabecalho/cabecalho.component';
import { RodapeComponent } from './componentes/rodape/rodape.component';
import { CriarPensamentoComponent } from './componentes/pensamentos/criar-pensamento/criar-pensamento.component';
import { FormsModule } from '@angular/forms';
import { ListaPensamentoComponent } from './componentes/pensamentos/lista-pensamento/lista-pensamento.component';
import { PensamentoComponent } from './componentes/pensamentos/pensamento/pensamento.component';
import {  HttpClientModule } from '@angular/common/http';
import { ExcluirPensamentoComponent } from './pensamentos/excluir-pensamento/excluir-pensamento.component';
import { ExluirPensamentoComponent } from './componentes/pensamentos/exluir-pensamento/exluir-pensamento.component';

@NgModule({
  declarations: [
    AppComponent,
    CabecalhoComponent,
    RodapeComponent,
    CriarPensamentoComponent,
    ListaPensamentoComponent,
    PensamentoComponent,
    ExcluirPensamentoComponent,
    ExluirPensamentoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
