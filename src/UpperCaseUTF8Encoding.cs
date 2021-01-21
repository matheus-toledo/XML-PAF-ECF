using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraXML {
    class UpperCaseUTF8Encoding : UTF8Encoding {
        
        public override string WebName { get { return base.WebName.ToUpper(); } }

        public static UpperCaseUTF8Encoding UpperCaseUTF8{
            get {
                if (upperCaseUtf8Encoding == null) {
                    upperCaseUtf8Encoding = new UpperCaseUTF8Encoding();
                }
                return upperCaseUtf8Encoding;
            }
        }
        private static UpperCaseUTF8Encoding upperCaseUtf8Encoding = null;
    }
}
