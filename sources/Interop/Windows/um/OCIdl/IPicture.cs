// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7BF80980-BF32-101A-8BBB-00AA00300CAB")]
    [NativeTypeName("struct IPicture : IUnknown")]
    public unsafe partial struct IPicture
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPicture*, Guid*, void**, int>)(lpVtbl[0]))((IPicture*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPicture*, uint>)(lpVtbl[1]))((IPicture*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPicture*, uint>)(lpVtbl[2]))((IPicture*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Handle([NativeTypeName("OLE_HANDLE *")] uint* pHandle)
        {
            return ((delegate* stdcall<IPicture*, uint*, int>)(lpVtbl[3]))((IPicture*)Unsafe.AsPointer(ref this), pHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_hPal([NativeTypeName("OLE_HANDLE *")] uint* phPal)
        {
            return ((delegate* stdcall<IPicture*, uint*, int>)(lpVtbl[4]))((IPicture*)Unsafe.AsPointer(ref this), phPal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Type([NativeTypeName("SHORT *")] short* pType)
        {
            return ((delegate* stdcall<IPicture*, short*, int>)(lpVtbl[5]))((IPicture*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Width([NativeTypeName("OLE_XSIZE_HIMETRIC *")] int* pWidth)
        {
            return ((delegate* stdcall<IPicture*, int*, int>)(lpVtbl[6]))((IPicture*)Unsafe.AsPointer(ref this), pWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Height([NativeTypeName("OLE_YSIZE_HIMETRIC *")] int* pHeight)
        {
            return ((delegate* stdcall<IPicture*, int*, int>)(lpVtbl[7]))((IPicture*)Unsafe.AsPointer(ref this), pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Render([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("LONG")] int cx, [NativeTypeName("LONG")] int cy, [NativeTypeName("OLE_XPOS_HIMETRIC")] int xSrc, [NativeTypeName("OLE_YPOS_HIMETRIC")] int ySrc, [NativeTypeName("OLE_XSIZE_HIMETRIC")] int cxSrc, [NativeTypeName("OLE_YSIZE_HIMETRIC")] int cySrc, [NativeTypeName("LPCRECT")] RECT* pRcWBounds)
        {
            return ((delegate* stdcall<IPicture*, IntPtr, int, int, int, int, int, int, int, int, RECT*, int>)(lpVtbl[8]))((IPicture*)Unsafe.AsPointer(ref this), hDC, x, y, cx, cy, xSrc, ySrc, cxSrc, cySrc, pRcWBounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int set_hPal([NativeTypeName("OLE_HANDLE")] uint hPal)
        {
            return ((delegate* stdcall<IPicture*, uint, int>)(lpVtbl[9]))((IPicture*)Unsafe.AsPointer(ref this), hPal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurDC([NativeTypeName("HDC *")] IntPtr* phDC)
        {
            return ((delegate* stdcall<IPicture*, IntPtr*, int>)(lpVtbl[10]))((IPicture*)Unsafe.AsPointer(ref this), phDC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SelectPicture([NativeTypeName("HDC")] IntPtr hDCIn, [NativeTypeName("HDC *")] IntPtr* phDCOut, [NativeTypeName("OLE_HANDLE *")] uint* phBmpOut)
        {
            return ((delegate* stdcall<IPicture*, IntPtr, IntPtr*, uint*, int>)(lpVtbl[11]))((IPicture*)Unsafe.AsPointer(ref this), hDCIn, phDCOut, phBmpOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_KeepOriginalFormat([NativeTypeName("BOOL *")] int* pKeep)
        {
            return ((delegate* stdcall<IPicture*, int*, int>)(lpVtbl[12]))((IPicture*)Unsafe.AsPointer(ref this), pKeep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_KeepOriginalFormat([NativeTypeName("BOOL")] int keep)
        {
            return ((delegate* stdcall<IPicture*, int, int>)(lpVtbl[13]))((IPicture*)Unsafe.AsPointer(ref this), keep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PictureChanged()
        {
            return ((delegate* stdcall<IPicture*, int>)(lpVtbl[14]))((IPicture*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SaveAsFile([NativeTypeName("LPSTREAM")] IStream* pStream, [NativeTypeName("BOOL")] int fSaveMemCopy, [NativeTypeName("LONG *")] int* pCbSize)
        {
            return ((delegate* stdcall<IPicture*, IStream*, int, int*, int>)(lpVtbl[15]))((IPicture*)Unsafe.AsPointer(ref this), pStream, fSaveMemCopy, pCbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Attributes([NativeTypeName("DWORD *")] uint* pDwAttr)
        {
            return ((delegate* stdcall<IPicture*, uint*, int>)(lpVtbl[16]))((IPicture*)Unsafe.AsPointer(ref this), pDwAttr);
        }
    }
}
