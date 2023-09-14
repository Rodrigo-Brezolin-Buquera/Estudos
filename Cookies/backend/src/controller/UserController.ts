import { Request, Response } from "express";
import { UserBusiness } from "../business/UserBusiness";
import { LoginInputDTO, UserInputDTO } from "../model/user";

export class UserController {
  
  public login = async (req: Request, res: Response) => {
    try {
      const { email, password } = req.body;

      const input: LoginInputDTO = {
        email,
        password,
      };
      console.log(input)
      const userBusiness = new UserBusiness();
      userBusiness.login(input);
      
      res
      // .writeHead(200, {
      //    "Set-Cookie": "token=12341; HttpOnly",
      //    "Access-Control-Allow-Credentials": "true"
      // })
      .setHeader('Set-Cookie','token="123123"; Max-Age=3000')
      .status(200)  
      // .cookie("token", "213412")
      .send({ message: "Usuário criado!" });
    } catch (error: any) {
      res.status(400).send(error.message);
    }
  };
}
