using System;


namespace ncc_lab_prameshwor
{
    class animal
    {
        public animal()
        {
            Console.WriteLine("iam animal");
        }
    }
    internal class demo
    {
        static void Main(string[] args)
        {
            animal cow = new animal();
        }
    }
}
