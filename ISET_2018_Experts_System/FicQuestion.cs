using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISET_2018_Experts_System
{
	public partial class EcranQuestion : Form
	{
		public EcranQuestion(string sQuestion)
		{
			InitializeComponent();
			lblQuestion.Text = sQuestion;
		}
		public string Reponse
		{
			get { return TBreponse.Text; }
		}
	}
}
