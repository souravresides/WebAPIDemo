import React, { useState } from 'react';
import Axios from 'axios';
import './App.css';


function App() {
  const url = "https://localhost:44330/api/Account"
  const [data, setData] = useState({
    Id:"",
    Name:"",
    Email:""
  })
function submit(e){
  e.preventDefault();
  Axios.post(url,{
    Id:data.Id,
    Name:data.Name,
    Email:data.Email
  })
  .then(res => {
    console.log(res.data)
  })
}

  function handle(e){
    const newdata ={...data}
    newdata[e.target.id] = e.target.value
    setData(newdata)
    console.log(newdata)
  }
  return (
    <div className="App">
     <form onSubmit={(e) => submit(e)}>
            <input onChange={(e)=>handle(e)} id="Id" value={data.Id} placeholder='Id' type="number"></input>
            <input onChange={(e)=>handle(e)} id="Name" value={data.Name} placeholder='Name' type="text"></input>
            <input onChange={(e)=>handle(e)} id="Email" value={data.Email} placeholder='Email' type="text"></input>
            <button>submit</button>
        </form>
    </div>
  );
}

export default App;
