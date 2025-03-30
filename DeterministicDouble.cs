using System;

public struct DeterministicDouble : IEquatable<DeterministicDouble>, IComparable<DeterministicDouble>
{
    private double Value;

    private DeterministicDouble(double value)
    {
        Value = value;
    }

    public static implicit operator DeterministicDouble(double value)
    {
        return new DeterministicDouble(value);
    }

    public static implicit operator DeterministicDouble(float value)
    {
        return new DeterministicDouble(value);
    }

    public static implicit operator DeterministicDouble(decimal value)
    {
        return new DeterministicDouble((double)value);
    }

    public static implicit operator DeterministicDouble(int value)
    {
        return new DeterministicDouble(value);
    }

    public static implicit operator DeterministicDouble(long value)
    {
        return new DeterministicDouble(value);
    }

    public static explicit operator float(DeterministicDouble d)
    {
        return (float)d.Value;
    }

    public static explicit operator decimal(DeterministicDouble d)
    {
        return (decimal)d.Value;
    }

    public static explicit operator int(DeterministicDouble d)
    {
        return (int)d.Value;
    }

    public static explicit operator long(DeterministicDouble d)
    {
        return (long)d.Value;
    }

    public static implicit operator double(DeterministicDouble d)
    {
        return d.Value;
    }

    public static DeterministicDouble operator +(DeterministicDouble a, DeterministicDouble b)
    {
        return new DeterministicDouble(a.Value + b.Value);
    }

    public static DeterministicDouble operator -(DeterministicDouble a, DeterministicDouble b)
    {
        return new DeterministicDouble(a.Value - b.Value);
    }

    public static DeterministicDouble operator *(DeterministicDouble a, DeterministicDouble b)
    {
        return new DeterministicDouble(a.Value * b.Value);
    }

    public static DeterministicDouble operator /(DeterministicDouble a, DeterministicDouble b)
    {
        return new DeterministicDouble(a.Value / b.Value);
    }

    public static bool operator ==(DeterministicDouble a, DeterministicDouble b)
    {
        return Approximately(a, b);
    }

    public static bool operator !=(DeterministicDouble a, DeterministicDouble b)
    {
        return !Approximately(a, b);
    }

    // ========== 비교 연산자 오버로딩 ==========
    public static bool operator <(DeterministicDouble a, DeterministicDouble b)
    {
        return a.CompareTo(b) < 0;
    }

    public static bool operator >(DeterministicDouble a, DeterministicDouble b)
    {
        return a.CompareTo(b) > 0;
    }

    public static bool operator <=(DeterministicDouble a, DeterministicDouble b)
    {
        return a.CompareTo(b) <= 0;
    }

    public static bool operator >=(DeterministicDouble a, DeterministicDouble b)
    {
        return a.CompareTo(b) >= 0;
    }

    private static bool Approximately(DeterministicDouble a, DeterministicDouble b, double tolerance = 1e-9)
    {
        var max = Math.Max(1.0, Math.Max(Math.Abs(a.Value), Math.Abs(b.Value)));
        return Math.Abs(a.Value - b.Value) <= tolerance * max;
    }

    public DeterministicDouble Round(int digits)
    {
        return new DeterministicDouble(Math.Round(this.Value, digits));
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public override string ToString()
    {
        return Value.ToString();
    }

    public bool Equals(DeterministicDouble other)
    {
        return Approximately(this, other);
    }

    public int CompareTo(DeterministicDouble other)
    {
        return Approximately(this, other) ? 0 : Value.CompareTo(other.Value);
    }
}