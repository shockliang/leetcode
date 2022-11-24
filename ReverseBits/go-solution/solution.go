package solution

func reverseBits(num uint32) uint32 {
	var value uint32 = 0
	pow := 31

	for num != 0 {
		value += (num & 1) << pow
		num = num >> 1
		pow--
	}

	return value
}
