using NLua;
using NLua.Exceptions;
using System.Data;
using System.Diagnostics;

namespace LuaCompilador
{
    public partial class Form1 : Form
    {
        private Lua luaScript;

        private readonly string[] reservedWords =
        {
            "and", "break", "do", "else", "elseif", "end", "false", "for", "function", "goto",
            "if", "in", "local", "nil", "not", "or", "repeat", "return", "then", "true", "until", "while"
        };

        public Form1()
        {
            InitializeComponent();
            InitializeLua();
        }

        private void InitializeLua()
        {
            luaScript = new Lua();

            // Registrar funciones matemáticas personalizadas
            luaScript.RegisterFunction("Suma", this, typeof(Form1).GetMethod("Suma"));
            luaScript.RegisterFunction("Resta", this, typeof(Form1).GetMethod("Resta"));
            luaScript.RegisterFunction("Multiplicacion", this, typeof(Form1).GetMethod("Multiplicacion"));
            luaScript.RegisterFunction("Division", this, typeof(Form1).GetMethod("Division"));

            // Registrar función personalizada
            luaScript.RegisterFunction("Saludo", this, typeof(Form1).GetMethod("Saludo"));

            // Sobrescribir la función print de Lua
            luaScript["print"] = new Action<object>((args) =>
            {
                string output = args switch
                {
                    object[] argArray => string.Join(" ", Array.ConvertAll(argArray, arg => arg?.ToString() ?? "nil")),
                    _ => args?.ToString() ?? "nil"
                };

                Invoke((MethodInvoker)(() => outputTextBox.AppendText(output + Environment.NewLine)));
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            errorTextBox.Clear();

            string luaCode = InputTextBox.Text;

            if (string.IsNullOrWhiteSpace(luaCode))
            {
                errorTextBox.AppendText("[Error] El código Lua está vacío. Escribe algo para ejecutar.\n");
                return;
            }

            try
            {
                luaScript.DoString(luaCode);
            }
            catch (LuaException luaEx)
            {
                errorTextBox.AppendText("[Lua Error] " + luaEx.Message + Environment.NewLine);
            }
            catch (Exception ex)
            {
                errorTextBox.AppendText("[Error] " + ex.Message + Environment.NewLine);
            }
        }

        public double Suma(double a, double b) => a + b;
        public double Resta(double a, double b) => a - b;
        public double Multiplicacion(double a, double b) => a * b;
        public double Division(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("No se puede dividir por cero.");
            return a / b;
        }

        public string Saludo(string nombre)
        {
            return $"¡Hola, {nombre} desde C#!";
        }

        private void cleanButtom_Click(object sender, EventArgs e)
        {
            InputTextBox.Clear();
            outputTextBox.Clear();
            errorTextBox.Clear();
        }
    }
}
