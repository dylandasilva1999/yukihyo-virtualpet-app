using System;
using System.Collections.Generic;
using System.Text;

namespace yukihyo.Objects
{
    public class Yukihyo
    {
        const string yukihyoNameKey = "yukihyoName";

        /*Yukihyo Name Function*/
        public string YukihyoName
        {
            get
            {
                if(App.Current.Properties.ContainsKey(yukihyoNameKey))
                {
                    return (string)App.Current.Properties[yukihyoNameKey];                
                } 
                else
                {
                    return "There is no name";
                }
            }
            set
            {
                App.Current.Properties[yukihyoNameKey] = value;
            }
        }
    }
}
