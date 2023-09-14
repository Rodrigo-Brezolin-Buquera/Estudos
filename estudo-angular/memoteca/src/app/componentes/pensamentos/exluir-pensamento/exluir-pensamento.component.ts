import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Pensamento } from '../pensamento';
import { PensamentoService } from '../pensamento.service';

@Component({
  selector: 'app-exluir-pensamento',
  templateUrl: './exluir-pensamento.component.html',
  styleUrls: ['./exluir-pensamento.component.css']
})
export class ExluirPensamentoComponent implements OnInit {

  pensamento:Pensamento = {
    id: 0,
    conteudo: '',
    autoria: "",
    modelo:""
  }

  constructor(
    private service: PensamentoService,
    private router: Router,
    private route: ActivatedRoute

  ){}

  ngOnInit(): void {
   const id = this.route.snapshot.paramMap.get("id")
   this.service.buscarPorId(parseInt(id!))
  }

  excluirPensamento() {
    if(this.pensamento.id) {
      this.service.excluir(this.pensamento.id).subscribe(()=>{
        this.router.navigate(["/listarPensamento"])
      })
    }
  }

}
