public class Solution {
    public bool CanJump(int[] nums) {
        int size= nums.Length;
        int max_size=0;
            
        if((size<2) || (nums[0]>=size))
            return true;
        
        for(int i=0; i < size ; i++){
            max_size=nums[i];
            while(max_size<size){
                max_size+=nums[max_size-1];
            }
            
            if(max_size==size){
                return true;
            }
        }
        return false;
    }
}