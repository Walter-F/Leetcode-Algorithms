public class Solution {
    public void Rotate(int[][] matrix) {

        // Transpose matrix which change row into column
        //O(n/2 * n/2)
       for(int i=0;i<matrix.GetLength(0)-1;i++){
           for(int j= i+1;j<matrix[i].Length;j++){
               int temp=matrix[i][j];
               matrix[i][j]=matrix[j][i];
               matrix[j][i]=temp;
           }
       }
       // reverse row of the matrix, to get the rotated Image
        //O(n * n/2)
       for(int i=0;i<matrix.GetLength(0);i++){
           int start=0;
           int end=matrix[i].Length-1;
           while(start<end){
                int temp=matrix[i][start];
                matrix[i][start]=matrix[i][end];
                matrix[i][end]=temp;
                start++;
                end--;
           }
       }
    }
}