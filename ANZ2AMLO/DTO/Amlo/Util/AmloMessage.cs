using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Util
{
    public class ActionConfirm
    {
        string vValue = "";
        private ActionConfirm(string value)
        { 
            Value=value;
        }

        public string Value { get { return vValue; } set { vValue = value; } }
        public static ActionConfirm Add { get { return new ActionConfirm("Do you want do Add?."); } }
        public static ActionConfirm Update { get { return new ActionConfirm("Do you want do Update?."); } }
        public static ActionConfirm Delete { get { return new ActionConfirm("Do you want do Delete?."); } }
        
    }

    public class ActionDone
    {
        string vValue = "";
        private ActionDone(string value)
        {
            Value = value;
        }

        public string Value { get { return vValue; } set { vValue = value; } }
        public static ActionDone Add { get { return new ActionDone("Add data successfully?."); } }
        public static ActionDone Update { get { return new ActionDone("Update data successfully?."); } }
        public static ActionDone Delete { get { return new ActionDone("Delete data successfully?."); } }

    }


}
