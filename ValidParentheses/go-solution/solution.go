package solution

func isValid(s string) bool {
	if len(s) <= 1 {
		return false
	}

	brackets := New()

	for i := 0; i < len(s); i++ {
		switch s[i] {
		case '(', '[', '{':
			brackets.Push(s[i])
			break
		case ')', ']', '}':
			if brackets.Len() <= 0 {
				return false
			}
			open := brackets.Pop().(uint8)
			if open == '(' && s[i] == ')' {
				continue
			}
			if open == '[' && s[i] == ']' {
				continue
			}
			if open == '{' && s[i] == '}' {
				continue
			}
			return false

		default:
			return false
		}
	}

	return brackets.Len() == 0
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
