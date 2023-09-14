
public class Gerente extends Funcionario {


	private int senha;
	
	
	
	public double GetBoinificacao() {
		return super.GetBoinificacao() + this.salario ;  
		// o super busca na classe pai se fosse this cairia em um loop 
	}



	@Override
	public double getAbsctract() {
		// algo implementado
		return 0;
	}
	
	
	

	
}
