using CV_Project332.Model;

namespace CV_Project332.Sevices
{
    public class CV_Grade
    {
        int g = 0;

        public int grade(informations info)
        {
            if (info.s1==true)
            {
                g=g+10;
            }
            if (info.s2==true)
            {
                g = g + 10;
            }
            if (info.s3==true)
            {
                g = g + 10;
            }
            if (info.s4==true)
            {
                g = g + 10;
            }
            if (info.gender == "Male")
            {
                g = g + 5;
            }
            if (info.gender == "Female")
            {
                g = g + 10;
            }
            return g;
        }
    }
}
