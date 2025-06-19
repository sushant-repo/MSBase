<template>
    <v-layout>
        <RouterView />
        <GenericSnackbar />
    </v-layout>
</template>

<script setup>
    import GenericSnackbar from "@/components/global/GenericSnackbar.vue";
    import { RouterView } from "vue-router";
</script>

