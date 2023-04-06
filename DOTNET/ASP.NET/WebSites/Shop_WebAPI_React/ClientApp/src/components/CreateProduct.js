import { Component } from "react";
import { NavLink } from "react-router-dom";

export class CreateProduct extends Component {

    render() {


        return (
            <>
                <h1>Create product</h1>
                <hr/>
                <form>
                    <div className="form-group">
                        <label>Name</label>
                        <input type="text" className="form-control" />
                    </div>

                    <div className="form-group">
                        <label>Price</label>
                        <input type="number" className="form-control" />
                    </div>


                    <div className="form-group">
                        <input type="button" className="btn btn-primary" value="Save"/>
                    </div>

                </form>

                <NavLink to="/products">Back to products</NavLink>
            </>
        
        );
    }
}
