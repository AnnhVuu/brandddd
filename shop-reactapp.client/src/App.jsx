import { Navigate, Route, Routes } from "react-router-dom";
import Header from "./component/Header";
import Body from "./component/Body";
import Detail from "./component/Detail";
import Login from "./component/Login";
import {  useState } from "react";
import ProtectedRoute from "./component/ProtectedRoute";
const App = () => {
    const [isLoggedIn] = useState(true);
  return (
    <>
      <div className="body">
        <Header isLoggedIn={isLoggedIn}></Header>
        <Routes>
          <Route exact path="/" element={<Body />} />
          <Route path="/Product/:productId" element={<Detail />} />
          <Route element={<ProtectedRoute isLoggedIn={!isLoggedIn} />}>
            <Route exact path="/Login" element={<Login />} />
          </Route>
          <Route path="*" element={<Navigate to="/" />} />
        </Routes>
      </div>
    </>
  );
};
export default App;
