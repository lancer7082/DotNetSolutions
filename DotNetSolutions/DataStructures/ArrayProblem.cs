namespace DotNetSolutions.DataStructures
{
    public static class ArrayProblem
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            var dict = new HashSet<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (!dict.Contains(nums[i]))
                {
                    dict.Add(nums[i]);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public static int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int sum = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];      
                if (sum > max) max = sum;

                if (sum < 0) sum = 0;
            }

            return max;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int index1 = -1, index2 = -1;
            var dict = new Dictionary<int, List<int>>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], new List<int> { i });
                }
                else
                {
                    dict[nums[i]].Add(i);
                }
            }

            foreach (var num in dict.Keys)
            {
                var val1 = dict[num];
                var num2 = target - num;
                if (num2 == num && val1.Count > 1)
                {
                    index1 = val1[0];
                    index2 = val1[1];
                    break;
                }
                else if (num2 != num && dict.TryGetValue(num2, out var val2))
                {
                    index1 = val1[0];
                    index2 = val2[0];
                    break;
                }
            }

            return new int[2] { index1, index2 };
        }

        public static void MergeSortedArray(int[] nums1, int m, int[] nums2, int n)
        {
            if (n <= 0) return;

            int i1 = 0, i2 = 0;

            if (m > 0)
            {
                while (i1 < m)
                {
                    // Двигаемся в 1-м массиве, пока не нашли больший элемент, чем во 2-м
                    while (nums1[i1] <= nums2[i2])
                    {
                        i1++;
                        if (i1 >= m) break;
                    }

                    var count = 0;
                    if (i1 < m)
                    {
                        // Двигаемся во 2-м массиве, пока не нашли элемент, больший, чем текущий в 1-м
                        while (nums2[i2] < nums1[i1])
                        {
                            i2++;
                            count++;
                            if (i2 >= n) break;
                        }

                        // Перемещение остатка 1-го массива вперед
                        m += count;
                        for (var i = m - 1; i >= i1 + count; i--)
                        {
                            nums1[i] = nums1[i - count];
                        }
                    }
                    else
                    {
                        count = n - i2;
                        i2 += count;
                    }

                    // Копирование блока из 2-го массива в 1-й
                    for (var i = 0; i < count; i++)
                    {
                        nums1[i1 + i] = nums2[i2 - count + i];
                    }

                    i1 += count;
                    if (i2 >= n) break;
                }
            }
            else
            {
                for(var i = 0; i < n; i++)
                {
                    nums1[i] = nums2[i];
                }
            }
        }

        /// <summary>
        /// Given two integer arrays nums1 and nums2, return an array of their intersection. 
        /// Each element in the result must appear as many times as it shows in both arrays 
        /// and you may return the result in any order.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var result = new List<int>(); 
            
            IDictionary<int, short> NumsToDictionary(int[] nums)
            {
                var dict = new Dictionary<int, short>();
                foreach (var num in nums)
                {
                    if (dict.TryGetValue(num, out var val))
                    {
                        dict[num] = (short)(val + 1);
                    }
                    else
                    {
                        dict.Add(num, 1);
                    }
                }

                return dict;
            }

            var dict1 = NumsToDictionary(nums1);
            var dict2 = NumsToDictionary(nums2);

            foreach(var item1 in dict1)
            {
                if (dict2.TryGetValue(item1.Key, out var val2))
                {
                    var val = Math.Min(item1.Value, val2);  
                    for (var i = 0; i < val; i++)
                    {
                        result.Add(item1.Key);
                    }
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// You are given an array prices where prices[i] is the price of a given stock on the ith day.
        /// You want to maximize your profit by choosing a single day to buy one stock 
        /// and choosing a different day in the future to sell that stock.
        /// Return the maximum profit you can achieve from this transaction.
        /// If you cannot achieve any profit, return 0.
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;

            int maxprofit = 0;

            int minprice = prices[0];
            for (var i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minprice)
                {
                    minprice = prices[i];
                }
                else 
                { 
                    maxprofit = Math.Max(maxprofit, prices[i] - minprice);
                }
            }

            return maxprofit;
        }
    }
}
