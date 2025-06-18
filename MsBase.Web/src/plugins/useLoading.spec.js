import { describe, test, expect } from "vitest";
import { useLoading } from "./useLoading";
import { isRef } from "vue";

describe("useLoading", () => {
    const loading = useLoading();

    test("should start and end correctly", () => {
        expect(isRef(loading)).toBeTruthy();
        expect(loading.value).toBe(false);

        loading.start();
        expect(loading.value).toBe(true);

        loading.end();
        expect(loading.value).toBe(false);
    });

    test("should allow multiple start calls and balanced end calls", () => {
        loading.start();
        loading.start();
        expect(loading.value).toBe(true);

        loading.end();
        expect(loading.value).toBe(true);
        loading.end();
        expect(loading.value).toBe(false);
    });

    test("should throw error if end is called more than start", () => {
        loading.start();
        loading.start();
        expect(loading.value).toBe(true);

        loading.end();
        loading.end();
        expect(loading.value).toBe(false);

        expect(() => loading.end()).toThrow(
            "[useLoading] Attempted to end loading when none was active"
        );
    });

    test("should throw error if end is called by itself", () => {
        expect(() => loading.end()).toThrow(
            "[useLoading] Attempted to end loading when none was active"
        );
    });
});
