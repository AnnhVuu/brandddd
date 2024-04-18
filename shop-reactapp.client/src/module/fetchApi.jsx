export async function fetchApi(URL) {
  const res = await fetch(URL);
  const data = await res.json();
  return data;
}
