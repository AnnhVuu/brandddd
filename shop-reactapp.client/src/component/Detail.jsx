import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { fetchApi } from "../module/fetchApi";
import Skeleton from "react-loading-skeleton";
import "react-loading-skeleton/dist/skeleton.css";
import "../css/Detail.css";
const Detail = () => {
  const { productId } = useParams();
  const [data, setData] = useState([]);
  const [isLoading, setIsLoading] = useState(true);
  const URL =
    "https://my-json-server.typicode.com/HuyKhanh309/demo/data/" + productId;
  useEffect(() => {
    fetchApi(URL).then((data) => {
      setData(data);
      setIsLoading(false);
    });
  }, []);
  return (
    <>
      <div className="container-xxl text-center display">
        <div class="row  py-5 p-4 ">
          {isLoading ? (
            <Loading></Loading>
          ) : (
            <>
              <div class="col">
                <img src={data.image} className="img"></img>
              </div>
              <div class="col">
                <h1>{data.name}</h1>
                <p>{data.price} VND</p>
              </div>
            </>
          )}
        </div>
      </div>
    </>
  );
};
function Loading() {
  return (
    <>
      <div class="col">
        <Skeleton className="img" />
      </div>
      <div class="col">
        <Skeleton className="card-text" count={4} />
      </div>
    </>
  );
}
export default Detail;
