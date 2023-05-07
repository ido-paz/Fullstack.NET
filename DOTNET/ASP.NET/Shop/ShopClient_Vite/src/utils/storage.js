const Keys = {
  accessToken: "accessToken",
  accessTokenExpires: "accessTokenExpires",
  refreshToken: "refreshToken",
  refreshTokenExpires: "refreshTokenExpires",
  expiresInSeconds : "expiresInSeconds",
  userName: "userName",
};

function setItem(name, value) {
  localStorage.setItem(name, value);
}

function getItem(name) {
  return localStorage.getItem(name);
}

function removeItem(name) {
  localStorage.removeItem(name);
}


function setTokenData(tokenData) {
  setItem(Keys.accessToken, tokenData[Keys.accessToken]);
  setItem(Keys.accessTokenExpires, tokenData[Keys.accessTokenExpires]);
  setItem(Keys.refreshToken, tokenData[Keys.refreshToken]);
  setItem(Keys.refreshTokenExpires, tokenData[Keys.refreshTokenExpires]);
  setItem(Keys.expiresInSeconds, tokenData[Keys.expiresInSeconds]);
}
//
function removeTokenData() {
  removeItem(Keys.accessToken);
  removeItem(Keys.accessTokenExpires);
  removeItem(Keys.refreshToken);
  removeItem(Keys.refreshTokenExpires);
  removeItem(Keys.expiresInSeconds);
}

export { setItem, getItem, removeItem,setTokenData,removeTokenData ,Keys};
