package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	actual := reverseBits(43261596)

	assert.Equal(t, 964176192, actual)
}

func Test2(t *testing.T) {
	actual := reverseBits(4294967293)

	assert.Equal(t, 3221225471, actual)
}
