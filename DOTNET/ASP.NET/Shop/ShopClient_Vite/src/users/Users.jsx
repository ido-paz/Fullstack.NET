import axios from "axios";
import {  useState } from "react";
import { Button } from "react-bootstrap";
import appSettings from "../appsettings.json";
import { BSModal } from "../components/BSModal";
import {getItem,Keys} from '../utils/storage'
//
const Users = () => {
  let [test1, setTest1] = useState("");
  let [test2, setTest2] = useState("");
  let [error, setError] = useState("");

  function callTest1() {
    axios
      .get(appSettings.ShopWebAPI_URL + "/users/test1")
      .then((res) => {
        setTest1(res.data);
      })
      .catch((error) => {        
        setError(error);
      });
  }
  //
  function callTest2() {
    let options = {
      headers: {
        Authorization: `Bearer ${getItem(Keys.accessToken)}`,
      },
    };
    //
    axios
      .get(appSettings.ShopWebAPI_URL + "/users/test2",options)
      .then((res) => {
        setTest2(res.data);
      })
      .catch((error) => {
        setError(error.message);
      });
  }
  //
  if (error)
    return <BSModal title="Error" body={error} defaultShow={true}></BSModal>;
  return (
    <>
      <h1>Users</h1>
      <div>
        <Button variant="primary" onClick={callTest1}>
          test1
        </Button>
        <label>{test1}</label>
      </div>
      <div>
        <Button variant="primary" onClick={callTest2}>
          test2
        </Button>
        <label>{test2}</label>
      </div>
    </>
  );
};

export default Users;
