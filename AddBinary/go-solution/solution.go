package solution

func addBinary(a string, b string) string {
	mapping := make(map[uint8]int)
	mapping['0'] = 0
	mapping['1'] = 1

	reverseMapping := make(map[int]uint8)
	reverseMapping[0] = '0'
	reverseMapping[1] = '1'

	queueA := NewQueue()
	queueB := NewQueue()

	for i := len(a) - 1; i >= 0; i-- {
		queueA.Enqueue(mapping[a[i]])
	}

	for i := len(b) - 1; i >= 0; i-- {
		queueB.Enqueue(mapping[b[i]])
	}

	maxQueue := NewQueue()
	minQueue := NewQueue()
	if len(a) >= len(b) {
		maxQueue = queueA
	} else {
		maxQueue = queueB
	}

	if len(a) >= len(b) {
		minQueue = queueB
	} else {
		minQueue = queueA
	}

	stack := NewStack()
	carry := 0

	for maxQueue.Len() > 0 {
		sum := 0
		value := 0

		if maxQueue.Len() > 0 && minQueue.Len() > 0 {
			sum = maxQueue.Dequeue().(int) + minQueue.Dequeue().(int) + carry
			if sum > 1 {
				carry = 1
				value = sum % 2
			} else {
				carry = 0
				value = sum
			}

			stack.Push(value)
		} else if maxQueue.Len() > 0 && minQueue.Len() == 0 {
			sum = maxQueue.Dequeue().(int) + carry
			if sum > 1 {
				carry = 1
				value = sum % 2
			} else {
				carry = 0
				value = sum
			}
			stack.Push(value)
		}
	}

	if carry > 0 {
		stack.Push(carry)
	}

	stackLen := stack.Len()
	strArray := make([]uint8, stackLen)

	for i := 0; i < stackLen; i++ {
		strArray[i] = reverseMapping[stack.Pop().(int)]
	}

	return string(strArray)
}

type (
	Queue struct {
		start, end *queueNode
		length     int
	}
	queueNode struct {
		value interface{}
		next  *queueNode
	}
)

// Create a new queue
func NewQueue() *Queue {
	return &Queue{nil, nil, 0}
}

// Take the next item off the front of the queue
func (this *Queue) Dequeue() interface{} {
	if this.length == 0 {
		return nil
	}
	n := this.start
	if this.length == 1 {
		this.start = nil
		this.end = nil
	} else {
		this.start = this.start.next
	}
	this.length--
	return n.value
}

// Put an item on the end of a queue
func (this *Queue) Enqueue(value interface{}) {
	n := &queueNode{value, nil}
	if this.length == 0 {
		this.start = n
		this.end = n
	} else {
		this.end.next = n
		this.end = n
	}
	this.length++
}

// Return the number of items in the queue
func (this *Queue) Len() int {
	return this.length
}

// Return the first item in the queue without removing it
func (this *Queue) Peek() interface{} {
	if this.length == 0 {
		return nil
	}
	return this.start.value
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
