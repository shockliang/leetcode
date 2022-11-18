package solution

func convertToTitle(columnNumber int) string {
	max := 26
	mapping := make(map[int]uint8)

	for i := 0; i < max; i++ {
		mapping[i+1] = uint8(i + 65)
	}

	stack := NewStack()
	for columnNumber > 0 {
		remainder := 0
		if columnNumber%max == 0 {
			remainder = max
		} else {
			remainder = columnNumber % max
		}
		columnNumber -= remainder
		columnNumber /= max
		stack.Push(mapping[remainder])
	}

	stackLen := stack.Len()
	chars := make([]uint8, stackLen)
	for i := 0; i < stackLen; i++ {
		chars[i] = stack.Pop().(uint8)
	}

	return string(chars)
}

type (
	Stack struct {
		top    *stackNode
		length int
	}
	stackNode struct {
		value interface{}
		prev  *stackNode
	}
)

// Create a new stack
func NewStack() *Stack {
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
	n := &stackNode{value, s.top}
	s.top = n
	s.length++
}
