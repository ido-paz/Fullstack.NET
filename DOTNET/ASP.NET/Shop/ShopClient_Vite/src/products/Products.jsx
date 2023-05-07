import { useEffect, useState } from "react";
import { NavLink } from "react-router-dom";
import { BSModal } from "../components/BSModal";
import appSettings from "../appsettings.json";
import { Button } from "react-bootstrap";
import axios from "axios";

const Products = (props) => {
  let [products, setProducts] = useState([]);
  let [errorMessage, setErrorMessage] = useState(null);
  //
  useEffect(() => {
    axios.get(appSettings.ShopWebAPI_URL + "/products")
      .then((response) => {
        if(response.data){
          setProducts(response.data);
        }
      })
      .catch((err) => {
        setErrorMessage(err.message);
      });
  }, []);
  //
  //
  function getProducts() {
    if (products == null || products.length == 0)
      return <div className="alert-text">No products...</div>;
    return (
      <table className="table">
        <thead>
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Price</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {products.map((p) => (
            <tr key={p.id}>
              <td>{p.id}</td>
              <td>{p.name}</td>
              <td>{p.price}</td>
              <td>
                <NavLink to={`/products/editProduct/${p.id}`}>Edit</NavLink> |
                <Button className="primary">Delete</Button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    );
  }
  //
  return (
    <>
      <h1>Products</h1>

      <NavLink to="/products/createProduct">Create new product</NavLink>
      <hr />
      {errorMessage ? (
        <BSModal title="Error" body={errorMessage} defaultShow={true} />
      ) : (
        getProducts()
      )}
    </>
  );
};

export default Products;
