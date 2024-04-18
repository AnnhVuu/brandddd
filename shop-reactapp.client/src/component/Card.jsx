import "../css/Card.css";
import PropType from "prop-types";
import Skeleton from "react-loading-skeleton";
import "react-loading-skeleton/dist/skeleton.css";
const Card = (props) => {
  const URL = "/Product/" + props.id;
  return (
    <a href={URL}>
      <div className="col">
        <div className="card " id="card">
          <img
            src={props.image}
            className="card-img-top pic"
            loading="lazy"
          ></img>
          <div className="card-body">
            <h5 className="card-text">{props.name}</h5>
            <h5 className="card-text">{props.price}</h5>
          </div>
        </div>
      </div>
    </a>
  );
};
export default Card;
