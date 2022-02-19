using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox
{
    public class Car
    {
        public string brandName;
        public string modelName;
        public int carDoorCount;
        public int carBatteryCapacity;
        public int mileageAmount;

        public Car(string brandName, string modelName, int carDoorCount, int carBatteryCapacity, int mileageAmount)
        {
            this.brandName = brandName;
            this.modelName = modelName;
            this.carDoorCount = carDoorCount;
            this.carBatteryCapacity = carBatteryCapacity;   
            this.mileageAmount = mileageAmount;
        }

        public void increaseMilage(int changeby)
        {
            if (changeby > 0)
            {
                var newMileageAmount = mileageAmount + changeby;
                mileageAmount = newMileageAmount;
            }

        }
        public bool isNew ()
        {
            if(mileageAmount <=1000)
            {
                return true;
            } else { return false; }
        } 
    }


}
