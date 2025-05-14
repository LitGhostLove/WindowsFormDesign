delegate double ConversionDelegate(double value);

        static void Main(string[] args)
        {
            Console.WriteLine("請輸入單位類型：1 = 英尺(Feet)，2 = 英碼(Yards)");
            string inputType = Console.ReadLine();

            Console.WriteLine("請輸入數值：");
            string inputValue = Console.ReadLine();

            if (!double.TryParse(inputValue, out double number))
            {
                Console.WriteLine("輸入的數值無效！");
                return;
            }

            // 委派變數
            ConversionDelegate converter;

            // 決定要使用哪個方法
            if (inputType == "1")
            {
                converter = FeetToInches;
            }
            else if (inputType == "2")
            {
                converter = YardsToInches;
            }
            else
            {
                Console.WriteLine("無效的單位類型！");
                return;
            }

            // 使用委派執行轉換
            double inches = converter(number);
            Console.WriteLine($"轉換結果：{inches} 英吋");
        }

        // 英尺轉英吋
        static double FeetToInches(double feet)
        {
            return feet * 12;
        }

        // 英碼轉英吋（1碼 = 3英尺 = 36英吋）
        static double YardsToInches(double yards)
        {
            return yards * 36;
        }