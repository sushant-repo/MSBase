import axios from "axios";

const http = axios.create({
    baseURL: "/api",
    timeout: 3000,
    headers: {
        "Content-Type": "application/json",
    },
});

http.interceptors.response.use(
    (response) => response,
    (error) => {
        if (import.meta.env.DEV) {
            if (error.response) {
                console.groupCollapsed(
                    `[RESPONSE ERROR] ${error.config?.method?.toUpperCase()} ${error.config?.url}`
                );
                console.error("Status:", error.response.status);
                console.error("Data:", error.response.data);
                console.error("Headers:", error.response.headers);
                console.groupEnd();
            } else {
                console.error("[NETWORK/SETUP ERROR]", error.message);
            }
        }
        return Promise.reject(error);
    }
);

export default http;
