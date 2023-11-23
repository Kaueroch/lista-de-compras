using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarefa_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = "Data" + DateTime.Now. ToString("HH//mm/ss");
            statusStrip1.Items[0].Text = "Data" + DateTime.Now . ToString("HH//mm/ss");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            list_acomprar.Items.Add(text_novos_produtos.Text);
            text_novos_produtos.Clear();
            text_novos_produtos.Focus();
        }

        private void btn_transferir_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_transferir_todos_Click(object sender, EventArgs e)
        {
            list_comprado.Items.AddRange(list_acomprar.Items);
        }

        private void btn_deletar_acomprar_Click(object sender, EventArgs e)
        {
            list_comprado.Items.Remove(list_comprado.SelectedItem);
        }

        private void btn_deletar_comprados_Click(object sender, EventArgs e)
        {
            list_comprado.Items.Remove(list_acomprar.SelectedItem);
        }

        private void text_novos_produtos_TextChanged(object sender, EventArgs e)
        {
            if (text_novos_produtos.Text == "")
            {
                MessageBox.Show("Digite o produto a comprar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text_novos_produtos.Focus();
            }
            else
            {
                list_acomprar.Items.Add(text_novos_produtos.Text);
                text_novos_produtos.Clear();
                text_novos_produtos.Focus();
            }

        }
    }
}
