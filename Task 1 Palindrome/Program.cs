using System.ComponentModel;

Console.WriteLine(IsPalindrome("nin")); 
static bool IsPalindrome(string text)
{

	char[] tmp = text.ToLower().ToCharArray();

	for (int i = 0; i < tmp.Length; i++)
	{
		if (tmp[i] == tmp[tmp.Length - 1 - i])
		{
			continue;
		}
		else
		{
			return false;
		}
	}

	return true;
}