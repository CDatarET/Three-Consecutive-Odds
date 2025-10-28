public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        int c = 0;
        for(int i = 0; i < arr.Length; i++){
            if(arr[i] % 2 != 0){
                c++;
            }
            else{
                c = 0;
            }

            if(c == 3){
                return(true);
            }
        }

        return(false);
    }
}
