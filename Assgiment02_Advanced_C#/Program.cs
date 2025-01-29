using System.Collections;

namespace Assgiment02_Advanced_C_
{
    internal class Program
    {
        #region Q1
        static void CountGreaterThanX()
        {
            int[] arr = { 11, 5, 3 };
            int[] queries = { 1, 5, 13 };

            foreach (int x in queries)
            {
                int count = arr.Count(num => num > x);
                Console.WriteLine($"numbers that is greater than {x}  is {count} items");
            }
        }
        #endregion

        #region Q2
        static void CheckPalindrome()
        {

            int[] array = { 1, 3, 2, 3, 4 };
            bool isPalindrome = array.SequenceEqual(array.Reverse());
            Console.WriteLine(isPalindrome ? "YES" : "NO");
        }
        #endregion

        #region Q3
        public static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        #endregion

        #region Q4
        public static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0) return false;
                    char top = stack.Pop();
                    if ((c == ')' && top != '(') || (c == ']' && top != '[') || (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
        #endregion

        #region Q6
        public static void RemoveOddNumbers(ArrayList list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if ((int)list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }
        }
        #endregion

        #region Q8
        public static void SearchTargetInStack(Stack<int> stack, int target)
        {
            int count = 0;
            foreach (var item in stack)
            {
                count++;
                if (item == target)
                {
                    Console.WriteLine($"Target was found successfully and the count = {count}");
                    return;
                }
            }
            Console.WriteLine("Target was not found");
        }
        #endregion

        #region Q10
        public static void FindSublistWithSum(List<int> list, int target)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int sum = 0;
                for (int j = i; j < list.Count; j++)
                {
                    sum += list[j];
                    if (sum == target)
                    {
                        Console.WriteLine($"[{string.Join(", ", list.GetRange(i, j - i + 1))}]");
                        return;
                    }
                }
            }
            Console.WriteLine("No sublist found");
        }
        #endregion

        #region Q11
        public static void ReverseFirstKElements(Queue<int> queue, int k)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
            // here for ReAdd items in queue
            for (int i = 0; i < queue.Count - k; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }
        #endregion
        static void Main(string[] args)
        {

            #region Q1
            //CountGreaterThanX();
            #endregion

            #region Q2
            //  CheckPalindrome();
            #endregion

            #region Q3
            //Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            //ReverseQueue(queue);

            //foreach (var item in queue)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion

            #region Q4
            //string input = "[]{}";
            //Console.WriteLine(IsBalanced(input) ? "Balanced" : "Not Balanced");
            #endregion

            #region Q5
            //int[] array = { 1, 2, 2, 3, 4, 4, 5 };
            //int[] uniqueArray = array.Distinct().ToArray();

            //foreach (var item in uniqueArray)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q6
            //ArrayList list = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //RemoveOddNumbers(list);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q7
            //Queue<object> queue = new Queue<object>();
            //// i use object datatype to hold all type of data i will add
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q8
            //Stack<int> stack = new Stack<int>(new[] { 1, 2, 3, 4, 5 });
            //int target = 10;
            //SearchTargetInStack(stack, target);
            #endregion

            #region Q9
            //// i search
            //int[] array1 = { 1, 2, 3, 4, 4 };
            //int[] array2 = { 10, 4, 4,3 };
            //var intersection = array1.Intersect(array2).ToArray();

            //foreach (var item in intersection)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q10
            //List<int> list = new List<int> { 1, 2, 3, 7, 5 };
            //int target = 10;
            //FindSublistWithSum(list, target);
            #endregion

            #region Q11
            //Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            //int k = 3;
            //ReverseFirstKElements(queue, k);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

        }
    }
}
