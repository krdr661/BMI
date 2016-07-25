using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 分離 個人資料 和 BMI
/// </summary>
namespace BMI05
{

    internal class GenderBoundaryAttribute : Attribute
    {
        internal double _max { get; set; }
        internal double _min { get; set; }
        public GenderBoundaryAttribute(double min, double max)
        {
            this._max = max;
            this._min = min;
        }
    }
    public enum GenderType
    {
        [GenderBoundary(20, 25)]
        Man = 1,
        [GenderBoundary(18, 22)]
        Woman
    }

    public class Human
    {
        public double weight { get; set; }
        public double height { get; set; }
        public GenderType Gender { get; set; }
    }

    public class BMIAdapter
    {
        //internal static double wrongValue
        //{
        //    get
        //    {
        //        return -1;
        //    }
        //}
        internal static readonly double wrongValue = -1;
        public double bmi { get; private set; }
        public string result { get; private set; }
        private Human _human { get; set; }
        public BMIAdapter(Human human)
        {
            this._human = human;
            this.GetBMI();
        }
        private void GetBMI()
        {
            if (this._human.weight > 0 && this._human.height > 0)
                bmi = this._human.weight / Math.Pow(this._human.height, 2);
            else
                bmi = wrongValue;
            
            BoundryHelper helper = new BoundryHelper(_human.Gender);
            ResultAdaper adapter = new ResultAdaper(helper.min, helper.max, bmi);
            this.result = adapter.Result;

        }
    }
    /// <summary>
    /// 將attribute 使用反射抓出初始設定值
    /// </summary>
    internal class BoundryHelper
    {
        internal double max { get; private set; }

        internal double min { get; private set; }

        public BoundryHelper(GenderType gender)
        {
            System.Reflection.FieldInfo data = typeof(GenderType).GetField(gender.ToString());
            Attribute attribute = Attribute.GetCustomAttribute(data, typeof(GenderBoundaryAttribute));
            this.max = ((GenderBoundaryAttribute)attribute)._max;
            this.min = ((GenderBoundaryAttribute)attribute)._min;
        }
    }
    /// <summary>
    /// 將取得的值轉成結果
    /// </summary>
    internal class ResultAdaper
    {
        public string Result { get; private set; }

        private double _max;
        private double _min;
        private double _bmi;

        internal ResultAdaper(double min, double max, double bmi)
        {
            _max = max;
            _min = min;
            _bmi = bmi;
            GetResult();
        }

        private void GetResult()
        {
            if (_bmi != BMIAdapter.wrongValue)
            {
                if (_bmi > _max)
                    Result = "太胖";
                else if (_bmi < _min)
                    Result = "太瘦";
                else
                    Result = "適中";
            }
            else
                Result = "體重或身高不得小於0";
        }
    }
}
