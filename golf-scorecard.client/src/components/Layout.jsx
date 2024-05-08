import React, { Component } from 'react';
//import { Container } from 'reactstrap';

//export class Layout extends Component {
//    static displayName = Layout.name;

//    render() {
//        return (
//            <div className='wrapper'>
//                <NavMenu />
//                <Container>
//                    <div className='main-container'>

//                        {this.props.children}
//                    </div>
//                </Container>
//            </div>
//        );
//    }
//}
function Layout() {
    return (
        <div className='wrapper'>
            {/*<NavMenu />*/}
            {/*<Container>*/}
                <div className='main-container'>

                    {this.props.children}
                </div>
            {/*</Container>*/}
        </div>
    );
}

export default Layout;
