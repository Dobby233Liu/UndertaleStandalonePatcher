using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis.Scripting.Hosting;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using UndertaleModLib;
using UndertaleModLib.Scripting;

namespace UTCSXPatcherGUI
{
    public partial class Form1 : Form
    {
        public UndertaleData Data = null;
        public string FilePath = "";

        public string boxCompleteMsg = "Waiting works";
        public string boxWorkingMsg = "I'm working";
        public string awaitingScriptCompleteMsg = "Running script";

        public ScriptSandbox _hack = new ScriptSandbox(null, "", false);

        public FileStream fsin = null;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            label1.TextChanged += Label1_TextChanged;
        }

        private void Label1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = _hack.Truncate(label1.Text, 0);
        }

        private void inputFileSelect_Click(object sender, EventArgs e)
        {
            label1.Text = boxWorkingMsg;
            if (DialogResult.OK == inputFileDialog.ShowDialog())
            {
                inputFileTB.Text = inputFileDialog.FileName;
                FilePath = inputFileDialog.FileName;
            }
            label1.Text = boxCompleteMsg;
        }
        private void outputFileSelect_Click(object sender, EventArgs e)
        {
            label1.Text = boxWorkingMsg;
            if (DialogResult.OK == outputFileDialog.ShowDialog())
            {
                outputFileTB.Text = inputFileDialog.FileName;
            }
            label1.Text = boxCompleteMsg;
        }
        private void scriptFileSelect_Click(object sender, EventArgs e)
        {
            label1.Text = boxWorkingMsg;
            if (DialogResult.OK == scriptFileDialog.ShowDialog())
            {
                scriptFileTB.Text = scriptFileDialog.FileName;
            }
            label1.Text = boxCompleteMsg;
        }

        private void loadInputButton_Click(object sender, EventArgs e)
        {
            label1.Text = boxWorkingMsg;
            try
            {
                fsin = new FileStream(inputFileTB.Text, FileMode.Open);
                Data = UndertaleIO.Read(fsin);
                while (null == Data) { Application.DoEvents(); }
            }
            catch (Exception es)
            {
                label1.Text = es.ToString();
                MessageBox.Show(es.Message, "Loading error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label1.Text = boxCompleteMsg;
        }
        private void saveOutputButton_Click(object sender, EventArgs e)
        {
            label1.Text = boxWorkingMsg;
            try {
                UndertaleIO.Write(fsin, Data);
            }
            catch (Exception es) {
                label1.Text = es.ToString();
                MessageBox.Show(es.Message, "Writing error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label1.Text = boxCompleteMsg;
        }

        private async void runScriptButton_ClickAsync(object sender, EventArgs e)
        {
            var sb = new ScriptSandbox(Data, FilePath, true);
            label1.Text = awaitingScriptCompleteMsg;
            try
            {
                var loader = new InteractiveAssemblyLoader();
                loader.RegisterDependency(typeof(UndertaleObject).GetTypeInfo().Assembly);
                var sf = new FileStream(scriptFileTB.Text, FileMode.Open);
                var sr = new StreamReader(sf);
                var script = CSharpScript.Create<object>(sr.ReadToEnd(), ScriptOptions.Default
                                .WithImports("UndertaleModLib", "UndertaleModLib.Models", "UndertaleModLib.Decompiler", "UndertaleModLib.Scripting", "System", "System.IO", "System.Collections.Generic")
                                .WithReferences(typeof(UndertaleObject).GetTypeInfo().Assembly),
                                typeof(IScriptInterface), loader);
                await script.RunAsync(sb);
                label1.Text = boxCompleteMsg;
            }catch(CompilationErrorException eanother)
            {
                label1.Text = eanother.ToString();
                MessageBox.Show(eanother.Message, "Script compiling error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ea)
            {
                label1.Text = e.ToString();
                MessageBox.Show(ea.Message, "Script error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(null, "everything: kryzs-h\nshit: Dobby233Liu", "Why", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
