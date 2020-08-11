using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FaceBook_Application_WForms
{
    public class ZodiacSign
    {
        private static Dictionary<eZodiacSign, string> sr_ImagesUrl;

        public eZodiacSign Sign { get; private set; }

        public string PictureUrl { get; private set; }

        public ZodiacSign BestMatchedWithSign {
            get
            {
                eZodiacSign matchedSign = pickMatchedSign();
                return new ZodiacSign(matchedSign);
            }
        }

        public enum eZodiacSign
        {
            Aquarius = 0,
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

        static ZodiacSign()
        {
            initZodiacSignsImagesUrlList();
        }

        public ZodiacSign(string i_Birthday)
        {
            initUserZodiacSign(i_Birthday);
            PictureUrl = sr_ImagesUrl[Sign];
            //setMatchedSign();
        }

        private ZodiacSign(eZodiacSign i_Sign)
        {
            Sign = i_Sign;
            PictureUrl = sr_ImagesUrl[Sign];
        }

        private void initUserZodiacSign(string i_Birthday)
        {
            string[] dateFormat = i_Birthday.Split('/');
            int month = int.Parse(dateFormat[0]);
            int day = int.Parse(dateFormat[1]);

            switch (month)
            {
                case 1:
                    Sign = day >= 20 ? eZodiacSign.Aquarius : eZodiacSign.Capricorn;
                    break;
                case 2:
                    Sign = day >= 19 ? eZodiacSign.Pisces : eZodiacSign.Capricorn;
                    break;
                case 3:
                    Sign = day >= 21 ? eZodiacSign.Aries : eZodiacSign.Pisces;
                    break;
                case 4:
                    Sign = day >= 20 ? eZodiacSign.Taurus : eZodiacSign.Aries;
                    break;
                case 5:
                    Sign = day >= 21 ? eZodiacSign.Gemini : eZodiacSign.Taurus;
                    break;
                case 6:
                    Sign = day >= 21 ? eZodiacSign.Cancer : eZodiacSign.Gemini;
                    break;
                case 7:
                    Sign = day >= 23 ? eZodiacSign.Leo : eZodiacSign.Cancer;
                    break;
                case 8:
                    Sign = day >= 23 ? eZodiacSign.Virgo : eZodiacSign.Leo;
                    break;
                case 9:
                    Sign = day >= 23 ? eZodiacSign.Libra : eZodiacSign.Virgo;
                    break;
                case 10:
                    Sign = day >= 23 ? eZodiacSign.Scorpio : eZodiacSign.Libra;
                    break;
                case 11:
                    Sign = day >= 22 ? eZodiacSign.Sagittarius : eZodiacSign.Scorpio;
                    break;
                case 12:
                    Sign = day >= 22 ? eZodiacSign.Capricorn : eZodiacSign.Sagittarius;
                    break;
            }
        }

        static private void initZodiacSignsImagesUrlList()
        {
            sr_ImagesUrl = new Dictionary<eZodiacSign, string>();

            sr_ImagesUrl[eZodiacSign.Aquarius] = "https://www.astrology-zodiac-signs.com/images/aquarius.jpg";
            sr_ImagesUrl[eZodiacSign.Pisces] = "https://www.astrology-zodiac-signs.com/images/pisces.jpg";
            sr_ImagesUrl[eZodiacSign.Aries] = "https://www.astrology-zodiac-signs.com/images/aries.jpg";
            sr_ImagesUrl[eZodiacSign.Taurus] = "https://www.astrology-zodiac-signs.com/images/taurus.jpg";
            sr_ImagesUrl[eZodiacSign.Gemini] = "https://www.astrology-zodiac-signs.com/images/gemini.jpg";
            sr_ImagesUrl[eZodiacSign.Cancer] = "https://www.astrology-zodiac-signs.com/images/cancer.jpg";
            sr_ImagesUrl[eZodiacSign.Leo] = "https://www.astrology-zodiac-signs.com/images/leo.jpg";
            sr_ImagesUrl[eZodiacSign.Virgo] = "https://www.astrology-zodiac-signs.com/images/virgo.jpg";
            sr_ImagesUrl[eZodiacSign.Libra] = "https://www.astrology-zodiac-signs.com/images/libra.jpg";
            sr_ImagesUrl[eZodiacSign.Scorpio] = "https://www.astrology-zodiac-signs.com/images/scorpio.jpg";
            sr_ImagesUrl[eZodiacSign.Sagittarius] = "https://www.astrology-zodiac-signs.com/images/sagittarius.jpg";
            sr_ImagesUrl[eZodiacSign.Capricorn] = "https://www.astrology-zodiac-signs.com/images/capricorn.jpg";
        }

        private eZodiacSign pickMatchedSign()
        {
            Random random = new Random();
            int fateSelection = random.Next(0, Enum.GetNames(typeof(eZodiacSign)).Length);
            return (eZodiacSign)fateSelection;
        }
    }
}
