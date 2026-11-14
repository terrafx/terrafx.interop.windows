// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/intsafe.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToUChar"]/*' />
    public static HRESULT Int8ToUChar([NativeTypeName("INT8")] sbyte i8Operand, [NativeTypeName("UCHAR *")] byte* pch)
    {
        HRESULT hr;

        if (i8Operand >= 0)
        {
            *pch = (byte)(i8Operand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pch = (byte)('\0');
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToUInt8"]/*' />
    public static HRESULT Int8ToUInt8([NativeTypeName("INT8")] sbyte i8Operand, [NativeTypeName("UINT8 *")] byte* pu8Result)
    {
        HRESULT hr;

        if (i8Operand >= 0)
        {
            *pu8Result = (byte)(i8Operand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pu8Result = unchecked(0xff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToUShort"]/*' />
    public static HRESULT Int8ToUShort([NativeTypeName("INT8")] sbyte i8Operand, ushort* pusResult)
    {
        HRESULT hr;

        if (i8Operand >= 0)
        {
            *pusResult = (ushort)(i8Operand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pusResult = 0xffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToUInt"]/*' />
    public static HRESULT Int8ToUInt([NativeTypeName("INT8")] sbyte i8Operand, uint* puResult)
    {
        HRESULT hr;

        if (i8Operand >= 0)
        {
            *puResult = (uint)(i8Operand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *puResult = 0xffffffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToULong"]/*' />
    public static HRESULT Int8ToULong([NativeTypeName("INT8")] sbyte i8Operand, [NativeTypeName("ULONG *")] uint* pulResult)
    {
        HRESULT hr;

        if (i8Operand >= 0)
        {
            *pulResult = (uint)(i8Operand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pulResult = 0xffffffffU;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToULongLong"]/*' />
    public static HRESULT Int8ToULongLong([NativeTypeName("INT8")] sbyte i8Operand, [NativeTypeName("ULONGLONG *")] ulong* pullResult)
    {
        HRESULT hr;

        if (i8Operand >= 0)
        {
            *pullResult = (ulong)(i8Operand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pullResult = 0xffffffffffffffffUL;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt8ToInt8"]/*' />
    public static HRESULT UInt8ToInt8([NativeTypeName("UINT8")] byte u8Operand, [NativeTypeName("INT8 *")] sbyte* pi8Result)
    {
        HRESULT hr;

        if (u8Operand <= 127)
        {
            *pi8Result = (sbyte)(u8Operand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pi8Result = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt8ToChar"]/*' />
    public static HRESULT UInt8ToChar([NativeTypeName("UINT8")] byte u8Operand, [NativeTypeName("CHAR *")] sbyte* pch)
    {
        return UInt8ToInt8(u8Operand, unchecked((sbyte*)(pch)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ByteToInt8"]/*' />
    public static HRESULT ByteToInt8(byte bOperand, [NativeTypeName("INT8 *")] sbyte* pi8Result)
    {
        HRESULT hr;

        if (bOperand <= 127)
        {
            *pi8Result = (sbyte)(bOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pi8Result = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ByteToChar"]/*' />
    public static HRESULT ByteToChar(byte bOperand, [NativeTypeName("CHAR *")] sbyte* pch)
    {
        return ByteToInt8(bOperand, unchecked((sbyte*)(pch)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToInt8"]/*' />
    public static HRESULT ShortToInt8(short sOperand, [NativeTypeName("INT8 *")] sbyte* pi8Result)
    {
        HRESULT hr;

        if ((sOperand >= (-127 - 1)) && (sOperand <= 127))
        {
            *pi8Result = (sbyte)(sOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pi8Result = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToUChar"]/*' />
    public static HRESULT ShortToUChar(short sOperand, [NativeTypeName("UCHAR *")] byte* pch)
    {
        HRESULT hr;

        if ((sOperand >= 0) && (sOperand <= 255))
        {
            *pch = (byte)(sOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pch = (byte)('\0');
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToChar"]/*' />
    public static HRESULT ShortToChar(short sOperand, [NativeTypeName("CHAR *")] sbyte* pch)
    {
        return ShortToInt8(sOperand, unchecked((sbyte*)(pch)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToUInt8"]/*' />
    public static HRESULT ShortToUInt8(short sOperand, [NativeTypeName("UINT8 *")] byte* pui8Result)
    {
        HRESULT hr;

        if ((sOperand >= 0) && (sOperand <= 0xff))
        {
            *pui8Result = (byte)(sOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pui8Result = unchecked(0xff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToUShort"]/*' />
    public static HRESULT ShortToUShort(short sOperand, ushort* pusResult)
    {
        HRESULT hr;

        if (sOperand >= 0)
        {
            *pusResult = (ushort)(sOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pusResult = 0xffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToUInt"]/*' />
    public static HRESULT ShortToUInt(short sOperand, uint* puResult)
    {
        HRESULT hr;

        if (sOperand >= 0)
        {
            *puResult = (uint)(sOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *puResult = 0xffffffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToULong"]/*' />
    public static HRESULT ShortToULong(short sOperand, [NativeTypeName("ULONG *")] uint* pulResult)
    {
        HRESULT hr;

        if (sOperand >= 0)
        {
            *pulResult = (uint)(sOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pulResult = 0xffffffffU;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToULongLong"]/*' />
    public static HRESULT ShortToULongLong(short sOperand, [NativeTypeName("ULONGLONG *")] ulong* pullResult)
    {
        HRESULT hr;

        if (sOperand >= 0)
        {
            *pullResult = (ulong)(sOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pullResult = 0xffffffffffffffffUL;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UShortToInt8"]/*' />
    public static HRESULT UShortToInt8(ushort usOperand, [NativeTypeName("INT8 *")] sbyte* pi8Result)
    {
        HRESULT hr;

        if (usOperand <= 127)
        {
            *pi8Result = (sbyte)(usOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pi8Result = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UShortToUChar"]/*' />
    public static HRESULT UShortToUChar(ushort usOperand, [NativeTypeName("UCHAR *")] byte* pch)
    {
        HRESULT hr;

        if (usOperand <= 255)
        {
            *pch = (byte)(usOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pch = (byte)('\0');
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UShortToChar"]/*' />
    public static HRESULT UShortToChar(ushort usOperand, [NativeTypeName("CHAR *")] sbyte* pch)
    {
        return UShortToInt8(usOperand, unchecked((sbyte*)(pch)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UShortToUInt8"]/*' />
    public static HRESULT UShortToUInt8(ushort usOperand, [NativeTypeName("UINT8 *")] byte* pui8Result)
    {
        HRESULT hr;

        if (usOperand <= 0xff)
        {
            *pui8Result = (byte)(usOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pui8Result = unchecked(0xff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UShortToShort"]/*' />
    public static HRESULT UShortToShort(ushort usOperand, short* psResult)
    {
        HRESULT hr;

        if (usOperand <= 32767)
        {
            *psResult = (short)(usOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *psResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToInt8"]/*' />
    public static HRESULT IntToInt8(int iOperand, [NativeTypeName("INT8 *")] sbyte* pi8Result)
    {
        HRESULT hr;

        if ((iOperand >= (-127 - 1)) && (iOperand <= 127))
        {
            *pi8Result = (sbyte)(iOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pi8Result = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToUChar"]/*' />
    public static HRESULT IntToUChar(int iOperand, [NativeTypeName("UCHAR *")] byte* pch)
    {
        HRESULT hr;

        if ((iOperand >= 0) && (iOperand <= 255))
        {
            *pch = (byte)(iOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pch = (byte)('\0');
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToChar"]/*' />
    public static HRESULT IntToChar(int iOperand, [NativeTypeName("CHAR *")] sbyte* pch)
    {
        return IntToInt8(iOperand, unchecked((sbyte*)(pch)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToUInt8"]/*' />
    public static HRESULT IntToUInt8(int iOperand, [NativeTypeName("UINT8 *")] byte* pui8Result)
    {
        HRESULT hr;

        if ((iOperand >= 0) && (iOperand <= 0xff))
        {
            *pui8Result = (byte)(iOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pui8Result = unchecked(0xff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToShort"]/*' />
    public static HRESULT IntToShort(int iOperand, short* psResult)
    {
        HRESULT hr;

        if ((iOperand >= (-32768)) && (iOperand <= 32767))
        {
            *psResult = (short)(iOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *psResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToUShort"]/*' />
    public static HRESULT IntToUShort(int iOperand, ushort* pusResult)
    {
        HRESULT hr;

        if ((iOperand >= 0) && (iOperand <= 0xffff))
        {
            *pusResult = (ushort)(iOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pusResult = 0xffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToUInt"]/*' />
    public static HRESULT IntToUInt(int iOperand, uint* puResult)
    {
        HRESULT hr;

        if (iOperand >= 0)
        {
            *puResult = (uint)(iOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *puResult = 0xffffffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToULong"]/*' />
    public static HRESULT IntToULong(int iOperand, [NativeTypeName("ULONG *")] uint* pulResult)
    {
        HRESULT hr;

        if (iOperand >= 0)
        {
            *pulResult = (uint)(iOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pulResult = 0xffffffffU;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToULongLong"]/*' />
    public static HRESULT IntToULongLong(int iOperand, [NativeTypeName("ULONGLONG *")] ulong* pullResult)
    {
        HRESULT hr;

        if (iOperand >= 0)
        {
            *pullResult = (ulong)(iOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pullResult = 0xffffffffffffffffUL;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToInt8"]/*' />
    public static HRESULT IntPtrToInt8([NativeTypeName("INT_PTR")] nint iOperand, [NativeTypeName("INT8 *")] sbyte* pi8Result)
    {
        HRESULT hr;

        if ((iOperand >= (-127 - 1)) && (iOperand <= 127))
        {
            *pi8Result = (sbyte)(iOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pi8Result = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToUChar"]/*' />
    public static HRESULT IntPtrToUChar([NativeTypeName("INT_PTR")] nint iOperand, [NativeTypeName("UCHAR *")] byte* pch)
    {
        HRESULT hr;

        if ((iOperand >= 0) && (iOperand <= 255))
        {
            *pch = (byte)(iOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pch = (byte)('\0');
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToChar"]/*' />
    public static HRESULT IntPtrToChar([NativeTypeName("INT_PTR")] nint iOperand, [NativeTypeName("CHAR *")] sbyte* pch)
    {
        return IntPtrToInt8(iOperand, unchecked((sbyte*)(pch)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToUInt8"]/*' />
    public static HRESULT IntPtrToUInt8([NativeTypeName("INT_PTR")] nint iOperand, [NativeTypeName("UINT8 *")] byte* pui8Result)
    {
        HRESULT hr;

        if ((iOperand >= 0) && (iOperand <= 0xff))
        {
            *pui8Result = (byte)(iOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pui8Result = unchecked(0xff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToShort"]/*' />
    public static HRESULT IntPtrToShort([NativeTypeName("INT_PTR")] nint iOperand, short* psResult)
    {
        HRESULT hr;

        if ((iOperand >= (-32768)) && (iOperand <= 32767))
        {
            *psResult = (short)(iOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *psResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToUShort"]/*' />
    public static HRESULT IntPtrToUShort([NativeTypeName("INT_PTR")] nint iOperand, ushort* pusResult)
    {
        HRESULT hr;

        if ((iOperand >= 0) && (iOperand <= 0xffff))
        {
            *pusResult = (ushort)(iOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pusResult = 0xffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToLongPtr"]/*' />
    public static HRESULT IntPtrToLongPtr([NativeTypeName("INT_PTR")] nint iOperand, [NativeTypeName("LONG_PTR *")] nint* plResult)
    {
        *plResult = (nint)(iOperand);
        return ((HRESULT)(0));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntToInt8"]/*' />
    public static HRESULT UIntToInt8(uint uOperand, [NativeTypeName("INT8 *")] sbyte* pi8Result)
    {
        HRESULT hr;

        if (uOperand <= 127)
        {
            *pi8Result = (sbyte)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pi8Result = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntToUChar"]/*' />
    public static HRESULT UIntToUChar(uint uOperand, [NativeTypeName("UCHAR *")] byte* pch)
    {
        HRESULT hr;

        if (uOperand <= 255)
        {
            *pch = (byte)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pch = (byte)('\0');
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntToChar"]/*' />
    public static HRESULT UIntToChar(uint uOperand, [NativeTypeName("CHAR *")] sbyte* pch)
    {
        return UIntToInt8(uOperand, unchecked((sbyte*)(pch)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntToUInt8"]/*' />
    public static HRESULT UIntToUInt8(uint uOperand, [NativeTypeName("UINT8 *")] byte* pui8Result)
    {
        HRESULT hr;

        if (uOperand <= 0xff)
        {
            *pui8Result = (byte)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pui8Result = unchecked(0xff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntToShort"]/*' />
    public static HRESULT UIntToShort(uint uOperand, short* psResult)
    {
        HRESULT hr;

        if (uOperand <= 32767)
        {
            *psResult = (short)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *psResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntToUShort"]/*' />
    public static HRESULT UIntToUShort(uint uOperand, ushort* pusResult)
    {
        HRESULT hr;

        if (uOperand <= 0xffff)
        {
            *pusResult = (ushort)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pusResult = 0xffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntToInt"]/*' />
    public static HRESULT UIntToInt(uint uOperand, int* piResult)
    {
        HRESULT hr;

        if (uOperand <= 2147483647)
        {
            *piResult = (int)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *piResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntToLong"]/*' />
    public static HRESULT UIntToLong(uint uOperand, [NativeTypeName("LONG *")] int* plResult)
    {
        HRESULT hr;

        if (uOperand <= 2147483647)
        {
            *plResult = (int)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *plResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToInt8"]/*' />
    public static HRESULT UIntPtrToInt8([NativeTypeName("UINT_PTR")] nuint uOperand, [NativeTypeName("INT8 *")] sbyte* pi8Result)
    {
        HRESULT hr;

        if (uOperand <= 127)
        {
            *pi8Result = (sbyte)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pi8Result = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToUChar"]/*' />
    public static HRESULT UIntPtrToUChar([NativeTypeName("UINT_PTR")] nuint uOperand, [NativeTypeName("UCHAR *")] byte* pch)
    {
        HRESULT hr;

        if (uOperand <= 255)
        {
            *pch = (byte)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pch = (byte)('\0');
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToChar"]/*' />
    public static HRESULT UIntPtrToChar([NativeTypeName("UINT_PTR")] nuint uOperand, [NativeTypeName("CHAR *")] sbyte* pch)
    {
        return UIntPtrToInt8(uOperand, unchecked((sbyte*)(pch)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToUInt8"]/*' />
    public static HRESULT UIntPtrToUInt8([NativeTypeName("UINT_PTR")] nuint uOperand, [NativeTypeName("UINT8 *")] byte* pu8Result)
    {
        HRESULT hr;

        if (uOperand <= 0xff)
        {
            *pu8Result = (byte)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pu8Result = unchecked(0xff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToShort"]/*' />
    public static HRESULT UIntPtrToShort([NativeTypeName("UINT_PTR")] nuint uOperand, short* psResult)
    {
        HRESULT hr;

        if (uOperand <= 32767)
        {
            *psResult = (short)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *psResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToInt16"]/*' />
    public static HRESULT UIntPtrToInt16([NativeTypeName("UINT_PTR")] nuint uOperand, [NativeTypeName("INT16 *")] short* pi16Result)
    {
        HRESULT hr;

        if (uOperand <= 32767)
        {
            *pi16Result = (short)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pi16Result = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToUShort"]/*' />
    public static HRESULT UIntPtrToUShort([NativeTypeName("UINT_PTR")] nuint uOperand, ushort* pusResult)
    {
        HRESULT hr;

        if (uOperand <= 0xffff)
        {
            *pusResult = (ushort)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pusResult = 0xffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToUInt16"]/*' />
    public static HRESULT UIntPtrToUInt16([NativeTypeName("UINT_PTR")] nuint uOperand, [NativeTypeName("UINT16 *")] ushort* pu16Result)
    {
        HRESULT hr;

        if (uOperand <= 0xffff)
        {
            *pu16Result = (ushort)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pu16Result = unchecked(0xffff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToInt"]/*' />
    public static HRESULT UIntPtrToInt([NativeTypeName("UINT_PTR")] nuint uOperand, int* piResult)
    {
        HRESULT hr;

        if (uOperand <= 2147483647)
        {
            *piResult = (int)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *piResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToLong"]/*' />
    public static HRESULT UIntPtrToLong([NativeTypeName("UINT_PTR")] nuint uOperand, [NativeTypeName("LONG *")] int* plResult)
    {
        HRESULT hr;

        if (uOperand <= 2147483647)
        {
            *plResult = (int)(uOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *plResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToInt8"]/*' />
    public static HRESULT LongToInt8([NativeTypeName("LONG")] int lOperand, [NativeTypeName("INT8 *")] sbyte* pi8Result)
    {
        HRESULT hr;

        if ((lOperand >= (-127 - 1)) && (lOperand <= 127))
        {
            *pi8Result = (sbyte)(lOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pi8Result = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToUChar"]/*' />
    public static HRESULT LongToUChar([NativeTypeName("LONG")] int lOperand, [NativeTypeName("UCHAR *")] byte* pch)
    {
        HRESULT hr;

        if ((lOperand >= 0) && (lOperand <= 255))
        {
            *pch = (byte)(lOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pch = (byte)('\0');
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToChar"]/*' />
    public static HRESULT LongToChar([NativeTypeName("LONG")] int lOperand, [NativeTypeName("CHAR *")] sbyte* pch)
    {
        return LongToInt8(lOperand, unchecked((sbyte*)(pch)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToUInt8"]/*' />
    public static HRESULT LongToUInt8([NativeTypeName("LONG")] int lOperand, [NativeTypeName("UINT8 *")] byte* pui8Result)
    {
        HRESULT hr;

        if ((lOperand >= 0) && (lOperand <= 0xff))
        {
            *pui8Result = (byte)(lOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pui8Result = unchecked(0xff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToShort"]/*' />
    public static HRESULT LongToShort([NativeTypeName("LONG")] int lOperand, short* psResult)
    {
        HRESULT hr;

        if ((lOperand >= (-32768)) && (lOperand <= 32767))
        {
            *psResult = (short)(lOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *psResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToUShort"]/*' />
    public static HRESULT LongToUShort([NativeTypeName("LONG")] int lOperand, ushort* pusResult)
    {
        HRESULT hr;

        if ((lOperand >= 0) && (lOperand <= 0xffff))
        {
            *pusResult = (ushort)(lOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pusResult = 0xffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToInt"]/*' />
    public static HRESULT LongToInt([NativeTypeName("LONG")] int lOperand, int* piResult)
    {
        ;

        *piResult = (int)(lOperand);
        return ((HRESULT)(0));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToIntPtr"]/*' />
    public static HRESULT LongToIntPtr([NativeTypeName("LONG")] int lOperand, [NativeTypeName("INT_PTR *")] nint* piResult)
    {
        *piResult = lOperand;
        return ((HRESULT)(0));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToUInt"]/*' />
    public static HRESULT LongToUInt([NativeTypeName("LONG")] int lOperand, uint* puResult)
    {
        HRESULT hr;

        if (lOperand >= 0)
        {
            *puResult = (uint)(lOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *puResult = 0xffffffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToULong"]/*' />
    public static HRESULT LongToULong([NativeTypeName("LONG")] int lOperand, [NativeTypeName("ULONG *")] uint* pulResult)
    {
        HRESULT hr;

        if (lOperand >= 0)
        {
            *pulResult = (uint)(lOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pulResult = 0xffffffffU;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToULongLong"]/*' />
    public static HRESULT LongToULongLong([NativeTypeName("LONG")] int lOperand, [NativeTypeName("ULONGLONG *")] ulong* pullResult)
    {
        HRESULT hr;

        if (lOperand >= 0)
        {
            *pullResult = (ulong)(lOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pullResult = 0xffffffffffffffffUL;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToInt8"]/*' />
    public static HRESULT LongPtrToInt8([NativeTypeName("LONG_PTR")] nint lOperand, [NativeTypeName("INT8 *")] sbyte* pi8Result)
    {
        HRESULT hr;

        if ((lOperand >= (-127 - 1)) && (lOperand <= 127))
        {
            *pi8Result = (sbyte)(lOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pi8Result = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToUChar"]/*' />
    public static HRESULT LongPtrToUChar([NativeTypeName("LONG_PTR")] nint lOperand, [NativeTypeName("UCHAR *")] byte* pch)
    {
        HRESULT hr;

        if ((lOperand >= 0) && (lOperand <= 255))
        {
            *pch = (byte)(lOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pch = (byte)('\0');
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToChar"]/*' />
    public static HRESULT LongPtrToChar([NativeTypeName("LONG_PTR")] nint lOperand, [NativeTypeName("CHAR *")] sbyte* pch)
    {
        return LongPtrToInt8(lOperand, unchecked((sbyte*)(pch)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToUInt8"]/*' />
    public static HRESULT LongPtrToUInt8([NativeTypeName("LONG_PTR")] nint lOperand, [NativeTypeName("UINT8 *")] byte* pui8Result)
    {
        HRESULT hr;

        if ((lOperand >= 0) && (lOperand <= 0xff))
        {
            *pui8Result = (byte)(lOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pui8Result = unchecked(0xff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToShort"]/*' />
    public static HRESULT LongPtrToShort([NativeTypeName("LONG_PTR")] nint lOperand, short* psResult)
    {
        HRESULT hr;

        if ((lOperand >= (-32768)) && (lOperand <= 32767))
        {
            *psResult = (short)(lOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *psResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToUShort"]/*' />
    public static HRESULT LongPtrToUShort([NativeTypeName("LONG_PTR")] nint lOperand, ushort* pusResult)
    {
        HRESULT hr;

        if ((lOperand >= 0) && (lOperand <= 0xffff))
        {
            *pusResult = (ushort)(lOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pusResult = 0xffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToIntPtr"]/*' />
    public static HRESULT LongPtrToIntPtr([NativeTypeName("LONG_PTR")] nint lOperand, [NativeTypeName("INT_PTR *")] nint* piResult)
    {
        ;

        *piResult = (nint)(lOperand);
        return ((HRESULT)(0));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToULongLong"]/*' />
    public static HRESULT LongPtrToULongLong([NativeTypeName("LONG_PTR")] nint lOperand, [NativeTypeName("ULONGLONG *")] ulong* pullResult)
    {
        HRESULT hr;

        if (lOperand >= 0)
        {
            *pullResult = (ulong)(lOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pullResult = 0xffffffffffffffffUL;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToInt8"]/*' />
    public static HRESULT ULongToInt8([NativeTypeName("ULONG")] uint ulOperand, [NativeTypeName("INT8 *")] sbyte* pi8Result)
    {
        HRESULT hr;

        if (ulOperand <= 127)
        {
            *pi8Result = (sbyte)(ulOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pi8Result = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToUChar"]/*' />
    public static HRESULT ULongToUChar([NativeTypeName("ULONG")] uint ulOperand, [NativeTypeName("UCHAR *")] byte* pch)
    {
        HRESULT hr;

        if (ulOperand <= 255)
        {
            *pch = (byte)(ulOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pch = (byte)('\0');
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToChar"]/*' />
    public static HRESULT ULongToChar([NativeTypeName("ULONG")] uint ulOperand, [NativeTypeName("CHAR *")] sbyte* pch)
    {
        return ULongToInt8(ulOperand, unchecked((sbyte*)(pch)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToUInt8"]/*' />
    public static HRESULT ULongToUInt8([NativeTypeName("ULONG")] uint ulOperand, [NativeTypeName("UINT8 *")] byte* pui8Result)
    {
        HRESULT hr;

        if (ulOperand <= 0xff)
        {
            *pui8Result = (byte)(ulOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pui8Result = unchecked(0xff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToShort"]/*' />
    public static HRESULT ULongToShort([NativeTypeName("ULONG")] uint ulOperand, short* psResult)
    {
        HRESULT hr;

        if (ulOperand <= 32767)
        {
            *psResult = (short)(ulOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *psResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToUShort"]/*' />
    public static HRESULT ULongToUShort([NativeTypeName("ULONG")] uint ulOperand, ushort* pusResult)
    {
        HRESULT hr;

        if (ulOperand <= 0xffff)
        {
            *pusResult = (ushort)(ulOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pusResult = 0xffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToInt"]/*' />
    public static HRESULT ULongToInt([NativeTypeName("ULONG")] uint ulOperand, int* piResult)
    {
        HRESULT hr;

        if (ulOperand <= 2147483647)
        {
            *piResult = (int)(ulOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *piResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToIntPtr"]/*' />
    public static HRESULT ULongToIntPtr([NativeTypeName("ULONG")] uint ulOperand, [NativeTypeName("INT_PTR *")] nint* piResult)
    {
        *piResult = (nint)(ulOperand);
        return ((HRESULT)(0));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToUInt"]/*' />
    public static HRESULT ULongToUInt([NativeTypeName("ULONG")] uint ulOperand, uint* puResult)
    {
        ;

        *puResult = (uint)(ulOperand);
        return ((HRESULT)(0));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToUIntPtr"]/*' />
    public static HRESULT ULongToUIntPtr([NativeTypeName("ULONG")] uint ulOperand, [NativeTypeName("UINT_PTR *")] nuint* puiResult)
    {
        ;

        *puiResult = (nuint)(ulOperand);
        return ((HRESULT)(0));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToLong"]/*' />
    public static HRESULT ULongToLong([NativeTypeName("ULONG")] uint ulOperand, [NativeTypeName("LONG *")] int* plResult)
    {
        HRESULT hr;

        if (ulOperand <= 2147483647)
        {
            *plResult = (int)(ulOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *plResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToLongPtr"]/*' />
    public static HRESULT ULongToLongPtr([NativeTypeName("ULONG")] uint ulOperand, [NativeTypeName("LONG_PTR *")] nint* plResult)
    {
        ;

        *plResult = (nint)(ulOperand);
        return ((HRESULT)(0));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToInt8"]/*' />
    public static HRESULT ULongPtrToInt8([NativeTypeName("ULONG_PTR")] nuint ulOperand, [NativeTypeName("INT8 *")] sbyte* pi8Result)
    {
        HRESULT hr;

        if (ulOperand <= 127)
        {
            *pi8Result = (sbyte)(ulOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pi8Result = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToUChar"]/*' />
    public static HRESULT ULongPtrToUChar([NativeTypeName("ULONG_PTR")] nuint ulOperand, [NativeTypeName("UCHAR *")] byte* pch)
    {
        HRESULT hr;

        if (ulOperand <= 255)
        {
            *pch = (byte)(ulOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pch = (byte)('\0');
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToChar"]/*' />
    public static HRESULT ULongPtrToChar([NativeTypeName("ULONG_PTR")] nuint ulOperand, [NativeTypeName("CHAR *")] sbyte* pch)
    {
        return ULongPtrToInt8(ulOperand, unchecked((sbyte*)(pch)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToUInt8"]/*' />
    public static HRESULT ULongPtrToUInt8([NativeTypeName("ULONG_PTR")] nuint ulOperand, [NativeTypeName("UINT8 *")] byte* pui8Result)
    {
        HRESULT hr;

        if (ulOperand <= 0xff)
        {
            *pui8Result = (byte)(ulOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pui8Result = unchecked(0xff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToShort"]/*' />
    public static HRESULT ULongPtrToShort([NativeTypeName("ULONG_PTR")] nuint ulOperand, short* psResult)
    {
        HRESULT hr;

        if (ulOperand <= 32767)
        {
            *psResult = (short)(ulOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *psResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToUShort"]/*' />
    public static HRESULT ULongPtrToUShort([NativeTypeName("ULONG_PTR")] nuint ulOperand, ushort* pusResult)
    {
        HRESULT hr;

        if (ulOperand <= 0xffff)
        {
            *pusResult = (ushort)(ulOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pusResult = 0xffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToInt"]/*' />
    public static HRESULT ULongPtrToInt([NativeTypeName("ULONG_PTR")] nuint ulOperand, int* piResult)
    {
        HRESULT hr;

        if (ulOperand <= 2147483647)
        {
            *piResult = (int)(ulOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *piResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToUIntPtr"]/*' />
    public static HRESULT ULongPtrToUIntPtr([NativeTypeName("ULONG_PTR")] nuint ulOperand, [NativeTypeName("UINT_PTR *")] nuint* puResult)
    {
        *puResult = (nuint)(ulOperand);
        return ((HRESULT)(0));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToLong"]/*' />
    public static HRESULT ULongPtrToLong([NativeTypeName("ULONG_PTR")] nuint ulOperand, [NativeTypeName("LONG *")] int* plResult)
    {
        HRESULT hr;

        if (ulOperand <= 2147483647)
        {
            *plResult = (int)(ulOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *plResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToInt8"]/*' />
    public static HRESULT LongLongToInt8([NativeTypeName("LONGLONG")] long llOperand, [NativeTypeName("INT8 *")] sbyte* pi8Result)
    {
        HRESULT hr;

        if ((llOperand >= (-127 - 1)) && (llOperand <= 127))
        {
            *pi8Result = (sbyte)(llOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pi8Result = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToUChar"]/*' />
    public static HRESULT LongLongToUChar([NativeTypeName("LONGLONG")] long llOperand, [NativeTypeName("UCHAR *")] byte* pch)
    {
        HRESULT hr;

        if ((llOperand >= 0) && (llOperand <= 255))
        {
            *pch = (byte)(llOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pch = (byte)('\0');
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToChar"]/*' />
    public static HRESULT LongLongToChar([NativeTypeName("LONGLONG")] long llOperand, [NativeTypeName("CHAR *")] sbyte* pch)
    {
        return LongLongToInt8(llOperand, unchecked((sbyte*)(pch)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToUInt8"]/*' />
    public static HRESULT LongLongToUInt8([NativeTypeName("LONGLONG")] long llOperand, [NativeTypeName("UINT8 *")] byte* pu8Result)
    {
        HRESULT hr;

        if ((llOperand >= 0) && (llOperand <= 0xff))
        {
            *pu8Result = (byte)(llOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pu8Result = unchecked(0xff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToShort"]/*' />
    public static HRESULT LongLongToShort([NativeTypeName("LONGLONG")] long llOperand, short* psResult)
    {
        HRESULT hr;

        if ((llOperand >= (-32768)) && (llOperand <= 32767))
        {
            *psResult = (short)(llOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *psResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToUShort"]/*' />
    public static HRESULT LongLongToUShort([NativeTypeName("LONGLONG")] long llOperand, ushort* pusResult)
    {
        HRESULT hr;

        if ((llOperand >= 0) && (llOperand <= 0xffff))
        {
            *pusResult = (ushort)(llOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pusResult = 0xffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToInt"]/*' />
    public static HRESULT LongLongToInt([NativeTypeName("LONGLONG")] long llOperand, int* piResult)
    {
        HRESULT hr;

        if ((llOperand >= (-2147483647 - 1)) && (llOperand <= 2147483647))
        {
            *piResult = (int)(llOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *piResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToUInt"]/*' />
    public static HRESULT LongLongToUInt([NativeTypeName("LONGLONG")] long llOperand, uint* puResult)
    {
        HRESULT hr;

        if ((llOperand >= 0) && (llOperand <= 0xffffffff))
        {
            *puResult = (uint)(llOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *puResult = 0xffffffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToLong"]/*' />
    public static HRESULT LongLongToLong([NativeTypeName("LONGLONG")] long llOperand, [NativeTypeName("LONG *")] int* plResult)
    {
        HRESULT hr;

        if ((llOperand >= (-2147483647 - 1)) && (llOperand <= 2147483647))
        {
            *plResult = (int)(llOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *plResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToLongPtr"]/*' />
    public static HRESULT LongLongToLongPtr([NativeTypeName("LONGLONG")] long llOperand, [NativeTypeName("LONG_PTR *")] nint* plResult)
    {
        *plResult = (nint)(llOperand);
        return ((HRESULT)(0));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToULong"]/*' />
    public static HRESULT LongLongToULong([NativeTypeName("LONGLONG")] long llOperand, [NativeTypeName("ULONG *")] uint* pulResult)
    {
        HRESULT hr;

        if ((llOperand >= 0) && (llOperand <= 0xffffffffU))
        {
            *pulResult = (uint)(llOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pulResult = 0xffffffffU;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToULongLong"]/*' />
    public static HRESULT LongLongToULongLong([NativeTypeName("LONGLONG")] long llOperand, [NativeTypeName("ULONGLONG *")] ulong* pullResult)
    {
        HRESULT hr;

        if (llOperand >= 0)
        {
            *pullResult = (ulong)(llOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pullResult = 0xffffffffffffffffUL;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToInt8"]/*' />
    public static HRESULT ULongLongToInt8([NativeTypeName("ULONGLONG")] ulong ullOperand, [NativeTypeName("INT8 *")] sbyte* pi8Result)
    {
        HRESULT hr;

        if (ullOperand <= 127)
        {
            *pi8Result = (sbyte)(ullOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pi8Result = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToUChar"]/*' />
    public static HRESULT ULongLongToUChar([NativeTypeName("ULONGLONG")] ulong ullOperand, [NativeTypeName("UCHAR *")] byte* pch)
    {
        HRESULT hr;

        if (ullOperand <= 255)
        {
            *pch = (byte)(ullOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pch = (byte)('\0');
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToChar"]/*' />
    public static HRESULT ULongLongToChar([NativeTypeName("ULONGLONG")] ulong ullOperand, [NativeTypeName("CHAR *")] sbyte* pch)
    {
        return ULongLongToInt8(ullOperand, unchecked((sbyte*)(pch)));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToUInt8"]/*' />
    public static HRESULT ULongLongToUInt8([NativeTypeName("ULONGLONG")] ulong ullOperand, [NativeTypeName("UINT8 *")] byte* pu8Result)
    {
        HRESULT hr;

        if (ullOperand <= 0xff)
        {
            *pu8Result = (byte)(ullOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pu8Result = unchecked(0xff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToShort"]/*' />
    public static HRESULT ULongLongToShort([NativeTypeName("ULONGLONG")] ulong ullOperand, short* psResult)
    {
        HRESULT hr;

        if (ullOperand <= 32767)
        {
            *psResult = (short)(ullOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *psResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToUShort"]/*' />
    public static HRESULT ULongLongToUShort([NativeTypeName("ULONGLONG")] ulong ullOperand, ushort* pusResult)
    {
        HRESULT hr;

        if (ullOperand <= 0xffff)
        {
            *pusResult = (ushort)(ullOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pusResult = 0xffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToInt"]/*' />
    public static HRESULT ULongLongToInt([NativeTypeName("ULONGLONG")] ulong ullOperand, int* piResult)
    {
        HRESULT hr;

        if (ullOperand <= 2147483647)
        {
            *piResult = (int)(ullOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *piResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToUInt"]/*' />
    public static HRESULT ULongLongToUInt([NativeTypeName("ULONGLONG")] ulong ullOperand, uint* puResult)
    {
        HRESULT hr;

        if (ullOperand <= 0xffffffff)
        {
            *puResult = (uint)(ullOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *puResult = 0xffffffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToLong"]/*' />
    public static HRESULT ULongLongToLong([NativeTypeName("ULONGLONG")] ulong ullOperand, [NativeTypeName("LONG *")] int* plResult)
    {
        HRESULT hr;

        if (ullOperand <= 2147483647)
        {
            *plResult = (int)(ullOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *plResult = (-1);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToULong"]/*' />
    public static HRESULT ULongLongToULong([NativeTypeName("ULONGLONG")] ulong ullOperand, [NativeTypeName("ULONG *")] uint* pulResult)
    {
        HRESULT hr;

        if (ullOperand <= 0xffffffffU)
        {
            *pulResult = (uint)(ullOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pulResult = 0xffffffffU;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToLongLong"]/*' />
    public static HRESULT ULongLongToLongLong([NativeTypeName("ULONGLONG")] ulong ullOperand, [NativeTypeName("LONGLONG *")] long* pllResult)
    {
        HRESULT hr;

        if (ullOperand <= 9223372036854775807L)
        {
            *pllResult = (long)(ullOperand);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pllResult = (-1L);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt8Add"]/*' />
    public static HRESULT UInt8Add([NativeTypeName("UINT8")] byte u8Augend, [NativeTypeName("UINT8")] byte u8Addend, [NativeTypeName("UINT8 *")] byte* pu8Result)
    {
        HRESULT hr;

        if (unchecked((byte)(u8Augend + u8Addend)) >= u8Augend)
        {
            *pu8Result = (byte)(u8Augend + u8Addend);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pu8Result = unchecked(0xff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UShortAdd"]/*' />
    public static HRESULT UShortAdd(ushort usAugend, ushort usAddend, ushort* pusResult)
    {
        HRESULT hr;

        if (unchecked((ushort)(usAugend + usAddend)) >= usAugend)
        {
            *pusResult = (ushort)(usAugend + usAddend);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pusResult = 0xffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntAdd"]/*' />
    public static HRESULT UIntAdd(uint uAugend, uint uAddend, uint* puResult)
    {
        HRESULT hr;

        if ((uAugend + uAddend) >= uAugend)
        {
            *puResult = (uAugend + uAddend);
            hr = ((HRESULT)(0));
        }
        else
        {
            *puResult = 0xffffffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongAdd"]/*' />
    public static HRESULT ULongAdd([NativeTypeName("ULONG")] uint ulAugend, [NativeTypeName("ULONG")] uint ulAddend, [NativeTypeName("ULONG *")] uint* pulResult)
    {
        HRESULT hr;

        if ((ulAugend + ulAddend) >= ulAugend)
        {
            *pulResult = (ulAugend + ulAddend);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pulResult = 0xffffffffU;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongAdd"]/*' />
    public static HRESULT ULongLongAdd([NativeTypeName("ULONGLONG")] ulong ullAugend, [NativeTypeName("ULONGLONG")] ulong ullAddend, [NativeTypeName("ULONGLONG *")] ulong* pullResult)
    {
        HRESULT hr;

        if ((ullAugend + ullAddend) >= ullAugend)
        {
            *pullResult = (ullAugend + ullAddend);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pullResult = 0xffffffffffffffffUL;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt8Sub"]/*' />
    public static HRESULT UInt8Sub([NativeTypeName("UINT8")] byte u8Minuend, [NativeTypeName("UINT8")] byte u8Subtrahend, [NativeTypeName("UINT8 *")] byte* pu8Result)
    {
        HRESULT hr;

        if (u8Minuend >= u8Subtrahend)
        {
            *pu8Result = (byte)(u8Minuend - u8Subtrahend);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pu8Result = unchecked(0xff);
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UShortSub"]/*' />
    public static HRESULT UShortSub(ushort usMinuend, ushort usSubtrahend, ushort* pusResult)
    {
        HRESULT hr;

        if (usMinuend >= usSubtrahend)
        {
            *pusResult = (ushort)(usMinuend - usSubtrahend);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pusResult = 0xffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntSub"]/*' />
    public static HRESULT UIntSub(uint uMinuend, uint uSubtrahend, uint* puResult)
    {
        HRESULT hr;

        if (uMinuend >= uSubtrahend)
        {
            *puResult = (uMinuend - uSubtrahend);
            hr = ((HRESULT)(0));
        }
        else
        {
            *puResult = 0xffffffff;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongSub"]/*' />
    public static HRESULT ULongSub([NativeTypeName("ULONG")] uint ulMinuend, [NativeTypeName("ULONG")] uint ulSubtrahend, [NativeTypeName("ULONG *")] uint* pulResult)
    {
        HRESULT hr;

        if (ulMinuend >= ulSubtrahend)
        {
            *pulResult = (ulMinuend - ulSubtrahend);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pulResult = 0xffffffffU;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongSub"]/*' />
    public static HRESULT ULongLongSub([NativeTypeName("ULONGLONG")] ulong ullMinuend, [NativeTypeName("ULONGLONG")] ulong ullSubtrahend, [NativeTypeName("ULONGLONG *")] ulong* pullResult)
    {
        HRESULT hr;

        if (ullMinuend >= ullSubtrahend)
        {
            *pullResult = (ullMinuend - ullSubtrahend);
            hr = ((HRESULT)(0));
        }
        else
        {
            *pullResult = 0xffffffffffffffffUL;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt8Mult"]/*' />
    public static HRESULT UInt8Mult([NativeTypeName("UINT8")] byte u8Multiplicand, [NativeTypeName("UINT8")] byte u8Multiplier, [NativeTypeName("UINT8 *")] byte* pu8Result)
    {
        uint uResult = ((uint)(u8Multiplicand)) * ((uint)(u8Multiplier));

        return UIntToUInt8(unchecked(uResult), pu8Result);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UShortMult"]/*' />
    public static HRESULT UShortMult(ushort usMultiplicand, ushort usMultiplier, ushort* pusResult)
    {
        uint ulResult = ((uint)(usMultiplicand)) * ((uint)(usMultiplier));

        return ULongToUShort(unchecked(ulResult), pusResult);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntMult"]/*' />
    public static HRESULT UIntMult(uint uMultiplicand, uint uMultiplier, uint* puResult)
    {
        ulong ull64Result = (((ulong)((uint)(uMultiplicand))) * ((ulong)((uint)(uMultiplier))));

        return ULongLongToUInt(unchecked(ull64Result), puResult);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongMult"]/*' />
    public static HRESULT ULongMult([NativeTypeName("ULONG")] uint ulMultiplicand, [NativeTypeName("ULONG")] uint ulMultiplier, [NativeTypeName("ULONG *")] uint* pulResult)
    {
        ulong ull64Result = (((ulong)((uint)(ulMultiplicand))) * ((ulong)((uint)(ulMultiplier))));

        return ULongLongToULong(unchecked(ull64Result), pulResult);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongMult"]/*' />
    public static HRESULT ULongLongMult([NativeTypeName("ULONGLONG")] ulong ullMultiplicand, [NativeTypeName("ULONGLONG")] ulong ullMultiplier, [NativeTypeName("ULONGLONG *")] ulong* pullResult)
    {
        HRESULT hr;
        ulong ullResultHigh;
        ulong ullResultLow;

        ullResultLow = _umul128(ullMultiplicand, ullMultiplier, &ullResultHigh);
        if (ullResultHigh == 0)
        {
            ;
            *pullResult = ullResultLow;
            hr = ((HRESULT)(0));
        }
        else
        {
            *pullResult = 0xffffffffffffffffUL;
            hr = ((HRESULT)(0x80070216));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows._ARM64_MULT_INTRINS_SUPPORTED"]/*' />
    [NativeTypeName("#define _ARM64_MULT_INTRINS_SUPPORTED 0")]
    public const int _ARM64_MULT_INTRINS_SUPPORTED = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INTSAFE_E_ARITHMETIC_OVERFLOW"]/*' />
    [NativeTypeName("#define INTSAFE_E_ARITHMETIC_OVERFLOW ((HRESULT)0x80070216L)")]
    public const int INTSAFE_E_ARITHMETIC_OVERFLOW = unchecked((int)(0x80070216));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT8_MIN"]/*' />
    [NativeTypeName("#define INT8_MIN (-127i8 - 1)")]
    public const int INT8_MIN = (-127 - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHORT_MIN"]/*' />
    [NativeTypeName("#define SHORT_MIN (-32768)")]
    public const int SHORT_MIN = (-32768);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT16_MIN"]/*' />
    [NativeTypeName("#define INT16_MIN (-32767i16 - 1)")]
    public const int INT16_MIN = (-32767 - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT32_MIN"]/*' />
    [NativeTypeName("#define INT32_MIN (-2147483647i32 - 1)")]
    public const int INT32_MIN = (-2147483647 - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LONGLONG_MIN"]/*' />
    [NativeTypeName("#define LONGLONG_MIN (-9223372036854775807i64 - 1)")]
    public const long LONGLONG_MIN = (-9223372036854775807L - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LONG64_MIN"]/*' />
    [NativeTypeName("#define LONG64_MIN (-9223372036854775807i64 - 1)")]
    public const long LONG64_MIN = (-9223372036854775807L - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT64_MIN"]/*' />
    [NativeTypeName("#define INT64_MIN (-9223372036854775807i64 - 1)")]
    public const long INT64_MIN = (-9223372036854775807L - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT8_MAX"]/*' />
    [NativeTypeName("#define INT8_MAX 127i8")]
    public const sbyte INT8_MAX = 127;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT8_MAX"]/*' />
    [NativeTypeName("#define UINT8_MAX 0xffui8")]
    public const byte UINT8_MAX = unchecked(0xff);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BYTE_MAX"]/*' />
    [NativeTypeName("#define BYTE_MAX 0xff")]
    public const int BYTE_MAX = 0xff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHORT_MAX"]/*' />
    [NativeTypeName("#define SHORT_MAX 32767")]
    public const int SHORT_MAX = 32767;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT16_MAX"]/*' />
    [NativeTypeName("#define INT16_MAX 32767i16")]
    public const short INT16_MAX = 32767;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.USHORT_MAX"]/*' />
    [NativeTypeName("#define USHORT_MAX 0xffff")]
    public const int USHORT_MAX = 0xffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT16_MAX"]/*' />
    [NativeTypeName("#define UINT16_MAX 0xffffui16")]
    public const ushort UINT16_MAX = unchecked(0xffff);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WORD_MAX"]/*' />
    [NativeTypeName("#define WORD_MAX 0xffff")]
    public const int WORD_MAX = 0xffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT32_MAX"]/*' />
    [NativeTypeName("#define INT32_MAX 2147483647i32")]
    public const int INT32_MAX = 2147483647;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT32_MAX"]/*' />
    [NativeTypeName("#define UINT32_MAX 0xffffffffui32")]
    public const uint UINT32_MAX = 0xffffffffU;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWORD_MAX"]/*' />
    [NativeTypeName("#define DWORD_MAX 0xffffffffUL")]
    public const uint DWORD_MAX = 0xffffffffU;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LONGLONG_MAX"]/*' />
    [NativeTypeName("#define LONGLONG_MAX 9223372036854775807i64")]
    public const long LONGLONG_MAX = 9223372036854775807L;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LONG64_MAX"]/*' />
    [NativeTypeName("#define LONG64_MAX 9223372036854775807i64")]
    public const long LONG64_MAX = 9223372036854775807L;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT64_MAX"]/*' />
    [NativeTypeName("#define INT64_MAX 9223372036854775807i64")]
    public const long INT64_MAX = 9223372036854775807L;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULONGLONG_MAX"]/*' />
    [NativeTypeName("#define ULONGLONG_MAX 0xffffffffffffffffui64")]
    public const ulong ULONGLONG_MAX = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWORDLONG_MAX"]/*' />
    [NativeTypeName("#define DWORDLONG_MAX 0xffffffffffffffffui64")]
    public const ulong DWORDLONG_MAX = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULONG64_MAX"]/*' />
    [NativeTypeName("#define ULONG64_MAX 0xffffffffffffffffui64")]
    public const ulong ULONG64_MAX = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWORD64_MAX"]/*' />
    [NativeTypeName("#define DWORD64_MAX 0xffffffffffffffffui64")]
    public const ulong DWORD64_MAX = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT64_MAX"]/*' />
    [NativeTypeName("#define UINT64_MAX 0xffffffffffffffffui64")]
    public const ulong UINT64_MAX = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT8_ERROR"]/*' />
    [NativeTypeName("#define INT8_ERROR (-1i8)")]
    public const int INT8_ERROR = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT8_ERROR"]/*' />
    [NativeTypeName("#define UINT8_ERROR 0xffui8")]
    public const byte UINT8_ERROR = unchecked(0xff);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BYTE_ERROR"]/*' />
    [NativeTypeName("#define BYTE_ERROR 0xff")]
    public const int BYTE_ERROR = 0xff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHORT_ERROR"]/*' />
    [NativeTypeName("#define SHORT_ERROR (-1)")]
    public const int SHORT_ERROR = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT16_ERROR"]/*' />
    [NativeTypeName("#define INT16_ERROR (-1i16)")]
    public const int INT16_ERROR = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.USHORT_ERROR"]/*' />
    [NativeTypeName("#define USHORT_ERROR 0xffff")]
    public const int USHORT_ERROR = 0xffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT16_ERROR"]/*' />
    [NativeTypeName("#define UINT16_ERROR 0xffffui16")]
    public const ushort UINT16_ERROR = unchecked(0xffff);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WORD_ERROR"]/*' />
    [NativeTypeName("#define WORD_ERROR 0xffff")]
    public const int WORD_ERROR = 0xffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT_ERROR"]/*' />
    [NativeTypeName("#define INT_ERROR (-1)")]
    public const int INT_ERROR = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT32_ERROR"]/*' />
    [NativeTypeName("#define INT32_ERROR (-1i32)")]
    public const int INT32_ERROR = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT_ERROR"]/*' />
    [NativeTypeName("#define UINT_ERROR 0xffffffff")]
    public const uint UINT_ERROR = 0xffffffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT32_ERROR"]/*' />
    [NativeTypeName("#define UINT32_ERROR 0xffffffffui32")]
    public const uint UINT32_ERROR = 0xffffffffU;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LONG_ERROR"]/*' />
    [NativeTypeName("#define LONG_ERROR (-1L)")]
    public const int LONG_ERROR = (-1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULONG_ERROR"]/*' />
    [NativeTypeName("#define ULONG_ERROR 0xffffffffUL")]
    public const uint ULONG_ERROR = 0xffffffffU;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWORD_ERROR"]/*' />
    [NativeTypeName("#define DWORD_ERROR 0xffffffffUL")]
    public const uint DWORD_ERROR = 0xffffffffU;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LONGLONG_ERROR"]/*' />
    [NativeTypeName("#define LONGLONG_ERROR (-1i64)")]
    public const long LONGLONG_ERROR = (-1L);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LONG64_ERROR"]/*' />
    [NativeTypeName("#define LONG64_ERROR (-1i64)")]
    public const long LONG64_ERROR = (-1L);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.INT64_ERROR"]/*' />
    [NativeTypeName("#define INT64_ERROR (-1i64)")]
    public const long INT64_ERROR = (-1L);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULONGLONG_ERROR"]/*' />
    [NativeTypeName("#define ULONGLONG_ERROR 0xffffffffffffffffui64")]
    public const ulong ULONGLONG_ERROR = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWORDLONG_ERROR"]/*' />
    [NativeTypeName("#define DWORDLONG_ERROR 0xffffffffffffffffui64")]
    public const ulong DWORDLONG_ERROR = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULONG64_ERROR"]/*' />
    [NativeTypeName("#define ULONG64_ERROR 0xffffffffffffffffui64")]
    public const ulong ULONG64_ERROR = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UINT64_ERROR"]/*' />
    [NativeTypeName("#define UINT64_ERROR 0xffffffffffffffffui64")]
    public const ulong UINT64_ERROR = 0xffffffffffffffffUL;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToByte"]/*' />
    [NativeTypeName("#define Int8ToByte Int8ToUInt8")]
    public static delegate*<sbyte, byte*, HRESULT> Int8ToByte => &Int8ToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToUInt16"]/*' />
    [NativeTypeName("#define Int8ToUInt16 Int8ToUShort")]
    public static delegate*<sbyte, ushort*, HRESULT> Int8ToUInt16 => &Int8ToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToWord"]/*' />
    [NativeTypeName("#define Int8ToWord Int8ToUShort")]
    public static delegate*<sbyte, ushort*, HRESULT> Int8ToWord => &Int8ToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToUInt32"]/*' />
    [NativeTypeName("#define Int8ToUInt32 Int8ToUInt")]
    public static delegate*<sbyte, uint*, HRESULT> Int8ToUInt32 => &Int8ToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToDWord"]/*' />
    [NativeTypeName("#define Int8ToDWord Int8ToULong")]
    public static delegate*<sbyte, uint*, HRESULT> Int8ToDWord => &Int8ToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToDWordPtr"]/*' />
    [NativeTypeName("#define Int8ToDWordPtr Int8ToULongPtr")]
    public static delegate*<sbyte, nuint*, HRESULT> Int8ToDWordPtr => &Int8ToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToDWordLong"]/*' />
    [NativeTypeName("#define Int8ToDWordLong Int8ToULongLong")]
    public static delegate*<sbyte, ulong*, HRESULT> Int8ToDWordLong => &Int8ToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToULong64"]/*' />
    [NativeTypeName("#define Int8ToULong64 Int8ToULongLong")]
    public static delegate*<sbyte, ulong*, HRESULT> Int8ToULong64 => &Int8ToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToDWord64"]/*' />
    [NativeTypeName("#define Int8ToDWord64 Int8ToULongLong")]
    public static delegate*<sbyte, ulong*, HRESULT> Int8ToDWord64 => &Int8ToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToUInt64"]/*' />
    [NativeTypeName("#define Int8ToUInt64 Int8ToULongLong")]
    public static delegate*<sbyte, ulong*, HRESULT> Int8ToUInt64 => &Int8ToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToSizeT"]/*' />
    [NativeTypeName("#define Int8ToSizeT Int8ToUIntPtr")]
    public static delegate*<sbyte, nuint*, HRESULT> Int8ToSizeT => &Int8ToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int8ToSIZET"]/*' />
    [NativeTypeName("#define Int8ToSIZET Int8ToULongPtr")]
    public static delegate*<sbyte, nuint*, HRESULT> Int8ToSIZET => &Int8ToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToByte"]/*' />
    [NativeTypeName("#define ShortToByte ShortToUInt8")]
    public static delegate*<short, byte*, HRESULT> ShortToByte => &ShortToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToUInt16"]/*' />
    [NativeTypeName("#define ShortToUInt16 ShortToUShort")]
    public static delegate*<short, ushort*, HRESULT> ShortToUInt16 => &ShortToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToWord"]/*' />
    [NativeTypeName("#define ShortToWord ShortToUShort")]
    public static delegate*<short, ushort*, HRESULT> ShortToWord => &ShortToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToUInt32"]/*' />
    [NativeTypeName("#define ShortToUInt32 ShortToUInt")]
    public static delegate*<short, uint*, HRESULT> ShortToUInt32 => &ShortToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToDWord"]/*' />
    [NativeTypeName("#define ShortToDWord ShortToULong")]
    public static delegate*<short, uint*, HRESULT> ShortToDWord => &ShortToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToDWordLong"]/*' />
    [NativeTypeName("#define ShortToDWordLong ShortToULongLong")]
    public static delegate*<short, ulong*, HRESULT> ShortToDWordLong => &ShortToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToULong64"]/*' />
    [NativeTypeName("#define ShortToULong64 ShortToULongLong")]
    public static delegate*<short, ulong*, HRESULT> ShortToULong64 => &ShortToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToDWord64"]/*' />
    [NativeTypeName("#define ShortToDWord64 ShortToULongLong")]
    public static delegate*<short, ulong*, HRESULT> ShortToDWord64 => &ShortToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToUInt64"]/*' />
    [NativeTypeName("#define ShortToUInt64 ShortToULongLong")]
    public static delegate*<short, ulong*, HRESULT> ShortToUInt64 => &ShortToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToSizeT"]/*' />
    [NativeTypeName("#define ShortToSizeT ShortToUIntPtr")]
    public static delegate*<short, nuint*, HRESULT> ShortToSizeT => &ShortToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShortToSIZET"]/*' />
    [NativeTypeName("#define ShortToSIZET ShortToULongPtr")]
    public static delegate*<short, nuint*, HRESULT> ShortToSIZET => &ShortToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToChar"]/*' />
    [NativeTypeName("#define Int16ToChar ShortToChar")]
    public static delegate*<short, sbyte*, HRESULT> Int16ToChar => &ShortToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToInt8"]/*' />
    [NativeTypeName("#define Int16ToInt8 ShortToInt8")]
    public static delegate*<short, sbyte*, HRESULT> Int16ToInt8 => &ShortToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToUChar"]/*' />
    [NativeTypeName("#define Int16ToUChar ShortToUChar")]
    public static delegate*<short, byte*, HRESULT> Int16ToUChar => &ShortToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToUInt8"]/*' />
    [NativeTypeName("#define Int16ToUInt8 ShortToUInt8")]
    public static delegate*<short, byte*, HRESULT> Int16ToUInt8 => &ShortToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToByte"]/*' />
    [NativeTypeName("#define Int16ToByte ShortToUInt8")]
    public static delegate*<short, byte*, HRESULT> Int16ToByte => &ShortToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToUShort"]/*' />
    [NativeTypeName("#define Int16ToUShort ShortToUShort")]
    public static delegate*<short, ushort*, HRESULT> Int16ToUShort => &ShortToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToUInt16"]/*' />
    [NativeTypeName("#define Int16ToUInt16 ShortToUShort")]
    public static delegate*<short, ushort*, HRESULT> Int16ToUInt16 => &ShortToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToWord"]/*' />
    [NativeTypeName("#define Int16ToWord ShortToUShort")]
    public static delegate*<short, ushort*, HRESULT> Int16ToWord => &ShortToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToUInt"]/*' />
    [NativeTypeName("#define Int16ToUInt ShortToUInt")]
    public static delegate*<short, uint*, HRESULT> Int16ToUInt => &ShortToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToUInt32"]/*' />
    [NativeTypeName("#define Int16ToUInt32 ShortToUInt")]
    public static delegate*<short, uint*, HRESULT> Int16ToUInt32 => &ShortToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToUIntPtr"]/*' />
    [NativeTypeName("#define Int16ToUIntPtr ShortToUIntPtr")]
    public static delegate*<short, nuint*, HRESULT> Int16ToUIntPtr => &ShortToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToULong"]/*' />
    [NativeTypeName("#define Int16ToULong ShortToULong")]
    public static delegate*<short, uint*, HRESULT> Int16ToULong => &ShortToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToULongPtr"]/*' />
    [NativeTypeName("#define Int16ToULongPtr ShortToULongPtr")]
    public static delegate*<short, nuint*, HRESULT> Int16ToULongPtr => &ShortToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToDWord"]/*' />
    [NativeTypeName("#define Int16ToDWord ShortToULong")]
    public static delegate*<short, uint*, HRESULT> Int16ToDWord => &ShortToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToDWordPtr"]/*' />
    [NativeTypeName("#define Int16ToDWordPtr ShortToULongPtr")]
    public static delegate*<short, nuint*, HRESULT> Int16ToDWordPtr => &ShortToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToULongLong"]/*' />
    [NativeTypeName("#define Int16ToULongLong ShortToULongLong")]
    public static delegate*<short, ulong*, HRESULT> Int16ToULongLong => &ShortToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToDWordLong"]/*' />
    [NativeTypeName("#define Int16ToDWordLong ShortToULongLong")]
    public static delegate*<short, ulong*, HRESULT> Int16ToDWordLong => &ShortToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToULong64"]/*' />
    [NativeTypeName("#define Int16ToULong64 ShortToULongLong")]
    public static delegate*<short, ulong*, HRESULT> Int16ToULong64 => &ShortToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToDWord64"]/*' />
    [NativeTypeName("#define Int16ToDWord64 ShortToULongLong")]
    public static delegate*<short, ulong*, HRESULT> Int16ToDWord64 => &ShortToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToUInt64"]/*' />
    [NativeTypeName("#define Int16ToUInt64 ShortToULongLong")]
    public static delegate*<short, ulong*, HRESULT> Int16ToUInt64 => &ShortToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToSizeT"]/*' />
    [NativeTypeName("#define Int16ToSizeT ShortToUIntPtr")]
    public static delegate*<short, nuint*, HRESULT> Int16ToSizeT => &ShortToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int16ToSIZET"]/*' />
    [NativeTypeName("#define Int16ToSIZET ShortToULongPtr")]
    public static delegate*<short, nuint*, HRESULT> Int16ToSIZET => &ShortToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UShortToByte"]/*' />
    [NativeTypeName("#define UShortToByte UShortToUInt8")]
    public static delegate*<ushort, byte*, HRESULT> UShortToByte => &UShortToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UShortToInt16"]/*' />
    [NativeTypeName("#define UShortToInt16 UShortToShort")]
    public static delegate*<ushort, short*, HRESULT> UShortToInt16 => &UShortToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt16ToChar"]/*' />
    [NativeTypeName("#define UInt16ToChar UShortToChar")]
    public static delegate*<ushort, sbyte*, HRESULT> UInt16ToChar => &UShortToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt16ToInt8"]/*' />
    [NativeTypeName("#define UInt16ToInt8 UShortToInt8")]
    public static delegate*<ushort, sbyte*, HRESULT> UInt16ToInt8 => &UShortToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt16ToUChar"]/*' />
    [NativeTypeName("#define UInt16ToUChar UShortToUChar")]
    public static delegate*<ushort, byte*, HRESULT> UInt16ToUChar => &UShortToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt16ToUInt8"]/*' />
    [NativeTypeName("#define UInt16ToUInt8 UShortToUInt8")]
    public static delegate*<ushort, byte*, HRESULT> UInt16ToUInt8 => &UShortToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt16ToByte"]/*' />
    [NativeTypeName("#define UInt16ToByte UShortToUInt8")]
    public static delegate*<ushort, byte*, HRESULT> UInt16ToByte => &UShortToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt16ToShort"]/*' />
    [NativeTypeName("#define UInt16ToShort UShortToShort")]
    public static delegate*<ushort, short*, HRESULT> UInt16ToShort => &UShortToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt16ToInt16"]/*' />
    [NativeTypeName("#define UInt16ToInt16 UShortToShort")]
    public static delegate*<ushort, short*, HRESULT> UInt16ToInt16 => &UShortToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WordToInt8"]/*' />
    [NativeTypeName("#define WordToInt8 UShortToInt8")]
    public static delegate*<ushort, sbyte*, HRESULT> WordToInt8 => &UShortToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WordToChar"]/*' />
    [NativeTypeName("#define WordToChar UShortToChar")]
    public static delegate*<ushort, sbyte*, HRESULT> WordToChar => &UShortToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WordToUChar"]/*' />
    [NativeTypeName("#define WordToUChar UShortToUChar")]
    public static delegate*<ushort, byte*, HRESULT> WordToUChar => &UShortToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WordToUInt8"]/*' />
    [NativeTypeName("#define WordToUInt8 UShortToUInt8")]
    public static delegate*<ushort, byte*, HRESULT> WordToUInt8 => &UShortToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WordToByte"]/*' />
    [NativeTypeName("#define WordToByte UShortToUInt8")]
    public static delegate*<ushort, byte*, HRESULT> WordToByte => &UShortToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WordToShort"]/*' />
    [NativeTypeName("#define WordToShort UShortToShort")]
    public static delegate*<ushort, short*, HRESULT> WordToShort => &UShortToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WordToInt16"]/*' />
    [NativeTypeName("#define WordToInt16 UShortToShort")]
    public static delegate*<ushort, short*, HRESULT> WordToInt16 => &UShortToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToByte"]/*' />
    [NativeTypeName("#define IntToByte IntToUInt8")]
    public static delegate*<int, byte*, HRESULT> IntToByte => &IntToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToInt16"]/*' />
    [NativeTypeName("#define IntToInt16 IntToShort")]
    public static delegate*<int, short*, HRESULT> IntToInt16 => &IntToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToUInt16"]/*' />
    [NativeTypeName("#define IntToUInt16 IntToUShort")]
    public static delegate*<int, ushort*, HRESULT> IntToUInt16 => &IntToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToWord"]/*' />
    [NativeTypeName("#define IntToWord IntToUShort")]
    public static delegate*<int, ushort*, HRESULT> IntToWord => &IntToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToUIntPtr"]/*' />
    [NativeTypeName("#define IntToUIntPtr IntToULongLong")]
    public static delegate*<int, ulong*, HRESULT> IntToUIntPtr => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToULongPtr"]/*' />
    [NativeTypeName("#define IntToULongPtr IntToULongLong")]
    public static delegate*<int, ulong*, HRESULT> IntToULongPtr => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToDWord"]/*' />
    [NativeTypeName("#define IntToDWord IntToULong")]
    public static delegate*<int, uint*, HRESULT> IntToDWord => &IntToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToDWordPtr"]/*' />
    [NativeTypeName("#define IntToDWordPtr IntToULongPtr")]
    public static delegate*<int, ulong*, HRESULT> IntToDWordPtr => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToDWordLong"]/*' />
    [NativeTypeName("#define IntToDWordLong IntToULongLong")]
    public static delegate*<int, ulong*, HRESULT> IntToDWordLong => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToULong64"]/*' />
    [NativeTypeName("#define IntToULong64 IntToULongLong")]
    public static delegate*<int, ulong*, HRESULT> IntToULong64 => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToDWord64"]/*' />
    [NativeTypeName("#define IntToDWord64 IntToULongLong")]
    public static delegate*<int, ulong*, HRESULT> IntToDWord64 => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToUInt64"]/*' />
    [NativeTypeName("#define IntToUInt64 IntToULongLong")]
    public static delegate*<int, ulong*, HRESULT> IntToUInt64 => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToSizeT"]/*' />
    [NativeTypeName("#define IntToSizeT IntToUIntPtr")]
    public static delegate*<int, ulong*, HRESULT> IntToSizeT => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntToSIZET"]/*' />
    [NativeTypeName("#define IntToSIZET IntToULongPtr")]
    public static delegate*<int, ulong*, HRESULT> IntToSIZET => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToChar"]/*' />
    [NativeTypeName("#define Int32ToChar IntToChar")]
    public static delegate*<int, sbyte*, HRESULT> Int32ToChar => &IntToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToInt8"]/*' />
    [NativeTypeName("#define Int32ToInt8 IntToInt8")]
    public static delegate*<int, sbyte*, HRESULT> Int32ToInt8 => &IntToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToUChar"]/*' />
    [NativeTypeName("#define Int32ToUChar IntToUChar")]
    public static delegate*<int, byte*, HRESULT> Int32ToUChar => &IntToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToByte"]/*' />
    [NativeTypeName("#define Int32ToByte IntToUInt8")]
    public static delegate*<int, byte*, HRESULT> Int32ToByte => &IntToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToUInt8"]/*' />
    [NativeTypeName("#define Int32ToUInt8 IntToUInt8")]
    public static delegate*<int, byte*, HRESULT> Int32ToUInt8 => &IntToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToShort"]/*' />
    [NativeTypeName("#define Int32ToShort IntToShort")]
    public static delegate*<int, short*, HRESULT> Int32ToShort => &IntToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToInt16"]/*' />
    [NativeTypeName("#define Int32ToInt16 IntToShort")]
    public static delegate*<int, short*, HRESULT> Int32ToInt16 => &IntToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToUShort"]/*' />
    [NativeTypeName("#define Int32ToUShort IntToUShort")]
    public static delegate*<int, ushort*, HRESULT> Int32ToUShort => &IntToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToUInt16"]/*' />
    [NativeTypeName("#define Int32ToUInt16 IntToUShort")]
    public static delegate*<int, ushort*, HRESULT> Int32ToUInt16 => &IntToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToWord"]/*' />
    [NativeTypeName("#define Int32ToWord IntToUShort")]
    public static delegate*<int, ushort*, HRESULT> Int32ToWord => &IntToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToUInt"]/*' />
    [NativeTypeName("#define Int32ToUInt IntToUInt")]
    public static delegate*<int, uint*, HRESULT> Int32ToUInt => &IntToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToUInt32"]/*' />
    [NativeTypeName("#define Int32ToUInt32 IntToUInt")]
    public static delegate*<int, uint*, HRESULT> Int32ToUInt32 => &IntToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToUIntPtr"]/*' />
    [NativeTypeName("#define Int32ToUIntPtr IntToUIntPtr")]
    public static delegate*<int, ulong*, HRESULT> Int32ToUIntPtr => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToULong"]/*' />
    [NativeTypeName("#define Int32ToULong IntToULong")]
    public static delegate*<int, uint*, HRESULT> Int32ToULong => &IntToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToULongPtr"]/*' />
    [NativeTypeName("#define Int32ToULongPtr IntToULongPtr")]
    public static delegate*<int, ulong*, HRESULT> Int32ToULongPtr => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToDWord"]/*' />
    [NativeTypeName("#define Int32ToDWord IntToULong")]
    public static delegate*<int, uint*, HRESULT> Int32ToDWord => &IntToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToDWordPtr"]/*' />
    [NativeTypeName("#define Int32ToDWordPtr IntToULongPtr")]
    public static delegate*<int, ulong*, HRESULT> Int32ToDWordPtr => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToULongLong"]/*' />
    [NativeTypeName("#define Int32ToULongLong IntToULongLong")]
    public static delegate*<int, ulong*, HRESULT> Int32ToULongLong => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToDWordLong"]/*' />
    [NativeTypeName("#define Int32ToDWordLong IntToULongLong")]
    public static delegate*<int, ulong*, HRESULT> Int32ToDWordLong => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToULong64"]/*' />
    [NativeTypeName("#define Int32ToULong64 IntToULongLong")]
    public static delegate*<int, ulong*, HRESULT> Int32ToULong64 => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToDWord64"]/*' />
    [NativeTypeName("#define Int32ToDWord64 IntToULongLong")]
    public static delegate*<int, ulong*, HRESULT> Int32ToDWord64 => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToUInt64"]/*' />
    [NativeTypeName("#define Int32ToUInt64 IntToULongLong")]
    public static delegate*<int, ulong*, HRESULT> Int32ToUInt64 => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToSizeT"]/*' />
    [NativeTypeName("#define Int32ToSizeT IntToUIntPtr")]
    public static delegate*<int, ulong*, HRESULT> Int32ToSizeT => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int32ToSIZET"]/*' />
    [NativeTypeName("#define Int32ToSIZET IntToULongPtr")]
    public static delegate*<int, ulong*, HRESULT> Int32ToSIZET => &IntToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToByte"]/*' />
    [NativeTypeName("#define IntPtrToByte IntPtrToUInt8")]
    public static delegate*<nint, byte*, HRESULT> IntPtrToByte => &IntPtrToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToInt16"]/*' />
    [NativeTypeName("#define IntPtrToInt16 IntPtrToShort")]
    public static delegate*<nint, short*, HRESULT> IntPtrToInt16 => &IntPtrToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToUInt16"]/*' />
    [NativeTypeName("#define IntPtrToUInt16 IntPtrToUShort")]
    public static delegate*<nint, ushort*, HRESULT> IntPtrToUInt16 => &IntPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToWord"]/*' />
    [NativeTypeName("#define IntPtrToWord IntPtrToUShort")]
    public static delegate*<nint, ushort*, HRESULT> IntPtrToWord => &IntPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToInt"]/*' />
    [NativeTypeName("#define IntPtrToInt LongLongToInt")]
    public static delegate*<long, int*, HRESULT> IntPtrToInt => &LongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToInt32"]/*' />
    [NativeTypeName("#define IntPtrToInt32 IntPtrToInt")]
    public static delegate*<long, int*, HRESULT> IntPtrToInt32 => &LongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToUInt"]/*' />
    [NativeTypeName("#define IntPtrToUInt LongLongToUInt")]
    public static delegate*<long, uint*, HRESULT> IntPtrToUInt => &LongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToUInt32"]/*' />
    [NativeTypeName("#define IntPtrToUInt32 IntPtrToUInt")]
    public static delegate*<long, uint*, HRESULT> IntPtrToUInt32 => &LongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToUIntPtr"]/*' />
    [NativeTypeName("#define IntPtrToUIntPtr LongLongToULongLong")]
    public static delegate*<long, ulong*, HRESULT> IntPtrToUIntPtr => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToLong"]/*' />
    [NativeTypeName("#define IntPtrToLong LongLongToLong")]
    public static delegate*<long, int*, HRESULT> IntPtrToLong => &LongLongToLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToULong"]/*' />
    [NativeTypeName("#define IntPtrToULong LongLongToULong")]
    public static delegate*<long, uint*, HRESULT> IntPtrToULong => &LongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToULongPtr"]/*' />
    [NativeTypeName("#define IntPtrToULongPtr LongLongToULongLong")]
    public static delegate*<long, ulong*, HRESULT> IntPtrToULongPtr => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToDWord"]/*' />
    [NativeTypeName("#define IntPtrToDWord IntPtrToULong")]
    public static delegate*<long, uint*, HRESULT> IntPtrToDWord => &LongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToDWordPtr"]/*' />
    [NativeTypeName("#define IntPtrToDWordPtr IntPtrToULongPtr")]
    public static delegate*<long, ulong*, HRESULT> IntPtrToDWordPtr => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToULongLong"]/*' />
    [NativeTypeName("#define IntPtrToULongLong LongLongToULongLong")]
    public static delegate*<long, ulong*, HRESULT> IntPtrToULongLong => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToDWordLong"]/*' />
    [NativeTypeName("#define IntPtrToDWordLong IntPtrToULongLong")]
    public static delegate*<long, ulong*, HRESULT> IntPtrToDWordLong => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToULong64"]/*' />
    [NativeTypeName("#define IntPtrToULong64 IntPtrToULongLong")]
    public static delegate*<long, ulong*, HRESULT> IntPtrToULong64 => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToDWord64"]/*' />
    [NativeTypeName("#define IntPtrToDWord64 IntPtrToULongLong")]
    public static delegate*<long, ulong*, HRESULT> IntPtrToDWord64 => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToUInt64"]/*' />
    [NativeTypeName("#define IntPtrToUInt64 IntPtrToULongLong")]
    public static delegate*<long, ulong*, HRESULT> IntPtrToUInt64 => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToSizeT"]/*' />
    [NativeTypeName("#define IntPtrToSizeT IntPtrToUIntPtr")]
    public static delegate*<long, ulong*, HRESULT> IntPtrToSizeT => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntPtrToSIZET"]/*' />
    [NativeTypeName("#define IntPtrToSIZET IntPtrToULongPtr")]
    public static delegate*<long, ulong*, HRESULT> IntPtrToSIZET => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntToByte"]/*' />
    [NativeTypeName("#define UIntToByte UIntToUInt8")]
    public static delegate*<uint, byte*, HRESULT> UIntToByte => &UIntToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntToInt16"]/*' />
    [NativeTypeName("#define UIntToInt16 UIntToShort")]
    public static delegate*<uint, short*, HRESULT> UIntToInt16 => &UIntToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntToUInt16"]/*' />
    [NativeTypeName("#define UIntToUInt16 UIntToUShort")]
    public static delegate*<uint, ushort*, HRESULT> UIntToUInt16 => &UIntToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntToWord"]/*' />
    [NativeTypeName("#define UIntToWord UIntToUShort")]
    public static delegate*<uint, ushort*, HRESULT> UIntToWord => &UIntToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntToInt32"]/*' />
    [NativeTypeName("#define UIntToInt32 UIntToInt")]
    public static delegate*<uint, int*, HRESULT> UIntToInt32 => &UIntToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntToPtrdiffT"]/*' />
    [NativeTypeName("#define UIntToPtrdiffT UIntToIntPtr")]
    public static delegate*<uint, nint*, HRESULT> UIntToPtrdiffT => &UIntToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntToSSIZET"]/*' />
    [NativeTypeName("#define UIntToSSIZET UIntToLongPtr")]
    public static delegate*<uint, nint*, HRESULT> UIntToSSIZET => &UIntToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToChar"]/*' />
    [NativeTypeName("#define UInt32ToChar UIntToChar")]
    public static delegate*<uint, sbyte*, HRESULT> UInt32ToChar => &UIntToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToInt8"]/*' />
    [NativeTypeName("#define UInt32ToInt8 UIntToInt8")]
    public static delegate*<uint, sbyte*, HRESULT> UInt32ToInt8 => &UIntToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToUChar"]/*' />
    [NativeTypeName("#define UInt32ToUChar UIntToUChar")]
    public static delegate*<uint, byte*, HRESULT> UInt32ToUChar => &UIntToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToUInt8"]/*' />
    [NativeTypeName("#define UInt32ToUInt8 UIntToUInt8")]
    public static delegate*<uint, byte*, HRESULT> UInt32ToUInt8 => &UIntToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToByte"]/*' />
    [NativeTypeName("#define UInt32ToByte UInt32ToUInt8")]
    public static delegate*<uint, byte*, HRESULT> UInt32ToByte => &UIntToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToShort"]/*' />
    [NativeTypeName("#define UInt32ToShort UIntToShort")]
    public static delegate*<uint, short*, HRESULT> UInt32ToShort => &UIntToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToInt16"]/*' />
    [NativeTypeName("#define UInt32ToInt16 UIntToShort")]
    public static delegate*<uint, short*, HRESULT> UInt32ToInt16 => &UIntToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToUShort"]/*' />
    [NativeTypeName("#define UInt32ToUShort UIntToUShort")]
    public static delegate*<uint, ushort*, HRESULT> UInt32ToUShort => &UIntToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToUInt16"]/*' />
    [NativeTypeName("#define UInt32ToUInt16 UIntToUShort")]
    public static delegate*<uint, ushort*, HRESULT> UInt32ToUInt16 => &UIntToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToWord"]/*' />
    [NativeTypeName("#define UInt32ToWord UIntToUShort")]
    public static delegate*<uint, ushort*, HRESULT> UInt32ToWord => &UIntToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToInt"]/*' />
    [NativeTypeName("#define UInt32ToInt UIntToInt")]
    public static delegate*<uint, int*, HRESULT> UInt32ToInt => &UIntToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToIntPtr"]/*' />
    [NativeTypeName("#define UInt32ToIntPtr UIntToIntPtr")]
    public static delegate*<uint, nint*, HRESULT> UInt32ToIntPtr => &UIntToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToInt32"]/*' />
    [NativeTypeName("#define UInt32ToInt32 UIntToInt")]
    public static delegate*<uint, int*, HRESULT> UInt32ToInt32 => &UIntToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToLong"]/*' />
    [NativeTypeName("#define UInt32ToLong UIntToLong")]
    public static delegate*<uint, int*, HRESULT> UInt32ToLong => &UIntToLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToLongPtr"]/*' />
    [NativeTypeName("#define UInt32ToLongPtr UIntToLongPtr")]
    public static delegate*<uint, nint*, HRESULT> UInt32ToLongPtr => &UIntToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToPtrdiffT"]/*' />
    [NativeTypeName("#define UInt32ToPtrdiffT UIntToPtrdiffT")]
    public static delegate*<uint, nint*, HRESULT> UInt32ToPtrdiffT => &UIntToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32ToSSIZET"]/*' />
    [NativeTypeName("#define UInt32ToSSIZET UIntToSSIZET")]
    public static delegate*<uint, nint*, HRESULT> UInt32ToSSIZET => &UIntToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToByte"]/*' />
    [NativeTypeName("#define UIntPtrToByte UIntPtrToUInt8")]
    public static delegate*<nuint, byte*, HRESULT> UIntPtrToByte => &UIntPtrToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToWord"]/*' />
    [NativeTypeName("#define UIntPtrToWord UIntPtrToUShort")]
    public static delegate*<nuint, ushort*, HRESULT> UIntPtrToWord => &UIntPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToInt32"]/*' />
    [NativeTypeName("#define UIntPtrToInt32 UIntPtrToInt")]
    public static delegate*<nuint, int*, HRESULT> UIntPtrToInt32 => &UIntPtrToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToUInt"]/*' />
    [NativeTypeName("#define UIntPtrToUInt ULongLongToUInt")]
    public static delegate*<ulong, uint*, HRESULT> UIntPtrToUInt => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToUInt32"]/*' />
    [NativeTypeName("#define UIntPtrToUInt32 UIntPtrToUInt")]
    public static delegate*<ulong, uint*, HRESULT> UIntPtrToUInt32 => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToULong"]/*' />
    [NativeTypeName("#define UIntPtrToULong ULongLongToULong")]
    public static delegate*<ulong, uint*, HRESULT> UIntPtrToULong => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToDWord"]/*' />
    [NativeTypeName("#define UIntPtrToDWord UIntPtrToULong")]
    public static delegate*<ulong, uint*, HRESULT> UIntPtrToDWord => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToLongLong"]/*' />
    [NativeTypeName("#define UIntPtrToLongLong ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> UIntPtrToLongLong => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToLong64"]/*' />
    [NativeTypeName("#define UIntPtrToLong64 UIntPtrToLongLong")]
    public static delegate*<ulong, long*, HRESULT> UIntPtrToLong64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToInt64"]/*' />
    [NativeTypeName("#define UIntPtrToInt64 UIntPtrToLongLong")]
    public static delegate*<ulong, long*, HRESULT> UIntPtrToInt64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToPtrdiffT"]/*' />
    [NativeTypeName("#define UIntPtrToPtrdiffT UIntPtrToIntPtr")]
    public static delegate*<nuint, nint*, HRESULT> UIntPtrToPtrdiffT => &UIntPtrToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrToSSIZET"]/*' />
    [NativeTypeName("#define UIntPtrToSSIZET UIntPtrToLongPtr")]
    public static delegate*<nuint, nint*, HRESULT> UIntPtrToSSIZET => &UIntPtrToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToByte"]/*' />
    [NativeTypeName("#define LongToByte LongToUInt8")]
    public static delegate*<int, byte*, HRESULT> LongToByte => &LongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToInt16"]/*' />
    [NativeTypeName("#define LongToInt16 LongToShort")]
    public static delegate*<int, short*, HRESULT> LongToInt16 => &LongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToUInt16"]/*' />
    [NativeTypeName("#define LongToUInt16 LongToUShort")]
    public static delegate*<int, ushort*, HRESULT> LongToUInt16 => &LongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToWord"]/*' />
    [NativeTypeName("#define LongToWord LongToUShort")]
    public static delegate*<int, ushort*, HRESULT> LongToWord => &LongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToInt32"]/*' />
    [NativeTypeName("#define LongToInt32 LongToInt")]
    public static delegate*<int, int*, HRESULT> LongToInt32 => &LongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToUInt32"]/*' />
    [NativeTypeName("#define LongToUInt32 LongToUInt")]
    public static delegate*<int, uint*, HRESULT> LongToUInt32 => &LongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToDWord"]/*' />
    [NativeTypeName("#define LongToDWord LongToULong")]
    public static delegate*<int, uint*, HRESULT> LongToDWord => &LongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToDWordPtr"]/*' />
    [NativeTypeName("#define LongToDWordPtr LongToULongPtr")]
    public static delegate*<int, nuint*, HRESULT> LongToDWordPtr => &LongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToDWordLong"]/*' />
    [NativeTypeName("#define LongToDWordLong LongToULongLong")]
    public static delegate*<int, ulong*, HRESULT> LongToDWordLong => &LongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToULong64"]/*' />
    [NativeTypeName("#define LongToULong64 LongToULongLong")]
    public static delegate*<int, ulong*, HRESULT> LongToULong64 => &LongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToDWord64"]/*' />
    [NativeTypeName("#define LongToDWord64 LongToULongLong")]
    public static delegate*<int, ulong*, HRESULT> LongToDWord64 => &LongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToUInt64"]/*' />
    [NativeTypeName("#define LongToUInt64 LongToULongLong")]
    public static delegate*<int, ulong*, HRESULT> LongToUInt64 => &LongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToPtrdiffT"]/*' />
    [NativeTypeName("#define LongToPtrdiffT LongToIntPtr")]
    public static delegate*<int, nint*, HRESULT> LongToPtrdiffT => &LongToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToSizeT"]/*' />
    [NativeTypeName("#define LongToSizeT LongToUIntPtr")]
    public static delegate*<int, nuint*, HRESULT> LongToSizeT => &LongToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongToSIZET"]/*' />
    [NativeTypeName("#define LongToSIZET LongToULongPtr")]
    public static delegate*<int, nuint*, HRESULT> LongToSIZET => &LongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToByte"]/*' />
    [NativeTypeName("#define LongPtrToByte LongPtrToUInt8")]
    public static delegate*<nint, byte*, HRESULT> LongPtrToByte => &LongPtrToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToInt16"]/*' />
    [NativeTypeName("#define LongPtrToInt16 LongPtrToShort")]
    public static delegate*<nint, short*, HRESULT> LongPtrToInt16 => &LongPtrToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToUInt16"]/*' />
    [NativeTypeName("#define LongPtrToUInt16 LongPtrToUShort")]
    public static delegate*<nint, ushort*, HRESULT> LongPtrToUInt16 => &LongPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToWord"]/*' />
    [NativeTypeName("#define LongPtrToWord LongPtrToUShort")]
    public static delegate*<nint, ushort*, HRESULT> LongPtrToWord => &LongPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToInt"]/*' />
    [NativeTypeName("#define LongPtrToInt LongLongToInt")]
    public static delegate*<long, int*, HRESULT> LongPtrToInt => &LongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToInt32"]/*' />
    [NativeTypeName("#define LongPtrToInt32 LongPtrToInt")]
    public static delegate*<long, int*, HRESULT> LongPtrToInt32 => &LongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToUInt"]/*' />
    [NativeTypeName("#define LongPtrToUInt LongLongToUInt")]
    public static delegate*<long, uint*, HRESULT> LongPtrToUInt => &LongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToUInt32"]/*' />
    [NativeTypeName("#define LongPtrToUInt32 LongPtrToUInt")]
    public static delegate*<long, uint*, HRESULT> LongPtrToUInt32 => &LongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToLong"]/*' />
    [NativeTypeName("#define LongPtrToLong LongLongToLong")]
    public static delegate*<long, int*, HRESULT> LongPtrToLong => &LongLongToLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToULong"]/*' />
    [NativeTypeName("#define LongPtrToULong LongLongToULong")]
    public static delegate*<long, uint*, HRESULT> LongPtrToULong => &LongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToDWord"]/*' />
    [NativeTypeName("#define LongPtrToDWord LongPtrToULong")]
    public static delegate*<long, uint*, HRESULT> LongPtrToDWord => &LongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToDWordPtr"]/*' />
    [NativeTypeName("#define LongPtrToDWordPtr LongPtrToULongPtr")]
    public static delegate*<nint, nuint*, HRESULT> LongPtrToDWordPtr => &LongPtrToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToDWordLong"]/*' />
    [NativeTypeName("#define LongPtrToDWordLong LongPtrToULongLong")]
    public static delegate*<nint, ulong*, HRESULT> LongPtrToDWordLong => &LongPtrToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToULong64"]/*' />
    [NativeTypeName("#define LongPtrToULong64 LongPtrToULongLong")]
    public static delegate*<nint, ulong*, HRESULT> LongPtrToULong64 => &LongPtrToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToDWord64"]/*' />
    [NativeTypeName("#define LongPtrToDWord64 LongPtrToULongLong")]
    public static delegate*<nint, ulong*, HRESULT> LongPtrToDWord64 => &LongPtrToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToUInt64"]/*' />
    [NativeTypeName("#define LongPtrToUInt64 LongPtrToULongLong")]
    public static delegate*<nint, ulong*, HRESULT> LongPtrToUInt64 => &LongPtrToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToSizeT"]/*' />
    [NativeTypeName("#define LongPtrToSizeT LongPtrToUIntPtr")]
    public static delegate*<nint, nuint*, HRESULT> LongPtrToSizeT => &LongPtrToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongPtrToSIZET"]/*' />
    [NativeTypeName("#define LongPtrToSIZET LongPtrToULongPtr")]
    public static delegate*<nint, nuint*, HRESULT> LongPtrToSIZET => &LongPtrToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToByte"]/*' />
    [NativeTypeName("#define ULongToByte ULongToUInt8")]
    public static delegate*<uint, byte*, HRESULT> ULongToByte => &ULongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToInt16"]/*' />
    [NativeTypeName("#define ULongToInt16 ULongToShort")]
    public static delegate*<uint, short*, HRESULT> ULongToInt16 => &ULongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToUInt16"]/*' />
    [NativeTypeName("#define ULongToUInt16 ULongToUShort")]
    public static delegate*<uint, ushort*, HRESULT> ULongToUInt16 => &ULongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToWord"]/*' />
    [NativeTypeName("#define ULongToWord ULongToUShort")]
    public static delegate*<uint, ushort*, HRESULT> ULongToWord => &ULongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToInt32"]/*' />
    [NativeTypeName("#define ULongToInt32 ULongToInt")]
    public static delegate*<uint, int*, HRESULT> ULongToInt32 => &ULongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToUInt32"]/*' />
    [NativeTypeName("#define ULongToUInt32 ULongToUInt")]
    public static delegate*<uint, uint*, HRESULT> ULongToUInt32 => &ULongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToPtrdiffT"]/*' />
    [NativeTypeName("#define ULongToPtrdiffT ULongToIntPtr")]
    public static delegate*<uint, nint*, HRESULT> ULongToPtrdiffT => &ULongToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongToSSIZET"]/*' />
    [NativeTypeName("#define ULongToSSIZET ULongToLongPtr")]
    public static delegate*<uint, nint*, HRESULT> ULongToSSIZET => &ULongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToByte"]/*' />
    [NativeTypeName("#define ULongPtrToByte ULongPtrToUInt8")]
    public static delegate*<nuint, byte*, HRESULT> ULongPtrToByte => &ULongPtrToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToInt16"]/*' />
    [NativeTypeName("#define ULongPtrToInt16 ULongPtrToShort")]
    public static delegate*<nuint, short*, HRESULT> ULongPtrToInt16 => &ULongPtrToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToUInt16"]/*' />
    [NativeTypeName("#define ULongPtrToUInt16 ULongPtrToUShort")]
    public static delegate*<nuint, ushort*, HRESULT> ULongPtrToUInt16 => &ULongPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToWord"]/*' />
    [NativeTypeName("#define ULongPtrToWord ULongPtrToUShort")]
    public static delegate*<nuint, ushort*, HRESULT> ULongPtrToWord => &ULongPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToInt32"]/*' />
    [NativeTypeName("#define ULongPtrToInt32 ULongPtrToInt")]
    public static delegate*<nuint, int*, HRESULT> ULongPtrToInt32 => &ULongPtrToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToUInt"]/*' />
    [NativeTypeName("#define ULongPtrToUInt ULongLongToUInt")]
    public static delegate*<ulong, uint*, HRESULT> ULongPtrToUInt => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToUInt32"]/*' />
    [NativeTypeName("#define ULongPtrToUInt32 ULongPtrToUInt")]
    public static delegate*<ulong, uint*, HRESULT> ULongPtrToUInt32 => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToULong"]/*' />
    [NativeTypeName("#define ULongPtrToULong ULongLongToULong")]
    public static delegate*<ulong, uint*, HRESULT> ULongPtrToULong => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToDWord"]/*' />
    [NativeTypeName("#define ULongPtrToDWord ULongPtrToULong")]
    public static delegate*<ulong, uint*, HRESULT> ULongPtrToDWord => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToLongLong"]/*' />
    [NativeTypeName("#define ULongPtrToLongLong ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> ULongPtrToLongLong => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToLong64"]/*' />
    [NativeTypeName("#define ULongPtrToLong64 ULongPtrToLongLong")]
    public static delegate*<ulong, long*, HRESULT> ULongPtrToLong64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToInt64"]/*' />
    [NativeTypeName("#define ULongPtrToInt64 ULongPtrToLongLong")]
    public static delegate*<ulong, long*, HRESULT> ULongPtrToInt64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToPtrdiffT"]/*' />
    [NativeTypeName("#define ULongPtrToPtrdiffT ULongPtrToIntPtr")]
    public static delegate*<nuint, nint*, HRESULT> ULongPtrToPtrdiffT => &ULongPtrToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrToSSIZET"]/*' />
    [NativeTypeName("#define ULongPtrToSSIZET ULongPtrToLongPtr")]
    public static delegate*<nuint, nint*, HRESULT> ULongPtrToSSIZET => &ULongPtrToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToInt8"]/*' />
    [NativeTypeName("#define DWordToInt8 ULongToInt8")]
    public static delegate*<uint, sbyte*, HRESULT> DWordToInt8 => &ULongToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToChar"]/*' />
    [NativeTypeName("#define DWordToChar ULongToChar")]
    public static delegate*<uint, sbyte*, HRESULT> DWordToChar => &ULongToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToUChar"]/*' />
    [NativeTypeName("#define DWordToUChar ULongToUChar")]
    public static delegate*<uint, byte*, HRESULT> DWordToUChar => &ULongToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToUInt8"]/*' />
    [NativeTypeName("#define DWordToUInt8 ULongToUInt8")]
    public static delegate*<uint, byte*, HRESULT> DWordToUInt8 => &ULongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToByte"]/*' />
    [NativeTypeName("#define DWordToByte ULongToUInt8")]
    public static delegate*<uint, byte*, HRESULT> DWordToByte => &ULongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToShort"]/*' />
    [NativeTypeName("#define DWordToShort ULongToShort")]
    public static delegate*<uint, short*, HRESULT> DWordToShort => &ULongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToInt16"]/*' />
    [NativeTypeName("#define DWordToInt16 ULongToShort")]
    public static delegate*<uint, short*, HRESULT> DWordToInt16 => &ULongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToUShort"]/*' />
    [NativeTypeName("#define DWordToUShort ULongToUShort")]
    public static delegate*<uint, ushort*, HRESULT> DWordToUShort => &ULongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToUInt16"]/*' />
    [NativeTypeName("#define DWordToUInt16 ULongToUShort")]
    public static delegate*<uint, ushort*, HRESULT> DWordToUInt16 => &ULongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToWord"]/*' />
    [NativeTypeName("#define DWordToWord ULongToUShort")]
    public static delegate*<uint, ushort*, HRESULT> DWordToWord => &ULongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToInt"]/*' />
    [NativeTypeName("#define DWordToInt ULongToInt")]
    public static delegate*<uint, int*, HRESULT> DWordToInt => &ULongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToInt32"]/*' />
    [NativeTypeName("#define DWordToInt32 ULongToInt")]
    public static delegate*<uint, int*, HRESULT> DWordToInt32 => &ULongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToIntPtr"]/*' />
    [NativeTypeName("#define DWordToIntPtr ULongToIntPtr")]
    public static delegate*<uint, nint*, HRESULT> DWordToIntPtr => &ULongToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToUInt"]/*' />
    [NativeTypeName("#define DWordToUInt ULongToUInt")]
    public static delegate*<uint, uint*, HRESULT> DWordToUInt => &ULongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToUInt32"]/*' />
    [NativeTypeName("#define DWordToUInt32 ULongToUInt")]
    public static delegate*<uint, uint*, HRESULT> DWordToUInt32 => &ULongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToUIntPtr"]/*' />
    [NativeTypeName("#define DWordToUIntPtr ULongToUIntPtr")]
    public static delegate*<uint, nuint*, HRESULT> DWordToUIntPtr => &ULongToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToLong"]/*' />
    [NativeTypeName("#define DWordToLong ULongToLong")]
    public static delegate*<uint, int*, HRESULT> DWordToLong => &ULongToLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToLongPtr"]/*' />
    [NativeTypeName("#define DWordToLongPtr ULongToLongPtr")]
    public static delegate*<uint, nint*, HRESULT> DWordToLongPtr => &ULongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToPtrdiffT"]/*' />
    [NativeTypeName("#define DWordToPtrdiffT ULongToIntPtr")]
    public static delegate*<uint, nint*, HRESULT> DWordToPtrdiffT => &ULongToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordToSSIZET"]/*' />
    [NativeTypeName("#define DWordToSSIZET ULongToLongPtr")]
    public static delegate*<uint, nint*, HRESULT> DWordToSSIZET => &ULongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToInt8"]/*' />
    [NativeTypeName("#define DWordPtrToInt8 ULongPtrToInt8")]
    public static delegate*<nuint, sbyte*, HRESULT> DWordPtrToInt8 => &ULongPtrToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToUChar"]/*' />
    [NativeTypeName("#define DWordPtrToUChar ULongPtrToUChar")]
    public static delegate*<nuint, byte*, HRESULT> DWordPtrToUChar => &ULongPtrToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToChar"]/*' />
    [NativeTypeName("#define DWordPtrToChar ULongPtrToChar")]
    public static delegate*<nuint, sbyte*, HRESULT> DWordPtrToChar => &ULongPtrToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToUInt8"]/*' />
    [NativeTypeName("#define DWordPtrToUInt8 ULongPtrToUInt8")]
    public static delegate*<nuint, byte*, HRESULT> DWordPtrToUInt8 => &ULongPtrToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToByte"]/*' />
    [NativeTypeName("#define DWordPtrToByte ULongPtrToUInt8")]
    public static delegate*<nuint, byte*, HRESULT> DWordPtrToByte => &ULongPtrToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToShort"]/*' />
    [NativeTypeName("#define DWordPtrToShort ULongPtrToShort")]
    public static delegate*<nuint, short*, HRESULT> DWordPtrToShort => &ULongPtrToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToInt16"]/*' />
    [NativeTypeName("#define DWordPtrToInt16 ULongPtrToShort")]
    public static delegate*<nuint, short*, HRESULT> DWordPtrToInt16 => &ULongPtrToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToUShort"]/*' />
    [NativeTypeName("#define DWordPtrToUShort ULongPtrToUShort")]
    public static delegate*<nuint, ushort*, HRESULT> DWordPtrToUShort => &ULongPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToUInt16"]/*' />
    [NativeTypeName("#define DWordPtrToUInt16 ULongPtrToUShort")]
    public static delegate*<nuint, ushort*, HRESULT> DWordPtrToUInt16 => &ULongPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToWord"]/*' />
    [NativeTypeName("#define DWordPtrToWord ULongPtrToUShort")]
    public static delegate*<nuint, ushort*, HRESULT> DWordPtrToWord => &ULongPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToInt"]/*' />
    [NativeTypeName("#define DWordPtrToInt ULongPtrToInt")]
    public static delegate*<nuint, int*, HRESULT> DWordPtrToInt => &ULongPtrToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToInt32"]/*' />
    [NativeTypeName("#define DWordPtrToInt32 ULongPtrToInt")]
    public static delegate*<nuint, int*, HRESULT> DWordPtrToInt32 => &ULongPtrToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToIntPtr"]/*' />
    [NativeTypeName("#define DWordPtrToIntPtr ULongPtrToIntPtr")]
    public static delegate*<nuint, nint*, HRESULT> DWordPtrToIntPtr => &ULongPtrToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToUInt"]/*' />
    [NativeTypeName("#define DWordPtrToUInt ULongPtrToUInt")]
    public static delegate*<ulong, uint*, HRESULT> DWordPtrToUInt => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToUInt32"]/*' />
    [NativeTypeName("#define DWordPtrToUInt32 ULongPtrToUInt")]
    public static delegate*<ulong, uint*, HRESULT> DWordPtrToUInt32 => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToUIntPtr"]/*' />
    [NativeTypeName("#define DWordPtrToUIntPtr ULongPtrToUIntPtr")]
    public static delegate*<nuint, nuint*, HRESULT> DWordPtrToUIntPtr => &ULongPtrToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToLong"]/*' />
    [NativeTypeName("#define DWordPtrToLong ULongPtrToLong")]
    public static delegate*<nuint, int*, HRESULT> DWordPtrToLong => &ULongPtrToLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToLongPtr"]/*' />
    [NativeTypeName("#define DWordPtrToLongPtr ULongPtrToLongPtr")]
    public static delegate*<nuint, nint*, HRESULT> DWordPtrToLongPtr => &ULongPtrToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToULong"]/*' />
    [NativeTypeName("#define DWordPtrToULong ULongPtrToULong")]
    public static delegate*<ulong, uint*, HRESULT> DWordPtrToULong => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToDWord"]/*' />
    [NativeTypeName("#define DWordPtrToDWord ULongPtrToULong")]
    public static delegate*<ulong, uint*, HRESULT> DWordPtrToDWord => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToLongLong"]/*' />
    [NativeTypeName("#define DWordPtrToLongLong ULongPtrToLongLong")]
    public static delegate*<ulong, long*, HRESULT> DWordPtrToLongLong => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToLong64"]/*' />
    [NativeTypeName("#define DWordPtrToLong64 ULongPtrToLongLong")]
    public static delegate*<ulong, long*, HRESULT> DWordPtrToLong64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToInt64"]/*' />
    [NativeTypeName("#define DWordPtrToInt64 ULongPtrToLongLong")]
    public static delegate*<ulong, long*, HRESULT> DWordPtrToInt64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToPtrdiffT"]/*' />
    [NativeTypeName("#define DWordPtrToPtrdiffT ULongPtrToIntPtr")]
    public static delegate*<nuint, nint*, HRESULT> DWordPtrToPtrdiffT => &ULongPtrToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrToSSIZET"]/*' />
    [NativeTypeName("#define DWordPtrToSSIZET ULongPtrToLongPtr")]
    public static delegate*<nuint, nint*, HRESULT> DWordPtrToSSIZET => &ULongPtrToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToByte"]/*' />
    [NativeTypeName("#define LongLongToByte LongLongToUInt8")]
    public static delegate*<long, byte*, HRESULT> LongLongToByte => &LongLongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToInt16"]/*' />
    [NativeTypeName("#define LongLongToInt16 LongLongToShort")]
    public static delegate*<long, short*, HRESULT> LongLongToInt16 => &LongLongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToUInt16"]/*' />
    [NativeTypeName("#define LongLongToUInt16 LongLongToUShort")]
    public static delegate*<long, ushort*, HRESULT> LongLongToUInt16 => &LongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToWord"]/*' />
    [NativeTypeName("#define LongLongToWord LongLongToUShort")]
    public static delegate*<long, ushort*, HRESULT> LongLongToWord => &LongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToInt32"]/*' />
    [NativeTypeName("#define LongLongToInt32 LongLongToInt")]
    public static delegate*<long, int*, HRESULT> LongLongToInt32 => &LongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToUInt32"]/*' />
    [NativeTypeName("#define LongLongToUInt32 LongLongToUInt")]
    public static delegate*<long, uint*, HRESULT> LongLongToUInt32 => &LongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToUIntPtr"]/*' />
    [NativeTypeName("#define LongLongToUIntPtr LongLongToULongLong")]
    public static delegate*<long, ulong*, HRESULT> LongLongToUIntPtr => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToULongPtr"]/*' />
    [NativeTypeName("#define LongLongToULongPtr LongLongToULongLong")]
    public static delegate*<long, ulong*, HRESULT> LongLongToULongPtr => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToDWord"]/*' />
    [NativeTypeName("#define LongLongToDWord LongLongToULong")]
    public static delegate*<long, uint*, HRESULT> LongLongToDWord => &LongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToDWordPtr"]/*' />
    [NativeTypeName("#define LongLongToDWordPtr LongLongToULongPtr")]
    public static delegate*<long, ulong*, HRESULT> LongLongToDWordPtr => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToDWordLong"]/*' />
    [NativeTypeName("#define LongLongToDWordLong LongLongToULongLong")]
    public static delegate*<long, ulong*, HRESULT> LongLongToDWordLong => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToULong64"]/*' />
    [NativeTypeName("#define LongLongToULong64 LongLongToULongLong")]
    public static delegate*<long, ulong*, HRESULT> LongLongToULong64 => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToDWord64"]/*' />
    [NativeTypeName("#define LongLongToDWord64 LongLongToULongLong")]
    public static delegate*<long, ulong*, HRESULT> LongLongToDWord64 => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToUInt64"]/*' />
    [NativeTypeName("#define LongLongToUInt64 LongLongToULongLong")]
    public static delegate*<long, ulong*, HRESULT> LongLongToUInt64 => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToPtrdiffT"]/*' />
    [NativeTypeName("#define LongLongToPtrdiffT LongLongToIntPtr")]
    public static delegate*<long, nint*, HRESULT> LongLongToPtrdiffT => &LongLongToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToSizeT"]/*' />
    [NativeTypeName("#define LongLongToSizeT LongLongToUIntPtr")]
    public static delegate*<long, ulong*, HRESULT> LongLongToSizeT => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToSSIZET"]/*' />
    [NativeTypeName("#define LongLongToSSIZET LongLongToLongPtr")]
    public static delegate*<long, nint*, HRESULT> LongLongToSSIZET => &LongLongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LongLongToSIZET"]/*' />
    [NativeTypeName("#define LongLongToSIZET LongLongToULongPtr")]
    public static delegate*<long, ulong*, HRESULT> LongLongToSIZET => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToChar"]/*' />
    [NativeTypeName("#define Long64ToChar LongLongToChar")]
    public static delegate*<long, sbyte*, HRESULT> Long64ToChar => &LongLongToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToInt8"]/*' />
    [NativeTypeName("#define Long64ToInt8 LongLongToInt8")]
    public static delegate*<long, sbyte*, HRESULT> Long64ToInt8 => &LongLongToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToUChar"]/*' />
    [NativeTypeName("#define Long64ToUChar LongLongToUChar")]
    public static delegate*<long, byte*, HRESULT> Long64ToUChar => &LongLongToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToUInt8"]/*' />
    [NativeTypeName("#define Long64ToUInt8 LongLongToUInt8")]
    public static delegate*<long, byte*, HRESULT> Long64ToUInt8 => &LongLongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToByte"]/*' />
    [NativeTypeName("#define Long64ToByte LongLongToUInt8")]
    public static delegate*<long, byte*, HRESULT> Long64ToByte => &LongLongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToShort"]/*' />
    [NativeTypeName("#define Long64ToShort LongLongToShort")]
    public static delegate*<long, short*, HRESULT> Long64ToShort => &LongLongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToInt16"]/*' />
    [NativeTypeName("#define Long64ToInt16 LongLongToShort")]
    public static delegate*<long, short*, HRESULT> Long64ToInt16 => &LongLongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToUShort"]/*' />
    [NativeTypeName("#define Long64ToUShort LongLongToUShort")]
    public static delegate*<long, ushort*, HRESULT> Long64ToUShort => &LongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToUInt16"]/*' />
    [NativeTypeName("#define Long64ToUInt16 LongLongToUShort")]
    public static delegate*<long, ushort*, HRESULT> Long64ToUInt16 => &LongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToWord"]/*' />
    [NativeTypeName("#define Long64ToWord LongLongToUShort")]
    public static delegate*<long, ushort*, HRESULT> Long64ToWord => &LongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToInt"]/*' />
    [NativeTypeName("#define Long64ToInt LongLongToInt")]
    public static delegate*<long, int*, HRESULT> Long64ToInt => &LongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToInt32"]/*' />
    [NativeTypeName("#define Long64ToInt32 LongLongToInt")]
    public static delegate*<long, int*, HRESULT> Long64ToInt32 => &LongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToIntPtr"]/*' />
    [NativeTypeName("#define Long64ToIntPtr LongLongToIntPtr")]
    public static delegate*<long, nint*, HRESULT> Long64ToIntPtr => &LongLongToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToUInt"]/*' />
    [NativeTypeName("#define Long64ToUInt LongLongToUInt")]
    public static delegate*<long, uint*, HRESULT> Long64ToUInt => &LongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToUInt32"]/*' />
    [NativeTypeName("#define Long64ToUInt32 LongLongToUInt")]
    public static delegate*<long, uint*, HRESULT> Long64ToUInt32 => &LongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToUIntPtr"]/*' />
    [NativeTypeName("#define Long64ToUIntPtr LongLongToUIntPtr")]
    public static delegate*<long, ulong*, HRESULT> Long64ToUIntPtr => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToLong"]/*' />
    [NativeTypeName("#define Long64ToLong LongLongToLong")]
    public static delegate*<long, int*, HRESULT> Long64ToLong => &LongLongToLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToLongPtr"]/*' />
    [NativeTypeName("#define Long64ToLongPtr LongLongToLongPtr")]
    public static delegate*<long, nint*, HRESULT> Long64ToLongPtr => &LongLongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToULong"]/*' />
    [NativeTypeName("#define Long64ToULong LongLongToULong")]
    public static delegate*<long, uint*, HRESULT> Long64ToULong => &LongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToULongPtr"]/*' />
    [NativeTypeName("#define Long64ToULongPtr LongLongToULongPtr")]
    public static delegate*<long, ulong*, HRESULT> Long64ToULongPtr => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToDWord"]/*' />
    [NativeTypeName("#define Long64ToDWord LongLongToULong")]
    public static delegate*<long, uint*, HRESULT> Long64ToDWord => &LongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToDWordPtr"]/*' />
    [NativeTypeName("#define Long64ToDWordPtr LongLongToULongPtr")]
    public static delegate*<long, ulong*, HRESULT> Long64ToDWordPtr => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToULongLong"]/*' />
    [NativeTypeName("#define Long64ToULongLong LongLongToULongLong")]
    public static delegate*<long, ulong*, HRESULT> Long64ToULongLong => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToPtrdiffT"]/*' />
    [NativeTypeName("#define Long64ToPtrdiffT LongLongToIntPtr")]
    public static delegate*<long, nint*, HRESULT> Long64ToPtrdiffT => &LongLongToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToSizeT"]/*' />
    [NativeTypeName("#define Long64ToSizeT LongLongToUIntPtr")]
    public static delegate*<long, ulong*, HRESULT> Long64ToSizeT => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToSSIZET"]/*' />
    [NativeTypeName("#define Long64ToSSIZET LongLongToLongPtr")]
    public static delegate*<long, nint*, HRESULT> Long64ToSSIZET => &LongLongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Long64ToSIZET"]/*' />
    [NativeTypeName("#define Long64ToSIZET LongLongToULongPtr")]
    public static delegate*<long, ulong*, HRESULT> Long64ToSIZET => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToChar"]/*' />
    [NativeTypeName("#define Int64ToChar LongLongToChar")]
    public static delegate*<long, sbyte*, HRESULT> Int64ToChar => &LongLongToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToInt8"]/*' />
    [NativeTypeName("#define Int64ToInt8 LongLongToInt8")]
    public static delegate*<long, sbyte*, HRESULT> Int64ToInt8 => &LongLongToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToUChar"]/*' />
    [NativeTypeName("#define Int64ToUChar LongLongToUChar")]
    public static delegate*<long, byte*, HRESULT> Int64ToUChar => &LongLongToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToUInt8"]/*' />
    [NativeTypeName("#define Int64ToUInt8 LongLongToUInt8")]
    public static delegate*<long, byte*, HRESULT> Int64ToUInt8 => &LongLongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToByte"]/*' />
    [NativeTypeName("#define Int64ToByte LongLongToUInt8")]
    public static delegate*<long, byte*, HRESULT> Int64ToByte => &LongLongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToShort"]/*' />
    [NativeTypeName("#define Int64ToShort LongLongToShort")]
    public static delegate*<long, short*, HRESULT> Int64ToShort => &LongLongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToInt16"]/*' />
    [NativeTypeName("#define Int64ToInt16 LongLongToShort")]
    public static delegate*<long, short*, HRESULT> Int64ToInt16 => &LongLongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToUShort"]/*' />
    [NativeTypeName("#define Int64ToUShort LongLongToUShort")]
    public static delegate*<long, ushort*, HRESULT> Int64ToUShort => &LongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToUInt16"]/*' />
    [NativeTypeName("#define Int64ToUInt16 LongLongToUShort")]
    public static delegate*<long, ushort*, HRESULT> Int64ToUInt16 => &LongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToWord"]/*' />
    [NativeTypeName("#define Int64ToWord LongLongToUShort")]
    public static delegate*<long, ushort*, HRESULT> Int64ToWord => &LongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToInt"]/*' />
    [NativeTypeName("#define Int64ToInt LongLongToInt")]
    public static delegate*<long, int*, HRESULT> Int64ToInt => &LongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToInt32"]/*' />
    [NativeTypeName("#define Int64ToInt32 LongLongToInt")]
    public static delegate*<long, int*, HRESULT> Int64ToInt32 => &LongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToIntPtr"]/*' />
    [NativeTypeName("#define Int64ToIntPtr LongLongToIntPtr")]
    public static delegate*<long, nint*, HRESULT> Int64ToIntPtr => &LongLongToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToUInt"]/*' />
    [NativeTypeName("#define Int64ToUInt LongLongToUInt")]
    public static delegate*<long, uint*, HRESULT> Int64ToUInt => &LongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToUInt32"]/*' />
    [NativeTypeName("#define Int64ToUInt32 LongLongToUInt")]
    public static delegate*<long, uint*, HRESULT> Int64ToUInt32 => &LongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToUIntPtr"]/*' />
    [NativeTypeName("#define Int64ToUIntPtr LongLongToUIntPtr")]
    public static delegate*<long, ulong*, HRESULT> Int64ToUIntPtr => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToLong"]/*' />
    [NativeTypeName("#define Int64ToLong LongLongToLong")]
    public static delegate*<long, int*, HRESULT> Int64ToLong => &LongLongToLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToLongPtr"]/*' />
    [NativeTypeName("#define Int64ToLongPtr LongLongToLongPtr")]
    public static delegate*<long, nint*, HRESULT> Int64ToLongPtr => &LongLongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToULong"]/*' />
    [NativeTypeName("#define Int64ToULong LongLongToULong")]
    public static delegate*<long, uint*, HRESULT> Int64ToULong => &LongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToULongPtr"]/*' />
    [NativeTypeName("#define Int64ToULongPtr LongLongToULongPtr")]
    public static delegate*<long, ulong*, HRESULT> Int64ToULongPtr => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToDWord"]/*' />
    [NativeTypeName("#define Int64ToDWord LongLongToULong")]
    public static delegate*<long, uint*, HRESULT> Int64ToDWord => &LongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToDWordPtr"]/*' />
    [NativeTypeName("#define Int64ToDWordPtr LongLongToULongPtr")]
    public static delegate*<long, ulong*, HRESULT> Int64ToDWordPtr => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToULongLong"]/*' />
    [NativeTypeName("#define Int64ToULongLong LongLongToULongLong")]
    public static delegate*<long, ulong*, HRESULT> Int64ToULongLong => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToDWordLong"]/*' />
    [NativeTypeName("#define Int64ToDWordLong LongLongToULongLong")]
    public static delegate*<long, ulong*, HRESULT> Int64ToDWordLong => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToULong64"]/*' />
    [NativeTypeName("#define Int64ToULong64 LongLongToULongLong")]
    public static delegate*<long, ulong*, HRESULT> Int64ToULong64 => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToDWord64"]/*' />
    [NativeTypeName("#define Int64ToDWord64 LongLongToULongLong")]
    public static delegate*<long, ulong*, HRESULT> Int64ToDWord64 => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToUInt64"]/*' />
    [NativeTypeName("#define Int64ToUInt64 LongLongToULongLong")]
    public static delegate*<long, ulong*, HRESULT> Int64ToUInt64 => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToPtrdiffT"]/*' />
    [NativeTypeName("#define Int64ToPtrdiffT LongLongToIntPtr")]
    public static delegate*<long, nint*, HRESULT> Int64ToPtrdiffT => &LongLongToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToSizeT"]/*' />
    [NativeTypeName("#define Int64ToSizeT LongLongToUIntPtr")]
    public static delegate*<long, ulong*, HRESULT> Int64ToSizeT => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToSSIZET"]/*' />
    [NativeTypeName("#define Int64ToSSIZET LongLongToLongPtr")]
    public static delegate*<long, nint*, HRESULT> Int64ToSSIZET => &LongLongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.Int64ToSIZET"]/*' />
    [NativeTypeName("#define Int64ToSIZET LongLongToULongPtr")]
    public static delegate*<long, ulong*, HRESULT> Int64ToSIZET => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToByte"]/*' />
    [NativeTypeName("#define ULongLongToByte ULongLongToUInt8")]
    public static delegate*<ulong, byte*, HRESULT> ULongLongToByte => &ULongLongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToInt16"]/*' />
    [NativeTypeName("#define ULongLongToInt16 ULongLongToShort")]
    public static delegate*<ulong, short*, HRESULT> ULongLongToInt16 => &ULongLongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToUInt16"]/*' />
    [NativeTypeName("#define ULongLongToUInt16 ULongLongToUShort")]
    public static delegate*<ulong, ushort*, HRESULT> ULongLongToUInt16 => &ULongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToWord"]/*' />
    [NativeTypeName("#define ULongLongToWord ULongLongToUShort")]
    public static delegate*<ulong, ushort*, HRESULT> ULongLongToWord => &ULongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToInt32"]/*' />
    [NativeTypeName("#define ULongLongToInt32 ULongLongToInt")]
    public static delegate*<ulong, int*, HRESULT> ULongLongToInt32 => &ULongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToIntPtr"]/*' />
    [NativeTypeName("#define ULongLongToIntPtr ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> ULongLongToIntPtr => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToUInt32"]/*' />
    [NativeTypeName("#define ULongLongToUInt32 ULongLongToUInt")]
    public static delegate*<ulong, uint*, HRESULT> ULongLongToUInt32 => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToDWord"]/*' />
    [NativeTypeName("#define ULongLongToDWord ULongLongToULong")]
    public static delegate*<ulong, uint*, HRESULT> ULongLongToDWord => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToDWordPtr"]/*' />
    [NativeTypeName("#define ULongLongToDWordPtr ULongLongToULongPtr")]
    public static delegate*<ulong, nuint*, HRESULT> ULongLongToDWordPtr => &ULongLongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToInt64"]/*' />
    [NativeTypeName("#define ULongLongToInt64 ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> ULongLongToInt64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToLong64"]/*' />
    [NativeTypeName("#define ULongLongToLong64 ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> ULongLongToLong64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToPtrdiffT"]/*' />
    [NativeTypeName("#define ULongLongToPtrdiffT ULongLongToIntPtr")]
    public static delegate*<ulong, long*, HRESULT> ULongLongToPtrdiffT => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToSizeT"]/*' />
    [NativeTypeName("#define ULongLongToSizeT ULongLongToUIntPtr")]
    public static delegate*<ulong, nuint*, HRESULT> ULongLongToSizeT => &ULongLongToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToSSIZET"]/*' />
    [NativeTypeName("#define ULongLongToSSIZET ULongLongToLongPtr")]
    public static delegate*<ulong, nint*, HRESULT> ULongLongToSSIZET => &ULongLongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongLongToSIZET"]/*' />
    [NativeTypeName("#define ULongLongToSIZET ULongLongToULongPtr")]
    public static delegate*<ulong, nuint*, HRESULT> ULongLongToSIZET => &ULongLongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToChar"]/*' />
    [NativeTypeName("#define DWordLongToChar ULongLongToChar")]
    public static delegate*<ulong, sbyte*, HRESULT> DWordLongToChar => &ULongLongToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToInt8"]/*' />
    [NativeTypeName("#define DWordLongToInt8 ULongLongToInt8")]
    public static delegate*<ulong, sbyte*, HRESULT> DWordLongToInt8 => &ULongLongToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToUChar"]/*' />
    [NativeTypeName("#define DWordLongToUChar ULongLongToUChar")]
    public static delegate*<ulong, byte*, HRESULT> DWordLongToUChar => &ULongLongToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToUInt8"]/*' />
    [NativeTypeName("#define DWordLongToUInt8 ULongLongToUInt8")]
    public static delegate*<ulong, byte*, HRESULT> DWordLongToUInt8 => &ULongLongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToByte"]/*' />
    [NativeTypeName("#define DWordLongToByte ULongLongToUInt8")]
    public static delegate*<ulong, byte*, HRESULT> DWordLongToByte => &ULongLongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToShort"]/*' />
    [NativeTypeName("#define DWordLongToShort ULongLongToShort")]
    public static delegate*<ulong, short*, HRESULT> DWordLongToShort => &ULongLongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToInt16"]/*' />
    [NativeTypeName("#define DWordLongToInt16 ULongLongToShort")]
    public static delegate*<ulong, short*, HRESULT> DWordLongToInt16 => &ULongLongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToUShort"]/*' />
    [NativeTypeName("#define DWordLongToUShort ULongLongToUShort")]
    public static delegate*<ulong, ushort*, HRESULT> DWordLongToUShort => &ULongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToUInt16"]/*' />
    [NativeTypeName("#define DWordLongToUInt16 ULongLongToUShort")]
    public static delegate*<ulong, ushort*, HRESULT> DWordLongToUInt16 => &ULongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToWord"]/*' />
    [NativeTypeName("#define DWordLongToWord ULongLongToUShort")]
    public static delegate*<ulong, ushort*, HRESULT> DWordLongToWord => &ULongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToInt"]/*' />
    [NativeTypeName("#define DWordLongToInt ULongLongToInt")]
    public static delegate*<ulong, int*, HRESULT> DWordLongToInt => &ULongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToInt32"]/*' />
    [NativeTypeName("#define DWordLongToInt32 ULongLongToInt")]
    public static delegate*<ulong, int*, HRESULT> DWordLongToInt32 => &ULongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToIntPtr"]/*' />
    [NativeTypeName("#define DWordLongToIntPtr ULongLongToIntPtr")]
    public static delegate*<ulong, long*, HRESULT> DWordLongToIntPtr => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToUInt"]/*' />
    [NativeTypeName("#define DWordLongToUInt ULongLongToUInt")]
    public static delegate*<ulong, uint*, HRESULT> DWordLongToUInt => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToUInt32"]/*' />
    [NativeTypeName("#define DWordLongToUInt32 ULongLongToUInt")]
    public static delegate*<ulong, uint*, HRESULT> DWordLongToUInt32 => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToUIntPtr"]/*' />
    [NativeTypeName("#define DWordLongToUIntPtr ULongLongToUIntPtr")]
    public static delegate*<ulong, nuint*, HRESULT> DWordLongToUIntPtr => &ULongLongToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToLong"]/*' />
    [NativeTypeName("#define DWordLongToLong ULongLongToLong")]
    public static delegate*<ulong, int*, HRESULT> DWordLongToLong => &ULongLongToLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToLongPtr"]/*' />
    [NativeTypeName("#define DWordLongToLongPtr ULongLongToLongPtr")]
    public static delegate*<ulong, nint*, HRESULT> DWordLongToLongPtr => &ULongLongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToULong"]/*' />
    [NativeTypeName("#define DWordLongToULong ULongLongToULong")]
    public static delegate*<ulong, uint*, HRESULT> DWordLongToULong => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToULongPtr"]/*' />
    [NativeTypeName("#define DWordLongToULongPtr ULongLongToULongPtr")]
    public static delegate*<ulong, nuint*, HRESULT> DWordLongToULongPtr => &ULongLongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToDWord"]/*' />
    [NativeTypeName("#define DWordLongToDWord ULongLongToULong")]
    public static delegate*<ulong, uint*, HRESULT> DWordLongToDWord => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToDWordPtr"]/*' />
    [NativeTypeName("#define DWordLongToDWordPtr ULongLongToULongPtr")]
    public static delegate*<ulong, nuint*, HRESULT> DWordLongToDWordPtr => &ULongLongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToLongLong"]/*' />
    [NativeTypeName("#define DWordLongToLongLong ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> DWordLongToLongLong => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToLong64"]/*' />
    [NativeTypeName("#define DWordLongToLong64 ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> DWordLongToLong64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToInt64"]/*' />
    [NativeTypeName("#define DWordLongToInt64 ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> DWordLongToInt64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToPtrdiffT"]/*' />
    [NativeTypeName("#define DWordLongToPtrdiffT ULongLongToIntPtr")]
    public static delegate*<ulong, long*, HRESULT> DWordLongToPtrdiffT => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToSizeT"]/*' />
    [NativeTypeName("#define DWordLongToSizeT ULongLongToUIntPtr")]
    public static delegate*<ulong, nuint*, HRESULT> DWordLongToSizeT => &ULongLongToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToSSIZET"]/*' />
    [NativeTypeName("#define DWordLongToSSIZET ULongLongToLongPtr")]
    public static delegate*<ulong, nint*, HRESULT> DWordLongToSSIZET => &ULongLongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongToSIZET"]/*' />
    [NativeTypeName("#define DWordLongToSIZET ULongLongToULongPtr")]
    public static delegate*<ulong, nuint*, HRESULT> DWordLongToSIZET => &ULongLongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToChar"]/*' />
    [NativeTypeName("#define ULong64ToChar ULongLongToChar")]
    public static delegate*<ulong, sbyte*, HRESULT> ULong64ToChar => &ULongLongToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToInt8"]/*' />
    [NativeTypeName("#define ULong64ToInt8 ULongLongToInt8")]
    public static delegate*<ulong, sbyte*, HRESULT> ULong64ToInt8 => &ULongLongToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToUChar"]/*' />
    [NativeTypeName("#define ULong64ToUChar ULongLongToUChar")]
    public static delegate*<ulong, byte*, HRESULT> ULong64ToUChar => &ULongLongToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToUInt8"]/*' />
    [NativeTypeName("#define ULong64ToUInt8 ULongLongToUInt8")]
    public static delegate*<ulong, byte*, HRESULT> ULong64ToUInt8 => &ULongLongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToByte"]/*' />
    [NativeTypeName("#define ULong64ToByte ULongLongToUInt8")]
    public static delegate*<ulong, byte*, HRESULT> ULong64ToByte => &ULongLongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToShort"]/*' />
    [NativeTypeName("#define ULong64ToShort ULongLongToShort")]
    public static delegate*<ulong, short*, HRESULT> ULong64ToShort => &ULongLongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToInt16"]/*' />
    [NativeTypeName("#define ULong64ToInt16 ULongLongToShort")]
    public static delegate*<ulong, short*, HRESULT> ULong64ToInt16 => &ULongLongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToUShort"]/*' />
    [NativeTypeName("#define ULong64ToUShort ULongLongToUShort")]
    public static delegate*<ulong, ushort*, HRESULT> ULong64ToUShort => &ULongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToUInt16"]/*' />
    [NativeTypeName("#define ULong64ToUInt16 ULongLongToUShort")]
    public static delegate*<ulong, ushort*, HRESULT> ULong64ToUInt16 => &ULongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToWord"]/*' />
    [NativeTypeName("#define ULong64ToWord ULongLongToUShort")]
    public static delegate*<ulong, ushort*, HRESULT> ULong64ToWord => &ULongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToInt"]/*' />
    [NativeTypeName("#define ULong64ToInt ULongLongToInt")]
    public static delegate*<ulong, int*, HRESULT> ULong64ToInt => &ULongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToInt32"]/*' />
    [NativeTypeName("#define ULong64ToInt32 ULongLongToInt")]
    public static delegate*<ulong, int*, HRESULT> ULong64ToInt32 => &ULongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToIntPtr"]/*' />
    [NativeTypeName("#define ULong64ToIntPtr ULongLongToIntPtr")]
    public static delegate*<ulong, long*, HRESULT> ULong64ToIntPtr => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToUInt"]/*' />
    [NativeTypeName("#define ULong64ToUInt ULongLongToUInt")]
    public static delegate*<ulong, uint*, HRESULT> ULong64ToUInt => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToUInt32"]/*' />
    [NativeTypeName("#define ULong64ToUInt32 ULongLongToUInt")]
    public static delegate*<ulong, uint*, HRESULT> ULong64ToUInt32 => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToUIntPtr"]/*' />
    [NativeTypeName("#define ULong64ToUIntPtr ULongLongToUIntPtr")]
    public static delegate*<ulong, nuint*, HRESULT> ULong64ToUIntPtr => &ULongLongToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToLong"]/*' />
    [NativeTypeName("#define ULong64ToLong ULongLongToLong")]
    public static delegate*<ulong, int*, HRESULT> ULong64ToLong => &ULongLongToLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToLongPtr"]/*' />
    [NativeTypeName("#define ULong64ToLongPtr ULongLongToLongPtr")]
    public static delegate*<ulong, nint*, HRESULT> ULong64ToLongPtr => &ULongLongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToULong"]/*' />
    [NativeTypeName("#define ULong64ToULong ULongLongToULong")]
    public static delegate*<ulong, uint*, HRESULT> ULong64ToULong => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToULongPtr"]/*' />
    [NativeTypeName("#define ULong64ToULongPtr ULongLongToULongPtr")]
    public static delegate*<ulong, nuint*, HRESULT> ULong64ToULongPtr => &ULongLongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToDWord"]/*' />
    [NativeTypeName("#define ULong64ToDWord ULongLongToULong")]
    public static delegate*<ulong, uint*, HRESULT> ULong64ToDWord => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToDWordPtr"]/*' />
    [NativeTypeName("#define ULong64ToDWordPtr ULongLongToULongPtr")]
    public static delegate*<ulong, nuint*, HRESULT> ULong64ToDWordPtr => &ULongLongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToLongLong"]/*' />
    [NativeTypeName("#define ULong64ToLongLong ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> ULong64ToLongLong => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToLong64"]/*' />
    [NativeTypeName("#define ULong64ToLong64 ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> ULong64ToLong64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToInt64"]/*' />
    [NativeTypeName("#define ULong64ToInt64 ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> ULong64ToInt64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToPtrdiffT"]/*' />
    [NativeTypeName("#define ULong64ToPtrdiffT ULongLongToIntPtr")]
    public static delegate*<ulong, long*, HRESULT> ULong64ToPtrdiffT => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToSizeT"]/*' />
    [NativeTypeName("#define ULong64ToSizeT ULongLongToUIntPtr")]
    public static delegate*<ulong, nuint*, HRESULT> ULong64ToSizeT => &ULongLongToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToSSIZET"]/*' />
    [NativeTypeName("#define ULong64ToSSIZET ULongLongToLongPtr")]
    public static delegate*<ulong, nint*, HRESULT> ULong64ToSSIZET => &ULongLongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64ToSIZET"]/*' />
    [NativeTypeName("#define ULong64ToSIZET ULongLongToULongPtr")]
    public static delegate*<ulong, nuint*, HRESULT> ULong64ToSIZET => &ULongLongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToChar"]/*' />
    [NativeTypeName("#define DWord64ToChar ULongLongToChar")]
    public static delegate*<ulong, sbyte*, HRESULT> DWord64ToChar => &ULongLongToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToInt8"]/*' />
    [NativeTypeName("#define DWord64ToInt8 ULongLongToInt8")]
    public static delegate*<ulong, sbyte*, HRESULT> DWord64ToInt8 => &ULongLongToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToUChar"]/*' />
    [NativeTypeName("#define DWord64ToUChar ULongLongToUChar")]
    public static delegate*<ulong, byte*, HRESULT> DWord64ToUChar => &ULongLongToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToUInt8"]/*' />
    [NativeTypeName("#define DWord64ToUInt8 ULongLongToUInt8")]
    public static delegate*<ulong, byte*, HRESULT> DWord64ToUInt8 => &ULongLongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToByte"]/*' />
    [NativeTypeName("#define DWord64ToByte ULongLongToUInt8")]
    public static delegate*<ulong, byte*, HRESULT> DWord64ToByte => &ULongLongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToShort"]/*' />
    [NativeTypeName("#define DWord64ToShort ULongLongToShort")]
    public static delegate*<ulong, short*, HRESULT> DWord64ToShort => &ULongLongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToInt16"]/*' />
    [NativeTypeName("#define DWord64ToInt16 ULongLongToShort")]
    public static delegate*<ulong, short*, HRESULT> DWord64ToInt16 => &ULongLongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToUShort"]/*' />
    [NativeTypeName("#define DWord64ToUShort ULongLongToUShort")]
    public static delegate*<ulong, ushort*, HRESULT> DWord64ToUShort => &ULongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToUInt16"]/*' />
    [NativeTypeName("#define DWord64ToUInt16 ULongLongToUShort")]
    public static delegate*<ulong, ushort*, HRESULT> DWord64ToUInt16 => &ULongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToWord"]/*' />
    [NativeTypeName("#define DWord64ToWord ULongLongToUShort")]
    public static delegate*<ulong, ushort*, HRESULT> DWord64ToWord => &ULongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToInt"]/*' />
    [NativeTypeName("#define DWord64ToInt ULongLongToInt")]
    public static delegate*<ulong, int*, HRESULT> DWord64ToInt => &ULongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToInt32"]/*' />
    [NativeTypeName("#define DWord64ToInt32 ULongLongToInt")]
    public static delegate*<ulong, int*, HRESULT> DWord64ToInt32 => &ULongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToIntPtr"]/*' />
    [NativeTypeName("#define DWord64ToIntPtr ULongLongToIntPtr")]
    public static delegate*<ulong, long*, HRESULT> DWord64ToIntPtr => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToUInt"]/*' />
    [NativeTypeName("#define DWord64ToUInt ULongLongToUInt")]
    public static delegate*<ulong, uint*, HRESULT> DWord64ToUInt => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToUInt32"]/*' />
    [NativeTypeName("#define DWord64ToUInt32 ULongLongToUInt")]
    public static delegate*<ulong, uint*, HRESULT> DWord64ToUInt32 => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToUIntPtr"]/*' />
    [NativeTypeName("#define DWord64ToUIntPtr ULongLongToUIntPtr")]
    public static delegate*<ulong, nuint*, HRESULT> DWord64ToUIntPtr => &ULongLongToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToLong"]/*' />
    [NativeTypeName("#define DWord64ToLong ULongLongToLong")]
    public static delegate*<ulong, int*, HRESULT> DWord64ToLong => &ULongLongToLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToLongPtr"]/*' />
    [NativeTypeName("#define DWord64ToLongPtr ULongLongToLongPtr")]
    public static delegate*<ulong, nint*, HRESULT> DWord64ToLongPtr => &ULongLongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToULong"]/*' />
    [NativeTypeName("#define DWord64ToULong ULongLongToULong")]
    public static delegate*<ulong, uint*, HRESULT> DWord64ToULong => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToULongPtr"]/*' />
    [NativeTypeName("#define DWord64ToULongPtr ULongLongToULongPtr")]
    public static delegate*<ulong, nuint*, HRESULT> DWord64ToULongPtr => &ULongLongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToDWord"]/*' />
    [NativeTypeName("#define DWord64ToDWord ULongLongToULong")]
    public static delegate*<ulong, uint*, HRESULT> DWord64ToDWord => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToDWordPtr"]/*' />
    [NativeTypeName("#define DWord64ToDWordPtr ULongLongToULongPtr")]
    public static delegate*<ulong, nuint*, HRESULT> DWord64ToDWordPtr => &ULongLongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToLongLong"]/*' />
    [NativeTypeName("#define DWord64ToLongLong ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> DWord64ToLongLong => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToLong64"]/*' />
    [NativeTypeName("#define DWord64ToLong64 ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> DWord64ToLong64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToInt64"]/*' />
    [NativeTypeName("#define DWord64ToInt64 ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> DWord64ToInt64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToPtrdiffT"]/*' />
    [NativeTypeName("#define DWord64ToPtrdiffT ULongLongToIntPtr")]
    public static delegate*<ulong, long*, HRESULT> DWord64ToPtrdiffT => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToSizeT"]/*' />
    [NativeTypeName("#define DWord64ToSizeT ULongLongToUIntPtr")]
    public static delegate*<ulong, nuint*, HRESULT> DWord64ToSizeT => &ULongLongToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToSSIZET"]/*' />
    [NativeTypeName("#define DWord64ToSSIZET ULongLongToLongPtr")]
    public static delegate*<ulong, nint*, HRESULT> DWord64ToSSIZET => &ULongLongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64ToSIZET"]/*' />
    [NativeTypeName("#define DWord64ToSIZET ULongLongToULongPtr")]
    public static delegate*<ulong, nuint*, HRESULT> DWord64ToSIZET => &ULongLongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToChar"]/*' />
    [NativeTypeName("#define UInt64ToChar ULongLongToChar")]
    public static delegate*<ulong, sbyte*, HRESULT> UInt64ToChar => &ULongLongToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToInt8"]/*' />
    [NativeTypeName("#define UInt64ToInt8 ULongLongToInt8")]
    public static delegate*<ulong, sbyte*, HRESULT> UInt64ToInt8 => &ULongLongToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToUChar"]/*' />
    [NativeTypeName("#define UInt64ToUChar ULongLongToUChar")]
    public static delegate*<ulong, byte*, HRESULT> UInt64ToUChar => &ULongLongToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToUInt8"]/*' />
    [NativeTypeName("#define UInt64ToUInt8 ULongLongToUInt8")]
    public static delegate*<ulong, byte*, HRESULT> UInt64ToUInt8 => &ULongLongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToByte"]/*' />
    [NativeTypeName("#define UInt64ToByte ULongLongToUInt8")]
    public static delegate*<ulong, byte*, HRESULT> UInt64ToByte => &ULongLongToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToShort"]/*' />
    [NativeTypeName("#define UInt64ToShort ULongLongToShort")]
    public static delegate*<ulong, short*, HRESULT> UInt64ToShort => &ULongLongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToInt16"]/*' />
    [NativeTypeName("#define UInt64ToInt16 ULongLongToShort")]
    public static delegate*<ulong, short*, HRESULT> UInt64ToInt16 => &ULongLongToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToUShort"]/*' />
    [NativeTypeName("#define UInt64ToUShort ULongLongToUShort")]
    public static delegate*<ulong, ushort*, HRESULT> UInt64ToUShort => &ULongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToUInt16"]/*' />
    [NativeTypeName("#define UInt64ToUInt16 ULongLongToUShort")]
    public static delegate*<ulong, ushort*, HRESULT> UInt64ToUInt16 => &ULongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToWord"]/*' />
    [NativeTypeName("#define UInt64ToWord ULongLongToUShort")]
    public static delegate*<ulong, ushort*, HRESULT> UInt64ToWord => &ULongLongToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToInt"]/*' />
    [NativeTypeName("#define UInt64ToInt ULongLongToInt")]
    public static delegate*<ulong, int*, HRESULT> UInt64ToInt => &ULongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToInt32"]/*' />
    [NativeTypeName("#define UInt64ToInt32 ULongLongToInt")]
    public static delegate*<ulong, int*, HRESULT> UInt64ToInt32 => &ULongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToIntPtr"]/*' />
    [NativeTypeName("#define UInt64ToIntPtr ULongLongToIntPtr")]
    public static delegate*<ulong, long*, HRESULT> UInt64ToIntPtr => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToUInt"]/*' />
    [NativeTypeName("#define UInt64ToUInt ULongLongToUInt")]
    public static delegate*<ulong, uint*, HRESULT> UInt64ToUInt => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToUInt32"]/*' />
    [NativeTypeName("#define UInt64ToUInt32 ULongLongToUInt")]
    public static delegate*<ulong, uint*, HRESULT> UInt64ToUInt32 => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToUIntPtr"]/*' />
    [NativeTypeName("#define UInt64ToUIntPtr ULongLongToUIntPtr")]
    public static delegate*<ulong, nuint*, HRESULT> UInt64ToUIntPtr => &ULongLongToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToLong"]/*' />
    [NativeTypeName("#define UInt64ToLong ULongLongToLong")]
    public static delegate*<ulong, int*, HRESULT> UInt64ToLong => &ULongLongToLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToLongPtr"]/*' />
    [NativeTypeName("#define UInt64ToLongPtr ULongLongToLongPtr")]
    public static delegate*<ulong, nint*, HRESULT> UInt64ToLongPtr => &ULongLongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToULong"]/*' />
    [NativeTypeName("#define UInt64ToULong ULongLongToULong")]
    public static delegate*<ulong, uint*, HRESULT> UInt64ToULong => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToULongPtr"]/*' />
    [NativeTypeName("#define UInt64ToULongPtr ULongLongToULongPtr")]
    public static delegate*<ulong, nuint*, HRESULT> UInt64ToULongPtr => &ULongLongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToDWord"]/*' />
    [NativeTypeName("#define UInt64ToDWord ULongLongToULong")]
    public static delegate*<ulong, uint*, HRESULT> UInt64ToDWord => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToDWordPtr"]/*' />
    [NativeTypeName("#define UInt64ToDWordPtr ULongLongToULongPtr")]
    public static delegate*<ulong, nuint*, HRESULT> UInt64ToDWordPtr => &ULongLongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToLongLong"]/*' />
    [NativeTypeName("#define UInt64ToLongLong ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> UInt64ToLongLong => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToLong64"]/*' />
    [NativeTypeName("#define UInt64ToLong64 ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> UInt64ToLong64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToInt64"]/*' />
    [NativeTypeName("#define UInt64ToInt64 ULongLongToLongLong")]
    public static delegate*<ulong, long*, HRESULT> UInt64ToInt64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToPtrdiffT"]/*' />
    [NativeTypeName("#define UInt64ToPtrdiffT ULongLongToIntPtr")]
    public static delegate*<ulong, long*, HRESULT> UInt64ToPtrdiffT => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToSizeT"]/*' />
    [NativeTypeName("#define UInt64ToSizeT ULongLongToUIntPtr")]
    public static delegate*<ulong, nuint*, HRESULT> UInt64ToSizeT => &ULongLongToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToSSIZET"]/*' />
    [NativeTypeName("#define UInt64ToSSIZET ULongLongToLongPtr")]
    public static delegate*<ulong, nint*, HRESULT> UInt64ToSSIZET => &ULongLongToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64ToSIZET"]/*' />
    [NativeTypeName("#define UInt64ToSIZET ULongLongToULongPtr")]
    public static delegate*<ulong, nuint*, HRESULT> UInt64ToSIZET => &ULongLongToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToChar"]/*' />
    [NativeTypeName("#define PtrdiffTToChar IntPtrToChar")]
    public static delegate*<nint, sbyte*, HRESULT> PtrdiffTToChar => &IntPtrToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToInt8"]/*' />
    [NativeTypeName("#define PtrdiffTToInt8 IntPtrToInt8")]
    public static delegate*<nint, sbyte*, HRESULT> PtrdiffTToInt8 => &IntPtrToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToUChar"]/*' />
    [NativeTypeName("#define PtrdiffTToUChar IntPtrToUChar")]
    public static delegate*<nint, byte*, HRESULT> PtrdiffTToUChar => &IntPtrToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToUInt8"]/*' />
    [NativeTypeName("#define PtrdiffTToUInt8 IntPtrToUInt8")]
    public static delegate*<nint, byte*, HRESULT> PtrdiffTToUInt8 => &IntPtrToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToByte"]/*' />
    [NativeTypeName("#define PtrdiffTToByte IntPtrToUInt8")]
    public static delegate*<nint, byte*, HRESULT> PtrdiffTToByte => &IntPtrToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToShort"]/*' />
    [NativeTypeName("#define PtrdiffTToShort IntPtrToShort")]
    public static delegate*<nint, short*, HRESULT> PtrdiffTToShort => &IntPtrToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToInt16"]/*' />
    [NativeTypeName("#define PtrdiffTToInt16 IntPtrToShort")]
    public static delegate*<nint, short*, HRESULT> PtrdiffTToInt16 => &IntPtrToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToUShort"]/*' />
    [NativeTypeName("#define PtrdiffTToUShort IntPtrToUShort")]
    public static delegate*<nint, ushort*, HRESULT> PtrdiffTToUShort => &IntPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToUInt16"]/*' />
    [NativeTypeName("#define PtrdiffTToUInt16 IntPtrToUShort")]
    public static delegate*<nint, ushort*, HRESULT> PtrdiffTToUInt16 => &IntPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToWord"]/*' />
    [NativeTypeName("#define PtrdiffTToWord IntPtrToUShort")]
    public static delegate*<nint, ushort*, HRESULT> PtrdiffTToWord => &IntPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToInt"]/*' />
    [NativeTypeName("#define PtrdiffTToInt IntPtrToInt")]
    public static delegate*<long, int*, HRESULT> PtrdiffTToInt => &LongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToInt32"]/*' />
    [NativeTypeName("#define PtrdiffTToInt32 IntPtrToInt")]
    public static delegate*<long, int*, HRESULT> PtrdiffTToInt32 => &LongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToUInt"]/*' />
    [NativeTypeName("#define PtrdiffTToUInt IntPtrToUInt")]
    public static delegate*<long, uint*, HRESULT> PtrdiffTToUInt => &LongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToUInt32"]/*' />
    [NativeTypeName("#define PtrdiffTToUInt32 IntPtrToUInt")]
    public static delegate*<long, uint*, HRESULT> PtrdiffTToUInt32 => &LongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToUIntPtr"]/*' />
    [NativeTypeName("#define PtrdiffTToUIntPtr IntPtrToUIntPtr")]
    public static delegate*<long, ulong*, HRESULT> PtrdiffTToUIntPtr => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToLong"]/*' />
    [NativeTypeName("#define PtrdiffTToLong IntPtrToLong")]
    public static delegate*<long, int*, HRESULT> PtrdiffTToLong => &LongLongToLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToLongPtr"]/*' />
    [NativeTypeName("#define PtrdiffTToLongPtr IntPtrToLongPtr")]
    public static delegate*<nint, nint*, HRESULT> PtrdiffTToLongPtr => &IntPtrToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToULong"]/*' />
    [NativeTypeName("#define PtrdiffTToULong IntPtrToULong")]
    public static delegate*<long, uint*, HRESULT> PtrdiffTToULong => &LongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToULongPtr"]/*' />
    [NativeTypeName("#define PtrdiffTToULongPtr IntPtrToULongPtr")]
    public static delegate*<long, ulong*, HRESULT> PtrdiffTToULongPtr => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToDWord"]/*' />
    [NativeTypeName("#define PtrdiffTToDWord IntPtrToULong")]
    public static delegate*<long, uint*, HRESULT> PtrdiffTToDWord => &LongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToDWordPtr"]/*' />
    [NativeTypeName("#define PtrdiffTToDWordPtr IntPtrToULongPtr")]
    public static delegate*<long, ulong*, HRESULT> PtrdiffTToDWordPtr => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToULongLong"]/*' />
    [NativeTypeName("#define PtrdiffTToULongLong IntPtrToULongLong")]
    public static delegate*<long, ulong*, HRESULT> PtrdiffTToULongLong => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToDWordLong"]/*' />
    [NativeTypeName("#define PtrdiffTToDWordLong IntPtrToULongLong")]
    public static delegate*<long, ulong*, HRESULT> PtrdiffTToDWordLong => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToULong64"]/*' />
    [NativeTypeName("#define PtrdiffTToULong64 IntPtrToULongLong")]
    public static delegate*<long, ulong*, HRESULT> PtrdiffTToULong64 => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToDWord64"]/*' />
    [NativeTypeName("#define PtrdiffTToDWord64 IntPtrToULongLong")]
    public static delegate*<long, ulong*, HRESULT> PtrdiffTToDWord64 => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToUInt64"]/*' />
    [NativeTypeName("#define PtrdiffTToUInt64 IntPtrToULongLong")]
    public static delegate*<long, ulong*, HRESULT> PtrdiffTToUInt64 => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToSizeT"]/*' />
    [NativeTypeName("#define PtrdiffTToSizeT IntPtrToUIntPtr")]
    public static delegate*<long, ulong*, HRESULT> PtrdiffTToSizeT => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PtrdiffTToSIZET"]/*' />
    [NativeTypeName("#define PtrdiffTToSIZET IntPtrToULongPtr")]
    public static delegate*<long, ulong*, HRESULT> PtrdiffTToSIZET => &LongLongToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToInt8"]/*' />
    [NativeTypeName("#define SizeTToInt8 UIntPtrToInt8")]
    public static delegate*<nuint, sbyte*, HRESULT> SizeTToInt8 => &UIntPtrToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToUChar"]/*' />
    [NativeTypeName("#define SizeTToUChar UIntPtrToUChar")]
    public static delegate*<nuint, byte*, HRESULT> SizeTToUChar => &UIntPtrToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToChar"]/*' />
    [NativeTypeName("#define SizeTToChar UIntPtrToChar")]
    public static delegate*<nuint, sbyte*, HRESULT> SizeTToChar => &UIntPtrToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToUInt8"]/*' />
    [NativeTypeName("#define SizeTToUInt8 UIntPtrToUInt8")]
    public static delegate*<nuint, byte*, HRESULT> SizeTToUInt8 => &UIntPtrToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToByte"]/*' />
    [NativeTypeName("#define SizeTToByte UIntPtrToUInt8")]
    public static delegate*<nuint, byte*, HRESULT> SizeTToByte => &UIntPtrToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToShort"]/*' />
    [NativeTypeName("#define SizeTToShort UIntPtrToShort")]
    public static delegate*<nuint, short*, HRESULT> SizeTToShort => &UIntPtrToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToInt16"]/*' />
    [NativeTypeName("#define SizeTToInt16 UIntPtrToShort")]
    public static delegate*<nuint, short*, HRESULT> SizeTToInt16 => &UIntPtrToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToUShort"]/*' />
    [NativeTypeName("#define SizeTToUShort UIntPtrToUShort")]
    public static delegate*<nuint, ushort*, HRESULT> SizeTToUShort => &UIntPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToUInt16"]/*' />
    [NativeTypeName("#define SizeTToUInt16 UIntPtrToUShort")]
    public static delegate*<nuint, ushort*, HRESULT> SizeTToUInt16 => &UIntPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToWord"]/*' />
    [NativeTypeName("#define SizeTToWord UIntPtrToUShort")]
    public static delegate*<nuint, ushort*, HRESULT> SizeTToWord => &UIntPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToInt"]/*' />
    [NativeTypeName("#define SizeTToInt UIntPtrToInt")]
    public static delegate*<nuint, int*, HRESULT> SizeTToInt => &UIntPtrToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToInt32"]/*' />
    [NativeTypeName("#define SizeTToInt32 UIntPtrToInt")]
    public static delegate*<nuint, int*, HRESULT> SizeTToInt32 => &UIntPtrToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToIntPtr"]/*' />
    [NativeTypeName("#define SizeTToIntPtr UIntPtrToIntPtr")]
    public static delegate*<nuint, nint*, HRESULT> SizeTToIntPtr => &UIntPtrToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToUInt"]/*' />
    [NativeTypeName("#define SizeTToUInt UIntPtrToUInt")]
    public static delegate*<ulong, uint*, HRESULT> SizeTToUInt => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToUInt32"]/*' />
    [NativeTypeName("#define SizeTToUInt32 UIntPtrToUInt")]
    public static delegate*<ulong, uint*, HRESULT> SizeTToUInt32 => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToLong"]/*' />
    [NativeTypeName("#define SizeTToLong UIntPtrToLong")]
    public static delegate*<nuint, int*, HRESULT> SizeTToLong => &UIntPtrToLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToLongPtr"]/*' />
    [NativeTypeName("#define SizeTToLongPtr UIntPtrToLongPtr")]
    public static delegate*<nuint, nint*, HRESULT> SizeTToLongPtr => &UIntPtrToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToULong"]/*' />
    [NativeTypeName("#define SizeTToULong UIntPtrToULong")]
    public static delegate*<ulong, uint*, HRESULT> SizeTToULong => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToDWord"]/*' />
    [NativeTypeName("#define SizeTToDWord UIntPtrToULong")]
    public static delegate*<ulong, uint*, HRESULT> SizeTToDWord => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToLongLong"]/*' />
    [NativeTypeName("#define SizeTToLongLong UIntPtrToLongLong")]
    public static delegate*<ulong, long*, HRESULT> SizeTToLongLong => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToLong64"]/*' />
    [NativeTypeName("#define SizeTToLong64 UIntPtrToLongLong")]
    public static delegate*<ulong, long*, HRESULT> SizeTToLong64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToInt64"]/*' />
    [NativeTypeName("#define SizeTToInt64 UIntPtrToLongLong")]
    public static delegate*<ulong, long*, HRESULT> SizeTToInt64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToPtrdiffT"]/*' />
    [NativeTypeName("#define SizeTToPtrdiffT UIntPtrToIntPtr")]
    public static delegate*<nuint, nint*, HRESULT> SizeTToPtrdiffT => &UIntPtrToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTToSSIZET"]/*' />
    [NativeTypeName("#define SizeTToSSIZET UIntPtrToLongPtr")]
    public static delegate*<nuint, nint*, HRESULT> SizeTToSSIZET => &UIntPtrToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToInt8"]/*' />
    [NativeTypeName("#define SSIZETToInt8 LongPtrToInt8")]
    public static delegate*<nint, sbyte*, HRESULT> SSIZETToInt8 => &LongPtrToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToUChar"]/*' />
    [NativeTypeName("#define SSIZETToUChar LongPtrToUChar")]
    public static delegate*<nint, byte*, HRESULT> SSIZETToUChar => &LongPtrToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToChar"]/*' />
    [NativeTypeName("#define SSIZETToChar LongPtrToChar")]
    public static delegate*<nint, sbyte*, HRESULT> SSIZETToChar => &LongPtrToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToUInt8"]/*' />
    [NativeTypeName("#define SSIZETToUInt8 LongPtrToUInt8")]
    public static delegate*<nint, byte*, HRESULT> SSIZETToUInt8 => &LongPtrToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToByte"]/*' />
    [NativeTypeName("#define SSIZETToByte LongPtrToUInt8")]
    public static delegate*<nint, byte*, HRESULT> SSIZETToByte => &LongPtrToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToShort"]/*' />
    [NativeTypeName("#define SSIZETToShort LongPtrToShort")]
    public static delegate*<nint, short*, HRESULT> SSIZETToShort => &LongPtrToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToInt16"]/*' />
    [NativeTypeName("#define SSIZETToInt16 LongPtrToShort")]
    public static delegate*<nint, short*, HRESULT> SSIZETToInt16 => &LongPtrToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToUShort"]/*' />
    [NativeTypeName("#define SSIZETToUShort LongPtrToUShort")]
    public static delegate*<nint, ushort*, HRESULT> SSIZETToUShort => &LongPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToUInt16"]/*' />
    [NativeTypeName("#define SSIZETToUInt16 LongPtrToUShort")]
    public static delegate*<nint, ushort*, HRESULT> SSIZETToUInt16 => &LongPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToWord"]/*' />
    [NativeTypeName("#define SSIZETToWord LongPtrToUShort")]
    public static delegate*<nint, ushort*, HRESULT> SSIZETToWord => &LongPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToInt"]/*' />
    [NativeTypeName("#define SSIZETToInt LongPtrToInt")]
    public static delegate*<long, int*, HRESULT> SSIZETToInt => &LongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToInt32"]/*' />
    [NativeTypeName("#define SSIZETToInt32 LongPtrToInt")]
    public static delegate*<long, int*, HRESULT> SSIZETToInt32 => &LongLongToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToIntPtr"]/*' />
    [NativeTypeName("#define SSIZETToIntPtr LongPtrToIntPtr")]
    public static delegate*<nint, nint*, HRESULT> SSIZETToIntPtr => &LongPtrToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToUInt"]/*' />
    [NativeTypeName("#define SSIZETToUInt LongPtrToUInt")]
    public static delegate*<long, uint*, HRESULT> SSIZETToUInt => &LongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToUInt32"]/*' />
    [NativeTypeName("#define SSIZETToUInt32 LongPtrToUInt")]
    public static delegate*<long, uint*, HRESULT> SSIZETToUInt32 => &LongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToUIntPtr"]/*' />
    [NativeTypeName("#define SSIZETToUIntPtr LongPtrToUIntPtr")]
    public static delegate*<nint, nuint*, HRESULT> SSIZETToUIntPtr => &LongPtrToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToLong"]/*' />
    [NativeTypeName("#define SSIZETToLong LongPtrToLong")]
    public static delegate*<long, int*, HRESULT> SSIZETToLong => &LongLongToLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToULong"]/*' />
    [NativeTypeName("#define SSIZETToULong LongPtrToULong")]
    public static delegate*<long, uint*, HRESULT> SSIZETToULong => &LongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToULongPtr"]/*' />
    [NativeTypeName("#define SSIZETToULongPtr LongPtrToULongPtr")]
    public static delegate*<nint, nuint*, HRESULT> SSIZETToULongPtr => &LongPtrToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToDWord"]/*' />
    [NativeTypeName("#define SSIZETToDWord LongPtrToULong")]
    public static delegate*<long, uint*, HRESULT> SSIZETToDWord => &LongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToDWordPtr"]/*' />
    [NativeTypeName("#define SSIZETToDWordPtr LongPtrToULongPtr")]
    public static delegate*<nint, nuint*, HRESULT> SSIZETToDWordPtr => &LongPtrToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToULongLong"]/*' />
    [NativeTypeName("#define SSIZETToULongLong LongPtrToULongLong")]
    public static delegate*<nint, ulong*, HRESULT> SSIZETToULongLong => &LongPtrToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToDWordLong"]/*' />
    [NativeTypeName("#define SSIZETToDWordLong LongPtrToULongLong")]
    public static delegate*<nint, ulong*, HRESULT> SSIZETToDWordLong => &LongPtrToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToULong64"]/*' />
    [NativeTypeName("#define SSIZETToULong64 LongPtrToULongLong")]
    public static delegate*<nint, ulong*, HRESULT> SSIZETToULong64 => &LongPtrToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToDWord64"]/*' />
    [NativeTypeName("#define SSIZETToDWord64 LongPtrToULongLong")]
    public static delegate*<nint, ulong*, HRESULT> SSIZETToDWord64 => &LongPtrToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToUInt64"]/*' />
    [NativeTypeName("#define SSIZETToUInt64 LongPtrToULongLong")]
    public static delegate*<nint, ulong*, HRESULT> SSIZETToUInt64 => &LongPtrToULongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToSizeT"]/*' />
    [NativeTypeName("#define SSIZETToSizeT LongPtrToUIntPtr")]
    public static delegate*<nint, nuint*, HRESULT> SSIZETToSizeT => &LongPtrToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSIZETToSIZET"]/*' />
    [NativeTypeName("#define SSIZETToSIZET LongPtrToULongPtr")]
    public static delegate*<nint, nuint*, HRESULT> SSIZETToSIZET => &LongPtrToULongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToInt8"]/*' />
    [NativeTypeName("#define SIZETToInt8 ULongPtrToInt8")]
    public static delegate*<nuint, sbyte*, HRESULT> SIZETToInt8 => &ULongPtrToInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToUChar"]/*' />
    [NativeTypeName("#define SIZETToUChar ULongPtrToUChar")]
    public static delegate*<nuint, byte*, HRESULT> SIZETToUChar => &ULongPtrToUChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToChar"]/*' />
    [NativeTypeName("#define SIZETToChar ULongPtrToChar")]
    public static delegate*<nuint, sbyte*, HRESULT> SIZETToChar => &ULongPtrToChar;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToUInt8"]/*' />
    [NativeTypeName("#define SIZETToUInt8 ULongPtrToUInt8")]
    public static delegate*<nuint, byte*, HRESULT> SIZETToUInt8 => &ULongPtrToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToByte"]/*' />
    [NativeTypeName("#define SIZETToByte ULongPtrToUInt8")]
    public static delegate*<nuint, byte*, HRESULT> SIZETToByte => &ULongPtrToUInt8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToShort"]/*' />
    [NativeTypeName("#define SIZETToShort ULongPtrToShort")]
    public static delegate*<nuint, short*, HRESULT> SIZETToShort => &ULongPtrToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToInt16"]/*' />
    [NativeTypeName("#define SIZETToInt16 ULongPtrToShort")]
    public static delegate*<nuint, short*, HRESULT> SIZETToInt16 => &ULongPtrToShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToUShort"]/*' />
    [NativeTypeName("#define SIZETToUShort ULongPtrToUShort")]
    public static delegate*<nuint, ushort*, HRESULT> SIZETToUShort => &ULongPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToUInt16"]/*' />
    [NativeTypeName("#define SIZETToUInt16 ULongPtrToUShort")]
    public static delegate*<nuint, ushort*, HRESULT> SIZETToUInt16 => &ULongPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToWord"]/*' />
    [NativeTypeName("#define SIZETToWord ULongPtrToUShort")]
    public static delegate*<nuint, ushort*, HRESULT> SIZETToWord => &ULongPtrToUShort;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToInt"]/*' />
    [NativeTypeName("#define SIZETToInt ULongPtrToInt")]
    public static delegate*<nuint, int*, HRESULT> SIZETToInt => &ULongPtrToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToInt32"]/*' />
    [NativeTypeName("#define SIZETToInt32 ULongPtrToInt")]
    public static delegate*<nuint, int*, HRESULT> SIZETToInt32 => &ULongPtrToInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToIntPtr"]/*' />
    [NativeTypeName("#define SIZETToIntPtr ULongPtrToIntPtr")]
    public static delegate*<nuint, nint*, HRESULT> SIZETToIntPtr => &ULongPtrToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToUInt"]/*' />
    [NativeTypeName("#define SIZETToUInt ULongPtrToUInt")]
    public static delegate*<ulong, uint*, HRESULT> SIZETToUInt => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToUInt32"]/*' />
    [NativeTypeName("#define SIZETToUInt32 ULongPtrToUInt")]
    public static delegate*<ulong, uint*, HRESULT> SIZETToUInt32 => &ULongLongToUInt;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToUIntPtr"]/*' />
    [NativeTypeName("#define SIZETToUIntPtr ULongPtrToUIntPtr")]
    public static delegate*<nuint, nuint*, HRESULT> SIZETToUIntPtr => &ULongPtrToUIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToLong"]/*' />
    [NativeTypeName("#define SIZETToLong ULongPtrToLong")]
    public static delegate*<nuint, int*, HRESULT> SIZETToLong => &ULongPtrToLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToLongPtr"]/*' />
    [NativeTypeName("#define SIZETToLongPtr ULongPtrToLongPtr")]
    public static delegate*<nuint, nint*, HRESULT> SIZETToLongPtr => &ULongPtrToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToULong"]/*' />
    [NativeTypeName("#define SIZETToULong ULongPtrToULong")]
    public static delegate*<ulong, uint*, HRESULT> SIZETToULong => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToDWord"]/*' />
    [NativeTypeName("#define SIZETToDWord ULongPtrToULong")]
    public static delegate*<ulong, uint*, HRESULT> SIZETToDWord => &ULongLongToULong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToLongLong"]/*' />
    [NativeTypeName("#define SIZETToLongLong ULongPtrToLongLong")]
    public static delegate*<ulong, long*, HRESULT> SIZETToLongLong => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToLong64"]/*' />
    [NativeTypeName("#define SIZETToLong64 ULongPtrToLongLong")]
    public static delegate*<ulong, long*, HRESULT> SIZETToLong64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToInt64"]/*' />
    [NativeTypeName("#define SIZETToInt64 ULongPtrToLongLong")]
    public static delegate*<ulong, long*, HRESULT> SIZETToInt64 => &ULongLongToLongLong;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToPtrdiffT"]/*' />
    [NativeTypeName("#define SIZETToPtrdiffT ULongPtrToIntPtr")]
    public static delegate*<nuint, nint*, HRESULT> SIZETToPtrdiffT => &ULongPtrToIntPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETToSSIZET"]/*' />
    [NativeTypeName("#define SIZETToSSIZET ULongPtrToLongPtr")]
    public static delegate*<nuint, nint*, HRESULT> SIZETToSSIZET => &ULongPtrToLongPtr;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt16Add"]/*' />
    [NativeTypeName("#define UInt16Add UShortAdd")]
    public static delegate*<ushort, ushort, ushort*, HRESULT> UInt16Add => &UShortAdd;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WordAdd"]/*' />
    [NativeTypeName("#define WordAdd UShortAdd")]
    public static delegate*<ushort, ushort, ushort*, HRESULT> WordAdd => &UShortAdd;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32Add"]/*' />
    [NativeTypeName("#define UInt32Add UIntAdd")]
    public static delegate*<uint, uint, uint*, HRESULT> UInt32Add => &UIntAdd;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrAdd"]/*' />
    [NativeTypeName("#define UIntPtrAdd ULongLongAdd")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> UIntPtrAdd => &ULongLongAdd;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrAdd"]/*' />
    [NativeTypeName("#define ULongPtrAdd ULongLongAdd")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> ULongPtrAdd => &ULongLongAdd;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordAdd"]/*' />
    [NativeTypeName("#define DWordAdd ULongAdd")]
    public static delegate*<uint, uint, uint*, HRESULT> DWordAdd => &ULongAdd;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrAdd"]/*' />
    [NativeTypeName("#define DWordPtrAdd ULongLongAdd")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> DWordPtrAdd => &ULongLongAdd;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETAdd"]/*' />
    [NativeTypeName("#define SIZETAdd ULongLongAdd")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> SIZETAdd => &ULongLongAdd;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongAdd"]/*' />
    [NativeTypeName("#define DWordLongAdd ULongLongAdd")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> DWordLongAdd => &ULongLongAdd;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64Add"]/*' />
    [NativeTypeName("#define ULong64Add ULongLongAdd")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> ULong64Add => &ULongLongAdd;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64Add"]/*' />
    [NativeTypeName("#define DWord64Add ULongLongAdd")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> DWord64Add => &ULongLongAdd;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64Add"]/*' />
    [NativeTypeName("#define UInt64Add ULongLongAdd")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> UInt64Add => &ULongLongAdd;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt16Sub"]/*' />
    [NativeTypeName("#define UInt16Sub UShortSub")]
    public static delegate*<ushort, ushort, ushort*, HRESULT> UInt16Sub => &UShortSub;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WordSub"]/*' />
    [NativeTypeName("#define WordSub UShortSub")]
    public static delegate*<ushort, ushort, ushort*, HRESULT> WordSub => &UShortSub;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32Sub"]/*' />
    [NativeTypeName("#define UInt32Sub UIntSub")]
    public static delegate*<uint, uint, uint*, HRESULT> UInt32Sub => &UIntSub;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrSub"]/*' />
    [NativeTypeName("#define UIntPtrSub ULongLongSub")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> UIntPtrSub => &ULongLongSub;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrSub"]/*' />
    [NativeTypeName("#define ULongPtrSub ULongLongSub")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> ULongPtrSub => &ULongLongSub;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordSub"]/*' />
    [NativeTypeName("#define DWordSub ULongSub")]
    public static delegate*<uint, uint, uint*, HRESULT> DWordSub => &ULongSub;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrSub"]/*' />
    [NativeTypeName("#define DWordPtrSub ULongLongSub")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> DWordPtrSub => &ULongLongSub;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETSub"]/*' />
    [NativeTypeName("#define SIZETSub ULongLongSub")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> SIZETSub => &ULongLongSub;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongSub"]/*' />
    [NativeTypeName("#define DWordLongSub ULongLongSub")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> DWordLongSub => &ULongLongSub;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64Sub"]/*' />
    [NativeTypeName("#define ULong64Sub ULongLongSub")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> ULong64Sub => &ULongLongSub;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64Sub"]/*' />
    [NativeTypeName("#define DWord64Sub ULongLongSub")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> DWord64Sub => &ULongLongSub;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64Sub"]/*' />
    [NativeTypeName("#define UInt64Sub ULongLongSub")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> UInt64Sub => &ULongLongSub;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt16Mult"]/*' />
    [NativeTypeName("#define UInt16Mult UShortMult")]
    public static delegate*<ushort, ushort, ushort*, HRESULT> UInt16Mult => &UShortMult;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WordMult"]/*' />
    [NativeTypeName("#define WordMult UShortMult")]
    public static delegate*<ushort, ushort, ushort*, HRESULT> WordMult => &UShortMult;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt32Mult"]/*' />
    [NativeTypeName("#define UInt32Mult UIntMult")]
    public static delegate*<uint, uint, uint*, HRESULT> UInt32Mult => &UIntMult;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UIntPtrMult"]/*' />
    [NativeTypeName("#define UIntPtrMult ULongLongMult")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> UIntPtrMult => &ULongLongMult;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULongPtrMult"]/*' />
    [NativeTypeName("#define ULongPtrMult ULongLongMult")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> ULongPtrMult => &ULongLongMult;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordMult"]/*' />
    [NativeTypeName("#define DWordMult ULongMult")]
    public static delegate*<uint, uint, uint*, HRESULT> DWordMult => &ULongMult;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordPtrMult"]/*' />
    [NativeTypeName("#define DWordPtrMult ULongLongMult")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> DWordPtrMult => &ULongLongMult;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeTMult"]/*' />
    [NativeTypeName("#define SizeTMult ULongLongMult")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> SizeTMult => &ULongLongMult;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SIZETMult"]/*' />
    [NativeTypeName("#define SIZETMult ULongLongMult")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> SIZETMult => &ULongLongMult;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWordLongMult"]/*' />
    [NativeTypeName("#define DWordLongMult ULongLongMult")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> DWordLongMult => &ULongLongMult;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ULong64Mult"]/*' />
    [NativeTypeName("#define ULong64Mult ULongLongMult")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> ULong64Mult => &ULongLongMult;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWord64Mult"]/*' />
    [NativeTypeName("#define DWord64Mult ULongLongMult")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> DWord64Mult => &ULongLongMult;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UInt64Mult"]/*' />
    [NativeTypeName("#define UInt64Mult ULongLongMult")]
    public static delegate*<ulong, ulong, ulong*, HRESULT> UInt64Mult => &ULongLongMult;
}
