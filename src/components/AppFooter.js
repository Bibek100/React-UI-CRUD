import React, { Fragment } from "react";
class AppFooter extends React.Component {
  render() {
    return (
      <Fragment>
        <hr className="featurette-divider" />
        <footer style={{ padding: "0 50px" }} className="navbar fixed-bottom">
          <p className="float-left">
            <a href="/">Back to top</a>
          </p>
        </footer>
      </Fragment>
    );
  }
}
export default AppFooter;
