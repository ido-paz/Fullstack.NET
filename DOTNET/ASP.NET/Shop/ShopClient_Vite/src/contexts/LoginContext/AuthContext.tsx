import React, { createContext } from 'react';

const AuthContext = createContext({isLoggedIn : true,userName:null,login:()=>{},logout:()=>{}});

export default AuthContext;
