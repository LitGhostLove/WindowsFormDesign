public Form1()
{
    InitializeComponent();
    this.MouseDown += FormMouseDown;  //添加事件
	
	//把label修成圓形，看起來比較像燈(?
    System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
    path.AddEllipse(0, 0, label1.Width, label1.Height);
    label1.Region = new Region(path);
}

private void FormMouseDown(object sender, MouseEventArgs e)
{
    if (e.Button == MouseButtons.Left)  //左鍵改為黃色的黃燈
    {
        label1.BackColor = Color.Yellow;
    }
    else if (e.Button == MouseButtons.Right)  //右鍵改為綠色的綠燈
    {
        label1.BackColor = Color.Green;
    }
    else if (e.Button == MouseButtons.Middle)  //測試用，中鍵改為紅色的綠燈
    {
        label1.BackColor = Color.Red;
    }
}