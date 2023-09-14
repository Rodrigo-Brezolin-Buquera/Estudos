package br.com.java.io.teste;

import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStreamReader;

public class TesteLeitura {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		
		FileInputStream fis = new FileInputStream("lorem.txt"); // recebe e le os bytes
		InputStreamReader isr = new InputStreamReader(fis); // traz caracteres
		BufferedReader br = new BufferedReader(isr); // organizar em string
		
		String linha = br.readLine();
		
		while (linha != null) {    // para continuar lendo as linhas
			System.out.println(linha);
			linha = br.readLine();     
		}
		
		
		
		br.close();
	}

}
