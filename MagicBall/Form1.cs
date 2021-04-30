using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicBall
{
    public partial class Form1 : Form
    {
        private bool _isYesMode;
        private MagicBall _magicBall = new MagicBall();

        public Form1()
        {
            InitializeComponent();
            yesLimit.Visible = YesLimitLabel.Visible = false;
            answerBox.Text = "";
        }

        public class MagicBall
        {
          
            public double yesLimit = 0.5;

            private readonly Dictionary<int, string> _answers = new Dictionary<int, string>()
            {
                {0, "Don’t count on it."}, 
                {1, "My reply is no."}, 
                {2, "My sources say no."}, 
                {3, "Outlook not so good."}, 
                {4, "Very doubtful."},

                {5, "Reply hazy, try again."},
                {6, "Ask again later."},
                {7, "Better not tell you now."},
                {8, "Cannot predict now."},
                {9, "Concentrate and ask again."},

                {10, "It is certain."},
                {11, "It is decidedly so."},
                {12, "Without a doubt."},
                {13, "Yes – definitely."},
                {14, "You may rely on it."},
                {15, "As I see it, yes."},
                {16, "Most likely."},
                {17, "Outlook good."},
                {18, "Yes."},
                {19, "Signs point to yes."}
            };

            private readonly Dictionary<int, double> _probability = new Dictionary<int, double>()
            {
                {0, 0.1},
                {1, 0.01},
                {2, 0.05},
                {3, 0.045},
                {4, 0.045},

                {5, 0.045},
                {6, 0.05},
                {7, 0.1},
                {8, 0.045},
                {9, 0.01},

                {10, 0.045},
                {11, 0.045},
                {12, 0.01},
                {13, 0.05},
                {14, 0.1},
                {15, 0.05},
                {16, 0.045},
                {17, 0.01},
                {18, 0.1},
                {19, 0.045}
            };

            public string RollBall()
            {
                Random random =  new Random();
                double Prob = random.NextDouble();
                for (var i = 0; i <= _probability.Count; i++)
                {
                    Prob -= _probability[i];
                    if (Prob <= 0) 
                        return _answers[i];
                };
                return null;
            }
        }

        private void SwitchBtn_Click(object sender, EventArgs e)
        {
            if (!_isYesMode)
            {
                _isYesMode = yesLimit.Visible = YesLimitLabel.Visible = true;
            }
            else
            {
                _isYesMode = yesLimit.Visible = YesLimitLabel.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AnsBtn_Click(object sender, EventArgs e)
        {
            if (questionBox.Text != "")
            {
                if (_isYesMode)
                {
                    Random random = new Random();
                    answerBox.Text = random.NextDouble() > (double) yesLimit.Value ? "Yes!" : "No.";
                }
                else
                {
                    answerBox.Text = _magicBall.RollBall();
                }
            }
            else
            {
                answerBox.Text = "Where is your question?";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
