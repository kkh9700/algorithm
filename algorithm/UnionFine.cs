public class UnionFind
{
    int[] parents;

    public UnionFind(int N)
    {
        parents = new int[N];
    }

    public int Find(int x)
    {
        if (parents[x] == x) return x;
        return parents[x] = Find(parents[x]);
    }

    public bool isUnion(int a, int b)
    {
        a = Find(a);
        b = Find(b);
        if (a == b) return true;
        else return false;
    }

    public void Union(int a, int b)
    {
        a = Find(a);
        b = Find(b);
        if (a < b) parents[b] = a;
        else parents[a] = b;
    }
}