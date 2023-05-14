import { useContext } from "react";
import { Navigate } from "react-router-dom";
import AuthContext from "../contexts/LoginContext/AuthContext";

export function ProtectedRoute({ children }) {
  let {isLoggedIn} = useContext(AuthContext);
  if (isLoggedIn) {
    return children;
  } else {
    return <Navigate to="/login" />;
  }
}
