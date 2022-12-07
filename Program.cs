// № 64:

// void ViewNum(int n)
// {
//     if (n >= 1)
//     {
//         Console.Write($"{n}; ");
//         ViewNum(n - 1);

//     }
// }

// Console.Write("Please input number N -> ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"N = {n} -> ");
// ViewNum(n);

// № 66:

// int SumAll(int m, int n)
// {
//     if (n < m) return 0;
//     else
//     {
//         return n + SumAll(m, n - 1);
//     }
// }

// Console.Write("Please input number M -> ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input number N -> ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"N = {n} -> {SumAll(m,n)}");


// № 68:

// int Akkerman(int n, int m)
// {
//     while (n != 0)
//     {
//         if (m == 0)
//         {
//             m = 1;
//         }
//         else
//         {
//             m = Akkerman(n, m - 1);
//         }
//         n = n - 1;
//     }
//     return m + 1;
// }

// Console.Write("Please input number n -> ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please input number m -> ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write($"m = {n}, n = {m} -> {Akkerman(n, m)}");