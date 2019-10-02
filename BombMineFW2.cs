using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Type number of row:  "); 
    int r = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Type number of column:  "); 
    int c = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Type number of bomb: ");
    int b = Int32.Parse(Console.ReadLine());

    int[,] matrix= new int[r,c];
    Random bomb = new Random();
    int numbom = b;
    int bp;
    int bpr;
   for (int i=0; i< matrix.GetLength(0); i++){
      for(int j = 0; j< matrix.GetLength(1); j++){
         matrix[i,j] =0;
      }
   }
    for (int i=0; i < numbom; i++){
    bp=bomb.Next(0, r);
    bpr=bomb.Next(0,c);
    matrix[bp,bpr] = 9; 
    }

     
    for (int i=0; i< matrix.GetLength(0); i++){
      for(int j = 0; j< matrix.GetLength(1); j++){
        if (matrix[i,j] < 9 ){
              if ((i+1) < r && (j+1) < c && matrix[i+1,j+1] ==9 ){
                matrix[i,j]++;
              }
              if ( (i-1) >-1 && (j-1) > -1 && matrix[i-1,j-1] ==9 ){
                matrix[i,j]++;
              }
              if ( (j+1) < c && matrix[i,j+1] ==9){
                matrix[i,j]++;
              }
              if ( (j-1) >-1 && matrix[i,j-1] ==9){
                matrix[i,j]++;
              }
             if ((i+1) < r && matrix[i+1,j] ==9 ){
                matrix[i,j]++;
              }
             if ((i-1)>-1 && matrix[i-1,j] ==9 ){
                matrix[i,j]++;

              }
              if ( (i+1) < r && (j-1) >-1 && matrix[i+1,j-1] ==9){
                      matrix[i,j]++;
              }
              if ((i-1) > -1 && (j+1) <c &&matrix[i-1,j+1] ==9){
                      matrix[i,j]++;
              }

        } else {
          matrix[i,j] =9;
        }
     
      }
    }
     string[,] matrix2 = new string[r,c];
    for (int i=0; i< matrix.GetLength(0); i++){
      for(int j = 0; j< matrix.GetLength(1); j++){
               if(matrix[i,j]==9)
                  {
                   matrix2[i,j]="X";
                  } else {
                      
                    int l;
                    string k;
                    l=matrix[i,j];
                    k=l.ToString();
                    matrix2[i,j]=k;
                  }

      Console.Write(matrix2[i,j]);

      }
      Console.WriteLine();
    }
  }
  

}
