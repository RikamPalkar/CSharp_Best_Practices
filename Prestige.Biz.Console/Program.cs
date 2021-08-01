using System.IO;

namespace Prestige.Biz.Console
{
    class Program
    {
        /// <summary>
        /// Actor's instance
        /// </summary>
        private Actor _anActor;
        /// <summary>
        /// Actor's instance
        /// </summary>
        public Actor AnActor
        {
            get
            {
                if (_anActor == null) 
                { 
                    return new Actor(); 
                }
                return _anActor;
            }
            set { _anActor = value; }
        }

        /// <summary>
        /// Constant variable number
        /// </summary>
        public const int ConstantNumber = 100;

        /// <summary>
        /// Readonly variable number
        /// </summary>
        public static readonly int ReadOnlyNumber = 0;

        /// <summary>
        /// static constructor of a class
        /// </summary>
        static Program()
        {
            ReadOnlyNumber = 5;
        }


        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //FileStream fs1 = new FileStream(@"C:\Users\E258490\OneDrive - WFT\Documents\Learning\Linkedin Learning\BestPracticesForDevelopers\theAgency.txt", FileMode.Open);
            //FileStream fs2 = new FileStream(@"C:\Users\E258490\OneDrive - WFT\Documents\Learning\Linkedin Learning\BestPracticesForDevelopers\theAgency.txt", FileMode.Open);

            using (FileStream fs1 = new FileStream(@"C:\Users\E258490\OneDrive - WFT\Documents\Learning\Linkedin Learning\BestPracticesForDevelopers\theAgency.txt", FileMode.Open))
            {
                //some operation on file
            }
            using (FileStream fs2 = new FileStream(@"C:\Users\E258490\OneDrive - WFT\Documents\Learning\Linkedin Learning\BestPracticesForDevelopers\theAgency.txt", FileMode.Open))
            {
                //some operation on file
            }

            //System.Console.WriteLine(ConstantNumber);
            //System.Console.WriteLine(ReadOnlyNumber);
            System.Console.ReadLine();
        }
    }
}
