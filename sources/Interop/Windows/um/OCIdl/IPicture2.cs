// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F5185DD8-2012-4B0B-AAD9-F052C6BD482B")]
    [NativeTypeName("struct IPicture2 : IUnknown")]
    public unsafe partial struct IPicture2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPicture2*, Guid*, void**, int>)(lpVtbl[0]))((IPicture2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPicture2*, uint>)(lpVtbl[1]))((IPicture2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPicture2*, uint>)(lpVtbl[2]))((IPicture2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Handle([NativeTypeName("HHANDLE *")] nuint* pHandle)
        {
            return ((delegate* stdcall<IPicture2*, nuint*, int>)(lpVtbl[3]))((IPicture2*)Unsafe.AsPointer(ref this), pHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_hPal([NativeTypeName("HHANDLE *")] nuint* phPal)
        {
            return ((delegate* stdcall<IPicture2*, nuint*, int>)(lpVtbl[4]))((IPicture2*)Unsafe.AsPointer(ref this), phPal);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Type([NativeTypeName("SHORT *")] short* pType)
        {
            return ((delegate* stdcall<IPicture2*, short*, int>)(lpVtbl[5]))((IPicture2*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Width([NativeTypeName("OLE_XSIZE_HIMETRIC *")] int* pWidth)
        {
            return ((delegate* stdcall<IPicture2*, int*, int>)(lpVtbl[6]))((IPicture2*)Unsafe.AsPointer(ref this), pWidth);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Height([NativeTypeName("OLE_YSIZE_HIMETRIC *")] int* pHeight)
        {
            return ((delegate* stdcall<IPicture2*, int*, int>)(lpVtbl[7]))((IPicture2*)Unsafe.AsPointer(ref this), pHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int Render([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("LONG")] int cx, [NativeTypeName("LONG")] int cy, [NativeTypeName("OLE_XPOS_HIMETRIC")] int xSrc, [NativeTypeName("OLE_YPOS_HIMETRIC")] int ySrc, [NativeTypeName("OLE_XSIZE_HIMETRIC")] int cxSrc, [NativeTypeName("OLE_YSIZE_HIMETRIC")] int cySrc, [NativeTypeName("LPCRECT")] RECT* pRcWBounds)
        {
            return ((delegate* stdcall<IPicture2*, IntPtr, int, int, int, int, int, int, int, int, RECT*, int>)(lpVtbl[8]))((IPicture2*)Unsafe.AsPointer(ref this), hDC, x, y, cx, cy, xSrc, ySrc, cxSrc, cySrc, pRcWBounds);
        }

        [return: NativeTypeName("HRESULT")]
        public int set_hPal([NativeTypeName("HHANDLE")] nuint hPal)
        {
            return ((delegate* stdcall<IPicture2*, nuint, int>)(lpVtbl[9]))((IPicture2*)Unsafe.AsPointer(ref this), hPal);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_CurDC([NativeTypeName("HDC *")] IntPtr* phDC)
        {
            return ((delegate* stdcall<IPicture2*, IntPtr*, int>)(lpVtbl[10]))((IPicture2*)Unsafe.AsPointer(ref this), phDC);
        }

        [return: NativeTypeName("HRESULT")]
        public int SelectPicture([NativeTypeName("HDC")] IntPtr hDCIn, [NativeTypeName("HDC *")] IntPtr* phDCOut, [NativeTypeName("HHANDLE *")] nuint* phBmpOut)
        {
            return ((delegate* stdcall<IPicture2*, IntPtr, IntPtr*, nuint*, int>)(lpVtbl[11]))((IPicture2*)Unsafe.AsPointer(ref this), hDCIn, phDCOut, phBmpOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_KeepOriginalFormat([NativeTypeName("BOOL *")] int* pKeep)
        {
            return ((delegate* stdcall<IPicture2*, int*, int>)(lpVtbl[12]))((IPicture2*)Unsafe.AsPointer(ref this), pKeep);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_KeepOriginalFormat([NativeTypeName("BOOL")] int keep)
        {
            return ((delegate* stdcall<IPicture2*, int, int>)(lpVtbl[13]))((IPicture2*)Unsafe.AsPointer(ref this), keep);
        }

        [return: NativeTypeName("HRESULT")]
        public int PictureChanged()
        {
            return ((delegate* stdcall<IPicture2*, int>)(lpVtbl[14]))((IPicture2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveAsFile([NativeTypeName("LPSTREAM")] IStream* pStream, [NativeTypeName("BOOL")] int fSaveMemCopy, [NativeTypeName("LONG *")] int* pCbSize)
        {
            return ((delegate* stdcall<IPicture2*, IStream*, int, int*, int>)(lpVtbl[15]))((IPicture2*)Unsafe.AsPointer(ref this), pStream, fSaveMemCopy, pCbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Attributes([NativeTypeName("DWORD *")] uint* pDwAttr)
        {
            return ((delegate* stdcall<IPicture2*, uint*, int>)(lpVtbl[16]))((IPicture2*)Unsafe.AsPointer(ref this), pDwAttr);
        }
    }
}
