using System;

namespace matrix_optics_2
{
    public class parseBD
    {
        public string BThDay;
        public static DateTime BD(string BThDay)
        {
            
            return DateTime.Parse(BThDay);
        }
        public static int myAge(string BthDay)
        {
           
            return DateTime.Now.Year-BD(BthDay).Year;
        }
    }
}