// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7BF80980-BF32-101A-8BBB-00AA00300CAB")]
    public unsafe partial struct IPicture
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPicture*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPicture*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPicture*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Handle([NativeTypeName("OLE_HANDLE *")] uint* pHandle)
        {
            return lpVtbl->get_Handle((IPicture*)Unsafe.AsPointer(ref this), pHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_hPal([NativeTypeName("OLE_HANDLE *")] uint* phPal)
        {
            return lpVtbl->get_hPal((IPicture*)Unsafe.AsPointer(ref this), phPal);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Type([NativeTypeName("SHORT *")] short* pType)
        {
            return lpVtbl->get_Type((IPicture*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Width([NativeTypeName("OLE_XSIZE_HIMETRIC *")] int* pWidth)
        {
            return lpVtbl->get_Width((IPicture*)Unsafe.AsPointer(ref this), pWidth);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Height([NativeTypeName("OLE_YSIZE_HIMETRIC *")] int* pHeight)
        {
            return lpVtbl->get_Height((IPicture*)Unsafe.AsPointer(ref this), pHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int Render([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("LONG")] int cx, [NativeTypeName("LONG")] int cy, [NativeTypeName("OLE_XPOS_HIMETRIC")] int xSrc, [NativeTypeName("OLE_YPOS_HIMETRIC")] int ySrc, [NativeTypeName("OLE_XSIZE_HIMETRIC")] int cxSrc, [NativeTypeName("OLE_YSIZE_HIMETRIC")] int cySrc, [NativeTypeName("LPCRECT")] RECT* pRcWBounds)
        {
            return lpVtbl->Render((IPicture*)Unsafe.AsPointer(ref this), hDC, x, y, cx, cy, xSrc, ySrc, cxSrc, cySrc, pRcWBounds);
        }

        [return: NativeTypeName("HRESULT")]
        public int set_hPal([NativeTypeName("OLE_HANDLE")] uint hPal)
        {
            return lpVtbl->set_hPal((IPicture*)Unsafe.AsPointer(ref this), hPal);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_CurDC([NativeTypeName("HDC *")] IntPtr* phDC)
        {
            return lpVtbl->get_CurDC((IPicture*)Unsafe.AsPointer(ref this), phDC);
        }

        [return: NativeTypeName("HRESULT")]
        public int SelectPicture([NativeTypeName("HDC")] IntPtr hDCIn, [NativeTypeName("HDC *")] IntPtr* phDCOut, [NativeTypeName("OLE_HANDLE *")] uint* phBmpOut)
        {
            return lpVtbl->SelectPicture((IPicture*)Unsafe.AsPointer(ref this), hDCIn, phDCOut, phBmpOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_KeepOriginalFormat([NativeTypeName("BOOL *")] int* pKeep)
        {
            return lpVtbl->get_KeepOriginalFormat((IPicture*)Unsafe.AsPointer(ref this), pKeep);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_KeepOriginalFormat([NativeTypeName("BOOL")] int keep)
        {
            return lpVtbl->put_KeepOriginalFormat((IPicture*)Unsafe.AsPointer(ref this), keep);
        }

        [return: NativeTypeName("HRESULT")]
        public int PictureChanged()
        {
            return lpVtbl->PictureChanged((IPicture*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveAsFile([NativeTypeName("LPSTREAM")] IStream* pStream, [NativeTypeName("BOOL")] int fSaveMemCopy, [NativeTypeName("LONG *")] int* pCbSize)
        {
            return lpVtbl->SaveAsFile((IPicture*)Unsafe.AsPointer(ref this), pStream, fSaveMemCopy, pCbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Attributes([NativeTypeName("DWORD *")] uint* pDwAttr)
        {
            return lpVtbl->get_Attributes((IPicture*)Unsafe.AsPointer(ref this), pDwAttr);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, uint> Release;

            [NativeTypeName("HRESULT (OLE_HANDLE *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, uint*, int> get_Handle;

            [NativeTypeName("HRESULT (OLE_HANDLE *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, uint*, int> get_hPal;

            [NativeTypeName("HRESULT (SHORT *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, short*, int> get_Type;

            [NativeTypeName("HRESULT (OLE_XSIZE_HIMETRIC *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, int*, int> get_Width;

            [NativeTypeName("HRESULT (OLE_YSIZE_HIMETRIC *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, int*, int> get_Height;

            [NativeTypeName("HRESULT (HDC, LONG, LONG, LONG, LONG, OLE_XPOS_HIMETRIC, OLE_YPOS_HIMETRIC, OLE_XSIZE_HIMETRIC, OLE_YSIZE_HIMETRIC, LPCRECT) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, IntPtr, int, int, int, int, int, int, int, int, RECT*, int> Render;

            [NativeTypeName("HRESULT (OLE_HANDLE) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, uint, int> set_hPal;

            [NativeTypeName("HRESULT (HDC *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, IntPtr*, int> get_CurDC;

            [NativeTypeName("HRESULT (HDC, HDC *, OLE_HANDLE *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, IntPtr, IntPtr*, uint*, int> SelectPicture;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, int*, int> get_KeepOriginalFormat;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, int, int> put_KeepOriginalFormat;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, int> PictureChanged;

            [NativeTypeName("HRESULT (LPSTREAM, BOOL, LONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, IStream*, int, int*, int> SaveAsFile;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IPicture*, uint*, int> get_Attributes;
        }
    }
}
