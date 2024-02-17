# Linked List

Linked lists stores a reference to the next element in the list.
Every instance is a node with the first node beeing the headnode. 



## Types of linked lists

### Singly linked list
Every node has two parts: the value and the pointer to the next node.

If we got at list of three element [1, 3, 8]
We got three different nodes

First node aka HeadeNode
[1, reference to second node] -> 
Second node
[3, reference to third node] -> 
Third node
[8, null]


We can only iterate forward. Cant go backwards because we dont know whats behind us, there are no reference.

We always start from the headnode. For example if we search for the value 7 in this list {1, 2, 3, 4, 5, 6, 7, 8, 9} we dysty from 1 and iterate all way up to 7. 

## Doubly linked list
Every node has three parts: the reference to the previous node, the value and the reference to the next node.
Enables two iterate backwards too. 

We got three different nodes

First node aka HeadeNode
[null, 1, reference to second node] -> 
Second node
<- [reference to first node, 3, reference to third node] -> 
Third node
<- [reference to second node, 8, null]



## Circular linked list
A circular linked list is the same as a single or double linked list except that the last node has a reference two the first node.

## Linked list vs Array

Linked list PRO if we: 
	- meed constant time insertions/deletions from the list
	- dont know the number of values that will be in the list
	- dont need random access to any elements in the list
	- want to be able to access item in the middle of the list

Arrays PRO if we:
	- need indexed/random access to elements
	- know beforehand the number of elements
	- need speed when iterating thorugh all the elements in sequence
	- are concerend about memory usage