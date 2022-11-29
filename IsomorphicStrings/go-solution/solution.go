package solution

func isIsomorphic(s string, t string) bool {
	if len(s) != len(t) {
		return false
	}

	sMapping := make(map[uint8]int)
	tMapping := make(map[uint8]int)
	sIsomorphic := make([]int, len(s))
	tIsomorphic := make([]int, len(t))

	for i := 0; i < len(s); i++ {
		_, sOk := sMapping[s[i]]
		if sOk {
			sIsomorphic[i] = sMapping[s[i]]
		} else {
			sMapping[s[i]] = i
			sIsomorphic[i] = sMapping[s[i]]
		}

		_, tOk := tMapping[t[i]]

		if tOk {
			tIsomorphic[i] = tMapping[t[i]]
		} else {
			tMapping[t[i]] = i
			tIsomorphic[i] = tMapping[t[i]]
		}
	}

	for i := 0; i < len(sIsomorphic); i++ {
		if sIsomorphic[i] == tIsomorphic[i] {
			continue
		} else {
			return false
		}
	}

	return true
}
