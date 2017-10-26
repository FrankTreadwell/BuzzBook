import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter, Route } from 'react-router-dom'

import MovieListPage from './modules/movies/pages/MovieListPage';

ReactDOM.render(
    <BrowserRouter>
        <Route path="/" component={MovieListPage} />
    </BrowserRouter>,
    document.getElementById('react-container')
);