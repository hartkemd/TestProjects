#include <stdio.h>

int main() {
    int num;
    int *pNum;
    int **ppNum;
    int ***pppNum;

    num = 5;
    pNum = &num;
    ppNum = &pNum;
    pppNum = &ppNum;

    printf("num=%d\n", num);
    printf("*pNum=%d\n", *pNum);
    printf("**ppNum=%d\n", **ppNum);
    printf("***pppNum=%d\n", ***pppNum);

    return 0;
}
