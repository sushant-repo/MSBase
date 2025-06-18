import "./assets/main.css";

import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import vuetify from "./vuetify";

import VPage from "@/components/global/VPage.vue";

const app = createApp(App);

app.use(router);
app.use(vuetify);
app.component("VPage", VPage);

app.mount("#app");

