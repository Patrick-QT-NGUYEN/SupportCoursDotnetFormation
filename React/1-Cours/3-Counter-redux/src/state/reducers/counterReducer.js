const initialState = 0;

const reducer = (
    state = initialState,
    action
) => {
    switch (action.type) {
        case "INCREASE":
            return state + action.payload;
        case "DECREASE":
            return state - action.payload
        default:
            return state
    }
}

export default reducer;