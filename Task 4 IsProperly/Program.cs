string text = "()((()))()()((7))";

Console.WriteLine(IsProperly(text));

static bool IsProperly(string sequence)
{
	Stack<char> brackets = new Stack<char>();

	foreach (var brck in sequence)
	{
		if (brck == '(')
		{
			brackets.Push('(');
		}
		else if (brck == ')')
		{
			if (!brackets.Any()) return false;
			brackets.Pop();
		}
	}

	if (brackets.Any()) return false;
	else return true;
}