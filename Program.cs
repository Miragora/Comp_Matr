using System;


struct Complex
{
    public double Re;
    public double Im;
    public double Complex(double re, double im)
    {
        Re = re;
        Im = im;
    }
    public double Complex_Add(Complex Z)
    {
        var re = Re + Z.Re;
        var im = Im + Z.Im;
        return new Complex(re, im);
    }
    public Complex_Myltiply(Complex Z)
    {
        var re = Re * Z.Re - Im * Z.Im;
        var im = Re * Z.Re + Im * Z.Im;
        return new Complex(re, im);
    }
    public double Get_Abs()
    {
        return Math.Sqrt(Re * Re + Im * Im);
    }
    public double Get_Arg()
    {
        return Math.Atan(Re / Im);
    }

}

//Matrix

    class Matrix
{
    private readonly int _N;
    private readonly int _M;
    private readonly double[,] _A;

    public Matrix (int N,int M)
    {
        _N = N;
        _M = M;
        _A = new double[N, M];
    }
    //возвращает N,M
    public int N
    {
        get
        {
            return _N;
        }
    }
    public int M
    {
        get
        {
            return _M;
        }
    }
    //Индексатор&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    public double this [int i, int j]
    {
        get
        {
            return _A[i,j];
        }
      /*  get
        {
            _A[i] = ;
        }
        */
    }
     //Умножение матрицы на матрицу
     public static Matrix Operator(Matrix A, Matrix B)
    {
        var C = new Matrix(A.N, B.M);
        for (int i =0; i< C.N; i++)
            for(int j = 0; j < C.M; j++)
            {
                var c = 0.0;
                    for (int k = 0; k < A.M; i++)
                    C += A[i, k] * B[k, j];
                C[i, j] = c;

            }
        return C;
    }
    //Транспонирование
    public Matrix Get_Transpose()
    {
        var result = new Matrix(_M, _N);
        for (int i = 0; i < _N; i++)
            for (int j = 0; j < _M; j++)
                result[i, j] = _A[i, j];
        return result;
    }

} 


namespace Сomplex_and_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

 
}
