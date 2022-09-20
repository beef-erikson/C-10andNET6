// See https://aka.ms/new-console-template for more information

using static System.Console;

WriteLine("---------------------------------------------------------------------------------------------");
WriteLine($"{"Type",0} {"Byte(s) of Memory",26} {"Min",30} {"Max",30}");
WriteLine("---------------------------------------------------------------------------------------------");
WriteLine($"{"sbyte",0} {sizeof(sbyte),9} {sbyte.MinValue,46} {sbyte.MaxValue,30}");
WriteLine($"{"byte",0} {sizeof(byte),10} {byte.MinValue,46} {byte.MaxValue,30}");
WriteLine($"{"short",0} {sizeof(short),9} {short.MinValue,46} {short.MaxValue,30}");
WriteLine($"{"ushort",0} {sizeof(ushort),8} {ushort.MinValue,46} {ushort.MaxValue,30}");
WriteLine($"{"int",0} {sizeof(int),11} {int.MinValue,46} {int.MaxValue,30}");
WriteLine($"{"uint",0} {sizeof(uint),10} {uint.MinValue,46} {uint.MaxValue,30}");
WriteLine($"{"long",0} {sizeof(long),10} {long.MinValue,46} {long.MaxValue,30}");
WriteLine($"{"ulong",0} {sizeof(ulong),9} {ulong.MinValue,46} {ulong.MaxValue,30}");
WriteLine($"{"float",0} {sizeof(float),9} {float.MinValue,46} {float.MaxValue,30}");
WriteLine($"{"double",0} {sizeof(double),8} {double.MinValue,46} {double.MaxValue,30}");
WriteLine($"{"decimal",0} {sizeof(decimal),8} {decimal.MinValue,45} {decimal.MaxValue,30}");