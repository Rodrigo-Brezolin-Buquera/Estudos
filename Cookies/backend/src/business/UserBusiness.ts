import { UserDatabase } from "../data/UserDatabase";
import { CustomError } from "../error/customError";
import { LoginInputDTO } from "../model/user";

export class UserBusiness {
public login = async ({ email, password }: LoginInputDTO) => {
   try {
   
     if (!email || !password) {
       throw new CustomError(400, 'Preencha os campos "name","nickname", "email" e "password"')
     }


     const userDatabase = new UserDatabase();

     const login = { email, password}
    
     await userDatabase.login(login);
   } catch (error: any) {
     throw new Error(error.message);
   }
 };

}

