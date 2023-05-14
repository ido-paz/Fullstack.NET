import { useEffect, useState } from "react";
import { BSModal } from "../components/BSModal";
import { ShopWebAPI_URL } from "../utils/settings";
import { Button } from "react-bootstrap";
import Card from "react-bootstrap/Card";
import Col from "react-bootstrap/Col";
import Row from "react-bootstrap/Row";
import axios from "axios";

const BuyProducts = (props) => {
  let [products, setProducts] = useState([]);
  let [errorMessage, setErrorMessage] = useState(null);
  //let {}
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
  function getProductsTable() {
    let imageCSS = { height: "100px", objectFit: "cover" };
    let cardCSS = { width: "11rem" };
    //
    if (products == null || products.length == 0)
      return <div className="alert alert-danger">No products...</div>;
    return (
      <Row xs={1} sm={2} md={3} lg={4} className="g-1">
        {Array.from(products).map((p, idx) => (
          <Col key={idx}>
            <Card style={cardCSS} border="dark">
              <Card.Img
                variant="top"
                style={imageCSS}
                alt={p.imageName}
                src={p.imageData}
              />
              <Card.Body>
                <Card.Title>
                  {p.name} costs only <span>{p.price}₪</span>
                </Card.Title>
                <Button variant="primary">Buy now!</Button>
              </Card.Body>
            </Card>
          </Col>
        ))}
      </Row>
    );
  }
  //
  return (
    <>
      <h1>Products</h1>

      {errorMessage ? (
        <BSModal title="Error" body={errorMessage} defaultShow={true} />
      ) : (
        getProductsTable()
      )}
    </>
  );
};

export default BuyProducts;
