private int arrMax(int[] arr)
{
    int max = arr[0];
    foreach (int n in arr)
    {
        if (n > max)
            max = n;
    }
    return max;
}

private int arrMin(int[] arr)
{
    int min = arr[0];
    foreach (int n in arr)
    {
        if (n < min)
            min = n;
    }
    return min;
}

private void textBox_Changed(object sender, EventArgs e)
{
    try
    {
        // 讀取 6 個 TextBox 中的數值
        int[] nums = new int[6];
        nums[0] = int.Parse(textBox1.Text);
        nums[1] = int.Parse(textBox2.Text);
        nums[2] = int.Parse(textBox3.Text);
        nums[3] = int.Parse(textBox4.Text);
        nums[4] = int.Parse(textBox5.Text);
        nums[5] = int.Parse(textBox6.Text);

        // 呼叫方法
        int min = arrMin(nums);
        int max = arrMax(nums);

        // 顯示結果
        label1.Text = "最大值：" + max.ToString();
        label2.Text = "最小值：" + min.ToString();
    }
    catch
    {
        label1.Text = "最大值：";
        label2.Text = "最小值：";
    }
}
