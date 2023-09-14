
public abstract class Funcionario {

	private String nome;
	private String cpf;
	protected double salario;
	
	
	public Funcionario() {
		
	}
	
	// método abstracto, não é concreto. os filhos irão implementar
	public abstract double getAbsctract(); 
	
	public double GetBoinificacao() {
		return this.salario * 0.1;
	}
	
	
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public String getCpf() {
		return cpf;
	}
	public void setCpf(String cpf) {
		this.cpf = cpf;
	}
	public double getSalario() {
		return salario;
	}
	public void setSalario(double salario) {
		this.salario = salario;
	}
	
	
}
