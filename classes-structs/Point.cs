class Point {
        public float X { get; }
        public float Y { get; }
        public Point(float x, float y) {
            X = x;
            Y = y;
        }
        public void Print() {
            Console.WriteLine($"X: {X}, Y: {Y}");
        }
    }