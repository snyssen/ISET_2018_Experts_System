using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISET_2018_Experts_System
{
	public interface  I_SE_Fait
	{
		string Descr();
		object Valeur();
		int Niveau();
		string Question();
		void DefinirNiveau(int n);
	}
	internal class SE_FaitBooleen : I_SE_Fait // internal signifie que la classe accessible dans le namespace
	{
		public void DefinirNiveau(int n)
		{
			_Niveau = n;
		}

		protected string _Descr;
		public string Descr()
		{
			return _Descr;
		}

		protected int _Niveau;
		public int Niveau()
		{
			return _Niveau;
		}

		protected string _Question;
		public string Question()
		{
			return _Question;
		}

		protected bool _Valeur;
		public object Valeur()
		{
			return _Valeur;
		}
		public SE_FaitBooleen(string Descr_, bool Valeur_, string Question_ = null, int Niveau_ = 0)  // args = VALEUR (ici string Question_ = null) permet d'assigner une valeur par défaut au cas pù l'args ne serait pas indiqué lors de l'appel
		{
			_Descr = Descr_;
			_Valeur = Valeur_;
			_Question = Question_;
			_Niveau = Niveau_;
		}
		public override string ToString()
		{
			string res = "";
			if (!_Valeur) res = "NON ";
			res += _Descr + " (" + _Niveau + ")";
			return res;
		}
	}
	internal class SE_FaitEntier : I_SE_Fait
	{
		public void DefinirNiveau(int n)
		{
			_Niveau = n;
		}

		protected string _Descr;
		public string Descr()
		{
			return _Descr;
		}

		protected int _Niveau;
		public int Niveau()
		{
			return _Niveau;
		}

		protected string _Question;
		public string Question()
		{
			return _Question;
		}

		protected int _Valeur;
		public object Valeur()
		{
			return _Valeur;
		}
		public SE_FaitEntier(string Descr_, int Valeur_, string Question_ = null, int Niveau_ = 0)
		{
			_Descr = Descr_;
			_Valeur = Valeur_;
			_Question = Question_;
			_Niveau = Niveau_;
		}
		public override string ToString()
		{
			return _Descr + " = " + _Valeur + " (" + _Niveau + ")";
		}
	}
	internal class SE_Faits
	{
		protected List<I_SE_Fait> _Faits;
		public List<I_SE_Fait> Faits { get { return _Faits; } }
		public SE_Faits() { _Faits = new List<I_SE_Fait>(); }
		public void RaZ() { _Faits.Clear(); }
		public void Ajouter(I_SE_Fait f) { _Faits.Add(f); }
		public I_SE_Fait Chercher(string Descr_)
		{ return _Faits.FirstOrDefault(x => x.Descr().Equals(Descr_)); }
		public object Valeur(string Descr_)
		{
			I_SE_Fait f = _Faits.FirstOrDefault(x => x.Descr().Equals(Descr_));
			if (f != null) return f.Valeur();
			else return null;
		}
	}
	internal static class CalculFait
	{
		internal static I_SE_Fait Determiner(string sFait)
		{
			sFait = sFait.Trim();
			string sQuestion = null;
			if (sFait.Contains("=")) // Entier
			{
				string[] sTmp = sFait.Split(new string[] { "=", "(", ")" }, StringSplitOptions.RemoveEmptyEntries );
				if (sTmp.Length >= 2)
				{
					if (sTmp.Length == 3)
						sQuestion = sTmp[2].Trim();
					return new SE_FaitEntier(sTmp[0].Trim(), int.Parse(sTmp[1]), sQuestion);
				}
				else // fait mal construit
				{
					return null;
				}
			} 
			else // Booleen
			{
				bool bTmp = true;
				if (sFait.StartsWith("!"))
				{
					bTmp = false;
					sFait = sFait.Substring(1);
				}
				string[] sTmp = sFait.Split(new string[] { "(", ")" }, StringSplitOptions.RemoveEmptyEntries);
				if (sTmp.Length == 2)
				{
					sQuestion = sTmp[1].Trim();
					return new SE_FaitBooleen(sTmp[0].Trim(), bTmp, sQuestion);
				}
				else // fait mal construit
				{
					return null;
				}
			}
		}

		internal static I_SE_Fait Determiner(I_SE_Fait fFait, SE_Moteur mMoteur)
		{
			if (fFait.GetType().Equals(typeof(SE_FaitEntier)))
				return new SE_FaitEntier(fFait.Descr(), mMoteur.QuestionEntier(fFait.Question()));
			else
				return new SE_FaitBooleen(fFait.Descr(), mMoteur.QuestionBooleen(fFait.Question()));
		}
	}
}
