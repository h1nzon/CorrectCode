
double sum = 0;
string candidate = "1234123401";

for (int i = 0; i < candidate.Length; i++)
{
    sum += Char.GetNumericValue(candidate[i]);
}

Console.WriteLine(sum);