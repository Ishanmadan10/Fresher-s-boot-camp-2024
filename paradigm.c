#include <stdio.h>
#include <stdbool.h>


bool filterstring(const char *s, const char *arr[], int size) {
    for (int i = 0; i < size; i++) {
        if (strcmp(s, arr[i]) == 0) {
            return true;
        }
    }
    return false;
}


bool searchstring(const char *arr[], int size) {
    for (int i = 0; i < size; i++) {
        if (filterstring(arr[i], arr, size)) {
            return true;
        }
    }
    return false;
}

int main() {
    const char *ar[4] = {"I", "work", "at", "zeiss"};
    const char *s = "zeiss";
    int size = sizeof(ar);
    bool val = searchstring(ar, size);

    if (val) {
        printf("is there\n");
    } else {
        printf("is not there\n");
    }

    return 0;
}
