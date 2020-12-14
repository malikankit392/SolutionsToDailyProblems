using System;

namespace JumpGameProblem
{
    class Program
    {
        static void Main(string[] args){
            Solution testObj= new Solution();
            int[] arr =new int[]{2,3,1,1,4};
            bool result;
            result = testObj.CanJump(arr);
            Console.WriteLine(result);
        }
    }
}