import { useEffect, useState } from "react";
import { fetchApi } from "../module/fetchApi";
import Card from "./Card";
import CardSkeleton from "./CardSkeleton";
import "../css/Body.css";
const Body = () => {
  const [data, setData] = useState([]);
  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {
    fetchApi("https://my-json-server.typicode.com/HuyKhanh309/demo/data").then(
      (data) => {
        setData(data);
        setIsLoading(false);
      }
    );
  }, []);
  return (
    <>
      <div className="container-xxl text-center display">
        <div className="row row-cols-sm-1 row-cols-md-2 row-cols-lg-3 row-cols-xl-4 g-4 py-5 p-4 gx-4">
          {isLoading ? (
            <CardSkeleton cards={8}></CardSkeleton>
          ) : (
            data.map((data) => (
              <Card
                key={data.id}
                id={data.id}
                image={data.image}
                name={data.name}
                price={data.price}
              ></Card>
            ))
          )}
        </div>
      </div>
    </>
  );
};
export default Body;
