namespace 大文件拷贝
{
    public partial class Form1 : Form
    {
        private string[] lines;

        public Form1()
        {
            InitializeComponent();
        }

        // 读取按钮
        private void btn_Read_Click(object sender, EventArgs e)
        {
            lines = File.ReadAllLines("Score.txt");
            foreach (var line in lines)
            {
                t_score.AppendText(line + Environment.NewLine);
            }
        }

        // 排序按钮
        private void btn_Sort_Click(object sender, EventArgs e)
        {
            foreach (var line in lines)
            {
                var scores = line.Split('，');
                t_sort.AppendText(scores[0]);
                t_sort.AppendText(" ");
                int cnt = 0;
                for (int i = 1; i < scores.Length; i++)
                {
                    cnt += int.Parse(scores[i]);
                }
                t_sort.AppendText(cnt.ToString());
                t_sort.AppendText(Environment.NewLine);
            }
        }
    }
}