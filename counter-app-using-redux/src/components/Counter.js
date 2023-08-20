import React, { useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { increment, decrement } from "../store/actions/types";

const Counter = () => {
  const countState = useSelector(state => state.count);
  const dispach = useDispatch();

  const handleIncrement = () => {
    dispach({
      type: increment
    }
    )
  }

  const handleDecrement = () => {
    dispach({
      type: decrement
    }
    )
  }
  return (
    <div>
      <p>{countState}</p>
      <button onClick={handleIncrement}>increment</button>
      <button onClick={handleDecrement}>decrement</button>
    </div>
  );
};

export default Counter;
