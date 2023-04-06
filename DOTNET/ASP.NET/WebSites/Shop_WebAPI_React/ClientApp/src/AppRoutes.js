import { Counter } from "./components/Counter";
import { CreateProduct } from "./components/CreateProduct";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import { ProductList } from "./components/ProductList";

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
];

export default AppRoutes;
