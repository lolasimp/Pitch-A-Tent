import React, { Component } from 'react';
import { Route, BrowserRouter, Redirect, Switch } from 'react-router-dom';
//import { Route } from 'react-router';
import  Locations  from './components/Locations/Locations';
import Home from './components/Home/Home';
import Login from './components/Login/Login';
import Register from './components/Register/Register';



export default class App extends Component {
  displayName = App.name

  render() {
      return (
        <Switch>
        <Route exact path='/Home' component={Home} />
        <Route exact path='/' component={Locations} />
        <Route exact path='/login' component={Login} />
        <Route exact path='/register' components={Register} />
        </Switch>

    );
  }
}


//import React, { Component } from 'react';
//import { Route, BrowserRouter, Redirect, Switch } from 'react-router-dom';
//import firebase from 'firebase';
//import './App.css';
//// Public
//import Home from './components/Home/Home';
//import Login from './components/Login/Login';
//import Register from './components/Register/Register';
//import Navbar from './components/Navbar/Navbar';


//// Private
//import WishList from './components/WishList/WishList';
//import Locations from './components/Locations/Locations';


//import fbConnection from './firebaseRequest/connection';
//fbConnection();

//const PrivateRoute = ({ component: Component, authed, ...rest }) => {
//    return (
//        <Route
//            {...rest}
//            render={props =>
//                authed === true ? (
//                    <Component {...props} />
//                ) : (
//                        <Redirect
//                            to={{ pathname: '/login', state: { from: props.location } }}
//                        />
//                    )
//            }
//        />
//    );
//};

//const PublicRoute = ({ component: Component, authed, ...rest }) => {
//    return (
//        <Route
//            {...rest}
//            render={props =>
//                authed === false ? (
//                    <Component {...props} />
//                ) : (
//                        <Redirect
//                            to={{ pathname: '/dashboard', state: { from: props.location } }}
//                        />
//                    )
//            }
//        />
//    );
//};

//class App extends Component {
//state = {
//    authed: false,
//}
//componentDidMount() {
//    this.removeListener = firebase.auth().onAuthStateChanged((user) => {
//        if (user) {
//            this.setState({ authed: true });
//        } else {
//            this.setState({ authed: false });
//        }
//    });
//}

//componentWillUnmount() {
//    this.removeListener();
//}

//getOut = () => {
//    this.setState({ authed: false });
//}

//render() {
//    return (
//        <div className="App">

//            <BrowserRouter>
//                <div>
//                    <Navbar
//                        authed={this.state.authed}
//                        getOut={this.getOut}
//                    />
//                    <div className="container">
//                        <div className="row">
//                            <Switch>
//                                <Route path="/" exact component={Home} />
//                                <PublicRoute
//                                    path="/login"
//                                    authed={this.state.authed}
//                                    component={Login}
//                                />
//                                <PublicRoute
//                                    path="/register"
//                                    authed={this.state.authed}
//                                    component={Register}
//                                />
//                                <PublicRoute
//                                    path="/Home"
//                                    authed={this.state.authed}
//                                    component={Home}
//                                />
//                                <PrivateRoute
//                                    path="/locations"
//                                    authed={this.state.authed}
//                                    component={Locations}
//                                />
//                                <PrivateRoute
//                                    path="/reviews"
//                                    authed={this.state.authed}
//                                    component={Edit}
//                                />
//                                <PrivateRoute
//                                    path="/child/childId/allplanets"
//                                    authed={this.state.authed}
//                                    component={AllPlanets}
//                                />
//                                <PrivateRoute
//                                    path="/child/userId/"
//                                    authed={this.state.authed}
//                                    component={WishList}
//                                />
//                            </Switch>
//                        </div>
//                    </div>
//                </div>
//            </BrowserRouter>
//        </div>
//    );
//}