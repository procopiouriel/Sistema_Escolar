﻿using System;
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
    /// Lógica interna para RecadastrarAluno.xaml
    /// </summary>
    public partial class RecadastrarAluno : Window
    {
        public RecadastrarAluno()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TelaConsulta tela = new TelaConsulta();
            this.Close();
            tela.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
