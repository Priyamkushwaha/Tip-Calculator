namespace tipCalculator
{
    public partial class Form1 : Form
    {
        // required variables
        private double Amount = 0;
        private int TipPercent = 0;
        private int NumOfPerson = 1;
        private double TipPerPerson = 0;
        private double TotalPerPerson = 0;
        public Form1()
        {
            InitializeComponent();
            //intializing text values
            txtBillAmount.Text = Convert.ToString(Amount);
            txtTipPercent.Text= Convert.ToString(TipPercent);
            txtNumOfPerson.Text= Convert.ToString(NumOfPerson);
            txtTipPerPerson.Text = Convert.ToString(TipPerPerson);
            txtTotalPerPerson.Text = Convert.ToString(TotalPerPerson);
        }
        // update is used whenever any value change
        private void update()
        {
            if (Amount >= 0 && TipPercent >= 0 && NumOfPerson >= 1)
            {
                TipPerPerson = (Amount * ((double)TipPercent / 100)) / NumOfPerson;
                TotalPerPerson = Amount / NumOfPerson + TipPerPerson;
                txtTipPerPerson.Text = Convert.ToString(TipPerPerson);
                txtTotalPerPerson.Text = Convert.ToString(TotalPerPerson);
            }
        }
        //event listener for BILL textbox
        private void txtBillAmount_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(txtBillAmount.Text, out Amount);
            update();
        }

        private void subTipButton_Click(object sender, EventArgs e)
        {
            if (TipPercent > 0)
            {
                TipPercent -= 1;
                txtTipPercent.Text = Convert.ToString(TipPercent);
            }
        }
        // event listener for tip %
        private void txtTipPercent_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txtTipPercent.Text, out TipPercent);
            update();
        }

        private void addTipButton_Click(object sender, EventArgs e)
        {
            if(TipPercent >= -1)
            {
                TipPercent += 1;
                txtTipPercent.Text = Convert.ToString(TipPercent);
            }
        }

        private void subPersonButtton_Click(object sender, EventArgs e)
        {
            if(NumOfPerson > 1)
            {
                NumOfPerson -= 1;
                txtNumOfPerson.Text = Convert.ToString(NumOfPerson);
            }
        }
        // event listener for Number of person
        private void txtNumOfPerson_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txtNumOfPerson.Text, out NumOfPerson);
            NumOfPerson = NumOfPerson == 0 ? 1 : NumOfPerson;
            update();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            if (NumOfPerson >= 0)
            {
                NumOfPerson += 1;
                txtNumOfPerson.Text = Convert.ToString(NumOfPerson);
            }
        }
    }
}