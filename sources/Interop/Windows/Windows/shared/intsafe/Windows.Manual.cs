// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/intsafe.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public static System.Int128 INT128_MIN => System.Int128.MinValue;

    public static System.Int128 INT128_MAX => System.Int128.MaxValue;

    public static System.UInt128 UINT128_MAX => System.UInt128.MaxValue;

    private static ulong _umul128(ulong multiplicand, ulong multiplier, ulong* highProduct)
    {
        System.UInt128 product = (System.UInt128)multiplicand * multiplier;
        *highProduct = (ulong)(product >> 64);
        return unchecked((ulong)product);
    }

    private static HRESULT SignedToUIntPtr(long operand, nuint* result)
    {
        if (operand >= 0)
        {
            *result = (nuint)operand;
            return (HRESULT)(0);
        }

        *result = nuint.MaxValue;
        return (HRESULT)(INTSAFE_E_ARITHMETIC_OVERFLOW);
    }

    private static HRESULT UnsignedToIntPtr(nuint operand, nint* result)
    {
        if (operand <= (nuint)nint.MaxValue)
        {
            *result = (nint)operand;
            return (HRESULT)(0);
        }

        *result = (nint)(-1);
        return (HRESULT)(INTSAFE_E_ARITHMETIC_OVERFLOW);
    }

    private static HRESULT LongLongToIntPtrCore(long operand, nint* result)
    {
        if ((operand >= (long)nint.MinValue) && (operand <= (long)nint.MaxValue))
        {
            *result = (nint)operand;
            return (HRESULT)(0);
        }

        *result = (nint)(-1);
        return (HRESULT)(INTSAFE_E_ARITHMETIC_OVERFLOW);
    }

    private static HRESULT ULongLongToUIntPtrCore(ulong operand, nuint* result)
    {
        if (operand <= (ulong)nuint.MaxValue)
        {
            *result = (nuint)operand;
            return (HRESULT)(0);
        }

        *result = nuint.MaxValue;
        return (HRESULT)(INTSAFE_E_ARITHMETIC_OVERFLOW);
    }

    private static HRESULT ULongLongToLongPtrCore(ulong operand, nint* result)
    {
        if (operand <= (ulong)nint.MaxValue)
        {
            *result = (nint)operand;
            return (HRESULT)(0);
        }

        *result = (nint)(-1);
        return (HRESULT)(INTSAFE_E_ARITHMETIC_OVERFLOW);
    }

    [return: NativeTypeName("DWORD")]
    public static uint LODWORD([NativeTypeName("DWORDLONG")] ulong value) => unchecked((uint)value);

    [return: NativeTypeName("DWORD")]
    public static uint HIDWORD([NativeTypeName("DWORDLONG")] ulong value) => (uint)(value >> 32);

    public static bool IsEqualLocaleName([NativeTypeName("PCWSTR")] char* localeName1, [NativeTypeName("PCWSTR")] char* localeName2)
    {
        if (localeName1 == localeName2)
        {
            return true;
        }

        if ((localeName1 == null) || (localeName2 == null))
        {
            return false;
        }

        while ((*localeName1 != '\0') && (*localeName2 != '\0'))
        {
            if (char.ToUpperInvariant(*localeName1) != char.ToUpperInvariant(*localeName2))
            {
                return false;
            }

            localeName1++;
            localeName2++;
        }

        return *localeName1 == *localeName2;
    }

    public static bool IsEqualDevPropKey(DEVPROPKEY a, DEVPROPKEY b) => a == b;

    public static bool IsEqualDevPropCompKey(DEVPROPCOMPKEY a, DEVPROPCOMPKEY b) => a == b;

    public static HRESULT Int8ToUIntPtr([NativeTypeName("INT8")] sbyte i8Operand, [NativeTypeName("UINT_PTR *")] nuint* puResult)
        => SignedToUIntPtr(i8Operand, puResult);

    public static HRESULT Int8ToULongPtr([NativeTypeName("INT8")] sbyte i8Operand, [NativeTypeName("ULONG_PTR *")] nuint* pulResult)
        => SignedToUIntPtr(i8Operand, pulResult);

    public static HRESULT ShortToUIntPtr([NativeTypeName("SHORT")] short sOperand, [NativeTypeName("UINT_PTR *")] nuint* puResult)
        => SignedToUIntPtr(sOperand, puResult);

    public static HRESULT ShortToULongPtr([NativeTypeName("SHORT")] short sOperand, [NativeTypeName("ULONG_PTR *")] nuint* pulResult)
        => SignedToUIntPtr(sOperand, pulResult);

    public static HRESULT ShortToDWordPtr([NativeTypeName("SHORT")] short sOperand, [NativeTypeName("DWORD_PTR *")] nuint* pdwResult)
        => SignedToUIntPtr(sOperand, pdwResult);

    public static HRESULT UIntToIntPtr([NativeTypeName("UINT")] uint uOperand, [NativeTypeName("INT_PTR *")] nint* piResult)
        => UnsignedToIntPtr((nuint)uOperand, piResult);

    public static HRESULT UIntToLongPtr([NativeTypeName("UINT")] uint uOperand, [NativeTypeName("LONG_PTR *")] nint* plResult)
        => UnsignedToIntPtr((nuint)uOperand, plResult);

    public static HRESULT UIntPtrToIntPtr([NativeTypeName("UINT_PTR")] nuint uOperand, [NativeTypeName("INT_PTR *")] nint* piResult)
        => UnsignedToIntPtr(uOperand, piResult);

    public static HRESULT UIntPtrToLongPtr([NativeTypeName("UINT_PTR")] nuint uOperand, [NativeTypeName("LONG_PTR *")] nint* plResult)
        => UnsignedToIntPtr(uOperand, plResult);

    public static HRESULT LongToUIntPtr([NativeTypeName("LONG")] int lOperand, [NativeTypeName("UINT_PTR *")] nuint* puResult)
        => SignedToUIntPtr(lOperand, puResult);

    public static HRESULT LongToULongPtr([NativeTypeName("LONG")] int lOperand, [NativeTypeName("ULONG_PTR *")] nuint* pulResult)
        => SignedToUIntPtr(lOperand, pulResult);

    public static HRESULT LongPtrToUIntPtr([NativeTypeName("LONG_PTR")] nint lOperand, [NativeTypeName("UINT_PTR *")] nuint* puResult)
        => SignedToUIntPtr(lOperand, puResult);

    public static HRESULT LongPtrToULongPtr([NativeTypeName("LONG_PTR")] nint lOperand, [NativeTypeName("ULONG_PTR *")] nuint* pulResult)
        => SignedToUIntPtr(lOperand, pulResult);

    public static HRESULT ULongPtrToIntPtr([NativeTypeName("ULONG_PTR")] nuint ulOperand, [NativeTypeName("INT_PTR *")] nint* piResult)
        => UnsignedToIntPtr(ulOperand, piResult);

    public static HRESULT ULongPtrToLongPtr([NativeTypeName("ULONG_PTR")] nuint ulOperand, [NativeTypeName("LONG_PTR *")] nint* plResult)
        => UnsignedToIntPtr(ulOperand, plResult);

    public static HRESULT LongLongToIntPtr([NativeTypeName("LONGLONG")] long llOperand, [NativeTypeName("INT_PTR *")] nint* piResult)
        => LongLongToIntPtrCore(llOperand, piResult);

    public static HRESULT ULongLongToUIntPtr([NativeTypeName("ULONGLONG")] ulong ullOperand, [NativeTypeName("UINT_PTR *")] nuint* puResult)
        => ULongLongToUIntPtrCore(ullOperand, puResult);

    public static HRESULT ULongLongToLongPtr([NativeTypeName("ULONGLONG")] ulong ullOperand, [NativeTypeName("LONG_PTR *")] nint* plResult)
        => ULongLongToLongPtrCore(ullOperand, plResult);

    public static HRESULT ULongLongToULongPtr([NativeTypeName("ULONGLONG")] ulong ullOperand, [NativeTypeName("ULONG_PTR *")] nuint* pulResult)
        => ULongLongToUIntPtrCore(ullOperand, pulResult);

    public static HRESULT SizeTAdd([NativeTypeName("size_t")] nuint Augend, [NativeTypeName("size_t")] nuint Addend, [NativeTypeName("size_t *")] nuint* pResult)
    {
        nuint result = unchecked(Augend + Addend);

        if (result >= Augend)
        {
            *pResult = result;
            return (HRESULT)(0);
        }

        *pResult = nuint.MaxValue;
        return (HRESULT)(INTSAFE_E_ARITHMETIC_OVERFLOW);
    }

    public static HRESULT SizeTSub([NativeTypeName("size_t")] nuint Minuend, [NativeTypeName("size_t")] nuint Subtrahend, [NativeTypeName("size_t *")] nuint* pResult)
    {
        if (Minuend >= Subtrahend)
        {
            *pResult = Minuend - Subtrahend;
            return (HRESULT)(0);
        }

        *pResult = nuint.MaxValue;
        return (HRESULT)(INTSAFE_E_ARITHMETIC_OVERFLOW);
    }

    public static nint INT_PTR_MIN => nint.MinValue;

    public static nint LONG_PTR_MIN => nint.MinValue;

    public static nint PTRDIFF_T_MIN => nint.MinValue;

    public static nint SSIZE_T_MIN => nint.MinValue;

    public static nint INT_PTR_MAX => nint.MaxValue;

    public static nuint UINT_PTR_MAX => nuint.MaxValue;

    public static nint LONG_PTR_MAX => nint.MaxValue;

    public static nuint ULONG_PTR_MAX => nuint.MaxValue;

    public static nuint DWORD_PTR_MAX => nuint.MaxValue;

    public static nint PTRDIFF_T_MAX => nint.MaxValue;

    public static nuint SIZE_T_MAX => nuint.MaxValue;

    public static nint SSIZE_T_MAX => nint.MaxValue;

    public static nuint _SIZE_T_MAX => nuint.MaxValue;

    public static nint INT_PTR_ERROR => (-1);

    public static nuint UINT_PTR_ERROR => nuint.MaxValue;

    public static nint LONG_PTR_ERROR => (-1);

    public static nuint ULONG_PTR_ERROR => nuint.MaxValue;

    public static nuint DWORD_PTR_ERROR => nuint.MaxValue;

    public static nint PTRDIFF_T_ERROR => (-1);

    public static nuint SIZE_T_ERROR => nuint.MaxValue;

    public static nint SSIZE_T_ERROR => (-1);

    public static nuint _SIZE_T_ERROR => nuint.MaxValue;
}
