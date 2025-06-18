import { defineConfig, globalIgnores } from "eslint/config";
import globals from "globals";
import js from "@eslint/js";
import pluginVue from "eslint-plugin-vue";
import pluginVitest from "@vitest/eslint-plugin";
import skipFormatting from "@vue/eslint-config-prettier/skip-formatting";
import eslintConfigPrettier from "eslint-config-prettier";
export default defineConfig([
    {
        name: "app/files-to-lint",
        files: ["**/*.{js,mjs,jsx,vue}"],
        rules: {
            eqeqeq: "error",
            semi: "error",
            "no-unused-vars": "error",
            "no-await-in-loop": "error",
            "func-style": [
                "error",
                "declaration",
                { allowArrowFunctions: false },
            ],
        },
    },

    {
        files: ["vite.config.js"],
        languageOptions: {
            ecmaVersion: "latest",
            sourceType: "module",
            globals: globals.node,
        },
    },

    globalIgnores(["**/dist/**", "**/dist-ssr/**", "**/coverage/**"]),

    {
        languageOptions: {
            globals: {
                ...globals.browser,
            },
        },
    },

    js.configs.recommended,
    ...pluginVue.configs["flat/essential"],

    {
        ...pluginVitest.configs.recommended,
        files: ["src/**/__tests__/*"],
    },
    skipFormatting,
    eslintConfigPrettier,
]);

