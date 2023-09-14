package br.com.bytebank.banco.test.util;

public class TesteInteger {

	public static void main(String[] args) {
		
		
		// converter string para numero:
		// cada tipo de numero tera um método
		
		
		String s = args[0]; // vem da execução do código
		
		
		//Wrappers
		
		Integer numero = Integer.valueOf(s); // outboxings
		numero.intValue(); // unboxing
		// ou
		
		int numero2 = Integer.parseInt(s);
		
		// clase Number -> mais generica
		
		Number  nun = Integer.valueOf(12);
		
		Number  nun2 = Float.valueOf(12.87f);
		
		Boolean bol = Boolean.FALSE;

	}

}
