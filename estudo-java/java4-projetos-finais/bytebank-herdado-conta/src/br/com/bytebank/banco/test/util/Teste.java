package br.com.bytebank.banco.test.util;

import java.util.ArrayList;

import br.com.bytebank.banco.modelo.Conta;
import br.com.bytebank.banco.modelo.ContaCorrente;

public class Teste {

	public static void main(String[] args) {
		
		
		// Generics
		// ArrayList
		
		// se for só adicionar é bom!
		
		
		// Explicitando os types
		ArrayList<Conta> lista = new ArrayList(); // o <Contaa> restringe a lista apenas para contas, sem isso aceitava qualquer objeto
		
		Conta cc = new ContaCorrente(22, 12312);
		lista.add(cc);
		
		System.out.println(lista.size());
		
		Conta ref = (Conta) lista.get(0); // pode tirar o casting (Conta)
		
		lista.remove(0);
		lista.add(cc);
		

		lista.contains(cc); // verifica se tem ou não a referencia
		lista.equals(cc); // verifica se tem um ibjeto que seja iguaal
		
		
		for(Object oRef : lista) {  // da para trocar por Conta
			System.out.println(oRef);
		}

	}

}
