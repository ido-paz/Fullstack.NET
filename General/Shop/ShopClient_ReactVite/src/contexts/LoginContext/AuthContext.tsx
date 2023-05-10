import React, { createContext } from 'react';

const AuthContext = createContext({isLoggedIn : true,roleID:0,userName:null,login:()=>{},logout:()=>{}});

export default AuthContext;
