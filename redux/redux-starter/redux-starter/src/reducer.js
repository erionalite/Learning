import * as actions from './actionTypes';
let lastId = 0;
// we use reducer so that we don't have to touch the doam but the state object. 
// guess the doam will be bound to the state. 
export default function reducer( state = [], action){
    switch(action.type){
        case actions.BUG_ADDED:
            return [
                ...state,
                {
                    id: ++lastId,
                    description: action.payload.description,
                    resolved: false
                }
            ];
        case actions.BUG_REMOVED:
            return state.filter(bug => bug.id !== action.payload.id);
        default: 
        return state;
    }
}