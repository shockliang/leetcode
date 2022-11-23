package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	actual := hammingWeight(11)

	assert.Equal(t, 3, actual)
}

func Test2(t *testing.T) {
	actual := hammingWeight(128)

	assert.Equal(t, 1, actual)
}

func Test3(t *testing.T) {
	actual := hammingWeight(4294967293)

	assert.Equal(t, 31, actual)
}
