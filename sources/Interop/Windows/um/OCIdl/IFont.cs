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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IFont* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IFont* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IFont* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_Name(IFont* pThis, [NativeTypeName("BSTR *")] ushort** pName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_Name(IFont* pThis, [NativeTypeName("BSTR")] ushort* name);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_Size(IFont* pThis, [NativeTypeName("CY *")] CY* pSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_Size(IFont* pThis, CY size);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_Bold(IFont* pThis, [NativeTypeName("BOOL *")] int* pBold);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_Bold(IFont* pThis, [NativeTypeName("BOOL")] int bold);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_Italic(IFont* pThis, [NativeTypeName("BOOL *")] int* pItalic);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_Italic(IFont* pThis, [NativeTypeName("BOOL")] int italic);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_Underline(IFont* pThis, [NativeTypeName("BOOL *")] int* pUnderline);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_Underline(IFont* pThis, [NativeTypeName("BOOL")] int underline);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_Strikethrough(IFont* pThis, [NativeTypeName("BOOL *")] int* pStrikethrough);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_Strikethrough(IFont* pThis, [NativeTypeName("BOOL")] int strikethrough);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_Weight(IFont* pThis, [NativeTypeName("SHORT *")] short* pWeight);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_Weight(IFont* pThis, [NativeTypeName("SHORT")] short weight);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_Charset(IFont* pThis, [NativeTypeName("SHORT *")] short* pCharset);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_Charset(IFont* pThis, [NativeTypeName("SHORT")] short charset);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_hFont(IFont* pThis, [NativeTypeName("HFONT *")] IntPtr* phFont);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(IFont* pThis, [NativeTypeName("IFont **")] IFont** ppFont);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsEqual(IFont* pThis, [NativeTypeName("IFont *")] IFont* pFontOther);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRatio(IFont* pThis, [NativeTypeName("LONG")] int cyLogical, [NativeTypeName("LONG")] int cyHimetric);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryTextMetrics(IFont* pThis, [NativeTypeName("TEXTMETRICOLE *")] TEXTMETRICW* pTM);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddRefHfont(IFont* pThis, [NativeTypeName("HFONT")] IntPtr hFont);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReleaseHfont(IFont* pThis, [NativeTypeName("HFONT")] IntPtr hFont);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetHdc(IFont* pThis, [NativeTypeName("HDC")] IntPtr hDC);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IFont*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IFont*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IFont*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("BSTR *")] ushort** pName)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_Name>(lpVtbl->get_Name)((IFont*)Unsafe.AsPointer(ref this), pName);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Name([NativeTypeName("BSTR")] ushort* name)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_Name>(lpVtbl->put_Name)((IFont*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Size([NativeTypeName("CY *")] CY* pSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_Size>(lpVtbl->get_Size)((IFont*)Unsafe.AsPointer(ref this), pSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Size(CY size)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_Size>(lpVtbl->put_Size)((IFont*)Unsafe.AsPointer(ref this), size);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Bold([NativeTypeName("BOOL *")] int* pBold)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_Bold>(lpVtbl->get_Bold)((IFont*)Unsafe.AsPointer(ref this), pBold);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Bold([NativeTypeName("BOOL")] int bold)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_Bold>(lpVtbl->put_Bold)((IFont*)Unsafe.AsPointer(ref this), bold);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Italic([NativeTypeName("BOOL *")] int* pItalic)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_Italic>(lpVtbl->get_Italic)((IFont*)Unsafe.AsPointer(ref this), pItalic);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Italic([NativeTypeName("BOOL")] int italic)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_Italic>(lpVtbl->put_Italic)((IFont*)Unsafe.AsPointer(ref this), italic);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Underline([NativeTypeName("BOOL *")] int* pUnderline)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_Underline>(lpVtbl->get_Underline)((IFont*)Unsafe.AsPointer(ref this), pUnderline);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Underline([NativeTypeName("BOOL")] int underline)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_Underline>(lpVtbl->put_Underline)((IFont*)Unsafe.AsPointer(ref this), underline);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Strikethrough([NativeTypeName("BOOL *")] int* pStrikethrough)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_Strikethrough>(lpVtbl->get_Strikethrough)((IFont*)Unsafe.AsPointer(ref this), pStrikethrough);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Strikethrough([NativeTypeName("BOOL")] int strikethrough)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_Strikethrough>(lpVtbl->put_Strikethrough)((IFont*)Unsafe.AsPointer(ref this), strikethrough);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Weight([NativeTypeName("SHORT *")] short* pWeight)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_Weight>(lpVtbl->get_Weight)((IFont*)Unsafe.AsPointer(ref this), pWeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Weight([NativeTypeName("SHORT")] short weight)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_Weight>(lpVtbl->put_Weight)((IFont*)Unsafe.AsPointer(ref this), weight);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Charset([NativeTypeName("SHORT *")] short* pCharset)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_Charset>(lpVtbl->get_Charset)((IFont*)Unsafe.AsPointer(ref this), pCharset);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_Charset([NativeTypeName("SHORT")] short charset)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_Charset>(lpVtbl->put_Charset)((IFont*)Unsafe.AsPointer(ref this), charset);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_hFont([NativeTypeName("HFONT *")] IntPtr* phFont)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_hFont>(lpVtbl->get_hFont)((IFont*)Unsafe.AsPointer(ref this), phFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IFont **")] IFont** ppFont)
        {
            return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)((IFont*)Unsafe.AsPointer(ref this), ppFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("IFont *")] IFont* pFontOther)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsEqual>(lpVtbl->IsEqual)((IFont*)Unsafe.AsPointer(ref this), pFontOther);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRatio([NativeTypeName("LONG")] int cyLogical, [NativeTypeName("LONG")] int cyHimetric)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetRatio>(lpVtbl->SetRatio)((IFont*)Unsafe.AsPointer(ref this), cyLogical, cyHimetric);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryTextMetrics([NativeTypeName("TEXTMETRICOLE *")] TEXTMETRICW* pTM)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryTextMetrics>(lpVtbl->QueryTextMetrics)((IFont*)Unsafe.AsPointer(ref this), pTM);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRefHfont([NativeTypeName("HFONT")] IntPtr hFont)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRefHfont>(lpVtbl->AddRefHfont)((IFont*)Unsafe.AsPointer(ref this), hFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseHfont([NativeTypeName("HFONT")] IntPtr hFont)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReleaseHfont>(lpVtbl->ReleaseHfont)((IFont*)Unsafe.AsPointer(ref this), hFont);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHdc([NativeTypeName("HDC")] IntPtr hDC)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetHdc>(lpVtbl->SetHdc)((IFont*)Unsafe.AsPointer(ref this), hDC);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_Name;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public IntPtr put_Name;

            [NativeTypeName("HRESULT (CY *) __attribute__((stdcall))")]
            public IntPtr get_Size;

            [NativeTypeName("HRESULT (CY) __attribute__((stdcall))")]
            public IntPtr put_Size;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr get_Bold;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr put_Bold;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr get_Italic;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr put_Italic;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr get_Underline;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr put_Underline;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr get_Strikethrough;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr put_Strikethrough;

            [NativeTypeName("HRESULT (SHORT *) __attribute__((stdcall))")]
            public IntPtr get_Weight;

            [NativeTypeName("HRESULT (SHORT) __attribute__((stdcall))")]
            public IntPtr put_Weight;

            [NativeTypeName("HRESULT (SHORT *) __attribute__((stdcall))")]
            public IntPtr get_Charset;

            [NativeTypeName("HRESULT (SHORT) __attribute__((stdcall))")]
            public IntPtr put_Charset;

            [NativeTypeName("HRESULT (HFONT *) __attribute__((stdcall))")]
            public IntPtr get_hFont;

            [NativeTypeName("HRESULT (IFont **) __attribute__((stdcall))")]
            public IntPtr Clone;

            [NativeTypeName("HRESULT (IFont *) __attribute__((stdcall))")]
            public IntPtr IsEqual;

            [NativeTypeName("HRESULT (LONG, LONG) __attribute__((stdcall))")]
            public IntPtr SetRatio;

            [NativeTypeName("HRESULT (TEXTMETRICOLE *) __attribute__((stdcall))")]
            public IntPtr QueryTextMetrics;

            [NativeTypeName("HRESULT (HFONT) __attribute__((stdcall))")]
            public IntPtr AddRefHfont;

            [NativeTypeName("HRESULT (HFONT) __attribute__((stdcall))")]
            public IntPtr ReleaseHfont;

            [NativeTypeName("HRESULT (HDC) __attribute__((stdcall))")]
            public IntPtr SetHdc;
        }
    }
}
