namespace Sorting
{
    public class Sorter
    {
        /// <summary>
        /// sorts a list of items in ascending order
        /// </summary>
        /// <typeparam name="T">The type of items in the list. Must implement IComparable</typeparam>
        /// <param name="list">the list of items to be sorted </param>
        public static List<T> GenericSort<T>(List<T> list) where T : IComparable
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j].CompareTo(list[j + 1]) > 0)
                    {
                        (list[j + 1], list[j]) = (list[j], list[j + 1]);
                    }
                }
            }
            return list;
        }
        public static void Main(string[] args)
        {
            var liste = new List<int> { 4, 3, 2, 1 };
            var sorted = GenericSort(liste);

            foreach (var item in sorted)
            {

                Console.Write(item);
            }
            Console.WriteLine("");




        }

    }
}