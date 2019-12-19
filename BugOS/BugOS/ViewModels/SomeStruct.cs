using System;

namespace BugOS.ViewModels
{
    public struct SomeStruct
    {
        private readonly byte[] m_Data;

        public SomeStruct(byte[] Data)
        {
            this.m_Data = Data;
        }

        public UInt32 Value
        {
            get
            {
                //redacted
                return 0;
            }
        }

        // This one
        public static implicit operator UInt32(SomeStruct Left)
        {
            return Left.Value;
        }

        // and this one.
        public static implicit operator Int64(SomeStruct Left)
        {
            return Convert.ToInt64(Left.Value);
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }

        public new string ToString(string Format)
        {
            return this.Value.ToString(Format);
        }

        public new string ToString(IFormatProvider FormatProvider)
        {
            return this.Value.ToString(null, FormatProvider);
        }

        public new string ToString(string Format, IFormatProvider FormatProvider)
        {
            return this.Value.ToString(Format, FormatProvider);
        }
    }
}