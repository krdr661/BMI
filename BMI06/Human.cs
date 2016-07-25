using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI06
{
    public enum GenderType
    {
        Man = 1,
        Woman
    }
    public class Human
    {
        public double weight { get; set; }
        public double height { get; set; }
        public GenderType Gender { get; set; }
    }
    public abstract class BMIStrategy
    {
        public Human human { get; set; }
        protected double _max;
        protected double _min;
        private double _bmi = 0;
        public double bmi
        {
            get
            {
                GetBMIValue();
                return _bmi;
            }
        }
        private string _result = string.Empty;
        public string result
        {
            get
            {
                GetBMIValue();
                GetResult();
                return _result;
            }
        }
        private void GetBMIValue()
        {
            if (human.weight > 0 && human.height > 0)
                _bmi = human.weight / Math.Pow(human.height, 2);
            else
                _bmi = -1;
        }
        private void GetResult()
        {
            if (bmi != -1)
            {
                if (bmi > _max)
                    _result = "太胖";
                else if (bmi < _min)
                    _result = "太瘦";
                else
                    _result = "適中";
            }
            else
                _result = "體重或身高不得小於0";
        }
    }
    internal class ManBMIStrategy : BMIStrategy
    {
        public ManBMIStrategy()
        {
            this._min = 20;
            this._max = 25;
        }
    }
    internal class WomanBMIStrategy : BMIStrategy
    {
        public WomanBMIStrategy()
        {
            this._min = 18;
            this._max = 22;
        }
    }
    public static class StrategyFactory
    {
        public static BMIStrategy GetStrategy(this Human human)
        {
            StrategyResource resource = StrategyResource.Strategies.Where(x => x.Gender == human.Gender).FirstOrDefault();
            if(resource!=null)
            {
                resource.Strategy.human = human;
                return resource.Strategy;
            }else
                throw new NullReferenceException();
        }
    }
    //隱藏資源的實作, 當 Strategy 擴充, 只要修改此處
    internal class StrategyResource
    {
        internal GenderType Gender{ get; private set; }

        internal BMIStrategy Strategy { get; private set; }

        private StrategyResource(GenderType gender, BMIStrategy strategy)
        {
            Gender = gender;
            Strategy = strategy;
        }

        //策略集合, 單例
        private static List<StrategyResource> _strategies;
        internal static List<StrategyResource> Strategies
        {
            get
            {
                if (_strategies == null)
                {
                    // _strategies = new List<StrategyResource>();
                    GetStrategies();
                }
                return _strategies;
            }
        }

        private static void GetStrategies()
        {
            _strategies = new List<StrategyResource>();
            _strategies.Add(new StrategyResource(GenderType.Man, new ManBMIStrategy()));
            _strategies.Add(new StrategyResource(GenderType.Woman, new WomanBMIStrategy()));
        }
    }
}
