import express, {Request, Response} from 'express'
import session from "express-session"
import cors from 'cors'
import cookieParser from "cookie-parser"

export const app = express()

app.use(express.json())
app.use(cors())
app.use(cookieParser())

// app.use(
//    session({
//       resave: false,
//       // saveUnitialized: false,
//       secret: "session",
//       cookie: {
//          maxAge: 1000*60*60,
//          sameSite: "none",
//          secure: true
//       }
//    })
// )

app.get('/setcookie', (req:Request, res:Response) => {
   res.setHeader('Set-Cookie','token="123123"; Max-Age=3000')
   // res.cookie(`Cookie token name`,`encrypted cookie string Value`);
   res.send('Cookie have been saved successfully');
});

app.listen(3003, () => {
   console.log('Servidor rodando na porta 3003')
})