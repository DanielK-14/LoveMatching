using System;
using System.Collections.Generic;

namespace Logic
{
    public class ZodiacSign
    {
        private static Dictionary<eZodiacSign, string> sr_ImagesUrl;

        public eZodiacSign Sign { get; private set; }

        public string PictureUrl { get; private set; }

        public static ZodiacSign GetRandomSign()
        {
            Random random = new Random();
            int fateSelection = random.Next(0, Enum.GetNames(typeof(eZodiacSign)).Length);
            eZodiacSign matchedSign = (eZodiacSign)fateSelection;
            return new ZodiacSign(matchedSign);
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
            Capricorn,
        }

        static ZodiacSign()
        {
            initZodiacSignsImagesUrlList();
        }

        public ZodiacSign(int i_Month, int i_Day)
        {
            initUserZodiacSign(i_Month, i_Day);
            PictureUrl = sr_ImagesUrl[Sign];
        }

        private ZodiacSign(eZodiacSign i_Sign)
        {
            Sign = i_Sign;
            PictureUrl = sr_ImagesUrl[Sign];
        }

        private static void initZodiacSignsImagesUrlList()
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

        private void initUserZodiacSign(int i_Month, int i_Day)
        {
            switch (i_Month)
            {
                case 1:
                    Sign = i_Day >= 20 ? eZodiacSign.Aquarius : eZodiacSign.Capricorn;
                    break;
                case 2:
                    Sign = i_Day >= 19 ? eZodiacSign.Pisces : eZodiacSign.Capricorn;
                    break;
                case 3:
                    Sign = i_Day >= 21 ? eZodiacSign.Aries : eZodiacSign.Pisces;
                    break;
                case 4:
                    Sign = i_Day >= 20 ? eZodiacSign.Taurus : eZodiacSign.Aries;
                    break;
                case 5:
                    Sign = i_Day >= 21 ? eZodiacSign.Gemini : eZodiacSign.Taurus;
                    break;
                case 6:
                    Sign = i_Day >= 21 ? eZodiacSign.Cancer : eZodiacSign.Gemini;
                    break;
                case 7:
                    Sign = i_Day >= 23 ? eZodiacSign.Leo : eZodiacSign.Cancer;
                    break;
                case 8:
                    Sign = i_Day >= 23 ? eZodiacSign.Virgo : eZodiacSign.Leo;
                    break;
                case 9:
                    Sign = i_Day >= 23 ? eZodiacSign.Libra : eZodiacSign.Virgo;
                    break;
                case 10:
                    Sign = i_Day >= 23 ? eZodiacSign.Scorpio : eZodiacSign.Libra;
                    break;
                case 11:
                    Sign = i_Day >= 22 ? eZodiacSign.Sagittarius : eZodiacSign.Scorpio;
                    break;
                case 12:
                    Sign = i_Day >= 22 ? eZodiacSign.Capricorn : eZodiacSign.Sagittarius;
                    break;
            }
        }
    }
}
