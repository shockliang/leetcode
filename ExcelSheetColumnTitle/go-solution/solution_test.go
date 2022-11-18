package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	actual := convertToTitle(1)

	assert.Equal(t, "A", actual)
}

func Test2(t *testing.T) {
	actual := convertToTitle(28)

	assert.Equal(t, "AB", actual)
}

func Test3(t *testing.T) {
	actual := convertToTitle(701)

	assert.Equal(t, "ZY", actual)
}

func Test4(t *testing.T) {
	actual := convertToTitle(52)

	assert.Equal(t, "AZ", actual)
}
