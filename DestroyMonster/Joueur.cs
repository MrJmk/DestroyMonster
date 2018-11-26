using Monster;
using Des;

namespace Joueurs
{
    public class Joueur
    {
        public int PtsDeVies { get; private set; }
        public int Numde { get; set; } = 0;

        public bool EstVivant
        {
            get { return PtsDeVies > 0; }
        }

        public Joueur(int points)
        {
            PtsDeVies = points;
        }

        public void Attaque(MonstreFacile monstre)
        {
            Numde = LanceLeDe();
            int lanceMonstre = monstre.LanceLeDe();
            if (Numde >= lanceMonstre)
                monstre.SubitDegats();
        }

        public void Attaque(BossDeFin boss)
        {
            int nbPoints = LanceLeDe(26);
            boss.SubitDegats(nbPoints);
        }

        public int LanceLeDe()
        {
            this.Numde = De.LanceLeDe();
            return Numde;
        }

        public int LanceLeDe(int valeur)
        {
            return De.LanceLeDe(valeur);
        }

        public void SubitDegats(int degats)
        {
            if (!BouclierFonctionne())
                PtsDeVies -= degats;
        }

        private bool BouclierFonctionne()
        {
            return De.LanceLeDe() <= 2;
        }
    }
}