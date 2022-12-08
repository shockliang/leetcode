package solution

import "fmt"

func getHint(secret string, guess string) string {
	secretMapping := make(map[uint8]int)
	var cowsGuess []uint8
	bull := 0
	cows := 0

	for i := 0; i < len(secret); i++ {
		if secret[i] == guess[i] {
			bull++
		} else {
			_, ok := secretMapping[secret[i]]
			if ok {
				secretMapping[secret[i]]++
			} else {
				secretMapping[secret[i]] = 1
			}

			cowsGuess = append(cowsGuess, guess[i])
		}
	}

	for i := 0; i < len(cowsGuess); i++ {
		_, ok := secretMapping[cowsGuess[i]]

		if ok && secretMapping[cowsGuess[i]] != 0 {
			cows++
			secretMapping[cowsGuess[i]]--
		}
	}

	return fmt.Sprintf("%dA%dB", bull, cows)
}
