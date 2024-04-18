import "../css/Card.css";
import Skeleton from "react-loading-skeleton";
import "react-loading-skeleton/dist/skeleton.css";
const CardSkeleton = (props) => {
  return Array(props.cards)
    .fill(0)
    .map((item, i) => (
      <div className="col" key={i}>
        <div className="card " id="card">
          <Skeleton className="card-img-top pic" />
          <div className="card-body">
            <Skeleton className="card-text" count={2} />
          </div>
        </div>
      </div>
    ));
};
export default CardSkeleton;
