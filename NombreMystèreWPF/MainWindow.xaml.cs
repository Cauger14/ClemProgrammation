using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NombreMystèreWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int aléatoire;
        int nbEssais;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NouvellePartie();
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            int chiffreNum = ChoisiUnChiffre();
            if (chiffreNum > 0)
            {

                if (chiffreNum != aléatoire)
                {
                    chiffreNum = Recommence(chiffreNum);
                }
                else
                {
                    Gagné();
                }
            }
        }

        private void btnNouvellePartie_Click(object sender, RoutedEventArgs e)
        {
            NouvellePartie();
        }

        // Partie code

        void NouvellePartie()
        {
            aléatoire = new Random().Next(1, 21);
            textBlockInfo.Text = "";
            textBoxEssai.Text = "";
            nbEssais = 0;
            Update();
        }
        void Gagné()
        {
            textBlockInfo.Text = "Félicitation tu as gagné";
        }

        void Update()
        {
            textBlockNbEssais.Text = "Nb d'essai:" + nbEssais;
        }
        int Recommence(int chiffreNum)
        {
            if (chiffreNum > aléatoire)
            {
                textBlockInfo.Text = "c'est moins";
            }
            else
            {
                textBlockInfo.Text = "c'est plus";
            }

            nbEssais = nbEssais + 1;
            Update();

            return chiffreNum;
        }

        int ChoisiUnChiffre()
        {
            string chiffre = textBoxEssai.Text;
            int chiffreNum;
            bool isNumeric = int.TryParse(chiffre, out chiffreNum);

            if (isNumeric == false)
            {
                textBlockInfo.Text = "Je t'ai demandé un chiffre pas autre chose :";
            }
            else
            {
                textBlockInfo.Text = "";
            }

            return chiffreNum;
        }
    }
}