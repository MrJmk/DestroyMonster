using Des;
using Joueurs;

namespace Monster
{
    public class MonstreFacile
    {
        private const int degats = 10;
        public bool EstVivant { get; private set; }
        public int LanceMonstre { get; set; } = 0;

        public MonstreFacile()
        {
            EstVivant = true;
        }

        public virtual void Attaque(Joueur joueur)
        {
            LanceMonstre = LanceLeDe();
            int lanceJoueur = joueur.LanceLeDe();
            if (LanceMonstre > lanceJoueur)
                joueur.SubitDegats(degats);
        }

        public void SubitDegats()
        {
            EstVivant = false;
        }

        public int LanceLeDe()
        {
            this.LanceMonstre = De.LanceLeDe();
            return LanceMonstre;
        }
    }
}