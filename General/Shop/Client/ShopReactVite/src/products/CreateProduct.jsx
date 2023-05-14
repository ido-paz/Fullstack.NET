import { useState } from "react";
import { BSModal } from "../components/BSModal";
import { NavLink, useNavigate } from "react-router-dom";
import {ShopWebAPI_URL} from "../utils/settings";
import axios from "axios";

const CreateProduct = () => {
  let [name, setName] = useState("");
  let [price, setPrice] = useState();
  let [image, setImage] = useState("");
  let [message, setMessage] = useState("");
  let navigate = useNavigate();
  //
  async function save(e) {
    e.preventDefault();
    if (name && price) {
      const formData = new FormData();
      formData.append("name", name);
      formData.append("price", price);
      formData.append("image", image);
      try {
        const response = await axios({
          method: "post",
          url: `${ShopWebAPI_URL}/products/withImage`,
          data: formData,
          headers: { "Content-Type": "multipart/form-data" },
        });
        alert("Saved");
        navigate("/products");
      } catch (error) {
        alert(error);
      }
    } else {
      alert("Name and price data are mandatory");
    }
  }
  //
  return (
    <>
      {message.length > 0 ? (
        <BSModal
          title="Error"
          body={message}
          defaultShow={true}
        ></BSModal>
      ) : (
        ""
      )}

      <h1>Create product</h1>

      <hr />

      <form onSubmit={save} method="post" encType="multipart/form-data">
        <div className="form-group">
          <label className="form-label">Name</label>
          <input
            type="text"
            className="form-control"
            value={name}
            onChange={(e) => setName(e.target.value)}
          />
        </div>

        <div className="form-group">
          <label className="form-label">Price</label>
          <input
            type="number"
            className="form-control"
            value={price}
            onChange={(e) => setPrice(e.target.value)}
          />
        </div>

        <div className="form-group">
          <label className="form-label">Image</label>
          <input
            type="file"
            className="form-control"
            onChange={(e) => setImage(e.target.files[0])}
          />
        </div>

        <div className="form-group">
          <button type="submit" className="btn btn-primary">
            Save
          </button>
        </div>
      </form>
      {/* <div className="alert alert-text">{error}</div> */}

      <NavLink to="/products">Back to products</NavLink>
    </>
  );
};

export default CreateProduct;
