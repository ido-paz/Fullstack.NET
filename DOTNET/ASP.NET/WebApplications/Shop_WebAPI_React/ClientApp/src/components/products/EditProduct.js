import { Component } from "react";
import { NavLink, Navigate } from "react-router-dom";

export class EditProduct extends Component {

    state = { id: -1, name: '', price: 1, saved: false };

    render() {
        let { name, price, saved } = this.state;
        if (saved) {
            return <Navigate to="/products" />;
        }
        //
        return (
            <>
                <h1>Edit product</h1>
                <hr />
                <form>
                    <div className="form-group">
                        <label>Name</label>
                        <input type="text" className="form-control" value={name} onChange={(e) => this.setState({ name: e.target.value })} />
                    </div>

                    <div className="form-group">
                        <label>Price</label>
                        <input type="number" className="form-control" value={price} onChange={(e) => this.setState({ price: e.target.value })} />
                    </div>


                    <div className="form-group">
                        <input type="button" className="btn btn-primary" value="Save" onClick={this.save} />
                    </div>

                </form>

                <NavLink to="/products">Back to products</NavLink>
            </>

        );
    }
    //
    componentDidMount = async () => {
        try {
            this.state.id = window.location.pathname.split('/')[3];
            let res = await fetch(' https://localhost:7148/products/' + this.state.id);
            if (res.ok) {
                let data = await res.json();
                this.setState({ name: data.name, price: data.price });
            }
            else {
                throw Error('Failed to load product');
            }
        } catch (e) {
            alert(e.message);
        }
    }

    //
    save = async () => {
        let { id, name, price } = this.state;
        let options = { method: 'PUT', headers: { "Content-Type": "application/json" }, body: JSON.stringify({ id, name, price }) };

        try {
            let res = await fetch(' https://localhost:7148/products', options);
            if (res.ok) {
                alert('Saved');
                this.setState({ saved: true });
            }
            else {
                throw Error('Failed to save');
            }
        } catch (e) {
            alert(e.message);
        }

    }
}
