
const initialState = [
    {
        id: 1,
        title: 'Apprendre Redux',
        completed: false
    },
    {
        id: 2,
        title: 'Créer un store Redux',
        completed: true
    },
    {
        id: 3,
        title: 'Utiliser un store Redux',
        completed: true
    },
    {
        id: 4,
        title: 'Mutter les states avec les actions',
        completed: false
    },
    {
        id: 5,
        title: 'Utiliser les states avec les séléctor',
        completed: true
    },
    {
        id: 6,
        title: 'Finir un projet react',
        completed: false
    }
];

// Définition des Actions
export const ADD_TODO_ACTION = 'ADD_TODO_ACTION';
export const UPDATE_TODO_ACTION = 'UPDATE_TODO_ACTION';
export const DELETE_TODO_ACTION = 'DELETE_TODO_ACTION';

export function TodosReducer(state = initialState, action) {
    switch (action.type) {
        // Création d'une action
        case ADD_TODO_ACTION:
            return {...state, ...action.payload};
        case UPDATE_TODO_ACTION:
            return state.map(todo => {
                if (todo.id === action.payload.id) {
                    return { ...todo, ...action.payload }
                } else {
                    return todo
                }
            })
        case DELETE_TODO_ACTION:
            return state.filter(todo=>todo.id !== action.payload);

        default:
            return state;
    }
};