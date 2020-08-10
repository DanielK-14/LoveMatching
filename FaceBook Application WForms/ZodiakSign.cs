using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FaceBook_Application_WForms
{
    public class ZodiakSign
    {
        public eSign Sign { get; private set; }

        public enum eSign
        {
            Aquarius,
            Pisces,
            Aries,
            Taurus,
            Gemini,
            Cancer,
            Leo,
            Virgo,
            Libra,
            Scorpio,
            Sagittarius,
            Capricorn
        }

        public ZodiakSign(string i_Birthday)
        {
            string[] dateFormat = i_Birthday.Split('/');
            int month = int.Parse(dateFormat[0]);
            int day = int.Parse(dateFormat[1]);

            if (month == 1)
            {
                Sign = day >= 20 ? eSign.Aquarius : eSign.Capricorn;
            }
            else if(month == 2)
            {
                Sign = day >= 19 ? eSign.Pisces : eSign.Aquarius;
            }
            else if(month == 3)
            {
                Sign = day >= 21 ? eSign.Aries : eSign.Pisces;
            }
            else if (month == 4)
            {
                Sign = day >= 20 ? eSign.Taurus : eSign.Aries;
            }
            else if (month == 5)
            {
                Sign = day >= 21 ? eSign.Gemini : eSign.Taurus;
            }
            else if (month == 6)
            {
                Sign = day >= 21 ? eSign.Cancer : eSign.Gemini;
            }
            else if (month == 7)
            {
                Sign = day >= 23 ? eSign.Leo : eSign.Cancer;
            }
            else if (month == 8)
            {
                Sign = day >= 23 ? eSign.Virgo : eSign.Leo;
            }
            else if (month == 9)
            {
                Sign = day >= 23 ? eSign.Libra : eSign.Virgo;
            }
            else if (month == 10)
            {
                Sign = day >= 23 ? eSign.Scorpio : eSign.Libra;
            }
            else if (month == 11)
            {
                Sign = day >= 22 ? eSign.Sagittarius : eSign.Scorpio;
            }
            else
            {
                Sign = day >= 22 ? eSign.Capricorn : eSign.Sagittarius;
            }

        }

        public ZodiakSign(eSign i_Sign)
        {
            Sign = i_Sign;
        }

        public ZodiakSign SignBestMatchedWith()
        {
            eSign sign;
            
            switch(Sign)
            {
                case eSign.Aquarius:
                    sign = eSign.Pisces;
                    break;
                case eSign.Pisces:
                    sign = eSign.Aries;
                    break;
                case eSign.Aries:
                    sign = eSign.Taurus;
                    break;
                case eSign.Taurus:
                    sign = eSign.Gemini;
                    break;
                case eSign.Gemini:
                    sign = eSign.Cancer;
                    break;
                case eSign.Cancer:
                    sign = eSign.Leo;
                    break;
                case eSign.Leo:
                    sign = eSign.Virgo;
                    break;
                case eSign.Virgo:
                    sign = eSign.Libra;
                    break;
                case eSign.Libra:
                    sign = eSign.Scorpio;
                    break;
                case eSign.Scorpio:
                    sign = eSign.Sagittarius;
                    break;
                case eSign.Sagittarius:
                    sign = eSign.Capricorn;
                    break;
                default:
                    sign = eSign.Aquarius;
                    break;
            }

            return new ZodiakSign(sign);
        }

        public string PictureUrl()
        {
            string url;
            switch (Sign)
            {
                case eSign.Aquarius:
                    url = "https://www.astrology-zodiac-signs.com/images/aquarius.jpg";
                    break;
                case eSign.Pisces:
                    url = "https://www.astrology-zodiac-signs.com/images/pisces.jpg";
                    break;
                case eSign.Aries:
                    url = "https://www.astrology-zodiac-signs.com/images/aries.jpg";
                    break;
                case eSign.Taurus:
                    url = "https://www.astrology-zodiac-signs.com/images/taurus.jpg";
                    break;
                case eSign.Gemini:
                    url = "https://www.astrology-zodiac-signs.com/images/gemini.jpg";
                    break;
                case eSign.Cancer:
                    url = "https://www.astrology-zodiac-signs.com/images/cancer.jpg";
                    break;
                case eSign.Leo:
                    url = "https://www.astrology-zodiac-signs.com/images/leo.jpg";
                    break;
                case eSign.Virgo:
                    url = "https://www.astrology-zodiac-signs.com/images/virgo.jpg";
                    break;
                case eSign.Libra:
                    url = "https://www.astrology-zodiac-signs.com/images/libra.jpg";
                    break;
                case eSign.Scorpio:
                    url = "https://www.astrology-zodiac-signs.com/images/scorpio.jpg";
                    break;
                case eSign.Sagittarius:
                    url = "https://www.astrology-zodiac-signs.com/images/sagittarius.jpg";
                    break;
                default:
                    url = "https://www.astrology-zodiac-signs.com/images/capricorn.jpg";
                    break;
            }

            return url;
        }
    }
}
