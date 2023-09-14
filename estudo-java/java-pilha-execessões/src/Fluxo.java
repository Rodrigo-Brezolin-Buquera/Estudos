

// exceptions e erros são diferentes => errors são usados pela maquina virtual, não os devs


public class Fluxo {

    public static void main(String[] args) {
        System.out.println("Ini do main");
        try {
        metodo1();
    } catch(Exception ex) { // pega todas as execessões (erros não!)
    	// error.setStackTrace(null);
    } 
        System.out.println("Fim do main");
    }

    
    private static void metodo1() {
        System.out.println("Ini do metodo1");
        metodo2();
        System.out.println("Fim do metodo1");
    }

    private static void metodo2() {
        System.out.println("Ini do metodo2");
        for(int i = 1; i <= 5; i++) {
            System.out.println(i);
            try  {
            	int a = i/0;
            } catch(ArithmeticException ex) { // quanto especficar execessão
            	String msg =  ex.getMessage();
            	System.out.println(msg);
            } finally {
            	// lembrar de verificar se a conexão existe!
            	System.out.println("fazer algo");
			}
        }
        
      
        throw new ArithmeticException();
        
        //System.out.println("Fim do metodo2");
    }
    
    
}