import logo from './logo.svg';
import './App.css';
import { useState } from 'react';

function App() {
  const [id,setId] = useState("");
  const [name,setName] = useState("");
  const [email,setEmail] = useState("");
function saveUser()
{
  console.warn({id,name,email});
let data ={id,name,email}
  fetch('https://localhost:44330/api/Account',{
    method:'POST',
    headers:{
      'Accept':'application/json',
      'Content-Type':'application/json'
    },
    body:JSON.stringify(data)
  }).then((result)=>{
    console.warn("result",result);
  })
}

  return (
    <div className="App">
    <h1>Post API</h1>
    <input type="text" value={id} onChange={(e)=>{setId(e.target.value)}} name="id" placeholder='Id'></input><br></br>
    <input type="text" value={name} onChange={(e)=>{setName(e.target.value)}} name="name" placeholder='Name'></input><br></br>
    <input type="text" value={email} onChange={(e)=>{setEmail(e.target.value)}} name="email" placeholder='Email'></input><br></br>
    <button onClick={saveUser}>Insert Data</button>
    </div>
  );
}

export default App;
