using System.Text;

namespace DotNetSolutions.Algorythms {
    public static class TwoPointersProblems {
        public static int[] TwoSumSorted(int[] numbers, int target) {
            var count = numbers.Length;
            var result = new int[2] {-1, -1};

            if (count < 2)
            {
                return result;
            }

            int i1 = 0;
            int l = 0, r = 0, m = 0;
            
            while (i1 < count - 1)
            {
                l = i1 + 1;
                r = count - 1;
                while (l < r)
                {
                    m = l + (r - l) / 2;
                    if (numbers[i1] + numbers[m] == target)
                    {
                        result[0] = i1 + 1;
                        result[1] = m + 1;
                        return result;                        
                    }
                    else if (numbers[m] + numbers[i1] < target)
                    {
                        l = m + 1;                        
                    }
                    else 
                    {
                        r = m - 1;
                    }
                }
                if (numbers[i1] + numbers[l] == target)
                {
                    result[0] = i1 + 1;
                    result[1] = l + 1;
                    return result;                        
                }
                i1++;
            }

            return result;  
        }

        public static void MoveZeroes(int[] nums)
        {
            var count = nums.Length;
            var posZero = count - 1;
            var countZeroes = 0;
            while (posZero >= 0)
            {
                while (nums[posZero] != 0)
                {
                    posZero--;
                    if (posZero < 0) break;
                }

                if (posZero < 0) break;

                if (nums[posZero] == 0)
                {
                    countZeroes++;

                    var i = posZero;
                    while (i < count - countZeroes)
                    {
                        nums[i] = nums[i + 1];
                        i++;
                    }
                    nums[count - countZeroes] = 0;
                    posZero--;
                }
            }
        }

        public static void Rotate(int[] nums, int k)
        {
            var count = nums.Length;

            if (k < 0) return;

            if (k > count)
            {
                k = k % count;
            }

            var buf = new int[k];

            for (int i = 0; i < k; i++)
            {
                buf[i] = nums[count - k + i];
            }

            for (int i = count - k - 1; i >= 0; i--)
            {
                nums[i + k] = nums[i];
            }

            for (int i = 0; i < k; i++)
            {
                nums[i] = buf[i];
            }

            Console.WriteLine($"nums = {string.Join(',', nums.ToList())}");
        }

        public static int[] SortedSquares(int[] nums)
        {
            var count = nums.Length;
            int[] result = new int[count];

            if (count == 1)
            {
                result[0] = (int)Math.Pow(nums[0], 2);
                return result;
            }

            var ipos = 0;
            while (ipos < count)
            {
                if (nums[ipos] >= 0) break;
                ipos++;
            }

            int iback = 0, iforw = 0;

            if (ipos == 0)
            {
                iback = ipos;
                iforw = ipos + 1;
            }
            else if (ipos >= count - 1)
            {
                iback = count - 2;
                iforw = count - 1;
            }
            else
            {
                if (Math.Abs(nums[ipos - 1]) < Math.Abs(nums[ipos + 1]))
                {
                    iback = ipos - 1;
                    iforw = ipos;
                }
                else
                {
                    iback = ipos;
                    iforw = ipos + 1;
                }
            }

            int i = 0;
            while (iback >= 0 || iforw < count)
            {
                if (iback < 0)
                {
                    result[i] = (int)Math.Pow(nums[iforw], 2);
                    iforw++;
                }
                else if (iforw >= count)
                {
                    result[i] = (int)Math.Pow(nums[iback], 2);
                    iback--;
                }
                else if (Math.Abs(nums[iback]) < Math.Abs(nums[iforw]))
                {
                    result[i] = (int)Math.Pow(nums[iback], 2);
                    iback--;
                }
                else
                {
                    result[i] = (int)Math.Pow(nums[iforw], 2);
                    iforw++;
                }

                i++;

            }

            return result;
        }

        public static void ReverseString(char[] s) {
            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                var tmp = s[r];
                s[r] = s[l];
                s[l] = tmp;

                l++;
                r--;
            }
        }

        public static string ReverseWords(string s)
        {
            var sb = new StringBuilder();
            int l = 0, r = 0, i = 0;

            while (i < s.Length)
            {
                l = i;
                while (s[i++] != ' ')
                {
                    if (i >= s.Length)
                    {
                        break;
                    }
                };
                char[] buf;
                if (i < s.Length)
                {
                    buf = s[l..(i - 1)].ToCharArray();
                }
                else
                {
                    buf = s[l..].ToCharArray();
                }

                l = 0;
                r = buf.Length - 1;
                while (l < r)
                {
                    var tmp = buf[r];
                    buf[r--] = buf[l];
                    buf[l++] = tmp;
                }
                sb.Append(new string(buf));
                if (s[i - 1] == ' ')
                {
                    sb.Append(' ');
                }
            }

            return sb.ToString();
        }
    }
}