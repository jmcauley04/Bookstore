import { createBrowserRouter } from 'react-router-dom';
import MainLayout from './layouts/MainLayout';

const routes = [
    {
        path: "/",
        element: <MainLayout />
        // children: [
        //     {
        //         path: "contacts/:contactId",
        //         element: <ContactDetails />
        //     }
        // ]
    },
];

const router = createBrowserRouter(routes);