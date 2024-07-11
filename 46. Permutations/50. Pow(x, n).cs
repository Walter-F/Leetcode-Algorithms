public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();
        var queue = new Queue<List<int>>();
        queue.Enqueue(new List<int>());
        
        for(int i=0;i<nums.Length;i++)
        {
            int size = queue.Count;
            for(int j=0;j<size;j++)
            {
                var curr = queue.Dequeue(); // get latest list
                for(int k=0;k<=curr.Count;k++) // add it into every single index
                {
                    var temp = new List<int>(curr); // take a copy
                    temp.Insert(k, nums[i]); // insert at index
                    queue.Enqueue(temp);
                }
            }
        }
        
        while(queue.Count > 0)
            result.Add(queue.Dequeue());
        
        return result;
    }
}