using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
using System.ComponentModel;
using System.Numerics;

namespace Neo.SmartContract
{
    /**
     * Calculator
     *
     * @author Minge
     * @email luchuan@ngd.neo.org
     * @date 2019/1/3
     */
    public class Calculator : Framework.SmartContract
    {
        [DisplayName("resultEvent")]
        public static event Action<BigInteger, BigInteger, BigInteger> resultEvent;

        public static Object Main(string operation, params object[] args)
        {
            if (Runtime.Trigger == TriggerType.Application)
            {
                if (operation == "add")
                {
                    if (args.Length != 2) return false;
                    BigInteger a = (BigInteger)args[0];
                    BigInteger b = (BigInteger)args[1];
                    BigInteger c =  a + b;
                    resultEvent(a, b, c);
                    return c;
                }
                if (operation == "sub")
                {
                    if (args.Length != 2) return false;
                    BigInteger a = (BigInteger)args[0];
                    BigInteger b = (BigInteger)args[1];
                    BigInteger c = a - b;
                    resultEvent(a, b, c);
                    return c;
                }
                if (operation == "multi")
                {
                    if (args.Length != 2) return false;
                    BigInteger a = (BigInteger)args[0];
                    BigInteger b = (BigInteger)args[1];
                    BigInteger c = a * b;
                    resultEvent(a, b, c);
                    return c;
                }
                if (operation == "div")
                {
                    if (args.Length != 2) return false;
                    BigInteger a = (BigInteger)args[0];
                    BigInteger b = (BigInteger)args[1];
                    BigInteger c = a / b;
                    resultEvent(a, b, c);
                    return c;
                }
            }
            return true;
        }
    }
}
