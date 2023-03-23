Console.WriteLine(CountVariants(3));
static int CountVariants(int stairCount)
{
	if (stairCount == 0 || stairCount == 1) return 1;

	return CountVariants(stairCount - 1) + CountVariants(stairCount - 2);
}