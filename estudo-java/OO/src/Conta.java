public class Conta {
	private double saldo;
	private int agencia = 01; // valor inicial padrão
	private int numero;
	private Cliente titular;
	private static int totalContas;
	
	
	// construtor 
	public Conta( int agencia, int numero ) {
		totalContas++;
		this.agencia = agencia;
		this.numero = numero;
	}
	//
	
	
	void deposita(double valor) {
		this.saldo = this.saldo + valor;
	};
	
	public boolean saca(double valor){
		if(this.saldo >= valor) {
			this.saldo = this.saldo - valor;
					return true ;
		} else {
			return false;
		}
		
	} ;
	
	public boolean transfere(double valor, Conta destino){
		if(this.saldo >= valor) {
			this.saldo = this.saldo - valor;
			destino.deposita(valor);
			return true;
		} else {
			return false;
		}
		
	} ;
	
	public double getSaldo() {
		return this.saldo;
	};
	
	public void setNumero( int numero) {
		this.agencia = numero;
	};
}