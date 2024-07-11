public class Solution {
    // Time O(9^(N*N)) as every unassigned index has 9 possible options || Space O(1) || Auxillary Space O(N*N), N = 9
    public void SolveSudoku(char[][] b) {
        int n = 9;
        bool[,] rCheck = new bool[n,n+1], cCheck = new bool[n,n+1], gCheck = new bool[n,n+1];
        // fill the indicator for rows, columns & grid with current digits for each cell in board
        for(int r=0;r<n;r++)
            for(int c=0;c<n;c++)
                if(b[r][c]!='.')
                {
                    var digit = b[r][c]-'0';
                    rCheck[r,digit]=cCheck[c,digit]=gCheck[GridID(r,c),digit]=true;
                }
        // Fill remaining cells using DFS in place
        Fill(0,0);

        // local helper func
        bool Fill(int r, int c)
        {
            // if reached end of curent row move to 1st column of next row
            if(c==n)
            {
                r=r+1;
                c=0;
            }
            // if all cells are filled return true
            if(r==n) return true;

            // if found a pre-filled digit move to next cell
            if(b[r][c]!='.')
                return Fill(r,c+1);
            
            for(int digit=1;digit<10;digit++)
                //If Digit not Already Present
                if(!(rCheck[r,digit] || cCheck[c,digit] || gCheck[GridID(r,c),digit]))
                {
                    // mark current digit
                    rCheck[r,digit]=cCheck[c,digit]=gCheck[GridID(r,c),digit]=true;

                    // add digit char to board
                    b[r][c]=(char)(digit+'0');
                    
                    // stop as soon as we get a answer
                    if(Fill(r,c+1)) return true;

                    // un mark current digit
                    rCheck[r,digit]=cCheck[c,digit]=gCheck[GridID(r,c),digit]=false;
                }
            // if none of the digits work than we revert to original state
            b[r][c]='.';
            return false;
        }
    }
    static int GridID(int r, int c) => 3*(r/3) + (c/3);
}