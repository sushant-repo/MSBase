<template>
    <v-page :loading="loading">
        <v-row>
            <v-col cols="12">
                <v-card width="100%">
                    <v-card-title>Patients</v-card-title>
                    <v-card-text>
                        <v-data-table
                            :headers="[
                                { title: 'Patient', key: 'fullName' },
                                { title: 'Gender', key: 'gender' },
                                { title: 'Birth Date', key: 'dateOfBirth' },
                            ]"
                            :items="patients"
                        ></v-data-table>
                    </v-card-text>
                </v-card>
            </v-col>
        </v-row>
    </v-page>
</template>

<script setup>
    import http from "@/plugins/http";
    import { ref } from "vue";
    import { useLoading } from "@/plugins/useLoading";
    import { getMessage } from "@/utils/text";
    import useSnackbar from "@/plugins/snackbar";

    const snackbar = useSnackbar();
    const patients = ref([]);
    const loading = useLoading();

    async function reload() {
        loading.start();
        try {
            patients.value = await http.get("/patients");
        } catch (error) {
            snackbar.error(getMessage(error));
        } finally {
            loading.end();
        }
    }

    reload();
</script>

