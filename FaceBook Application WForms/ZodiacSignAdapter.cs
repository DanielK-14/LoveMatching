using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI
{
    public class ZodiacSignAdapter
    {
        private ZodiacSign m_RealZodiacSign;

        public string PictureUrl {
            get
            {
                return m_RealZodiacSign.PictureUrl;
            }
         }

        public string Name {
            get
            {
                return Enum.GetName(typeof(ZodiacSign.eZodiacSign), m_RealZodiacSign.Sign);
            }
        }

        public ZodiacSignAdapter BestMatchedSign { get; private set; }

        private ZodiacSignAdapter(ZodiacSign i_RealZodiacSign)
        {
            m_RealZodiacSign = i_RealZodiacSign;
        }

        public ZodiacSignAdapter(string i_Birthday)
        {

            string[] dateFormat = i_Birthday.Split('/');
            int month = int.Parse(dateFormat[0]);
            int day = int.Parse(dateFormat[1]);

            m_RealZodiacSign = new ZodiacSign(month, day);
        }

        public void UpdateBestMatchedSign()
        {
            BestMatchedSign = new ZodiacSignAdapter(ZodiacSign.GetRandomSign());
        }
    }
}
