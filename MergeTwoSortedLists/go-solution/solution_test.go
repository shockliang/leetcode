package solution

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func Test1(t *testing.T) {
	l1 := ListNode{1, &ListNode{2, &ListNode{4, nil}}}
	l2 := ListNode{1, &ListNode{3, &ListNode{4, nil}}}

	actual := mergeTwoLists(&l1, &l2)

	assert.Equal(t, []int{1, 1, 2, 3, 4, 4}, actual.Produce())
}

func Test2(t *testing.T) {
	actual := mergeTwoLists(nil, nil)

	assert.Equal(t, []int{}, actual.Produce())
}

func Test3(t *testing.T) {
	l2 := ListNode{Val: 0, Next: nil}

	actual := mergeTwoLists(nil, &l2)

	assert.Equal(t, []int{0}, actual.Produce())
}

func (node *ListNode) Produce() []int {
	result := make([]int, 0)
	for node != nil {
		result = append(result, node.Val)
		node = node.Next
	}

	return result
}
