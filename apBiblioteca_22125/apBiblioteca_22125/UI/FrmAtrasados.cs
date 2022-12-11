using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using BLL;
using DTO;
namespace apBiblioteca_22125.UI
{
    public partial class FrmAtrasados : Form
    {
        public FrmAtrasados()
        {
            InitializeComponent();
        }
        public string banco, usuario, senha;

        private void FrmAtrasados_Load(object sender, EventArgs e)
        {
            EmprestimoBLL bll = new EmprestimoBLL(banco, usuario, senha);
            dgvAtrasados.Rows.Clear();
            DataTable tabela = bll.SelecionarEmprestimosAtrasados();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {

                if (i != tabela.Rows.Count - 1)
                    dgvAtrasados.Rows.Add();
                
                dgvAtrasados[0, i].Value = tabela.Rows[i][0];
                dgvAtrasados[1, i].Value = tabela.Rows[i][1];
                dgvAtrasados[2, i].Value = tabela.Rows[i][2];
                dgvAtrasados[3, i].Value = tabela.Rows[i][3];
                dgvAtrasados[4, i].Value = tabela.Rows[i][4];
            }
        }
    }
}
