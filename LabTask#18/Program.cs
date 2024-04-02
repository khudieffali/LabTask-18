internal class Program
{
      static void Main(string[] args)
    {
    #region Task
    head1:
        Console.WriteLine("1 ci ededi daxil edin");
        string input = Console.ReadLine();
        bool number = int.TryParse(input, out int numberOne);
        if (number == false) goto head1;
        head2:
        Console.WriteLine("2 ci ededi daxil edin");
        string input1 = Console.ReadLine();
        bool number1 = int.TryParse(input1, out int numberTwo);
        if (number1 == false) goto head2;
         
        //Checker(numberOne,numberTwo);
        Check(numberOne,numberTwo);


        #endregion
    }

    //static void Checker(int a,int b)
    //{
    //    int count = 0;
    //    int start = 0;
    //    int end = 0;
    //    int[] arr = {75,82,97,20,12,185,1,958,2555,32};
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        if (arr[i] == a)
    //        {
    //            start = i;
    //        }
    //        if (arr[i] == b)
    //        {
    //            end = i;
    //        }
    //    }
    //    int[] arr2 = new int[end-1];

    //    for (int i = start+1; i < end; i++)
    //    {

    //        arr2[count] = arr[i];
    //        count++;
    //        if (i == end)
    //        {
    //            break;
    //        }
    //    }
    //    int endNum;
    //    int sum = 0;
    //    int number;
    //    for (int i = 0; i < arr2.Length; i++)
    //    {
    //        number = arr2[i];
    //        foreach (var item in arr2)
    //        {
                
    //            if (arr2[i] > 0)
    //            {
    //                endNum = number % 10;
    //                number = (number - endNum) / 10;
    //                sum += endNum;
    //            }
             
    //        }
    //        if (sum > 7)
    //        {
    //            Console.WriteLine(arr2[i]);
    //        }

    //        sum = 0;
    //    }
    //}

     static void Check(int min,int max)
    {
       int sum = 0;
       int[] arr = {75,82,97,20,12,185,1,958,2555,32};
        foreach (var item in arr)
        {
            if(item>min && item < max)
            {
                int temp = item;
                while(temp > 0)
                {
                    int lastNum = temp % 10;
                    sum+= lastNum;
                    temp /= 10;
                }
                if (sum > 7)
                {
                    Console.WriteLine(item);
                }
            }
         
        }

    }
}