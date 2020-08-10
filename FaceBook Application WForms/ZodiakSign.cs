using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FaceBook_Application_WForms
{
    public class ZodiakSign
    {
        public eSign Sign { get; private set; }

        public eSign SignBestMatchedWith { get; private set; }

        public string PictureUrl { get; private set; }



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

            setMatchedSign();
            setPictureUrl();

        }

        public ZodiakSign(eSign i_Sign)
        {
            Sign = i_Sign;
            setMatchedSign();
            setPictureUrl();
        }

        private void setMatchedSign()
        {
            switch(Sign)
            {
                case eSign.Aquarius:
                    SignBestMatchedWith = eSign.Pisces;
                    break;
                case eSign.Pisces:
                    SignBestMatchedWith = eSign.Aries;
                    break;
                case eSign.Aries:
                    SignBestMatchedWith = eSign.Taurus;
                    break;
                case eSign.Taurus:
                    SignBestMatchedWith = eSign.Gemini;
                    break;
                case eSign.Gemini:
                    SignBestMatchedWith = eSign.Cancer;
                    break;
                case eSign.Cancer:
                    SignBestMatchedWith = eSign.Leo;
                    break;
                case eSign.Leo:
                    SignBestMatchedWith = eSign.Virgo;
                    break;
                case eSign.Virgo:
                    SignBestMatchedWith = eSign.Libra;
                    break;
                case eSign.Libra:
                    SignBestMatchedWith = eSign.Scorpio;
                    break;
                case eSign.Scorpio:
                    SignBestMatchedWith = eSign.Sagittarius;
                    break;
                case eSign.Sagittarius:
                    SignBestMatchedWith = eSign.Capricorn;
                    break;
                default:
                    SignBestMatchedWith = eSign.Aquarius;
                    break;
            }
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
