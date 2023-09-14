import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CriarPensamentoComponent } from './componentes/pensamentos/criar-pensamento/criar-pensamento.component';
import { ExluirPensamentoComponent } from './componentes/pensamentos/exluir-pensamento/exluir-pensamento.component';
import { ListaPensamentoComponent } from './componentes/pensamentos/lista-pensamento/lista-pensamento.component';

const routes: Routes = [
  {
    path: "",
    redirectTo: "listarPensamento",
    pathMatch: "full" 
  },
  {
    path: "criarPensamento",
    component: CriarPensamentoComponent
  },
  {
    path: "listarPensamento",
    component: ListaPensamentoComponent
  },
  {
    path: "pensamentos/excluirPensamento/:id",
    component: ExluirPensamentoComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
