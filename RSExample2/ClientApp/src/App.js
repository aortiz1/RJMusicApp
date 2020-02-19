import React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import FetchData from './components/FetchData';
import AlbumList from './components/AlbumList';

export default () => (
  <Layout>
    <Route exact path='/' component={Home} />
    <Route path='/counter' component={Counter} />
    <Route path='/albums' component={AlbumList} />
    <Route path='/fetch-data/:startDateIndex?' component={FetchData} />
  </Layout>
);