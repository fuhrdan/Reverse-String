void reverseString(char* s, int sSize) {
    int len = sSize;
    for(int x = 0; x < len/2; x++)
    {
        char temp = s[x];
        s[x] = s[len - x - 1];
        s[len - x - 1] = temp;
//        printf("%c\n",s[x]);
    }
}