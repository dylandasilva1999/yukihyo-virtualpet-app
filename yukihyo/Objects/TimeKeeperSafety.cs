using System;
using System.Collections.Generic;
using System.Text;

namespace yukihyo.Objects
{
    public class TimeKeeperSafety
    {
        const string startTimeKey = "startSafetyTime";
        const string storedTimeKey = "storedSafetyTime";

        public DateTime StartTime
        {
            get
            {
                if (App.Current.Properties.ContainsKey(startTimeKey))
                {
                    return new DateTime((long)App.Current.Properties[startTimeKey]);
                }
                else
                {
                    return DateTime.Now;
                }
            }
            set
            {
                App.Current.Properties[startTimeKey] = value.Ticks;
            }
        }

        public DateTime StoredTime
        {
            get
            {
                if (App.Current.Properties.ContainsKey(storedTimeKey))
                {
                    return new DateTime((long)App.Current.Properties[storedTimeKey]);
                }
                else
                {
                    return DateTime.Now;
                }
            }
            set
            {
                App.Current.Properties[storedTimeKey] = value.Ticks;
            }
        }

        public TimeKeeperSafety()
        {

        }

        public double GetTimeElapsed()
        {
            return (StoredTime - StartTime).TotalSeconds;
        }
    }
}
