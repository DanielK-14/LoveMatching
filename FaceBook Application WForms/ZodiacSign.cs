using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FaceBook_Application_WForms
{
    public class ZodiacSign
    {
        private List<string> m_ImagesUrl;

        public eZodiacSign UserSign { get; private set; }

        public eZodiacSign BestMatchedWithSign { get; private set; }

        public string UserPictureUrl { get; private set; }

        public string MatchPictureUrl { get; private set; }

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

        public ZodiacSign(string i_Birthday)
        {
            initZodiacSignsImagesUrlList();
            initUserZodiacSign(i_Birthday);
            setMatchedSign();
        }

        private void initUserZodiacSign(string i_Birthday)
        {
            string[] dateFormat = i_Birthday.Split('/');
            int month = int.Parse(dateFormat[0]);
            int day = int.Parse(dateFormat[1]);

            switch (month)
            {
                case 1:
                    UserSign = day >= 20 ? eZodiacSign.Aquarius : eZodiacSign.Capricorn;
                    break;
                case 2:
                    UserSign = day >= 19 ? eZodiacSign.Pisces : eZodiacSign.Capricorn;
                    break;
                case 3:
                    UserSign = day >= 21 ? eZodiacSign.Aries : eZodiacSign.Pisces;
                    break;
                case 4:
                    UserSign = day >= 20 ? eZodiacSign.Taurus : eZodiacSign.Aries;
                    break;
                case 5:
                    UserSign = day >= 21 ? eZodiacSign.Gemini : eZodiacSign.Taurus;
                    break;
                case 6:
                    UserSign = day >= 21 ? eZodiacSign.Cancer : eZodiacSign.Gemini;
                    break;
                case 7:
                    UserSign = day >= 23 ? eZodiacSign.Leo : eZodiacSign.Cancer;
                    break;
                case 8:
                    UserSign = day >= 23 ? eZodiacSign.Virgo : eZodiacSign.Leo;
                    break;
                case 9:
                    UserSign = day >= 23 ? eZodiacSign.Libra : eZodiacSign.Virgo;
                    break;
                case 10:
                    UserSign = day >= 23 ? eZodiacSign.Scorpio : eZodiacSign.Libra;
                    break;
                case 11:
                    UserSign = day >= 22 ? eZodiacSign.Sagittarius : eZodiacSign.Scorpio;
                    break;
                case 12:
                    UserSign = day >= 22 ? eZodiacSign.Capricorn : eZodiacSign.Sagittarius;
                    break;
            }

            UserPictureUrl = m_ImagesUrl[(int)UserSign];
        }

        private void initZodiacSignsImagesUrlList()
        {
            m_ImagesUrl = new List<string>();
            string url;
            for (int i = 0; i < Enum.GetNames(typeof(eZodiacSign)).Length; i++)
            {
                switch (UserSign)
                {
                    case eZodiacSign.Aquarius:
                        url = "https://www.astrology-zodiac-signs.com/images/aquarius.jpg";
                        break;
                    case eZodiacSign.Pisces:
                        url = "https://www.astrology-zodiac-signs.com/images/pisces.jpg";
                        break;
                    case eZodiacSign.Aries:
                        url = "https://www.astrology-zodiac-signs.com/images/aries.jpg";
                        break;
                    case eZodiacSign.Taurus:
                        url = "https://www.astrology-zodiac-signs.com/images/taurus.jpg";
                        break;
                    case eZodiacSign.Gemini:
                        url = "https://www.astrology-zodiac-signs.com/images/gemini.jpg";
                        break;
                    case eZodiacSign.Cancer:
                        url = "https://www.astrology-zodiac-signs.com/images/cancer.jpg";
                        break;
                    case eZodiacSign.Leo:
                        url = "https://www.astrology-zodiac-signs.com/images/leo.jpg";
                        break;
                    case eZodiacSign.Virgo:
                        url = "https://www.astrology-zodiac-signs.com/images/virgo.jpg";
                        break;
                    case eZodiacSign.Libra:
                        url = "https://www.astrology-zodiac-signs.com/images/libra.jpg";
                        break;
                    case eZodiacSign.Scorpio:
                        url = "https://www.astrology-zodiac-signs.com/images/scorpio.jpg";
                        break;
                    case eZodiacSign.Sagittarius:
                        url = "https://www.astrology-zodiac-signs.com/images/sagittarius.jpg";
                        break;
                    default:
                        url = "https://www.astrology-zodiac-signs.com/images/capricorn.jpg";
                        break;
                }

                m_ImagesUrl[i] = url;
            }
        }

        private void setMatchedSign()
        {
            Random random = new Random();
            int fateSelection = random.Next(0, Enum.GetNames(typeof(eZodiacSign)).Length);
            BestMatchedWithSign = (eZodiacSign)fateSelection;
            MatchPictureUrl = m_ImagesUrl[fateSelection];
        }
    }
}
