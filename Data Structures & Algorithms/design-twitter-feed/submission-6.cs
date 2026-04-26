public class Twitter
{
    private readonly int LIMIT = 10;

    private int time = 0;

    // id -> posts(old -> new)
    private Dictionary<int, LinkedList<(int, int)>> posts = new();

    // id  -> follows
    private Dictionary<int, HashSet<int>> follows = new();

    public Twitter()
    {

    }

    // assume that the bigger the id the recent the post
    public void PostTweet(int userId, int tweetId)
    {
        if (!posts.ContainsKey(userId))
        {
            posts[userId] = new LinkedList<(int, int)>();
        }

        if (posts[userId].Count >= LIMIT)
        {
            posts[userId].RemoveFirst();
        }

        posts[userId].AddLast((tweetId, time++));
    }

    public List<int> GetNewsFeed(int userId)
    {
        // 10 * (followed users + 1)

        var maxHeap = new PriorityQueue<int, int>();

        // self
        if (posts.ContainsKey(userId))
        {
            var tweets = posts[userId];
            foreach (var tweet in tweets)
            {
                if (maxHeap.Count >= LIMIT)
                {
                    maxHeap.Dequeue();
                }
                maxHeap.Enqueue(tweet.Item1, tweet.Item2);
            }
        }

        // others
        if (follows.ContainsKey(userId))
        {
            foreach (var following in follows[userId])
            {
                if (!posts.ContainsKey(following))
                {
                    continue;
                }

                var tweets = posts[following];
                foreach (var tweet in tweets)
                {
                    if (maxHeap.Count >= LIMIT)
                    {
                        maxHeap.Dequeue();
                    }
                    maxHeap.Enqueue(tweet.Item1, tweet.Item2);
                }
            }
        }

        // find top10, use minheap, top is min, reverse
        // for most recent to least recent
        var result = new List<int>();
        while(maxHeap.Count > 0)
        {
            result.Add(maxHeap.Dequeue());
        }
        result.Reverse();

        return result;
    }

    public void Follow(int followerId, int followeeId)
    {
        if (followerId == followeeId) {
            return;
        }

        if (!follows.ContainsKey(followerId))
        {
            follows[followerId] = new HashSet<int>();
        }
        follows[followerId].Add(followeeId);
    }

    public void Unfollow(int followerId, int followeeId)
    {
        if (!follows.ContainsKey(followerId))
        {
            return;
        }

        follows[followerId].Remove(followeeId);
    }
}
