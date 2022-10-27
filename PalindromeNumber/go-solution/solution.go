package solution

import (
	"math"
	"strconv"
	"unicode/utf8"
)

func isPalindrome(x int) bool {
	if x >= math.MaxInt32 || x < math.MinInt32 || x < 0 {
		return false
	}

	num := strconv.FormatInt(int64(x), 10)
	reverse := reverse(num)

	return num == reverse
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
