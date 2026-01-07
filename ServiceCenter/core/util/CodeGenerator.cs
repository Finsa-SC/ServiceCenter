using ServiceCenter.core.network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.core.util
{
    internal class CodeGenerator
    {
        public static string codeGenerator(string prefix, string query)
        {
            var code = DBHelper.executeScalar(query);
            if (code == DBNull.Value || code is null || code == null) return prefix + 0001;
            string stringCode = code.ToString();
            string lastCode = stringCode.Replace(prefix, "");
            int number = int.Parse(lastCode);
            number++;
            return prefix+number;
        }
    }
}
