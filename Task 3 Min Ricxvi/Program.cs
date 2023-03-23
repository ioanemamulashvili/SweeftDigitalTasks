int[] numbers = { 5, 3, 204, 6, 7, 8, 4,1,2,-5};
Console.WriteLine(NotContains(numbers));

static int NotContains(int[] array)
{
	int tmp = 1;

	while (array.Contains(tmp))
	{
		tmp++;
	}
	return tmp;

}