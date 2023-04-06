import { Component } from "react";
import { NavLink } from "react-router-dom";

export class ProductList extends Component {

    constructor(props) {
        super(props);
        this.state = { items: [], loading: true };
    }

    componentDidMount() {
        this.populateProductsData();
    }

    render() {
        let { items, loading } = this.state;
        if (loading)
            return (<div>No products</div>);
        //
        let rows = items.map((p, i) => {
            return (<tr><td>{p.id}</td><td>{p.name}</td><td>{p.price}</td></tr>);
        });

        return (
            <>
                <h1>Product list</h1>
                <hr />
                <NavLink to="create-product">Create new product</NavLink>

                <table className="table">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Name</th>
                            <th>Price</th>
                        </tr>
                    </thead>
                    <tbody>
                        { rows}
                    </tbody>
                </table>

            </>
        );
    }

    populateProductsData() {
        fetch('products').then(res => res.json()).
            then(json => this.setState({ items: json, loading: false })).
            catch(err => console.error(err));
    }
}
