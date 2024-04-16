import store from "./store";
import {bugAdded,bugRemoved} from "./actions.js";



const unsubscribe = store.subscribe(() => {
    console.log("store changed", store.getState());
});

store.dispatch(bugAdded("Bug 1"));

unsubscribe();
store.dispatch(bugRemoved(1));
console.log(store.getState());


