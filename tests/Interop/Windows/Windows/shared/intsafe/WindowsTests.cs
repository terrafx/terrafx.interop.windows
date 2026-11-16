// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/intsafe.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
public static unsafe partial class WindowsTests
{
    private const int IntSafeError = unchecked((int)0x80070216);

    /// <summary>Validates signed conversions to native unsigned pointer types.</summary>
    [Test]
    public static void IntSafeSignedToNativeUnsignedTest()
    {
        nuint result = 0;

        Assert.That((int)Int8ToUIntPtr(-1, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo(nuint.MaxValue));
        Assert.That((int)Int8ToULongPtr(-1, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo(nuint.MaxValue));
        Assert.That((int)ShortToUIntPtr(-1, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo(nuint.MaxValue));
        Assert.That((int)ShortToULongPtr(-1, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo(nuint.MaxValue));
        Assert.That((int)ShortToDWordPtr(-1, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo(nuint.MaxValue));
        Assert.That((int)LongToUIntPtr(-1, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo(nuint.MaxValue));
        Assert.That((int)LongToULongPtr(-1, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo(nuint.MaxValue));
        Assert.That((int)LongPtrToUIntPtr(-1, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo(nuint.MaxValue));
        Assert.That((int)LongPtrToULongPtr(-1, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo(nuint.MaxValue));

        Assert.That((int)LongToUIntPtr(1, &result), Is.EqualTo(0));
        Assert.That(result, Is.EqualTo((nuint)1));
        Assert.That((int)LongPtrToULongPtr(1, &result), Is.EqualTo(0));
        Assert.That(result, Is.EqualTo((nuint)1));
    }

    /// <summary>Validates unsigned conversions to native signed pointer types.</summary>
    [Test]
    public static void IntSafeUnsignedToNativeSignedTest()
    {
        nint result = 0;

        Assert.That((int)UIntPtrToIntPtr(nuint.MaxValue, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo((nint)(-1)));
        Assert.That((int)UIntPtrToLongPtr(nuint.MaxValue, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo((nint)(-1)));
        Assert.That((int)ULongPtrToIntPtr(nuint.MaxValue, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo((nint)(-1)));
        Assert.That((int)ULongPtrToLongPtr(nuint.MaxValue, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo((nint)(-1)));

        HRESULT hr = UIntToIntPtr(uint.MaxValue, &result);
        if (System.IntPtr.Size == 8)
        {
            Assert.That((int)hr, Is.EqualTo(0));
            Assert.That(result, Is.EqualTo(unchecked((nint)uint.MaxValue)));
        }
        else
        {
            Assert.That((int)hr, Is.EqualTo(IntSafeError));
            Assert.That(result, Is.EqualTo((nint)(-1)));
        }

        hr = UIntToLongPtr(uint.MaxValue, &result);
        if (System.IntPtr.Size == 8)
        {
            Assert.That((int)hr, Is.EqualTo(0));
            Assert.That(result, Is.EqualTo(unchecked((nint)uint.MaxValue)));
        }
        else
        {
            Assert.That((int)hr, Is.EqualTo(IntSafeError));
            Assert.That(result, Is.EqualTo((nint)(-1)));
        }
    }

    /// <summary>Validates conversions between 64-bit integers and native pointer types.</summary>
    [Test]
    public static void IntSafeInt64ToNativePointerTest()
    {
        nint signedResult = 0;
        HRESULT hr = LongLongToIntPtr(long.MinValue, &signedResult);

        if (System.IntPtr.Size == 8)
        {
            Assert.That((int)hr, Is.EqualTo(0));
            Assert.That(signedResult, Is.EqualTo(unchecked((nint)long.MinValue)));
            Assert.That((int)LongLongToIntPtr(long.MaxValue, &signedResult), Is.EqualTo(0));
            Assert.That(signedResult, Is.EqualTo(unchecked((nint)long.MaxValue)));
        }
        else
        {
            Assert.That((int)hr, Is.EqualTo(IntSafeError));
            Assert.That(signedResult, Is.EqualTo((nint)(-1)));
        }

        nuint unsignedResult = 0;
        hr = ULongLongToUIntPtr(ulong.MaxValue, &unsignedResult);

        if (System.IntPtr.Size == 8)
        {
            Assert.That((int)hr, Is.EqualTo(0));
            Assert.That(unsignedResult, Is.EqualTo(nuint.MaxValue));
            Assert.That((int)ULongLongToULongPtr(ulong.MaxValue, &unsignedResult), Is.EqualTo(0));
            Assert.That(unsignedResult, Is.EqualTo(nuint.MaxValue));
        }
        else
        {
            Assert.That((int)hr, Is.EqualTo(IntSafeError));
            Assert.That(unsignedResult, Is.EqualTo(nuint.MaxValue));
        }

        Assert.That((int)ULongLongToLongPtr(ulong.MaxValue, &signedResult), Is.EqualTo(IntSafeError));
        Assert.That(signedResult, Is.EqualTo((nint)(-1)));
    }

    /// <summary>Validates native-size arithmetic overflow handling.</summary>
    [Test]
    public static void IntSafeSizeTArithmeticTest()
    {
        nuint result = 0;

        Assert.That((int)SizeTAdd(nuint.MaxValue, 1, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo(nuint.MaxValue));
        Assert.That((int)SizeTAdd(1, 2, &result), Is.EqualTo(0));
        Assert.That(result, Is.EqualTo((nuint)3));

        Assert.That((int)SizeTSub(0, 1, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo(nuint.MaxValue));
        Assert.That((int)SizeTSub(3, 1, &result), Is.EqualTo(0));
        Assert.That(result, Is.EqualTo((nuint)2));
    }

    /// <summary>Validates the generated 64-bit multiplication binding.</summary>
    [Test]
    public static void IntSafeULongLongMultTest()
    {
        ulong result = 0;

        Assert.That((int)ULongLongMult(ulong.MaxValue, 2, &result), Is.EqualTo(IntSafeError));
        Assert.That(result, Is.EqualTo(ulong.MaxValue));
        Assert.That((int)ULongLongMult(ulong.MaxValue, 1, &result), Is.EqualTo(0));
        Assert.That(result, Is.EqualTo(ulong.MaxValue));
    }

    /// <summary>Validates the manually ported 128-bit limits.</summary>
    [Test]
    public static void IntSafeInt128LimitsTest()
    {
        Assert.That(INT128_MIN, Is.EqualTo(System.Int128.MinValue));
        Assert.That(INT128_MAX, Is.EqualTo(System.Int128.MaxValue));
        Assert.That(UINT128_MAX, Is.EqualTo(System.UInt128.MaxValue));
    }

    /// <summary>Validates the low- and high-word extraction macros.</summary>
    [Test]
    public static void IntSafeWordExtractionTest()
    {
        const ulong value = 0x0123456789abcdef;

        Assert.That(LODWORD(value), Is.EqualTo(0x89abcdefu));
        Assert.That(HIDWORD(value), Is.EqualTo(0x01234567u));
    }
}
