import axios from "axios"



function App() {

  const login = () => {
    axios.get("http://localhost:3003/setcookie").then((res)=>{
      console.log(res)
    })
    .catch((err)=>{
      console.log(err)
    })

    // axios.post("http://localhost:3003/user/login", {email: "email@email.com", password:"123456"})
    // .then((res)=>{
    //   console.log(res)
    // })
    // .catch((err)=>{
    //   console.log(err)
    // })
  }

  return (
    <div >
      <h3>Teste de cookies</h3>

      <button onClick={login}>Logar</button>
    </div>
  );
}

export default App;
