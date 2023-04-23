import { Counter } from "./components/Counter";
import { CreateProduct } from "./components/products/CreateProduct";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import { ProductList } from "./components/products/ProductList";
import { EditProduct } from "./components/products/EditProduct";

const AppRoutes = [
    {
        index: true,
        element: <Home />
    },
    {
        path: '/counter',
        element: <Counter />
    },
    {
        path: '/fetch-data',
        element: <FetchData />
    }
    ,
    {
        path: '/products',
        element: <ProductList />
    }
    ,
    {
        path: '/products/create-product',
        element: <CreateProduct />
    }
    ,
    {
        path: '/products/edit-product/:id',
        element: <EditProduct />
    }
];

export default AppRoutes;


