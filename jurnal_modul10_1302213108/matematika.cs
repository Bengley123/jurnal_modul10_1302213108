namespace MatematikaLibrary
{
    public class matematika
    {
        public static int kpk(int a, int b)
        {
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            int kpk = max;

            while (kpk % min != 0)
            {
                kpk += max;
            }
            return kpk;
        }

        public static int fpb(int a, int b)
        {
            int ans = 0;

            while (b > 0)
            {
                ans = a % b;
                a = b;
                b = ans;
            }
            return a;
        }

        public static String turunan(int[]persamaan)
        {
            int a = 0;
            int b = 0;  
            int c = 0;
            int d = 0;

            while(d<3)
            {
                a = persamaan[0] * 3;
                b = persamaan[1] * 2;
                c = persamaan[2] * 1;

                d++;

                string x = a + "x2 + " + b + "x + " + c;
                return x;
            }
        }

        public static String Integral(int[]persamaan)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;

            while (d < 4)
            {
                a = persamaan[0] / 4;
                a = persamaan[1] / 3;
                a = persamaan[2] / 2;
                a = persamaan[3] / 1;

                e++;

            }
            string x = "x" + a + " " + b + "x3 + " + c + "x2 + ";
            return x;
        }
    }
}