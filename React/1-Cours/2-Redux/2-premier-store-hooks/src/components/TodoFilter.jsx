import React from 'react'
import { connect } from "react-redux"
import { setFilterAction } from "../store/filterActions"
import { filterSelector } from "../store/filterSelector"

export function TodoFilter ({ value, onChange }) {
    //console.log("TodoFilterValue : "+value);
    return <div>
        <button className="btn btn-secondary" disabled={value === null} onClick={() => onChange(null)}>Aucun Filtre</button>
        <button className="btn btn-secondary" disabled={value === true} onClick={() => onChange(true)}>Complétée(s)</button>
        <button className="btn btn-secondary" disabled={value === false} onClick={() => onChange(false)}>A faire(s)</button>
    </div>
}

export const TodoFilterStore = connect(
    (state) => ({
        value: filterSelector(state)
    }),
    (dispatch) => ({
        onChange: (value) => dispatch(setFilterAction(value))
    })
)(TodoFilter) // Composant à décorer

// export function TodoFilterStore (){
//     const filter = useSelector(filterSelector)
//     const dispatch = useDispatch()
//     const onChange = useCallback(value => {
//         dispatch(setFilterAction(value))
//         // eslint-disable-next-line react-hooks/exhaustive-deps
//     }, [])

//     // Utilisation de notre composant sans logique store
//     return <TodoFilter filter={filter} onChange={onChange} />
// }