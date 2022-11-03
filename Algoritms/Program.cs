#region Task 1
//int[] numbers = { 2, 0, 4, 64, 2, 5, 34, 24, 1, 563, 42 };

//int min = numbers[0];
//int minIndex = 0;
//int max = numbers[0];
//int maxIndex = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//	if (numbers[i] <= min)
//	{
//		min = numbers[i];
//		minIndex = i;
//	}
//	else if (numbers[i] >= max)
//	{
//		max = numbers[i];
//		maxIndex = i;
//	}

//}
//numbers[minIndex] = max;
//numbers[maxIndex] = min;
//for (int i = 0; i < numbers.Length; i++)
//{
//	Console.WriteLine(numbers[i]);
//}

#endregion

int num = 102344;
int i;
int numZero = 0;
int numOne = 0;
int numTwo = 0;
int numThree = 0;
int numFour = 0;
int numFive = 0;
int numSix = 0;
int numSeven = 0;
int numEight = 0;
int numNine = 0;


    while (num > 0)
    {
        i = num % 10;
        if (i == 0)
        {
            numZero++;
        }
        else if (i == 1)
        {
            numOne++;
        }
        else if (i == 2)
        {
            numTwo++;
        }
        else if (i == 3)
        {
            numThree++;
        }
        else if (i == 4)
        {
            numFour++;
        }
        else if (i == 5)
        {
            numFive++;
        }
        else if (i == 6)
        {
            numSix++;
        }
        else if (i == 7)
        {
            numSeven++;
        }
        else if (i == 8)
        {
            numEight++;
        }
        else if (i == 9)
        {
            numNine++;
        }
    num = (num - i) / 10;
    }

    if (numZero > 1 || numOne > 1 || numTwo > 1 || numThree > 1 || numFour > 1 || numFive > 1 || numSix > 1 || numSeven > 1 || numEight > 1 || numNine > 1)
    {
        Console.WriteLine("Tekrar reqem var");
    }
    else
    {
        Console.WriteLine("Hamisi ferqldiir");
    }
