using System;

namespace Test.Exercise3
{
    public class Exercise3
    {
        public int PeopleAnsweredYes(double man, double woman) => (int)(man + woman);

        public int PeopleAnsweredNo(double manAnsweredNo, double womanAnsweredNo) =>(int)(manAnsweredNo + womanAnsweredNo);

        public double PercentageOfWomenAnsweredYes(double womenAnsweredYes, int women) => Math.Round((womenAnsweredYes / women) * 100, 2);

        public double PercentageOfMenAnsweredNo(double menAnsweredNo, int men) => Math.Round((menAnsweredNo/men)*100, 2);
    }

}