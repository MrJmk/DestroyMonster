using System;
using System.Windows.Forms;
using Joueurs;
using Monster;
using System.Threading;
using Application = System.Windows.Forms.Application;

namespace DestroyMonster
{
    public partial class Form1 : Form
    {
        public Joueur joueur = new Joueur(50);
        public MonstreFacile monstre1 = FabriqueDeMonstre();
        public int cptScore = 0;

        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void Form1_Load()
        {
            labelScore.Text = cptScore.ToString();
            labelVie.Text = joueur.PtsDeVies.ToString();
            labelNum2.Text = joueur.Numde.ToString();

            labelNum.Text = monstre1.LanceMonstre.ToString();
            if (monstre1 is MonstreDifficile)
                labelNiveau.Text = "Magique";
            else
                labelNiveau.Text = "Guerrier";
        }

        private void iniform()
        {
            joueur = new Joueur(50);
            monstre1 = FabriqueDeMonstre();
            cptScore = 0;
        }

        private void Jeu1()
        {
            while (monstre1.EstVivant && joueur.EstVivant)
            {
                joueur.Attaque(monstre1);
                Form1_Load();
                if (monstre1.EstVivant)
                {
                    Thread.Sleep(1000);
                    monstre1.Attaque(joueur);
                    Form1_Load();
                }
             }

             if (joueur.EstVivant)
             {
                if (monstre1 is MonstreDifficile)
                    cptScore+=2;
                else
                    cptScore++;
                Form1_Load();
             }
             else 
             {
                messBox();
             }
             monstre1 = FabriqueDeMonstre();
        }
         

        private static MonstreFacile FabriqueDeMonstre()
        {
            Random random = new Random();
            if (random.Next(2) == 0)
                return new MonstreFacile();
            else
                return new MonstreDifficile();
        }

        private void messBox()
        {
            var message = "Voulez vous recommencer ?";
            var title = "Hey!";
            var result = MessageBox.Show(
                message,                  
                title,                    
                MessageBoxButtons.YesNo,  
                MessageBoxIcon.Question); 
            switch (result)
            {
                case DialogResult.Yes:   
                    iniform();
                    Form1_Load();
                    break;
                case DialogResult.No:    
                    Application.Exit();
                    break;
                default:                 
                    MessageBox.Show("What did you press?");
                    break;
            }
        }

        private void Jouer_Click(object sender, EventArgs e)
        {
            Jeu1();
        }
    }

}

