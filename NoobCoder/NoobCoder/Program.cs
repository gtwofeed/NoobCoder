using NoobCoder;

// (5*A + 2*B)*A
Matrix A = new();
A.Read();
Matrix B = new();
B.Read();
var A5 = Matrix.Multiply(A, 5);
var B2 = Matrix.Multiply(B, 2);
var AB = Matrix.Sum(A5, B2);
Matrix.Multiplication(AB, A).Write();