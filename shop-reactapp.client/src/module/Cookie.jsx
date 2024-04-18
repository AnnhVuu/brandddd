//Cookie
export function setCookie(name, value, time) {
  const date = new Date();
  date.setTime(date.getTime() + time * 1000);
  let expires = "expires=" + date.toUTCString();
  document.cookie = `${name}=${value}; ${expires}; path=/`;
}

export function deleteCookie(name) {
  setCookie(name, null, null);
}

export function getCookie(name) {
  const cookiesDecoded = decodeURIComponent(document.cookie);
  const cookiesArray = cookiesDecoded.split("; ");
  let result = null;
  cookiesArray.forEach((element) => {
    if (element.indexOf(name) == 0) {
      result = element.substring(name.length + 1);
    }
  });
  return result;
}
