using DataLayer.Services;

namespace WorldCupForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var selectionService = new SelectionService();
            if (!selectionService.Exists)
            {
                using (var startupForm = new StartupForm(selectionService))
                {
                    if (startupForm.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                }
            }

            Application.Run(new MainForm());

        }
    }
}