using MaterialSkin;
using MaterialSkin.Controls;

namespace CourseWorkForms
{
    public static class DesignManager
    {
        public static void ConfigurateForm(MaterialForm form)
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(form);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Grey600, Accent.Red100, TextShade.WHITE);
        }
    }
}
