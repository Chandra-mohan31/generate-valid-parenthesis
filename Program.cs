namespace task_11_04_23
{
    internal class Program
    {

        public static void backtrack(string res,int open,int close,int n,List<string> resList)
        {
            if(res.Length == n * 2)
            {
                resList.Add(res);
                return;
            }
            if(open < n)
            {
                backtrack(res += "(", open + 1, close, n, resList);

            }
            if(close < open)
            {
                backtrack(res += ")", open , close + 1, n, resList);

            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> list = new List<string>();
            int n = 3;
            //int no_of_open_braces = 0;
            //int no_of_close_braces = 0;
            string res = "";
            backtrack(res, 0, 0, n, list);

            foreach(var item in list)
            {
                Console.Write($"{item} \t");
            }


            

        }
    }
}