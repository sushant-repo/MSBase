<template>
    <v-snackbar v-model="showSnackbar" :color="color" location="top">
        {{ message }}
    </v-snackbar>
</template>

<script setup>
    import { ref, watch } from "vue";
    import useSnackbar from "@/plugins/snackbar";

    const snackbar = useSnackbar();

    const showSnackbar = ref(false);
    const message = ref("");
    const color = ref("info");

    watch(
        () => snackbar.state.value,
        (snackbar) => {
            if (snackbar) {
                message.value = snackbar.message || "";
                color.value = snackbar.type || "info";
                showSnackbar.value = true;
            } else {
                showSnackbar.value = false;
            }
        }
    );
</script>
