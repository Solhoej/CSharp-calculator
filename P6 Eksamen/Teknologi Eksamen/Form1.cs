using System.Drawing.Text;
using System.Runtime.CompilerServices;

namespace Teknologi_Eksamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Paint += new PaintEventHandler(StartupShapeDrawing);
        }

        private void StartupShapeDrawing(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Pen blackPen = new Pen(Color.Black);
            Pen bluePen = new Pen(Color.Blue);
            Pen aquaPen = new Pen(Color.Aqua);

            SolidBrush aquaBrush = new SolidBrush(Color.FromArgb(189, 252, 251));
            SolidBrush lightGreyBrush = new SolidBrush(Color.FromArgb(220, 220, 220));

            graphics.FillRectangle(aquaBrush, 20, 20, 260, 90);
            graphics.DrawRectangle(blackPen, 20, 20, 260, 90);


            graphics.FillRectangle(lightGreyBrush, 300, 20, 260, 90);
            graphics.DrawRectangle(blackPen, 300, 20, 260, 90);

            graphics.FillRectangle(aquaBrush, 580, 20, 260, 90);
            graphics.DrawRectangle(blackPen, 580, 20, 260, 90);

            blackPen.Dispose();
            bluePen.Dispose();
            aquaPen.Dispose();

            aquaBrush.Dispose();
            lightGreyBrush.Dispose();
        }

        public void SubmitNewCategory_Click(object sender, EventArgs e)
        {
            string Category = NewCategory.Text;

            List<string> Expenses = new List<string>();
            Expenses.Add(Category);

            MessageBox.Show($"Ny kategori {Category} tilføjet");

            foreach (string expense in Expenses)
            {
                System.Diagnostics.Debug.WriteLine(expense);
            }
        }

        public void SubmitEarnings_Click(object sender, EventArgs e)
        {
            int Earnings = int.Parse(EarningsBox.ToString());
        }

        private void SelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class Categories
    {
        public string Name { get; private set; }
        public int Total { get; private set; }

        public Categories(string name)
        {
            Name = name;
            Total = 0;
        }

        public void AddExpense(int amount)
        {
            Total += amount;
        }

        public void RemoveExpense(int amount)
        {
            Total -= amount;
        }
    }
}