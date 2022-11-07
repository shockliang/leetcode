package solution

import (
	"strings"
	"unicode/utf8"
)

func isPalindrome(s string) bool {
	lower := strings.ToLower(s)
	palindrome := make([]uint8, len(s))
	count := 0

	for i := 0; i < len(lower); i++ {
		if (lower[i] >= 97 && lower[i] <= 122) ||
			(lower[i] >= 48 && lower[i] <= 57) {
			palindrome[count] = lower[i]
			count++
		}
	}

	palindromeStr := string(palindrome[:count])
	reverseStr := reverse(palindromeStr)

	return palindromeStr == reverseStr
}

func reverse(s string) string {
	size := len(s)
	buf := make([]byte, size)
	for start := 0; start < size; {
		r, n := utf8.DecodeRuneInString(s[start:])
		start += n
		utf8.EncodeRune(buf[size-start:], r)
	}
	return string(buf)
}
