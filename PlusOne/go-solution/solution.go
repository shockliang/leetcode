package solution

func plusOne(digits []int) []int {
	length := len(digits)
	carry := 1
	digitsStack := New()
	for i := length - 1; i >= 0; i-- {
		if digits[i]+carry >= 10 {
			current := (digits[i] + 1) % 10
			digitsStack.Push(current)
		} else {
			digitsStack.Push(digits[i] + carry)
			carry = 0
		}
	}

	if carry > 0 {
		digitsStack.Push(1)
	}

	stackLength := digitsStack.length
	ary := make([]int, stackLength)

	for i := 0; i < stackLength; i++ {
		ary[i] = digitsStack.Pop().(int)
	}

	return ary
}

type (
	Stack struct {
		top    *node
		length int
	}
	node struct {
		value interface{}
		prev  *node
	}
)

// Create a new stack
func New() *Stack {
	return &Stack{nil, 0}
}

// Return the number of items in the stack
func (s *Stack) Len() int {
	return s.length
}

// View the top item on the stack
func (s *Stack) Peek() interface{} {
	if s.length == 0 {
		return nil
	}
	return s.top.value
}

// Pop the top item of the stack and return it
func (s *Stack) Pop() interface{} {
	if s.length == 0 {
		return nil
	}

	n := s.top
	s.top = n.prev
	s.length--
	return n.value
}

// Push a value onto the top of the stack
func (s *Stack) Push(value interface{}) {
	n := &node{value, s.top}
	s.top = n
	s.length++
}
