namespace Leetcode {
    public class SingleNumber {
        public int SingleNum(int[] nums) {
            var alone = nums.GroupBy(x => x)
                .Where(y => y.Count() == 1)
                .Select(z => z.Key)
                .ToList();
                if(alone.Count > 1) {
                    System.Console.WriteLine("No single num exists in array. There are multiple.");
                    return 0;

                } else
            System.Console.WriteLine($"The single num is {alone[0]}.");
        return alone[0];
        }
    }
}