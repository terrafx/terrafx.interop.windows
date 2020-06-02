// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F5185DD8-2012-4B0B-AAD9-F052C6BD482B")]
    public unsafe partial struct IPicture2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPicture2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPicture2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPicture2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Handle([NativeTypeName("HHANDLE *")] nuint* pHandle)
        {
            return lpVtbl->get_Handle((IPicture2*)Unsafe.AsPointer(ref this), pHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_hPal([NativeTypeName("HHANDLE *")] nuint* phPal)
        {
            return lpVtbl->get_hPal((IPicture2*)Unsafe.AsPointer(ref this), phPal);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Type([NativeTypeName("SHORT *")] short* pType)
        {
            return lpVtbl->get_Type((IPicture2*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Width([NativeTypeName("OLE_XSIZE_HIMETRIC *")] int* pWidth)
        {
            return lpVtbl->get_Width((IPicture2*)Unsafe.AsPointer(ref this), pWidth);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Height([NativeTypeName("OLE_YSIZE_HIMETRIC *")] int* pHeight)
        {
            return lpVtbl->get_Height((IPicture2*)Unsafe.AsPointer(ref this), pHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int Render([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("LONG")] int cx, [NativeTypeName("LONG")] int cy, [NativeTypeName("OLE_XPOS_HIMETRIC")] int xSrc, [NativeTypeName("OLE_YPOS_HIMETRIC")] int ySrc, [NativeTypeName("OLE_XSIZE_HIMETRIC")] int cxSrc, [NativeTypeName("OLE_YSIZE_HIMETRIC")] int cySrc, [NativeTypeName("LPCRECT")] RECT* pRcWBounds)
        {
            return lpVtbl->Render((IPicture2*)Unsafe.AsPointer(ref this), hDC, x, y, cx, cy, xSrc, ySrc, cxSrc, cySrc, pRcWBounds);
        }

        [return: NativeTypeName("HRESULT")]
        public int set_hPal([NativeTypeName("HHANDLE")] nuint hPal)
        {
            return lpVtbl->set_hPal((IPicture2*)Unsafe.AsPointer(ref this), hPal);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_CurDC([NativeTypeName("HDC *")] IntPtr* phDC)
        {
            return lpVtbl->get_CurDC((IPicture2*)Unsafe.AsPointer(ref this), phDC);
        }

        [return: NativeTypeName("HRESULT")]
        public int SelectPicture([NativeTypeName("HDC")] IntPtr hDCIn, [NativeTypeName("HDC *")] IntPtr* phDCOut, [NativeTypeName("HHANDLE *")] nuint* phBmpOut)
        {
            return lpVtbl->SelectPicture((IPicture2*)Unsafe.AsPointer(ref this), hDCIn, phDCOut, phBmpOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_KeepOriginalFormat([NativeTypeName("BOOL *")] int* pKeep)
        {
            return lpVtbl->get_KeepOriginalFormat((IPicture2*)Unsafe.AsPointer(ref this), pKeep);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_KeepOriginalFormat([NativeTypeName("BOOL")] int keep)
        {
            return lpVtbl->put_KeepOriginalFormat((IPicture2*)Unsafe.AsPointer(ref this), keep);
        }

        [return: NativeTypeName("HRESULT")]
        public int PictureChanged()
        {
            return lpVtbl->PictureChanged((IPicture2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveAsFile([NativeTypeName("LPSTREAM")] IStream* pStream, [NativeTypeName("BOOL")] int fSaveMemCopy, [NativeTypeName("LONG *")] int* pCbSize)
        {
            return lpVtbl->SaveAsFile((IPicture2*)Unsafe.AsPointer(ref this), pStream, fSaveMemCopy, pCbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Attributes([NativeTypeName("DWORD *")] uint* pDwAttr)
        {
            return lpVtbl->get_Attributes((IPicture2*)Unsafe.AsPointer(ref this), pDwAttr);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, uint> Release;

            [NativeTypeName("HRESULT (HHANDLE *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, nuint*, int> get_Handle;

            [NativeTypeName("HRESULT (HHANDLE *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, nuint*, int> get_hPal;

            [NativeTypeName("HRESULT (SHORT *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, short*, int> get_Type;

            [NativeTypeName("HRESULT (OLE_XSIZE_HIMETRIC *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, int*, int> get_Width;

            [NativeTypeName("HRESULT (OLE_YSIZE_HIMETRIC *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, int*, int> get_Height;

            [NativeTypeName("HRESULT (HDC, LONG, LONG, LONG, LONG, OLE_XPOS_HIMETRIC, OLE_YPOS_HIMETRIC, OLE_XSIZE_HIMETRIC, OLE_YSIZE_HIMETRIC, LPCRECT) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, IntPtr, int, int, int, int, int, int, int, int, RECT*, int> Render;

            [NativeTypeName("HRESULT (HHANDLE) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, nuint, int> set_hPal;

            [NativeTypeName("HRESULT (HDC *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, IntPtr*, int> get_CurDC;

            [NativeTypeName("HRESULT (HDC, HDC *, HHANDLE *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, IntPtr, IntPtr*, nuint*, int> SelectPicture;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, int*, int> get_KeepOriginalFormat;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, int, int> put_KeepOriginalFormat;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, int> PictureChanged;

            [NativeTypeName("HRESULT (LPSTREAM, BOOL, LONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, IStream*, int, int*, int> SaveAsFile;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture2*, uint*, int> get_Attributes;
        }
    }
}
