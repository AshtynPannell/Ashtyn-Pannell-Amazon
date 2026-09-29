namespace Ashtyn_Pannell_Amazon
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}