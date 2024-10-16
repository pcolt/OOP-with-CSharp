class Program {
    static void Main() {
        var p1 = new Point(1, 1);
        var p2 = new Point(2, 2);
        var p3 = new Point(3, 1);
        var p4 = new Point(1, 3);
        var p5 = new Point(3, 3);
        var middlePoint = CartesianPlan.getMiddlePoint(p1, p2);
        middlePoint.Print();
        var centerPoligon = CartesianPlan.getCenterPoligon([p1, p3, p4, p5]);
        centerPoligon.Print();
    }

    struct CartesianPlan {
        static public Point getMiddlePoint(Point p1, Point p2) {
            var x = (p1.X + p2.X) / 2;
            var y = (p1.Y + p2.Y) / 2;
            return new Point(x, y);
        }

        static public Point getCenterPoligon(Point[] points) {
            float sumX = 0;
            float sumY = 0;
            foreach (var point in points) {
                sumX = sumX + point.X;
                sumY = sumY + point.Y;
            }
            return new Point(sumX / points.Length, sumY / points.Length);
        }
    }
}