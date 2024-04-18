import Logo from "../assets/Logo.png";
import PropType from "prop-types";
import "../css/Header.css";
const Header = (props) => {
  return (
    <>
      <nav className="navbar navbar-expand-lg bg-body-tertiary sticky-top ">
        <div className="container-lg">
          <div id="start">
            <a className="navbar-brand text-uppercase" href="/">
              <img
                src={Logo}
                alt="Logo"
                className="d-inline-block align-text-top logo"
              ></img>
            </a>
          </div>

          <div id="center" className="input-group mb-3 search-bar  ">
            <select
              className="form-select form-select-sm btn-select"
              aria-label="Default select example"
            >
              <option selected>All</option>
              <option value="1">One</option>
              <option value="2">Two</option>
              <option value="3">Three</option>
            </select>
            <input
              type="text"
              className="form-control input-sm  "
              placeholder="Search"
              aria-label="Recipient's username"
              aria-describedby="button-addon2"
            ></input>
            <button className="btn btn-outline-info search-btn" type="button">
              <svg
                xmlns="http://www.w3.org/2000/svg"
                width="16"
                height="16"
                fill="currentColor"
                className="bi bi-search"
                viewBox="0 0 16 16"
              >
                <path d="M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0" />
              </svg>
            </button>
          </div>

          <div id="end" className="d-none d-lg-block d-xl-block d-xxl-block ">
            <form className="d-flex ">
              {props.isLoggedIn === true ? (
                <div class="dropdown btn-dropdown">
                  <a
                    class="btn btn-outline-primary  dropdown-toggle"
                    role="button"
                    data-bs-toggle="dropdown"
                    aria-expanded="false"
                  >
                    Tran Lieu Huy Khanh
                  </a>

                  <ul class="dropdown-menu">
                    <li>
                      <a class="dropdown-item" href="#">
                        Profile
                      </a>
                    </li>
                    <li class="dropdown-item">Logout</li>
                  </ul>
                </div>
              ) : (
                <>
                  <a href="/Login">
                    <button
                      className="btn btn-outline-primary btn-login"
                      type="button"
                    >
                      Login
                    </button>
                  </a>
                  <button
                    className="btn btn-outline-primary btn-sign-up"
                    type="button"
                  >
                    Sign up
                  </button>
                </>
              )}

              <a href="#" className="position-relative a">
                <span className="position-absolute top-0 start-50 badge rounded-pill bg-danger">
                  99+
                  <span className="visually-hidden">unread messages</span>
                </span>
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="30"
                  height="30"
                  fill="currentColor"
                  className="bi bi-bell bell "
                  viewBox="0 0 16 16"
                >
                  <path d="M8 16a2 2 0 0 0 2-2H6a2 2 0 0 0 2 2M8 1.918l-.797.161A4.002 4.002 0 0 0 4 6c0 .628-.134 2.197-.459 3.742-.16.767-.376 1.566-.663 2.258h10.244c-.287-.692-.502-1.49-.663-2.258C12.134 8.197 12 6.628 12 6a4.002 4.002 0 0 0-3.203-3.92L8 1.917zM14.22 12c.223.447.481.801.78 1H1c.299-.199.557-.553.78-1C2.68 10.2 3 6.88 3 6c0-2.42 1.72-4.44 4.005-4.901a1 1 0 1 1 1.99 0A5.002 5.002 0 0 1 13 6c0 .88.32 4.2 1.22 6" />
                </svg>
              </a>
              <a href="#" className="position-relative a">
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  width="30"
                  height="30"
                  fill="currentColor"
                  className="bi bi-cart cart "
                  viewBox="0 0 16 16"
                >
                  <path d="M0 1.5A.5.5 0 0 1 .5 1H2a.5.5 0 0 1 .485.379L2.89 3H14.5a.5.5 0 0 1 .491.592l-1.5 8A.5.5 0 0 1 13 12H4a.5.5 0 0 1-.491-.408L2.01 3.607 1.61 2H.5a.5.5 0 0 1-.5-.5M3.102 4l1.313 7h8.17l1.313-7H3.102zM5 12a2 2 0 1 0 0 4 2 2 0 0 0 0-4m7 0a2 2 0 1 0 0 4 2 2 0 0 0 0-4m-7 1a1 1 0 1 1 0 2 1 1 0 0 1 0-2m7 0a1 1 0 1 1 0 2 1 1 0 0 1 0-2" />
                </svg>
                <span className="position-absolute top-0 start-50  translate-start badge rounded-pill bg-danger">
                  99+
                  <span className="visually-hidden">unread messages</span>
                </span>
              </a>
            </form>
          </div>

          <button
            className="navbar-toggler"
            type="button"
            data-bs-toggle="collapse"
            data-bs-target="#navbarNavAltMarkup"
            aria-controls="navbarNavAltMarkup"
            aria-expanded="false"
            aria-label="Toggle navigation"
          >
            <span className="navbar-toggler-icon"></span>
          </button>

          <div className="collapse navbar-collapse " id="navbarNavAltMarkup">
            <div className="d-lg-none d-xl-none d-xxl-none">
              <div className="navbar-nav">
                <a className="nav-link " href="/Login">
                  Login
                </a>
                <a className="nav-link" href="#">
                  Sign up
                </a>
                <a className="nav-link" href="#">
                  Notification
                </a>
                <a className="nav-link" href="#">
                  Card
                </a>
              </div>
            </div>
          </div>
        </div>
      </nav>
    </>
  );
};
Header.proptypes = {
  isLoggedIn: PropType.bool,
  name: PropType.string,
};
export default Header;
