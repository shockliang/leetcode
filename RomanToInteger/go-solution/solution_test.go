package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	actual := romanToInt("III")

	assert.Equal(t, 3, actual)
}

func Test2(t *testing.T) {
	actual := romanToInt("LVIII")

	assert.Equal(t, 58, actual)
}

func Test3(t *testing.T) {
	actual := romanToInt("MCMXCIV")

	assert.Equal(t, 1994, actual)
}

func Test4(t *testing.T) {
	actual := romanToInt("XII")

	assert.Equal(t, 12, actual)
}

func Test5(t *testing.T) {
	actual := romanToInt("XXVII")

	assert.Equal(t, 27, actual)
}

func Test6(t *testing.T) {
	actual := romanToInt("IV")

	assert.Equal(t, 4, actual)
}
