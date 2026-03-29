public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        // 按位置降序排序
        // 从距离终点最远的开始 计算距离终点更近的所需时间
        //      如果一个位置到达终点的所需时间比上一个位置到达终点的所需时间长，那么 fleet ++
        //      更新当前的时间作为比较

        int n = position.Length;
        Car[] cars = new Car[n];
        for (int i = 0; i < n; i ++) { 
            cars[i] = new Car() {
                Position = position[i],
                Speed = speed[i],
            };
        }

        Array.Sort(cars, (a, b) => b.Position.CompareTo(a.Position));

        int fleet = 1;
        double maxPrevTime = (double)(target - cars[0].Position) / cars[0].Speed;
        for (int i = 1; i < n; i ++) {
            double currTime = (double)(target - cars[i].Position) / cars[i].Speed;
            if (currTime > maxPrevTime) {
                fleet ++;
                maxPrevTime = currTime;
            }
        }

        return fleet;
    }

    public class Car {
        public int Position { get; set; }
        public int Speed { get; set; }
    }
}
