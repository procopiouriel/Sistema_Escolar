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
using System.Windows.Shapes;

namespace Sistema_Escolar.Telas
{
    /// <summary>
    /// Lógica interna para RecadastrarEscola.xaml
    /// </summary>
    public partial class RecadastrarEscola : Window
    {
        public RecadastrarEscola()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TelaConsulta tela = new TelaConsulta();
            this.Close();
            tela.Show();
        }
    }
}
