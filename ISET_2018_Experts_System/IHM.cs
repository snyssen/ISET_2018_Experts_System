using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISET_2018_Experts_System
{
	public interface I_SE_IHM
	{
		int QuestionEntier(string sQuestion);
		bool QuestionBooleen(string sQuestion);
		void AfficherFaits(List<I_SE_Fait> lFaits);
		void AfficherRegles(List<SE_Regle> lRegles);
	}
}
