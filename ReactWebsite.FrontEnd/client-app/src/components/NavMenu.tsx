import { Navbar, Nav, NavDropdown, Container } from 'react-bootstrap'

function NavMenu() {
    return (
        <Navbar variant="dark" bg="primary" expand="lg">
            <Container>
                <Navbar.Brand href="/">ReactWebsite</Navbar.Brand>
                <Navbar.Toggle aria-controls="basic-navbar-nav" />
                <Navbar.Collapse id="basic-navbar-nav">
                    <Nav className="me-auto">
                        <Nav.Link href="/">Home</Nav.Link>
                    </Nav>
                </Navbar.Collapse>
            </Container>
        </Navbar>
    )
}

export default NavMenu;