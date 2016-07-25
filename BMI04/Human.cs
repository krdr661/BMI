using System;

namespace BMI04
{
    /// <summary>
    /// 封裝計算公式, 以 BMI 為主角, Template Pattern
    /// </summary>
    public abstract class Human
    {
        public double weight { get; set; }
        public double height { get; set; }

        private bool _calculated = false;
        private double _bmi = 0;

        public double bmi
        {
            get
            {
                if (!_calculated)
                {
                    GetBMIValue();
                }
                return _bmi;
            }
        }
        private void GetBMIValue()
        {
            if (weight > 0 && height > 0)
                _bmi = weight / Math.Pow(height, 2);
            else
                _bmi = -1;
        }

        public string Result
        {
            get
            {
                return GetResult();
            }

        }
        //繼承
        protected abstract string GetResult();

        public class Man : Human
        {
            protected override string GetResult()
            {
                if (bmi < 20)
                    return "太瘦";
                else if (bmi > 25)
                    return "太胖";
                else
                    return "適中";
            }
        }
        public class Woman : Human
        {
            protected override string GetResult()
            {
                if (bmi < 18)
                    return "太瘦";
                else if (bmi > 22)
                    return "太胖";
                else
                    return "適中";
            }
        }
    }
}
