using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut {
    internal class Calculator {
        public static void Triple0(ref int x) {
            x *= 3;
        }
        public static void Triple1(int origin, out int result ) {
            result = origin * 3;
        }
    }

}
