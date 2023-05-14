import { useEffect, useState } from "react";
import { NavLink } from "react-router-dom";
import { BSModal } from "../components/BSModal";
import { ShopWebAPI_URL } from "../utils/settings";
import { Button } from "react-bootstrap";
import axios from "axios";

const ManageProducts = (props) => {
  let [products, setProducts] = useState([]);
  let [errorMessage, setErrorMessage] = useState(null);
  //
  useEffect(() => {
    getProducts();
  }, []);
  //
  function getProducts() {
    axios
      .get(ShopWebAPI_URL + "/products")
      .then((response) => {
        if (response.data) {
          setProducts(response.data);
        }
        else{
          console.log('empty response.data');  
        }
      })
      .catch((err) => {
        setErrorMessage(err.message);
      });
  }
  //
  function deleteProduct(id) {
    axios
      .delete(ShopWebAPI_URL + "/products/" + id)
      .then((res) => {
        getProducts();
      })
      .catch((err) => {
        setErrorMessage(err.message);
      });
  }
  //
  function getProductsTable() {
    if (products == null || products.length == 0)
      return <div className="alert alert-danger">No products...</div>;
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
                <Button className="primary" onClick={() => deleteProduct(p.id)}>
                  Delete
                </Button>
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
        getProductsTable()
      )}
    </>
  );
};

export default ManageProducts;
