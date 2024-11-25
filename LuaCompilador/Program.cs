using NLua;

namespace LuaCompilador
{
    class Program
    {
        [STAThread]
        
            static void Main()
            {
                // Habilitar el estilo visual y la configuración predeterminada de Windows Forms
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Iniciar la aplicación con el formulario principal (Form1)
                Application.Run(new Form1());
            }
    }
}


