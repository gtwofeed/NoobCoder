using NoobCoder;

var A = new Matrix();
A.Read();

var B = new Matrix();
B.Read();

var M = Matrix.Multiplication(A, B);
M.Write();