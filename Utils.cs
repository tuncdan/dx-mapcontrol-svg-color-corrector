using System;
using System.Text;
using System.Windows.Forms;

namespace SvgColorCorrector
{
    internal class Utils
    {
        internal static string GetExceptionMessages(Exception ex)
        {
            StringBuilder result = new StringBuilder();
            result.Append("Error occured: ");

            do
            {
                result.AppendLine(ex.Message);
                result.AppendLine(ex.StackTrace);
                result.AppendLine();
            } while ((ex = ex?.InnerException) != null);

            return result.ToString();
        }

        internal static string GetPath<T>(string title) where T : FileDialog
        {
            using (T fileDialog = (T)Activator.CreateInstance(typeof(T)))
            {
                fileDialog.Filter = "SVG Files (*.svg)|*.svg";
                fileDialog.Title = title;

                if (fileDialog.ShowDialog() != DialogResult.OK)
                    return null;

                return fileDialog.FileName;
            }
        }
    }
}
