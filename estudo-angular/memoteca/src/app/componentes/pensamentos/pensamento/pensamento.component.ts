import { Component, Input, OnInit } from '@angular/core';
import { Pensamento } from '../pensamento';

@Component({
  selector: 'app-pensamento',
  templateUrl: './pensamento.component.html',
  styleUrls: ['./pensamento.component.css']
})
export class PensamentoComponent implements OnInit {
  ngOnInit(): void {
    
  }

 @Input() pensamento: Pensamento ={
    id: 0,
    conteudo: "Angular",
    autoria: "eu",
    modelo: "modelo3"
  }

  constructor() { }

  larguraPensamento(): string {
    if(this.pensamento.conteudo.length >= 256) {
      return "pensamento-g"
    }
    return "pensamento-p"
  }
}
