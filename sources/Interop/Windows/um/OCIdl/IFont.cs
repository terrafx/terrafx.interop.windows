// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BEF6E002-A874-101A-8BBA-00AA00300CAB")]
    [NativeTypeName("struct IFont : IUnknown")]
    public unsafe partial struct IFont
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFont*, Guid*, void**, int>)(lpVtbl[0]))((IFont*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFont*, uint>)(lpVtbl[1]))((IFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFont*, uint>)(lpVtbl[2]))((IFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("BSTR *")] ushort** pName)
        {
            return ((delegate* unmanaged<IFont*, ushort**, int>)(lpVtbl[3]))((IFont*)Unsafe.AsPointer(ref this), pName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Name([NativeTypeName("BSTR")] ushort* name)
        {
            return ((delegate* unmanaged<IFont*, ushort*, int>)(lpVtbl[4]))((IFont*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Size(CY* pSize)
        {
            return ((delegate* unmanaged<IFont*, CY*, int>)(lpVtbl[5]))((IFont*)Unsafe.AsPointer(ref this), pSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Size(CY size)
        {
            return ((delegate* unmanaged<IFont*, CY, int>)(lpVtbl[6]))((IFont*)Unsafe.AsPointer(ref this), size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Bold([NativeTypeName("BOOL *")] int* pBold)
        {
            return ((delegate* unmanaged<IFont*, int*, int>)(lpVtbl[7]))((IFont*)Unsafe.AsPointer(ref this), pBold);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Bold([NativeTypeName("BOOL")] int bold)
        {
            return ((delegate* unmanaged<IFont*, int, int>)(lpVtbl[8]))((IFont*)Unsafe.AsPointer(ref this), bold);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Italic([NativeTypeName("BOOL *")] int* pItalic)
        {
            return ((delegate* unmanaged<IFont*, int*, int>)(lpVtbl[9]))((IFont*)Unsafe.AsPointer(ref this), pItalic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Italic([NativeTypeName("BOOL")] int italic)
        {
            return ((delegate* unmanaged<IFont*, int, int>)(lpVtbl[10]))((IFont*)Unsafe.AsPointer(ref this), italic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Underline([NativeTypeName("BOOL *")] int* pUnderline)
        {
            return ((delegate* unmanaged<IFont*, int*, int>)(lpVtbl[11]))((IFont*)Unsafe.AsPointer(ref this), pUnderline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Underline([NativeTypeName("BOOL")] int underline)
        {
            return ((delegate* unmanaged<IFont*, int, int>)(lpVtbl[12]))((IFont*)Unsafe.AsPointer(ref this), underline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Strikethrough([NativeTypeName("BOOL *")] int* pStrikethrough)
        {
            return ((delegate* unmanaged<IFont*, int*, int>)(lpVtbl[13]))((IFont*)Unsafe.AsPointer(ref this), pStrikethrough);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Strikethrough([NativeTypeName("BOOL")] int strikethrough)
        {
            return ((delegate* unmanaged<IFont*, int, int>)(lpVtbl[14]))((IFont*)Unsafe.AsPointer(ref this), strikethrough);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Weight([NativeTypeName("SHORT *")] short* pWeight)
        {
            return ((delegate* unmanaged<IFont*, short*, int>)(lpVtbl[15]))((IFont*)Unsafe.AsPointer(ref this), pWeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Weight([NativeTypeName("SHORT")] short weight)
        {
            return ((delegate* unmanaged<IFont*, short, int>)(lpVtbl[16]))((IFont*)Unsafe.AsPointer(ref this), weight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Charset([NativeTypeName("SHORT *")] short* pCharset)
        {
            return ((delegate* unmanaged<IFont*, short*, int>)(lpVtbl[17]))((IFont*)Unsafe.AsPointer(ref this), pCharset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Charset([NativeTypeName("SHORT")] short charset)
        {
            return ((delegate* unmanaged<IFont*, short, int>)(lpVtbl[18]))((IFont*)Unsafe.AsPointer(ref this), charset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_hFont([NativeTypeName("HFONT *")] IntPtr* phFont)
        {
            return ((delegate* unmanaged<IFont*, IntPtr*, int>)(lpVtbl[19]))((IFont*)Unsafe.AsPointer(ref this), phFont);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IFont** ppFont)
        {
            return ((delegate* unmanaged<IFont*, IFont**, int>)(lpVtbl[20]))((IFont*)Unsafe.AsPointer(ref this), ppFont);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsEqual(IFont* pFontOther)
        {
            return ((delegate* unmanaged<IFont*, IFont*, int>)(lpVtbl[21]))((IFont*)Unsafe.AsPointer(ref this), pFontOther);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRatio([NativeTypeName("LONG")] int cyLogical, [NativeTypeName("LONG")] int cyHimetric)
        {
            return ((delegate* unmanaged<IFont*, int, int, int>)(lpVtbl[22]))((IFont*)Unsafe.AsPointer(ref this), cyLogical, cyHimetric);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryTextMetrics([NativeTypeName("TEXTMETRICOLE *")] TEXTMETRICW* pTM)
        {
            return ((delegate* unmanaged<IFont*, TEXTMETRICW*, int>)(lpVtbl[23]))((IFont*)Unsafe.AsPointer(ref this), pTM);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddRefHfont([NativeTypeName("HFONT")] IntPtr hFont)
        {
            return ((delegate* unmanaged<IFont*, IntPtr, int>)(lpVtbl[24]))((IFont*)Unsafe.AsPointer(ref this), hFont);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseHfont([NativeTypeName("HFONT")] IntPtr hFont)
        {
            return ((delegate* unmanaged<IFont*, IntPtr, int>)(lpVtbl[25]))((IFont*)Unsafe.AsPointer(ref this), hFont);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHdc([NativeTypeName("HDC")] IntPtr hDC)
        {
            return ((delegate* unmanaged<IFont*, IntPtr, int>)(lpVtbl[26]))((IFont*)Unsafe.AsPointer(ref this), hDC);
        }
    }
}
