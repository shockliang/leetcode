package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	actual := addBinary("11", "1")

	assert.Equal(t, "100", actual)
}

func Test2(t *testing.T) {
	actual := addBinary("1010", "1011")

	assert.Equal(t, "10101", actual)
}

func Test3(t *testing.T) {
	actual := addBinary("10101", "1011")

	assert.Equal(t, "100000", actual)
}

func Test4(t *testing.T) {
	actual := addBinary("1", "0")

	assert.Equal(t, "1", actual)
}

func Test5(t *testing.T) {
	actual := addBinary("1", "1")

	assert.Equal(t, "10", actual)
}
