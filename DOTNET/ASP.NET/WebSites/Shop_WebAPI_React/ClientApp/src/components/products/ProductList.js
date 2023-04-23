import { Component } from "react";
import { NavLink } from "react-router-dom";

export class ProductList extends Component {

    constructor(props) {
        super(props);
        this.state = { items: [], loading: true };
    }

    componentDidMount() {
        this.fetchProducts();
    }

    render() {
        let { items, loading } = this.state;
        if (loading)
            return (<div>No products</div>);
        //
        let rows = items.map((p, i) => {
            let editTo = "/products/edit-product/" + p.id;
            return (<tr key={p.id}>
                <td>{p.id}</td>
                <td>{p.name}</td>
                <td>{p.price}</td>
                <td>
                    <NavLink to={editTo} >Edit</NavLink> |
                    <button onClick={(e)=>this.delete(p.id)} className="btn btn-primary">Delete</button>
                </td>
            </tr>);
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
                            <th>Actions</th>
                        </tr>
                    </thead>
                    <tbody>
                        { rows}
                    </tbody>
                </table>

            </>
        );
    }

    async delete(id) {
        try {
            let res = await fetch('products/' + id, { method: 'DELETE' });
            if (res.ok) {
                this.fetchProducts();
            }
        } catch (e) {
            alert(e.message);
        }
    }


    fetchProducts() {
        fetch('products').then(res => res.json()).
            then(json => this.setState({ items: json, loading: false })).
            catch(err => console.error(err));
    }
}
