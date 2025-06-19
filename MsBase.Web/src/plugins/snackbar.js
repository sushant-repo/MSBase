// composables/useSnackbar.js
import { ref } from "vue";

const state = ref(null); // shared reactive state

function show(type, message, timeout = 10000) {
    state.value = { type, message };
    console.log(state.value);

    setTimeout(() => {
        state.value = null;
    }, timeout);
}

function success(msg, timeout) {
    show("success", msg, timeout);
}

function error(msg, timeout) {
    show("error", msg, timeout);
}

function info(msg, timeout) {
    show("info", msg, timeout);
}

export default function useSnackbar() {
    return {
        state,
        success,
        error,
        info,
    };
}
