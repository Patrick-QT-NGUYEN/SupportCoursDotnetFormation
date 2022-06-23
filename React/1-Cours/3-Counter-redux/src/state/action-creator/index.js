
export const increaseCounter = (amount) => {
    return (dispatch) => {
        dispatch({
            type: "INCREASE",
            payload: amount
        });
    }
}


export const decreaseCounter = (amount) => {
    return (dispatch) => {
        dispatch({
            type: "DECREASE",
            payload: amount
        });
    }
}