﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI03
{
    public class BMI
    {
        /// <summary>
        /// 取得BMI的結果
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <param name="gender">將男性設定為True</param>
        /// <returns></returns>
        public string GetBMIResult(double weight, double height, bool gender)
        {
            double bmi = GetBMIValue(weight, height);
            if (bmi != -1)
            {
                if (gender)
                {
                    if (bmi < 20)
                        return "太瘦";
                    else if (bmi > 25)
                        return "太胖";
                    else
                        return "適中";
                }
                else
                {
                    if (bmi < 18)
                        return "太瘦";
                    else if (bmi > 22)
                        return "太胖";
                    else
                        return "適中";
                }
            }
            else
                return "體重或身高不得小於0";
        }
        private double GetBMIValue(double weight, double height)
        {
            if (weight > 0 && height > 0)
                return weight / Math.Pow(height, 2);
            else
                return -1;
        }
    }
}
