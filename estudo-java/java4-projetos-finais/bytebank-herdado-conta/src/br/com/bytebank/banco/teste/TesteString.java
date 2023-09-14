package br.com.bytebank.banco.teste;

public class TesteString {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		String teste = "teste";
		
		teste.length();
		
		// uma vez que a string é criada ela não pode ser alterado
		String novaString = teste.replace("e", "a").toUpperCase();
		
		System.out.println(novaString);
		
		
		teste.charAt(0) ; // char na posição zero
		
		teste.indexOf("s"); //retorna o index desse caracter
		
		teste.substring(1); // divide a string apartir do index - ver outras sobrecargas
		
		teste.isEmpty(); // retornar boolean indicando se é vazio ou não
		
		teste.trim();
		
		teste.contains("est"); // retorna boolean
		
	}

}
