package solution

func romanToInt(s string) int {
	romanMap := make(map[uint8]int)
	romanMap['I'] = 1
	romanMap['V'] = 5
	romanMap['X'] = 10
	romanMap['L'] = 50
	romanMap['C'] = 100
	romanMap['D'] = 500
	romanMap['M'] = 1000

	value := 0

	for i := len(s) - 1; i >= 0; i-- {
		if i == len(s)-1 {
			value = romanMap[s[i]]
		}
		if i-1 >= 0 && romanMap[s[i-1]] < romanMap[s[i]] {
			value -= romanMap[s[i-1]]
			continue
		}

		if i-1 >= 0 && romanMap[s[i-1]] >= romanMap[s[i]] {
			value += romanMap[s[i-1]]
		}

	}

	return value
}
