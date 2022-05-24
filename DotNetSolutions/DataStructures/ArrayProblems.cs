namespace DotNetSolutions.DataStructures
{
    public static class ArrayProblems
    {
        /// <summary>
        /// 217. Contains Duplicate
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 53. Maximum Subarray
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 1. Two Sum
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 88. Merge Sorted Array
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
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
        /// 350. Intersection of Two Arrays II
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
        /// 121. Best Time to Buy and Sell Stock
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

        /// <summary>
        /// 566. Reshape the Matrix
        /// You are given an m x n matrix mat and two integers r and c representing the number of rows 
        /// and the number of columns of the wanted reshaped matrix.
        /// The reshaped matrix should be filled with all the elements of the original matrix 
        /// in the same row-traversing order as they were.
        /// If the reshape operation with given parameters is possible and legal, output the new reshaped matrix; 
        /// Otherwise, output the original matrix.
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            var r_orig = mat.Length;
            var c_orig = mat[0].Length;

            if (r * c != r_orig * c_orig)
            {
                return mat;
            }

            int i = 0, j = 0;
            var result = new int[r][];
            result[0] = new int[c];
            for(var i_orig = 0; i_orig < r_orig; i_orig++)
            {
                for (var j_orig = 0; j_orig < c_orig; j_orig++)
                {
                    result[i][j] = mat[i_orig][j_orig];
                    j++;
                    if (j >= c)
                    {
                        i++;
                        if (i >= r) break;
                        result[i] = new int[c];
                        j = 0;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 118. Pascal's Triangle
        /// Given an integer numRows, return the first numRows of Pascal's triangle.
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public static IList<IList<int>> PascalsTriangleGenerate(int numRows)
        {
            var result = new List<IList<int>>();

            if (numRows == 0) return result;

            IList<int> GenerateRow(int rowIndex, IList<int>? prevRow)
            {
                if (rowIndex == 0)
                {
                    // First row
                    return new List<int> { 1 };
                }

                if (prevRow == null)
                {
                    throw new ArgumentNullException(nameof(prevRow));
                }

                var row = new List<int>();

                for(var i = 0; i <= prevRow.Count; i++)
                {
                    var n1 = (i == 0) ? 0 : prevRow[i - 1];
                    var n2 = (i == prevRow.Count) ? 0 : prevRow[i];
                    row.Add(n1 + n2);
                }

                return row;
            }

            IList<int>? row = null;

            for (var i = 0; i < numRows; i++)
            {
                row = GenerateRow(i, row);
                result.Add(row);
            }

            return result;
        }

        /// <summary>
        /// 36. Valid Sudoku
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        public static bool IsValidSudoku(char[][] board)
        {
            var size = board.Length;

            var rows = new HashSet<string>();
            var columns = new HashSet<string>();
            var area = new HashSet<string>();

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    if (board[i][j] != '.')
                    {
                        var rowKey = "r" + Convert.ToChar(0x31 + i) + board[i][j];
                        if (rows.Contains(rowKey)) return false;
                        rows.Add(rowKey);

                        var colKey = "c" + Convert.ToChar(0x31 + j) + board[i][j];
                        if (columns.Contains(colKey)) return false;
                        columns.Add(colKey);
                        
                        var areaKey = "a" + Convert.ToChar(0x31 + i / 3) + Convert.ToChar(0x31 + j / 3) + board[i][j];
                        if (area.Contains(areaKey)) return false;
                        area.Add(areaKey);
                    }
                }
            }

            return true;
        }
    }
}
