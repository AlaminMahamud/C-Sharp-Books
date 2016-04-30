// Demonstrating a type-unsafe code with C

#include <stdio.h>
int main(int argc, char** argv)
{
	char *first_arg = argv[1];
	int *first_arg_as_int = (int *)first_arg;
	printf("%d", *first_arg_as_int);
}