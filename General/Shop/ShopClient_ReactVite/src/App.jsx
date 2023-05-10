import { useEffect, useRef, useState } from "react";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import TopNavigation from "./navigation/TopNavigation";
import Home from "./publicPages/Home";
import ManageProducts from "./products/ManageProducts";
import Users from "./users/Users";
import Login from "./publicPages/Login";
import { ProtectedRoute } from "./navigation/ProtectedRoute";
import AuthContext from "./contexts/LoginContext/AuthContext";
import { Keys, getItem, setLoginData, removeLoginData } from "./utils/storage";
import axios from "axios";
import CreateProduct from "./products/CreateProduct";
import BuyProducts from "./products/BuyProducts";
import {ShopWebAPI_URL} from "./utils/settings";

function App() {
  let [isLoggedIn, setIsLoggedIn] = useState(false);
  let [roleID, setRoleID] = useState(0);
  let timerID = useRef();

  useEffect(() => {
    console.log("App useEffect", Date());
    console.log("settings.js ShopWebAPI_URL",ShopWebAPI_URL);
    //create a loop that refresh the tokens only if there is refreshToken
    if (getItem(Keys.refreshToken) && isNaN(timerID)) {
      setRefreshTokenInterval();
      refreshToken();
    }
  }, []);
  //
  function setRefreshTokenInterval() {
    if (isNaN(timerID)) {
      let expiresInSeconds = getItem(Keys.expiresInSeconds);
      let refreshInterval = expiresInSeconds
        ? Number(expiresInSeconds) / 2
        : 30;
      timerID = setInterval(refreshToken, refreshInterval * 1000);
      console.log("starting refreshToken", refreshInterval, Date());
    }
  }
  //
  function refreshToken() {
    console.log("refreshToken", Date());
    axios
      .post(ShopWebAPI_URL + "/users/refreshToken", {
        refreshToken: getItem(Keys.refreshToken),
      })
      .then((response) => {
        login(response.data);
      })
      .catch((error) => {
        logout();
      });
  }
  //
  function login(loginData) {
    setLoginData(loginData.userResponse, loginData.tokensData);
    setRefreshTokenInterval();
    setRoleID(loginData.userResponse[Keys.roleID]);
    setIsLoggedIn(true);
  }
  //
  function logout() {
    clearTimeout(timerID);
    removeLoginData();
    setIsLoggedIn(false);
  }
  //
  return (
    <div className="container-fluid">
      <AuthContext.Provider value={{ isLoggedIn, roleID, login, logout }}>
        <BrowserRouter>
          <TopNavigation />
          <Routes>
            <Route path="/" element={<Home />} />
            <Route
              path="/products"
              element={
                <ProtectedRoute>
                  {roleID == 1 ? <ManageProducts /> : <BuyProducts />}
                </ProtectedRoute>
              }
            />
            <Route
              path="/products/createProduct"
              element={
                <ProtectedRoute>
                  <CreateProduct />
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

            <Route path="*" element={<div>Route not found</div>} />
          </Routes>
        </BrowserRouter>
      </AuthContext.Provider>
    </div>
  );
}

export default App;
