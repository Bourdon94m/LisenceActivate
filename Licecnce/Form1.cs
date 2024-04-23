using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licecnce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<char> allCharacters = new List<char>();
            List<char> randomCharacters = new List<char>();


            for (char c = 'A'; c <= 'Z'; c++) { allCharacters.Add(c); }
            for (char c = 'a'; c <= 'z';  c++) { allCharacters.Add(c); }
            for (char c = '0'; c < '9'; c++) { allCharacters.Add(c); }

            

            for (int i=0; i < 14; i++)
            {
                // Générer un index aléatoire dans la plage des caractères disponibles
                int randomIndexId = random.Next(0, allCharacters.Count);
                // Ajouter le caractère correspondant à l'index aléatoire à la liste de caractères aléatoires
                randomCharacters.Add(allCharacters[randomIndexId]);
            }

            string randomString = new string(randomCharacters.ToArray());


            textBoxIdentifiant.Text = randomString;


            for (int i = 0; i < 18; i++)
            {
                // Générer un index aléatoire dans la plage des caractères disponibles
                int randomIndexLisence = random.Next(0, allCharacters.Count);
                // Ajouter le caractère correspondant à l'index aléatoire à la liste de caractères aléatoires
                randomCharacters.Add(allCharacters[randomIndexLisence]);
            }

            randomString = new string(randomCharacters.ToArray());

            textBoxActivate.Text = randomString;

        }
    }
}
