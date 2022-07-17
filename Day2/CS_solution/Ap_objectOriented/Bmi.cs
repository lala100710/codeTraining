using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap_objectOriented
{
    internal class Bmi
    {
        private double _height, _weight, _bmi;
        public Bmi(double height, double weight)
        {
            _height = height;
            _weight = weight;
        }
        public double BMIcal()
        {

            return _weight/(_height/100)/ (_height / 100);
        }
        public string status()
        {
            if (BMIcal() < 18.5)
                return string.Format("身高 :{0}cm 體重 :{1}kg BMI:{2:0.00}  體重過輕", _height, _weight, BMIcal());
               
            else if(BMIcal() < 24)
                return string.Format("身高 :{0}cm 體重 :{1}kg BMI:{2:0.00}  體重正常", _height, _weight, BMIcal());
        
            else
                return string.Format("身高 :{0}cm 體重 :{1}kg BMI:{2:0.00}  體重過重", _height, _weight, BMIcal());
  
           
        }

        
    }
}
