package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	actual := lengthOfLastWord("Hello World")

	assert.Equal(t, 5, actual)
}

func Test2(t *testing.T) {
	actual := lengthOfLastWord("   fly me   to   the moon  ")

	assert.Equal(t, 4, actual)
}

func Test3(t *testing.T) {
	actual := lengthOfLastWord("luffy is still joyboy")

	assert.Equal(t, 6, actual)
}
