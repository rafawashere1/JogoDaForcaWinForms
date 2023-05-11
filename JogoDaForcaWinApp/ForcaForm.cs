namespace JogoDaForcaWinApp
{
    public partial class ForcaForm : Form
    {
        private readonly Forca _forca;

        public ForcaForm()
        {
            InitializeComponent();

            _forca = new Forca();

            ConfigurarBotoes();
        }

        private void ConfigurarBotoes()
        {
            btnA.Click += AtribuirLetra;
            btnB.Click += AtribuirLetra;
            btnC.Click += AtribuirLetra;
            btnD.Click += AtribuirLetra;
            btnE.Click += AtribuirLetra;
            btnF.Click += AtribuirLetra;
            btnG.Click += AtribuirLetra;
            btnH.Click += AtribuirLetra;
            btnI.Click += AtribuirLetra;
            btnJ.Click += AtribuirLetra;
            btnK.Click += AtribuirLetra;
            btnL.Click += AtribuirLetra;
            btnM.Click += AtribuirLetra;
            btnN.Click += AtribuirLetra;
            btnO.Click += AtribuirLetra;
            btnP.Click += AtribuirLetra;
            btnQ.Click += AtribuirLetra;
            btnR.Click += AtribuirLetra;
            btnS.Click += AtribuirLetra;
            btnT.Click += AtribuirLetra;
            btnU.Click += AtribuirLetra;
            btnV.Click += AtribuirLetra;
            btnW.Click += AtribuirLetra;
            btnX.Click += AtribuirLetra;
            btnY.Click += AtribuirLetra;
            btnZ.Click += AtribuirLetra;
        }

        private void AtribuirLetra(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            _forca.letra = botaoClicado.Text[0];

            botaoClicado.Enabled = false;
            _forca.achou = false;
            _forca.tentou = false;

            VerificarLetraEncontrada();

            VerificarLetraTentada();

            ProcurarLetra();

            PreencherTracos();

            VerificarVitoria();

            IncrementarErros();

            VerificarDerrota();
        }

        private void VerificarDerrota()
        {
            switch (_forca.erros)
            {
                case 1: pictureBox2.Visible = true; break;
                case 2: pictureBox2.Visible = false; pictureBox3.Visible = true; break;
                case 3: pictureBox3.Visible = false; pictureBox4.Visible = true; break;
                case 4: pictureBox4.Visible = false; pictureBox5.Visible = true; break;
                case 5: pictureBox5.Visible = false; pictureBox6.Visible = true; break;
                case 6: pictureBox6.Visible = false; pictureBox7.Visible = true; break;
                case 7:

                    pictureBox7.Visible = false; pictureBox8.Visible = true;

                    MessageBox.Show("Você perdeu! :( \nReinicie o jogo.");

                    break;
            }
        }

        private void IncrementarErros()
        {
            if (_forca.achou == false && _forca.tentou == false)
            {
                _forca.erros++;
                lblChutes.Text += " " + _forca.letra;
            }
        }

        private void VerificarVitoria()
        {
            if (_forca.faltam == 0)
                MessageBox.Show("Você venceu!");
        }

        private void PreencherTracos()
        {
            lblTracos.Text = "";

            for (int i = 0; i != _forca.quantidade; i++)
            {
                lblTracos.Text += _forca.escondido[i];
            }
        }

        private void ProcurarLetra()
        {
            if (_forca.tentou == false)
            {
                for (int i = 0; i != _forca.quantidade; i++)
                {
                    if (_forca.letra == _forca.palavraSecreta[i])
                    {
                        _forca.escondido[i] = _forca.letra;
                        _forca.achou = true;
                        _forca.faltam -= 1;
                    }
                }
            }
        }

        private void VerificarLetraTentada()
        {
            _forca.tentativas = lblChutes.Text;

            for (int i = 0; i < _forca.tentativas.Length; i++)
            {
                if (_forca.letra == _forca.tentativas[i])
                    _forca.tentou = true;
            }
        }

        private void VerificarLetraEncontrada()
        {
            for (int i = 0; i < _forca.quantidade; i++)
            {
                if (_forca.letra == _forca.escondido[i])
                    _forca.tentou = true;
            }
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            btnComecar.Visible = false;
            _forca.quantidade = _forca.palavraSecreta.Length;
            _forca.faltam = _forca.quantidade;
            lblTracos.Text = "";
            lblChutes.Text = "";

            for (int i = 0; i < _forca.quantidade; i++)
            {
                _forca.escondido[i] = '_';
                lblTracos.Text += _forca.escondido[i];
            }

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnH.Enabled = true;
            btnI.Enabled = true;
            btnJ.Enabled = true;
            btnK.Enabled = true;
            btnL.Enabled = true;
            btnM.Enabled = true;
            btnN.Enabled = true;
            btnO.Enabled = true;
            btnP.Enabled = true;
            btnQ.Enabled = true;
            btnR.Enabled = true;
            btnS.Enabled = true;
            btnT.Enabled = true;
            btnU.Enabled = true;
            btnV.Enabled = true;
            btnW.Enabled = true;
            btnX.Enabled = true;
            btnY.Enabled = true;
            btnZ.Enabled = true;

            lblPalavraSecreta.Visible = true;
            lblErros.Visible = true;
        }
    }
}