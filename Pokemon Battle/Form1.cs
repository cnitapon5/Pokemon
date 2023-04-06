using Pokemon_Battle.pokemons;

namespace Pokemon_Battle
{
    public partial class Form1 : Form
    {
        

        List<character> pokemons;
        character selectedPokemon;
        character player;
        character enemy;


        private bool isCollapsed;
        public Form1()
        {
            InitializeComponent();

            pokemons = new List<character>();
            pokemons.Add(new Beedrill());
            pokemons.Add(new spear());
            pokemons.Add(new Lechonk());
            pokemons.Add(new IronThorns());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = ("300");
            this.textBox5.Text = ("30");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = ("400");
            this.textBox5.Text = ("40");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = ("500");
            this.textBox5.Text = ("50");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = ("600");
            this.textBox5.Text = ("60");
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int i = Convert.ToInt32(textBox4.Text);
            int j = Convert.ToInt32(textBox5.Text);
            int a = i - j;
            textBox4.Text = a.ToString();

            int p = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox6.Text);
            int b = p - c;
            textBox2.Text = b.ToString();  

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}