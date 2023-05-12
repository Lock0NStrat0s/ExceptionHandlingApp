
int[] ages = new int[] { 1, 3, 5 };
for (int i = 0; i <= ages.Length; i++)
{
	try
	{
        Console.WriteLine(ages[i]);
    }
    catch (Exception ex)
	{
        Console.WriteLine(ex.Message);
        throw new Exception("There was an error handling the array", ex);
    }
}