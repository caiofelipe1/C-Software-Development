namespace Aula10._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string senha = textSenha.Text;

            if (usuario == "LUCAS SIMIDU" && senha == "123")
            {
                MessageBox.Show("Login realizado com sucesso!");
                Menu telaMenu = new Menu();
                telaMenu.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Carregando... Aguarde!", "LUCAS SIMIDU");
        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
