package solution

type ListNode struct {
	Val  int
	Next *ListNode
}

func reverseList(head *ListNode) *ListNode {
	var privous *ListNode = nil
	current := head

	for current != nil {
		var temp = current.Next
		current.Next = privous
		privous = current
		current = temp
	}
	return privous
}
