import {  useEffect, useState } from "react";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import TopNavigation from "./navigation/TopNavigation";
import Home from "./publicPages/Home";
import Products from "./products/products";
import Users from "./users/Users";
import Login from "./publicPages/Login";
import { ProtectedRoute } from "./navigation/ProtectedRoute";
import AuthContext from "./contexts/LoginContext/AuthContext";
import { Keys, getItem, setTokenData, removeTokenData } from "./utils/storage";
import axios from "axios";
import appSettings from "./appsettings.json";

function App() {
  let [isLoggedIn, setIsLoggedIn] = useState(false);

  useEffect(() => {
    console.log("App useEffect",Date());
    //create a loop that refresh the tokens only if there is refreshToken
    if (getItem(Keys.refreshToken)) {
      let expiresInSeconds = getItem(Keys.expiresInSeconds);
      let refreshInterval = expiresInSeconds
        ? Number(expiresInSeconds) / 2
        : 30;
      console.log("refreshInterval", refreshInterval);
      refreshToken();
      setInterval(refreshToken, refreshInterval * 1000);
    }
  }, []);

  function refreshToken() {    
    console.log("refreshToken",Date());
    axios
      .post(appSettings.ShopWebAPI_URL + "/users/refreshToken", {
        refreshToken: getItem(Keys.refreshToken),
      })
      .then((response) => {
        login(null, response.data);
      })
      .catch((error) => {
        logout();
      });
  }
  //
  function login(userName, tokenData) {
    setTokenData(tokenData);
    setIsLoggedIn(true);
  }
  //
  function logout() {
    removeTokenData();
    setIsLoggedIn(false);
  }
  //
  return (
    <>
      <AuthContext.Provider value={{ isLoggedIn, login, logout }}>
        <BrowserRouter>
          <TopNavigation />
          <Routes>
            <Route path="/" element={<Home />} />
            <Route
              path="/products"
              element={
                <ProtectedRoute>
                  <Products />
                </ProtectedRoute>
              }
            />
            <Route
              path="/users"
              element={
                <ProtectedRoute>
                  <Users />
                </ProtectedRoute>
              }
            />
            <Route path="/login" element={<Login />} />
          </Routes>
        </BrowserRouter>
      </AuthContext.Provider>
    </>
  );
}

export default App;
