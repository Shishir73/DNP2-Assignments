using System;
using System.Collections.Generic;

namespace Assignment1.Model
{
    class Car : IComparable<Car>
    {
        public int kmPhr { get; set; }
        public double psPkw { get; set; }
        public int uPmin { get; set; }
        public int ccm { get; set; }
        public double zeroToHundred { get; set; }
        public int zylinder { get; set; }


        public Car(int kmPhr, double psPkw, int uPmin, int ccm, double zeroToHundred, int zylinder)
        {
            this.kmPhr = kmPhr;
            this.psPkw = psPkw;
            this.uPmin = uPmin;
            this.ccm = ccm;
            this.zeroToHundred = zeroToHundred;
            this.zylinder = zylinder;
        }

        public int CompareTo(Car c)
        {
            return c.kmPhr.CompareTo(this.kmPhr);
        }

        public override string ToString()
        {
            return "Cars with top speed: " + kmPhr
                + " kmph, Ps/kW: " + psPkw + ", U/min: " + uPmin + ", CCM: " + ccm
                + " 0 to 100 km/h: " + zeroToHundred + " seconds, and "
                + zylinder + " zylinders";
        }

        #region COMPARING CARS ALL PROPERTIES

        public class SortingByPsPkw : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                return x.psPkw.CompareTo(y.psPkw);
            }
        }

        public class SortingByUPMin : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                return x.uPmin.CompareTo(y.uPmin);
            }
        }

        public class SortingByCcm : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                return x.ccm.CompareTo(y.ccm);
            }
        }

        public class SortingByZeroToHund : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                return x.zeroToHundred.CompareTo(y.zeroToHundred);
            }
        }

        public class SortingByZylinder : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                return x.zylinder.CompareTo(y.zylinder);
            }
        }

        #endregion
    }
}
