using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace שאלה_מה_בגרות
{
    class pixel
    {
        private int red; //צבע אדום
        private int green;//צבע ירוק
        private int blue;// צבע כחול
        public pixel()
        {
            this.red = 0;
            this.green = 0;
            this.blue = 0;
        }
        public pixel(int red, int green, int blue)
        {
            if(red>=0&& red<=255&& green>=0 && green <= 255&& blue>=0 && blue <= 255)
            { 
                this.red = red;
                this.green = green;
                this.blue = blue;
            }
            else
            {
                this.red = 0;
                this.green = 0;
                this.blue = 0;
            }
        }
        public void Mix(pixel pxl)
        {
            this.red = (this.red + pxl.red)/2;
            this.green = (this.green + pxl.green)/2;
            this.blue = (this.blue + pxl.blue)/2;
        }




    }
}
