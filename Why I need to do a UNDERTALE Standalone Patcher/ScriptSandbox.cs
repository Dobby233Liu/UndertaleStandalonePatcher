using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UndertaleModLib;
using UndertaleModLib.Scripting;

namespace UTCSXPatcherGUI
{
    public partial class ScriptSandbox : IScriptInterface
    {
        public UndertaleData Data { get; set; }
        public string FilePath { get; set; }
        public bool CanSave { get; set; }
        public object Highlighted { get; set; }
        public object Selected { get; set; }

        public ScriptSandbox(UndertaleData D, string FilePat, bool cs)
        {
            Data = D;
            FilePath = FilePat;
            CanSave = cs;
            Highlighted = null;
            Selected = null;
        }

        public void ScriptMessage(string message)
        {
            MessageBox.Show(message, "Script mesage", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool ScriptQuestion(string message)
        {
            return MessageBox.Show(message, "Script message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public void ScriptOpenURL(string url)
        {
            Process.Start(url);
        }

        public void EnsureDataLoaded()
        {
            if (Data == null)
                throw new Exception("Please load data.win first!");
        }

        public void ChangeSelection(object newsel){}

        public string Truncate(string s, int maxlen) {
            string maxlens = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            int maxlen2 = maxlens.Length;
            int maxlen3 = 0;
            if (maxlen.Equals(0)) maxlen3 = maxlen2; else maxlen3 = maxlen;
            if (string.IsNullOrEmpty(s)) return s;
            return s.Length <= maxlen3 ? s : s.Substring(0, maxlen3);
        }
    }
}
