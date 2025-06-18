<template>
    <v-overlay
        :model-value="loading"
        scroll-strategy="block"
        class="align-center justify-center"
        persistent
    >
        <v-progress-circular
            color="primary"
            indeterminate
            :size="60"
        ></v-progress-circular>
    </v-overlay>
</template>

<script setup>
    defineProps({
        loading: {
            type: Boolean,
        },
    });
</script>
