
public class TesteRefs {

	public static void main(String[] args) {
		Conta primeiraConta = new Conta(); 
		primeiraConta.saldo = 200;
		
		Conta segundaConta = primeiraConta ; // a segunda conta vai referenciar para a primeira conta

	}
}
