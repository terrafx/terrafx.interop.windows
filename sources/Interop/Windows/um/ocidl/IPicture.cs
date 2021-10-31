// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7BF80980-BF32-101A-8BBB-00AA00300CAB")]
    [NativeTypeName("struct IPicture : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPicture
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPicture*, Guid*, void**, int>)(lpVtbl[0]))((IPicture*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPicture*, uint>)(lpVtbl[1]))((IPicture*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPicture*, uint>)(lpVtbl[2]))((IPicture*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_Handle([NativeTypeName("OLE_HANDLE *")] uint* pHandle)
        {
            return ((delegate* unmanaged<IPicture*, uint*, int>)(lpVtbl[3]))((IPicture*)Unsafe.AsPointer(ref this), pHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_hPal([NativeTypeName("OLE_HANDLE *")] uint* phPal)
        {
            return ((delegate* unmanaged<IPicture*, uint*, int>)(lpVtbl[4]))((IPicture*)Unsafe.AsPointer(ref this), phPal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT get_Type([NativeTypeName("SHORT *")] short* pType)
        {
            return ((delegate* unmanaged<IPicture*, short*, int>)(lpVtbl[5]))((IPicture*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT get_Width([NativeTypeName("OLE_XSIZE_HIMETRIC *")] int* pWidth)
        {
            return ((delegate* unmanaged<IPicture*, int*, int>)(lpVtbl[6]))((IPicture*)Unsafe.AsPointer(ref this), pWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Height([NativeTypeName("OLE_YSIZE_HIMETRIC *")] int* pHeight)
        {
            return ((delegate* unmanaged<IPicture*, int*, int>)(lpVtbl[7]))((IPicture*)Unsafe.AsPointer(ref this), pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Render([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("LONG")] int cx, [NativeTypeName("LONG")] int cy, [NativeTypeName("OLE_XPOS_HIMETRIC")] int xSrc, [NativeTypeName("OLE_YPOS_HIMETRIC")] int ySrc, [NativeTypeName("OLE_XSIZE_HIMETRIC")] int cxSrc, [NativeTypeName("OLE_YSIZE_HIMETRIC")] int cySrc, [NativeTypeName("LPCRECT")] RECT* pRcWBounds)
        {
            return ((delegate* unmanaged<IPicture*, IntPtr, int, int, int, int, int, int, int, int, RECT*, int>)(lpVtbl[8]))((IPicture*)Unsafe.AsPointer(ref this), hDC, x, y, cx, cy, xSrc, ySrc, cxSrc, cySrc, pRcWBounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT set_hPal([NativeTypeName("OLE_HANDLE")] uint hPal)
        {
            return ((delegate* unmanaged<IPicture*, uint, int>)(lpVtbl[9]))((IPicture*)Unsafe.AsPointer(ref this), hPal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_CurDC([NativeTypeName("HDC *")] IntPtr* phDC)
        {
            return ((delegate* unmanaged<IPicture*, IntPtr*, int>)(lpVtbl[10]))((IPicture*)Unsafe.AsPointer(ref this), phDC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SelectPicture([NativeTypeName("HDC")] IntPtr hDCIn, [NativeTypeName("HDC *")] IntPtr* phDCOut, [NativeTypeName("OLE_HANDLE *")] uint* phBmpOut)
        {
            return ((delegate* unmanaged<IPicture*, IntPtr, IntPtr*, uint*, int>)(lpVtbl[11]))((IPicture*)Unsafe.AsPointer(ref this), hDCIn, phDCOut, phBmpOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_KeepOriginalFormat(BOOL* pKeep)
        {
            return ((delegate* unmanaged<IPicture*, BOOL*, int>)(lpVtbl[12]))((IPicture*)Unsafe.AsPointer(ref this), pKeep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_KeepOriginalFormat(BOOL keep)
        {
            return ((delegate* unmanaged<IPicture*, BOOL, int>)(lpVtbl[13]))((IPicture*)Unsafe.AsPointer(ref this), keep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT PictureChanged()
        {
            return ((delegate* unmanaged<IPicture*, int>)(lpVtbl[14]))((IPicture*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SaveAsFile([NativeTypeName("LPSTREAM")] IStream* pStream, BOOL fSaveMemCopy, [NativeTypeName("LONG *")] int* pCbSize)
        {
            return ((delegate* unmanaged<IPicture*, IStream*, BOOL, int*, int>)(lpVtbl[15]))((IPicture*)Unsafe.AsPointer(ref this), pStream, fSaveMemCopy, pCbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_Attributes([NativeTypeName("DWORD *")] uint* pDwAttr)
        {
            return ((delegate* unmanaged<IPicture*, uint*, int>)(lpVtbl[16]))((IPicture*)Unsafe.AsPointer(ref this), pDwAttr);
        }
    }
}
