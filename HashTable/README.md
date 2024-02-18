# Hash Table
Takes a value as an input then stores the value with a hashing function and returns an index number. This makes it good for storing key value pairs. 

## Hashing algorithm / hash fucntion
An function/algorithm that converts the input to a hashcode and store it in an index value and returns an output.
An hashfunction must return the same hashcode for the same key everytime its called.

Input -> hashCode -> index -> output

## Hashing collisions
To avoid hash collisions (if we get the same key for two different values) there are several techniques to use. 

### Seperate chaining
If we store an array or linked list inside of out our hash table. Like this 

[0|1|2|3|4]
	[0,R1]
		[1,R2]
			[2,null]

This weird "illustration" is an effort to show a hash table with index 0, 1, 2, 3, 4 that on index 2 stores a linked list with the nodes 
0, 1, 2 and theire respective valus (R1 is the node reference to the next node, in this code node 1).


### Open addressing
If we try to store someting at an index position that already holds a value then in just jumps to the new index position 
to check if it's available. If it's available ut stores it here instead.
