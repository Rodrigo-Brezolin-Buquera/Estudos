package br.com.bytebank.banco.teste;

import br.com.bytebank.banco.modelo.Conta;
import br.com.bytebank.banco.modelo.ContaCorrente;

public class TesteArrayReferencias {

	public static void main(String[] args) {
	
		ContaCorrente[] contas = new ContaCorrente[5] ; // valor padrão é null

		
		ContaCorrente cc2 = new ContaCorrente(22, 333);
		
		contas[0] = cc2;
		
		
		Conta[] qualquerConta = new Conta[10]; // mais generico
		
		
		
		qualquerConta[0]= cc2;
		
		
		ContaCorrente ref = (ContaCorrente) qualquerConta[3]; // casting (type cast) , indica o tipo, similar ao "as" no TS
		
		Object[] maisGenerico = new Object[2]; // ainda mais generico
	}

}
