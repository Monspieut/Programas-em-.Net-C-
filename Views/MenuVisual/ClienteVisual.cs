using System;
using System.Windows.Forms;
using System.Drawing;

namespace View
{

    public class ClienteVisual : Form
    {

        private Button btnCadastrarCliente = new Button();

        private Button btnListarCliente = new Button();

        private Button btnAtualizarCliente = new Button();

        private Button btnRemoverCliente = new Button();

        private Button btnEncMenu = new Button();

        public ClienteVisual()
        {

            this.Text = "Menu Cliente";
            this.BackColor = Color.LightYellow;

            //Cliente


            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.Size = new Size(200, 30);
            btnCadastrarCliente.Location = new Point(200, 50);
            btnCadastrarCliente.Click += new EventHandler(this.btnCadastrarClienteClick);



            btnListarCliente.Text = "Lista de Clientes Cadastrados";
            btnListarCliente.Size = new Size(200, 30);
            btnListarCliente.Location = new Point(200, 100);



            btnAtualizarCliente.Text = "Atualizar Clientes";
            btnAtualizarCliente.Size = new Size(200, 30);
            btnAtualizarCliente.Location = new Point(200, 150);



            btnRemoverCliente.Text = "Remover Clientes";
            btnRemoverCliente.Size = new Size(200, 30);
            btnRemoverCliente.Location = new Point(200, 200);

            btnEncMenu.Text = "Encerrar Menu";
            btnEncMenu.Size = new Size(200, 30);
            btnEncMenu.Location = new Point(200, 300);
            btnEncMenu.Click += new EventHandler(this.btnEncMenuClick);
            btnEncMenu.BackColor = Color.White;


            this.Size = new Size(600, 600);

            //Buttons Clientes

            this.Controls.Add(btnCadastrarCliente);
            this.Controls.Add(btnListarCliente);
            this.Controls.Add(btnAtualizarCliente);
            this.Controls.Add(btnRemoverCliente);

            this.Controls.Add(btnEncMenu);


        }

        
         private void btnCadastrarClienteClick(object sender, EventArgs e)
        {
            CadastroClienteVisual cadastroCliente = new CadastroClienteVisual();
            cadastroCliente.Show();
        }


        private void btnEncMenuClick(object sender, EventArgs e)
        {  //Cria o Evento do botão (Click)
            DialogResult resultado = MessageBox.Show("Deseja Sair do Menu?", "Menu Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Até a próxima!");
            }
            else
            {
                MessageBox.Show("Opção desconhecida!");
            }
            this.Close();

        }
    }
}
