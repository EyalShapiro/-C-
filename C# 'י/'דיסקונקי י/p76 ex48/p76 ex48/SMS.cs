using System;
using System.Collections.Generic;
using System.Text;

namespace p76_ex48
{
    class SMS
    {

        private string moral_phone_num;
        private string recipient_phone_num;
        private string content_message;



        public SMS(string moral_phone_num, string recipient_phone_num, string content_message)
        {
            this.moral_phone_num = moral_phone_num;
            this.recipient_phone_num = recipient_phone_num;
            this.content_message = content_message;
        }

        public string GetMoral_phone_num()
        {
            return this.moral_phone_num;
        }
        public string GetRecipient_phone_num()
        {
            return this.recipient_phone_num;
        }
        public string GetContent_message()
        {
            return this.content_message;
        }

        public void SetMoral_phone_num(string moral_phone_numToSet)
        {
            this.moral_phone_num= moral_phone_numToSet;
        }
        public void SetRecipient_phone_num(string recipient_phone_numToSet)
        {
            this.recipient_phone_num = recipient_phone_numToSet;
        }

        public void SetContent_message(string content_messageToSet)
        {
            this.content_message = content_messageToSet;
        }
        public bool CompareTo(SMS other)
        {
            if (this.content_message!=other.content_message&&this.moral_phone_num==other.recipient_phone_num&& other.moral_phone_num == this.recipient_phone_num)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public override string ToString()
        {
            return this.moral_phone_num+ "-" + this.recipient_phone_num + "-" + this.content_message;
        }

    }
}
