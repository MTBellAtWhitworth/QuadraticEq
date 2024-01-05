/******************************
* QuadraticEquation class concept
* originally explored by J.Batista for
* teaching exception handling and
* test driven development for CS371
* in 2019. Modified and repurposed
* by M.Bell for use in teaching
* structured exception handling in
* 2023.
*******************************/

class QuadraticEq {
    //First some properties!
    public double A {get; init;}
    public double B {get; init;}
    public double C {get; init;}

    //Now a constructor
    public QuadraticEq(double a = 1.0, double b = 1.0, double c = 1.0) {
       A = a;
       B = b;
       C = c; 
    }

    public (double Xpos, double Xneg) Solve() {
        double firstVal = (-B + Math.Sqrt((B*B)-(4*A*C))) / (2*A);
        double secondVal = (-B - Math.Sqrt((B*B)-(4*A*C))) / (2*A);
        return (firstVal, secondVal);
    }
}