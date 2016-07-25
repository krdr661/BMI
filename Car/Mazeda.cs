using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Mazeda : ICar
    {
        private ISpeedUpSet _speedUp;
        private ISpeedDownSet _speedDown;
        private IUseItemSet _useItem;
        private IAtkSet _atk;

        public Mazeda(ISpeedUpSet speedUp, ISpeedDownSet speedDown, IUseItemSet useItem, IAtkSet atk)
        {
            this._speedUp = speedUp;
            this._speedDown = speedDown;
            this._useItem = useItem;
            this._atk = atk;
        }



        public void Atk()
        {
            this._atk.Atk();
        }

        public void SpeedDown()
        {
            this._speedDown.SpeedDown();
        }

        public void SpeedUp()
        {
            this._speedUp.SpeedUp();
        }

        public void UseItem()
        {
            this._useItem.UseItem();
        }
    }
}
