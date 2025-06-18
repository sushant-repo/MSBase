import { computed, ref } from "vue";

export function useLoading() {
    const count = ref(0);

    const loading = computed(() => count.value !== 0);

    // eslint-disable-next-line vue/no-ref-as-operand
    loading.start = function (updateValue = true) {
        if (updateValue) count.value += 1;
    };

    // eslint-disable-next-line vue/no-ref-as-operand
    loading.end = function (updateValue = true) {
        if (updateValue) {
            if (count.value === 0) {
                throw new Error(
                    "[useLoading] Attempted to end loading when none was active"
                );
            }
            count.value -= 1;
        }
    };

    return loading;
}
