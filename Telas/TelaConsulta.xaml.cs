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
    /// Lógica interna para TelaConsulta.xaml
    /// </summary>
    public partial class TelaConsulta : Window
    {
        public TelaConsulta()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastroEscola tela = new CadastroEscola();
            this.Visibility = Visibility.Collapsed;
            tela.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            TelaLogin tela = new TelaLogin();
            this.Visibility = Visibility.Collapsed;
            tela.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CadastroAluno tela = new CadastroAluno();
            this.Visibility = Visibility.Collapsed;
            tela.ShowDialog();
        }
    }
}
