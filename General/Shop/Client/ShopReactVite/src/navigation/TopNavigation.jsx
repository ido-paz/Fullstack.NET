import { useContext } from "react";
import Nav from "react-bootstrap/Nav";
import { NavLink } from "react-router-dom";
import AuthContext from "../contexts/LoginContext/AuthContext";

const TopNavigation = () => {
  let { isLoggedIn, roleID, logout } = useContext(AuthContext);
  return (
    <>
      <Nav variant="tabs" defaultActiveKey="/">
        <Nav.Item>
          <NavLink to="/" className="nav-link">
            <img
              className="logo"
              alt="Home"
              title="Home"
              src="https://is2-ssl.mzstatic.com/image/thumb/Purple113/v4/2f/25/63/2f256393-0c7d-9ced-cfcc-ecd1ab99dcb1/source/256x256bb.jpg"
            />
          </NavLink>
        </Nav.Item>
        {getGuardedLinks()}
        {getAuthenticationLinks()}
      </Nav>
    </>
  );
  //
  function getAuthenticationLinks() {
    if (isLoggedIn) {
      return (
        <Nav.Item>
          <NavLink to="#" className="nav-link" onClick={logout}>
            Logout
            <svg
              xmlns="http://www.w3.org/2000/svg"
              width="16"
              height="16"
              fill="currentColor"
              className="bi bi-box-arrow-right"
              viewBox="0 0 16 16"
            >
              <path
                fillRule="evenodd"
                d="M10 12.5a.5.5 0 0 1-.5.5h-8a.5.5 0 0 1-.5-.5v-9a.5.5 0 0 1 .5-.5h8a.5.5 0 0 1 .5.5v2a.5.5 0 0 0 1 0v-2A1.5 1.5 0 0 0 9.5 2h-8A1.5 1.5 0 0 0 0 3.5v9A1.5 1.5 0 0 0 1.5 14h8a1.5 1.5 0 0 0 1.5-1.5v-2a.5.5 0 0 0-1 0v2z"
              />
              <path
                fillRule="evenodd"
                d="M15.854 8.354a.5.5 0 0 0 0-.708l-3-3a.5.5 0 0 0-.708.708L14.293 7.5H5.5a.5.5 0 0 0 0 1h8.793l-2.147 2.146a.5.5 0 0 0 .708.708l3-3z"
              />
            </svg>
          </NavLink>
        </Nav.Item>
      );
    } else {
      return (
        <Nav.Item>
          <NavLink to="/login" className="nav-link">
            Login
            <svg
              xmlns="http://www.w3.org/2000/svg"
              width="16"
              height="16"
              fill="currentColor"
              className="bi bi-box-arrow-in-left"
              viewBox="0 0 16 16"
            >
              <path
                fillRule="evenodd"
                d="M10 3.5a.5.5 0 0 0-.5-.5h-8a.5.5 0 0 0-.5.5v9a.5.5 0 0 0 .5.5h8a.5.5 0 0 0 .5-.5v-2a.5.5 0 0 1 1 0v2A1.5 1.5 0 0 1 9.5 14h-8A1.5 1.5 0 0 1 0 12.5v-9A1.5 1.5 0 0 1 1.5 2h8A1.5 1.5 0 0 1 11 3.5v2a.5.5 0 0 1-1 0v-2z"
              />
              <path
                fillRule="evenodd"
                d="M4.146 8.354a.5.5 0 0 1 0-.708l3-3a.5.5 0 1 1 .708.708L5.707 7.5H14.5a.5.5 0 0 1 0 1H5.707l2.147 2.146a.5.5 0 0 1-.708.708l-3-3z"
              />
            </svg>
          </NavLink>
        </Nav.Item>
      );
    }
  }
  //
  function getGuardedLinks() {
    if (isLoggedIn) {
      return (
        <>
          <Nav.Item>
            <NavLink to="/products" className="nav-link">
              Products
            </NavLink>
          </Nav.Item>
          {roleID == 1 ? (
            <Nav.Item>
              <NavLink to="/users" className="nav-link">
                Users
              </NavLink>
            </Nav.Item>
          ) : (
            ""
          )}
        </>
      );
    }
  }
};

export default TopNavigation;
