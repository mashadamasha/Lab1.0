using System.Security.Cryptography.X509Certificates;

namespace TestProject1
{
    public class UnitTest1
    {

        [Fact]
        
        public void IsSumValid()
        {
            int[] vec = new[] { 1, 2, 0, 3, 4, 4, 5 };
            var sum = ConsoleApp1.FirstPart.AbsSum(vec);

            Assert.Equal(16, sum);
        }

        [Fact]
        public void IsSumNull()
        {
            int[] vec = new[] { 2, 3, 4, -5, 6 };
            int? sum = ConsoleApp1.FirstPart.AbsSum(vec);

            Assert.Null(sum);
        }

        [Fact]
        public void IsMinValid() {
            int[] vec = new[] { 6, -9, 2, -1, -8 };
            int min = ConsoleApp1.FirstPart.MinAbs(vec);

            Assert.Equal(1, min);
        }
       
        
        [Fact]
        public void IsVecValid() {
            int[] vec = new[] { 2, 3, 4, -5, 6 }; 

            int[] new_vec = ConsoleApp1.FirstPart.Renovate(vec);
            int[] exp = { 2, 4, 6, 3, -5 };
            Assert.Equal(exp, vec);

        }
        [Fact]
        public void IsLocMinValid()
        {
            int[,] matrix = { 
                { 1,2,3,4,5,6,7,8,9,0}, 
                { 1,2,3,4,5,6,7,8,9,0}, 
                { 1,2,3,4,0,6,7,8,9,0}, 
                { 1,2,3,4,5,6,7,8,9,0},
                { 1,2,3,4,5,6,7,8,9,0},
                { 1,2,3,4,5,6,7,8,9,0},
                { 1,2,3,4,5,6,7,8,9,0},
                { 1,2,3,4,5,6,7,8,9,0}, 
                { 1,2,3,4,5,6,7,8,9,0},
                { 1,2,3,4,5,6,7,8,9,0} };
            int k = ConsoleApp1.SecondPart.CountLocMin(matrix);
            Assert.Equal(1, k);
              
        }

        [Fact]
        public void IsDiagSumValid()
        {
            int[,] matrix = {
                { 1,2,3,4,5,6,7,8,9,0},
                { 1,2,3,4,5,6,7,8,9,0},
                { 1,2,3,4,0,6,7,8,9,0},
                { 1,2,3,4,5,6,7,8,9,0},
                { 1,2,3,4,5,6,7,8,9,0},
                { 1,2,3,4,5,6,7,8,9,0},
                { 1,2,3,4,5,6,7,8,9,0},
                { 1,2,3,4,5,6,7,8,9,0},
                { 1,2,3,4,5,6,7,8,9,0},
                { 1,2,3,4,5,6,7,8,9,0} };
            int sum = ConsoleApp1.SecondPart.SumMainDiag(matrix);
            Assert.Equal(235, sum);
        }
    }
}