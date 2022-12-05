import React from 'react';
import Axios from 'axios';

function PostForm(){
    return(
    <div>
        <form>
            <input placeholder='Id' type="number"></input>
            <input placeholder='Name' type="text"></input>
            <input placeholder='Email' type="text"></input>
        </form>
    </div>
    );
}