import { isAxiosError } from "axios";

export function getMessage(error) {
    let message = "An unexpected error occured.";
    if (isAxiosError(error)) {
        const data = error.response?.data;

        if (
            data &&
            typeof data.Message === "string" &&
            data.Message.trim().length
        ) {
            message = data.Message;
        } else if (typeof data === "string" && data.trim().length) {
            message = data;
        } else if (data?.message) {
            message = data.message;
        }
    } else if (error?.message) {
        message = error.message;
    }

    return message;
}
