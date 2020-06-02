// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BEF6E002-A874-101A-8BBA-00AA00300CAB")]
    public unsafe partial struct IFont
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IFont*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IFont*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IFont*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("BSTR *")] ushort** pName)
        {
            return lpVtbl->get_Name((IFont*)Unsafe.AsPointer(ref this), pName);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Name([NativeTypeName("BSTR")] ushort* name)
        {
            return lpVtbl->put_Name((IFont*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Size([NativeTypeName("CY *")] CY* pSize)
        {
            return lpVtbl->get_Size((IFont*)Unsafe.AsPointer(ref this), pSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Size(CY size)
        {
            return lpVtbl->put_Size((IFont*)Unsafe.AsPointer(ref this), size);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Bold([NativeTypeName("BOOL *")] int* pBold)
        {
            return lpVtbl->get_Bold((IFont*)Unsafe.AsPointer(ref this), pBold);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Bold([NativeTypeName("BOOL")] int bold)
        {
            return lpVtbl->put_Bold((IFont*)Unsafe.AsPointer(ref this), bold);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Italic([NativeTypeName("BOOL *")] int* pItalic)
        {
            return lpVtbl->get_Italic((IFont*)Unsafe.AsPointer(ref this), pItalic);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Italic([NativeTypeName("BOOL")] int italic)
        {
            return lpVtbl->put_Italic((IFont*)Unsafe.AsPointer(ref this), italic);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Underline([NativeTypeName("BOOL *")] int* pUnderline)
        {
            return lpVtbl->get_Underline((IFont*)Unsafe.AsPointer(ref this), pUnderline);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Underline([NativeTypeName("BOOL")] int underline)
        {
            return lpVtbl->put_Underline((IFont*)Unsafe.AsPointer(ref this), underline);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Strikethrough([NativeTypeName("BOOL *")] int* pStrikethrough)
        {
            return lpVtbl->get_Strikethrough((IFont*)Unsafe.AsPointer(ref this), pStrikethrough);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Strikethrough([NativeTypeName("BOOL")] int strikethrough)
        {
            return lpVtbl->put_Strikethrough((IFont*)Unsafe.AsPointer(ref this), strikethrough);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Weight([NativeTypeName("SHORT *")] short* pWeight)
        {
            return lpVtbl->get_Weight((IFont*)Unsafe.AsPointer(ref this), pWeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Weight([NativeTypeName("SHORT")] short weight)
        {
            return lpVtbl->put_Weight((IFont*)Unsafe.AsPointer(ref this), weight);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Charset([NativeTypeName("SHORT *")] short* pCharset)
        {
            return lpVtbl->get_Charset((IFont*)Unsafe.AsPointer(ref this), pCharset);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Charset([NativeTypeName("SHORT")] short charset)
        {
            return lpVtbl->put_Charset((IFont*)Unsafe.AsPointer(ref this), charset);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_hFont([NativeTypeName("HFONT *")] IntPtr* phFont)
        {
            return lpVtbl->get_hFont((IFont*)Unsafe.AsPointer(ref this), phFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IFont **")] IFont** ppFont)
        {
            return lpVtbl->Clone((IFont*)Unsafe.AsPointer(ref this), ppFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("IFont *")] IFont* pFontOther)
        {
            return lpVtbl->IsEqual((IFont*)Unsafe.AsPointer(ref this), pFontOther);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRatio([NativeTypeName("LONG")] int cyLogical, [NativeTypeName("LONG")] int cyHimetric)
        {
            return lpVtbl->SetRatio((IFont*)Unsafe.AsPointer(ref this), cyLogical, cyHimetric);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryTextMetrics([NativeTypeName("TEXTMETRICOLE *")] TEXTMETRICW* pTM)
        {
            return lpVtbl->QueryTextMetrics((IFont*)Unsafe.AsPointer(ref this), pTM);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRefHfont([NativeTypeName("HFONT")] IntPtr hFont)
        {
            return lpVtbl->AddRefHfont((IFont*)Unsafe.AsPointer(ref this), hFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseHfont([NativeTypeName("HFONT")] IntPtr hFont)
        {
            return lpVtbl->ReleaseHfont((IFont*)Unsafe.AsPointer(ref this), hFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHdc([NativeTypeName("HDC")] IntPtr hDC)
        {
            return lpVtbl->SetHdc((IFont*)Unsafe.AsPointer(ref this), hDC);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, uint> Release;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, ushort**, int> get_Name;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, ushort*, int> put_Name;

            [NativeTypeName("HRESULT (CY *) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, CY*, int> get_Size;

            [NativeTypeName("HRESULT (CY) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, CY, int> put_Size;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, int*, int> get_Bold;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, int, int> put_Bold;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, int*, int> get_Italic;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, int, int> put_Italic;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, int*, int> get_Underline;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, int, int> put_Underline;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, int*, int> get_Strikethrough;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, int, int> put_Strikethrough;

            [NativeTypeName("HRESULT (SHORT *) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, short*, int> get_Weight;

            [NativeTypeName("HRESULT (SHORT) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, short, int> put_Weight;

            [NativeTypeName("HRESULT (SHORT *) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, short*, int> get_Charset;

            [NativeTypeName("HRESULT (SHORT) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, short, int> put_Charset;

            [NativeTypeName("HRESULT (HFONT *) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, IntPtr*, int> get_hFont;

            [NativeTypeName("HRESULT (IFont **) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, IFont**, int> Clone;

            [NativeTypeName("HRESULT (IFont *) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, IFont*, int> IsEqual;

            [NativeTypeName("HRESULT (LONG, LONG) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, int, int, int> SetRatio;

            [NativeTypeName("HRESULT (TEXTMETRICOLE *) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, TEXTMETRICW*, int> QueryTextMetrics;

            [NativeTypeName("HRESULT (HFONT) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, IntPtr, int> AddRefHfont;

            [NativeTypeName("HRESULT (HFONT) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, IntPtr, int> ReleaseHfont;

            [NativeTypeName("HRESULT (HDC) __attribute__((stdcall))")]
            public delegate* stdcall<IFont*, IntPtr, int> SetHdc;
        }
    }
}
