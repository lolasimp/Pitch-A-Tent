import React, { Component } from 'react';
import tent from './img/Tent.png';

export class NavMenu extends Component {
  //displayName = NavMenu.name

  render() {
    return (
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <a className="navbar-brand" href="#"><img className="tent" src={tent}></img></a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarColor03" aria-controls="navbarColor03" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div className="collapse navbar-collapse" id="navbarColor01">
                <ul className="navbar-nav mr-auto">
                    <li className="nav-item active">
                        <a className="nav-link" href="#">Home <span className="sr-only">(current)</span></a>
                    </li>
                    <li className="nav-item">
                        <a className="nav-link" href="/wishItems">Wish Items</a>
                    </li>
                </ul>
            </div>
        </nav>
    );
  }
}

export default NavMenu;