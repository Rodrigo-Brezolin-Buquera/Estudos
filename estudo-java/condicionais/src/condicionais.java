
public class condicionais {
	
public static void main(String[] args) {
	
	int idade = 20;
	
	if(idade >=18) {
		System.out.println("maior de idade");
	} else {
		System.out.println("menor de idade");
	}
	
	
	// || ou
	// && e 
	
	boolean a = true;
	
	// não tem true/false implicito no java
	
	switch (idade) {
		case 10: 
			System.out.println(idade + "foi");
			break;
		case 20: 
			System.out.println(idade);
			break;
		default:
			System.out.println("nao foi");
			break;
	
	}
}



}
