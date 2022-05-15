namespace DotNetSolutions.Algorythms
{
    public static class BinarySearchProblems
    {
        public static int Search(int[] nums, int target)
        {
            int SearchPartial(int[] nums, int start, int end, int target)
            {
                if (start == end)
                {
                    if (nums[start] == target) return start;
                    return -1;
                }
                else
                {
                    int med = start + (end - start) / 2;
                    if (nums[med] == target)
                    {
                        return med;
                    }
                    else if (nums[med] > target)
                    {
                        return SearchPartial(nums, start, med, target);
                    }
                    else
                    {
                        return SearchPartial(nums, med + 1, end, target);
                    }
                }
            }

            return SearchPartial(nums, 0, nums.Length - 1, target);
        }

        public static int FirstBadVersion(int n)
        {
            bool[] versions = new bool[] { false, false, false, true, true, true };

            bool IsBadVersion(int n)
            {
                if (n < 1 || n > versions.Length) return false;
                return versions[n - 1];
            }

            int FirstBadVersionPartial(int start, int end)
            {
                if (!IsBadVersion(end)) return -1;

                if (!IsBadVersion(end - 1)) return end;

                int med = start + (end - start) / 2;

                if (!IsBadVersion(med))
                {
                    return FirstBadVersionPartial(med, end);
                }
                else
                {
                    return FirstBadVersionPartial(start, med);
                }
            }

            return FirstBadVersionPartial(1, n);
        }

        public static int SearchInsert(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            int index = left;
            while (left <= right)
            {
                if (nums[right] == target) return right;
                if (nums[left] == target) return left;
                if (right - left <= 1)
                {
                    if (nums[right] < target) return right + 1;
                    if (nums[left] > target) return left;
                    return left + 1;
                }

                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid;
                }
                else if (nums[mid] > target)
                {
                    right = mid;
                }
            }
            return -1;
        }
    }
}
