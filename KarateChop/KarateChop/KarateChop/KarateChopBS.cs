namespace KarateChop
{
    public class KarateChopBS
    {
        public int Count { get; set; } = 0;
        //Iterative approach
        public int Chop(int target, int[] array)
        {
            Count = 0;
            //Two pointer
            //p1 first index
            //p2 last index
            int p1 = 0;
            int p2 = array.Length - 1;
            while (p1 <= p2)
            {
                Count++;
                //get mid index
                int mid = p1 + ((p2 - p1) / 2);
                int val = array[mid];
                if (target == val)
                    return mid;
                //move pointer
                if (target > val)
                    p1 = mid + 1;
                else
                    p2 = mid - 1;
            }
            return -1;
        }
    }
}
