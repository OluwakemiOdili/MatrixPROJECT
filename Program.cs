namespace MatrixPROJECT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] kemi = new int[2, 2, 2]
            {
                { {1,2 },{2,3 } },
                { {3,4 },{2,5 } },

            };

            int[,,] esther = new int[2, 2, 2]
            {
                { {1,2 },{2,3 } },
                { {3,4 },{2,5 } },

            };
            int[,,] product = new int[2, 2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        product[i, j, k] = esther[i, j, k] * kemi[i, j, k]; 
                        Console.WriteLine(product[i, j, k]);    
                    }
                }
            }

        }
    }
}