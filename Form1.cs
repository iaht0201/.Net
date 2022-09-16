namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ErrorProvider error;
        // Khai báo global
        public Form1()
        {
            InitializeComponent();
            error = new ErrorProvider();
            
            // Để khỏi tạo khi cần 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("a");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                #region get value
                var sothunhat = txtsothunhat.Text;
                var sothuhai = txtsothuhai.Text;
                error.Clear();
                #endregion
                #region check validation
                if (String.IsNullOrEmpty(sothunhat))
                {
                    error.SetError(txtsothunhat, "Vui lòng nhập dữ liệu");
                    return;
                }
                if (String.IsNullOrEmpty(sothuhai))
                {
                    error.SetError(txtsothuhai, "Vui lòng nhập dữ liệu");
                    return;
                }
                #endregion

                #region handle 
                double _sothunhat = Convert.ToDouble(sothunhat);
                double _sothuhai = Convert.ToDouble(sothuhai);

                var ketqua = _sothunhat + _sothuhai;


                if (rdblabel.Checked)
                    lblketqua.Text = ketqua.ToString("N2");
                else MessageBox.Show($"Kết quả : {ketqua:N2}");  
                #endregion
            }
            #region exception
            catch (FormatException ex)
            {
                MessageBox.Show("Dữ liệu bạn nhập không đúng. Vui lòng xem lại");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Dữ liệu bạn nhập quá lớn. Vui lòng xem lại");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu của bạn đã xuất hiên lỗi" + ex.Message);

                // Exception --> lấy tất cả các lỗi 
                // FormatException --> lấy lỗi liên quan tới định dạng 
                //OverflowException --> lỗi kiên quan overflow 

            } 
            #endregion



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lnkchonmau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            var result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                var color = dialog.Color;
                this.BackColor = color;
            } 
        }

        private void llkchonhinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var image = dialog.FileName;
                this.BackgroundImage = new Bitmap(image);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.BackColor = Color.White;
             }
        }
    }
}