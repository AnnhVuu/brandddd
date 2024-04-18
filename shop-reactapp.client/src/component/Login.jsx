import React from "react";

function login() {
  axios
    .post("/login", { username: "HuyKhanh" })
    .then((response) => {
      // Xử lý phản hồi thành công
      setCookie("accessToken", response.data.accessToken, 20);
      setCookie("refreshToken", response.data.refreshToken, 3600);
      getUsername();
    })
    .catch((error) => {
      // Xử lý lỗi
      console.error("Error", error);
    });
}

const Login = () => {
  return <div>Login</div>;
};

export default Login;
