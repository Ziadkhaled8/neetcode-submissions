public class TimeMap {
    private Dictionary<string, SortedList<int, string>> map;
    public TimeMap() {
        map=new  Dictionary<string, SortedList<int, string>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!map.ContainsKey(key))
        {
            map[key] = new SortedList<int, string>();
        }
        map[key][timestamp] = value;
    }
    
    public string Get(string key, int timestamp) {
        if (!map.ContainsKey(key)) return "";
        var stamps=map[key];
        int l=0;
        int r=stamps.Count-1;
        while(l<=r)
        {
            int mid= l +(r-l)/2;
            if(stamps.Keys[mid]==timestamp)
                return stamps.Values[mid];
            else if(stamps.Keys[mid]>timestamp)
                r=mid-1;
            else

                l=mid+1;
        }
        if(r>=0)
            return stamps.Values[r];
        else
            return "";
    }
}
