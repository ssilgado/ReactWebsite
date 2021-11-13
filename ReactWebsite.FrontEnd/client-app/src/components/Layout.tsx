import { Container } from 'react-bootstrap'
import NavMenu from './NavMenu'
import Footer from './Footer'

function Layout(props: any) {
    return (
        <><NavMenu />
        <div>
            <Container>
                {props.children}
            </Container>
        </div>
        <Footer /></>
    );
}

export default Layout;