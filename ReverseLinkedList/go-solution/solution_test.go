package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	head := ListNode{1, &ListNode{2, &ListNode{3, &ListNode{4, &ListNode{5, nil}}}}}

	actual := reverseList(&head)

	assert.Equal(t, []int{5, 4, 3, 2, 1}, actual.Produce())
}

func Test2(t *testing.T) {
	head := ListNode{1, &ListNode{2, nil}}

	actual := reverseList(&head)

	assert.Equal(t, []int{2, 1}, actual.Produce())
}

func Test3(t *testing.T) {

	actual := reverseList(nil)

	assert.Equal(t, []int{}, actual.Produce())
}

func (node *ListNode) Produce() []int {
	result := make([]int, 0)
	for node != nil {
		result = append(result, node.Val)
		node = node.Next
	}

	return result
}
