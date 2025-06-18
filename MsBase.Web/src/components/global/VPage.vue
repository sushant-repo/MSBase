<template>
    <v-container>
        <slot></slot>

        <main-loading :loading="loading" />
    </v-container>
</template>

<script setup>
    import MainLoading from "./MainLoading.vue";

    defineProps({
        loading: {
            type: Boolean,
        },
    });
</script>
