using System.Data;
using System.Globalization;
using System.Linq.Expressions;

class Matrix{
    private int[][] arr;

    public int this[int row,int column]{
        get{return arr[row][column];}
        set{arr[row][column]=value;}
    }
    public void FillMatrixRandom(int rows,int columns,int min,int max){
        Random rand=new Random();
        arr=new int[rows][];
        for(int i=0;i<rows;i++){
            arr[i]=new int[columns];
            for(int j=0;j<columns;j++){
                arr[i][j]=rand.Next(min,max);
            }
        }
    }



}
class Program{
    static void Main(){
        Matrix a= new Matrix();
        a.FillMatrixRandom(3,4,-2,5);
        for(int i=0;i<4;i++){
            Console.WriteLine();
            for(int j=0;j<3;j++){
                Console.Write(a[j,i]+" ");
            }
        }
    }
}