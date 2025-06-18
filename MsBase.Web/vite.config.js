import { fileURLToPath, URL } from "node:url";

import { defineConfig, loadEnv } from "vite";
import vue from "@vitejs/plugin-vue";
import vueDevTools from "vite-plugin-vue-devtools";

// https://vite.dev/config/
export default defineConfig(({ mode }) => {
    const env = loadEnv(mode, process.cwd());
    const target = env.VITE_APP_BASE_URL;

    // Confirm it looks right in the terminal
    console.log("✔ Loaded VITE_APP_BASE_URL:", target);

    // throw error if value is invalid
    if (!target || !/^https?:\/\//.test(target)) {
        throw new Error(`Invalid VITE_APP_BASE_URL: "${target}"`);
    }

    return {
        plugins: [vue(), vueDevTools()],
        resolve: {
            alias: {
                "@": fileURLToPath(new URL("./src", import.meta.url)),
            },
        },
        server: {
            proxy: {
                "/api": {
                    target,
                    changeOrigin: true,
                    rewrite: (path) => path.replace(/^\/api/, ""),
                },
            },
        },
    };
});

