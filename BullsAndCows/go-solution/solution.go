package solution

import "fmt"

func getHint(secret string, guess string) string {
	h := make([]int, 10)
	bull := 0
	cows := 0

	for i := 0; i < len(secret); i++ {
		if secret[i] == guess[i] {
			bull++
		} else {
			if h[secret[i]-'0'] < 0 {
				cows++
			}
			if h[guess[i]-'0'] > 0 {
				cows++
			}

			h[secret[i]-'0']++
			h[guess[i]-'0']--
		}
	}

	return fmt.Sprintf("%dA%dB", bull, cows)
}
