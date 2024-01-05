// Code for trying out the quadratic equation class! -- MTB

Console.WriteLine("Welcome to the Quadratic Equation Solver!");
Console.Write("What is A? ");
double A = double.Parse(Console.ReadLine());
Console.Write("What is B? ");
double B = double.Parse(Console.ReadLine());
Console.Write("What is C? ");
double C = double.Parse(Console.ReadLine());

Console.WriteLine("Now attempting to make your equation...");
QuadraticEq qBert = new QuadraticEq(A,B,C);

Console.WriteLine("...and solving it!");
(double xPos, double xNeg) = qBert.Solve();
Console.WriteLine("{0} and {1} are your answers!", xPos, xNeg);

Console.WriteLine("Press ENTER to exit the program");
Console.ReadLine();
