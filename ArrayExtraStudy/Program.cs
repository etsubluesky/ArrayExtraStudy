using ArrayExtraStudy;

ParkRules[] rules = new ParkRules[10];

rules[0] = new ParkRules();
rules[0].NameOfRide = "Merry-go-round";
rules[0].Feet = 3;
rules[0].Inches = 0;
rules[0].ChildrenUnder10CanRide = true;

rules[1] = new ParkRules();
rules[1].NameOfRide = "Thunder";
rules[1].Feet = 5;
rules[1].Inches = 8;
rules[1].ChildrenUnder10CanRide = false;

int[] values = { 1, 2, 3, 4, 5 };
int[] valuesShallowCopy = values;

int[] deepCopy = new int[values.Length];

values[0] = 7;
values[1] = 8;
valuesShallowCopy[2] = 9;
values[3] = 10;
values[4] = 11; 

for (int i = 0; i < values.Length; i++)
{
    Console.WriteLine(values[i]);
    Console.WriteLine(valuesShallowCopy[i]);
    deepCopy[i] = values[i];

}

values[0] = 100;

for (int i = 0; i < values.Length; i++)
{
    Console.WriteLine(values[i]);
    Console.WriteLine(valuesShallowCopy[i]);
    Console.WriteLine(deepCopy[i]);

}


Console.WriteLine(ArraysEqualsBaseOnContents(new int[] {1,2,3,4,5}, new int[] {1,2,3,4,5} ));


//this only works if they are sorted
static bool ArraysEqualMustBeSorted(int[] array1, int[] array2)
{
    //call a sort method on the two arrays first!

    if(array1.Length != array2.Length)
    {
        return false;
    }
    else
    {
        for (int i = 0; i < array2.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }
    }

    return true;
}

static bool ArraysEqualsBaseOnContents(int[] array1, int[] array2)
{
    //call a sort method on the two arrays first!
    bool contains = false;

    if (array1.Length != array2.Length)
    {
        return false;
    }
    else
    {
        for (int i = 0; i < array1.Length; i++)
        {
           

            for (int j = 0; j < array2.Length; j++)
            {
                if (array1[i] != array2[j])
                {
                    contains = false;
                }
                else
                {
                    contains = true;
                    break;
                }

                if(contains == false)
                {
                    return contains;
                }
 

            }
        }
    }

    return contains;
}

