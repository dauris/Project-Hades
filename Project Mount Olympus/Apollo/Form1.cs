using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Apollo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var sre = new SpeechRecognitionEngine();
            var sr = new SpeechRecognizer();
            var gb = new GrammarBuilder("hello computer");
            var g = new Grammar(gb);

            sr.LoadGrammar(g);
            //sr.SpeechRecognized += new EventHandler(sr_)
        }
    }
}
