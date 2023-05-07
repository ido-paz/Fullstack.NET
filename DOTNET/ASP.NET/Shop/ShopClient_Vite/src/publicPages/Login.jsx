import { useContext, useState } from "react";
import Button from "react-bootstrap/Button";
import Form from "react-bootstrap/Form";
import AuthContext from "../contexts/LoginContext/AuthContext";
import { useNavigate } from "react-router-dom";
import appSettings from "../appsettings.json";
import axios from "axios";

function Login() {
  let [errorMessage, setErrorMessage] = useState("");
  let [enteredPassword, setEnteredPassword] = useState("");
  let [enteredUserName, setEnteredUserName] = useState("");
  let { isLoggedIn, login, logout } = useContext(AuthContext);
  let navigate = useNavigate();
  //
  function onLogin() {
    if (enteredUserName) {
      axios
        .post(appSettings.ShopWebAPI_URL + "/users/login", {
          userName: enteredUserName,
          password: enteredPassword,
        })
        .then((response) => {
          if (response.data) {
            console.log(response.data);
            login(enteredUserName, response.data);
            navigate("/");
          } else throw Error("No response.data");
        })
        .catch((error) => {
          setErrorMessage("Error while trying to login ," + error.message);
        });
    }else{
      setErrorMessage('User name is mandatory');
    }
  }
  //
  if (isLoggedIn) {
    return (
      <Button variant="primary" type="button" onClick={logout}>
        Logout
      </Button>
    );
  }
  //
  return (
    <Form className="login">
      <Form.Group className="mb-3" controlId="formBasicEmail">
        <Form.Control
          type="text"
          placeholder="Enter user name"
          value={enteredUserName}
          onChange={(e) => setEnteredUserName(e.target.value)}
        />
      </Form.Group>

      <Form.Group className="mb-3" controlId="formBasicPassword">
        <Form.Control
          type="password"
          placeholder="Enter password"
          value={enteredPassword}
          onChange={(e) => setEnteredPassword(e.target.value)}
        />
      </Form.Group>
      {errorMessage ? (
        <div className="alert alert-danger">{errorMessage}</div>
      ) : (
        ""
      )}
      <Button variant="primary" type="button" onClick={onLogin}>
        Login
      </Button>
    </Form>
  );
}

export default Login;
