Console.WriteLine(MinSplit(65));
static int MinSplit (int amount)
{
	int[] coins = { 50, 20, 10, 5, 1 };
	int split = 0;
	int tmp = 0;

	for (int i = 0; i < coins.Length; i++)
	{
		if (amount >= coins[i])
		{
			  tmp = amount / coins[i];
				split += amount / coins[i];
				amount -= tmp * coins[i];
		}
	}

	return split;
}