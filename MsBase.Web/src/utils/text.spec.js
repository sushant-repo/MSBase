import { describe, it, expect, afterEach, vi } from "vitest";
import { getMessage } from "./text";
import { isAxiosError } from "axios";

vi.mock("axios", () => ({
    isAxiosError: vi.fn(),
}));

describe("getMessage", () => {
    const defaultMessage = "An unexpected error occured.";

    afterEach(() => {
        vi.clearAllMocks();
    });

    it("should return general message for empty error", () => {
        const errorWithEmptyMessage = new Error();
        const messageForEmptyError = getMessage(errorWithEmptyMessage);
        expect(messageForEmptyError).toBe(defaultMessage);
    });

    it("should return correct message for non-axios error", () => {
        let errorMessage = "Some error";
        const error = new Error(errorMessage);
        const message = getMessage(error);
        expect(message).toBe(errorMessage);
    });

    it("returns .Message from Axios error", () => {
        isAxiosError.mockReturnValue(true);
        const error = {
            response: {
                data: {
                    Message: "This is an error",
                },
            },
        };
        expect(getMessage(error)).toBe("This is an error");
    });

    it("returns .message from Axios error", () => {
        isAxiosError.mockReturnValue(true);
        const error = {
            response: {
                data: {
                    message: "lowercase message",
                },
            },
        };
        expect(getMessage(error)).toBe("lowercase message");
    });

    it("returns string body from Axios error", () => {
        isAxiosError.mockReturnValue(true);
        const error = {
            response: {
                data: "Raw string error",
            },
        };
        expect(getMessage(error)).toBe("Raw string error");
    });

    it("returns default message for empty Axios response", () => {
        isAxiosError.mockReturnValue(true);
        const error = {
            response: {
                data: {},
            },
        };
        expect(getMessage(error)).toBe(defaultMessage);
    });
});
