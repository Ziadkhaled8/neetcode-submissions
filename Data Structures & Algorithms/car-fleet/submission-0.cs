public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var pairs = new List<(int pos, int spd)>();
        for (int i = 0; i < position.Length; i++)
        {
            pairs.Add((position[i], speed[i]));
        }
        pairs.Sort((a, b) => b.pos.CompareTo(a.pos));
        var time=new Stack<float>();
        foreach(var x in pairs)
        {
           time.Push((float)(target - x.pos) / x.spd); 
            if(time.Count>=2 && time.Peek()<=time.ElementAt(1))
            {
                time.Pop();
            }
        }
        return time.Count;

    }
}
