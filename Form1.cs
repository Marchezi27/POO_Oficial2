using POO_Oficial_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Oficial_2
{
public partial class Form1 : Form
{
    // Lista para armazenar os produtos
    List<Produto> produtos = new List<Produto>();

    public Form1()
    {
        InitializeComponent();
    }
}
