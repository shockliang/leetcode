package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {

	actual := getHint("1807", "7810")

	assert.Equal(t, "1A3B", actual)
}

func Test2(t *testing.T) {

	actual := getHint("1123", "0111")

	assert.Equal(t, "1A1B", actual)
}

func Test3(t *testing.T) {

	actual := getHint("1122", "2211")

	assert.Equal(t, "0A4B", actual)
}

func Test4(t *testing.T) {

	actual := getHint("1122", "0001")

	assert.Equal(t, "0A1B", actual)
}
