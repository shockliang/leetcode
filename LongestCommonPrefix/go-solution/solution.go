package solution

import (
	"math"
	"strings"
)

func longestCommonPrefix(strs []string) string {
	shortestStr := minBy(strs)
	mathCount := 0
	strsLen := len(strs)

	for mathCount != strsLen {
		mathCount = 0
		for _, str := range strs {
			if strings.HasPrefix(str, shortestStr) {
				mathCount++
			}
		}

		if mathCount < strsLen {
			currentLen := len(shortestStr)
			shortestStr = shortestStr[:currentLen-1]
		}
	}

	if mathCount == strsLen {
		return shortestStr
	} else {
		return ""
	}
}

func minBy(strs []string) string {
	length := math.MaxInt32
	idx := 0
	for i, element := range strs {
		if len(element) <= length {
			length = len(element)
			idx = i
		}
	}

	return strs[idx]
}
