namespace TimeStamper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data != null)
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    e.Effect = DragDropEffects.Copy;
                }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data != null)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files != null)
                    foreach (string file in files)
                    {
                        if (File.Exists(file))
                        {
                            var st = dateTimePicker1.Value;
                            var ot = File.GetCreationTime(file);

                            System.DateTime targetTime = new(st.Year, st.Month, st.Day, ot.Hour, ot.Minute, ot.Second);
                             
                            if(created_checkbox.Checked)
                            {
                                File.SetCreationTime(file, targetTime);
                            }
                            if (modified_checkbox.Checked)
                            {
                                File.SetLastWriteTime(file, targetTime);
                            }
                            if (opened_checkbox.Checked)
                            {
                                File.SetLastAccessTime(file, targetTime);
                            }
                        }
                    }
            }
        }
    }
}
