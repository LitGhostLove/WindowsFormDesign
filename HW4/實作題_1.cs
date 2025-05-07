private void Form1_Load(object sender, EventArgs e)
{
    int[] nums = new int[5];
    Random rand = new Random();

    for (int i = 0; i < 5; i++)
    {
        nums[i] = rand.Next(1, 201);
    }

    Array.Sort(nums);
    label1.Text = "排序後的陣列：" + string.Join(", ", nums);
}
