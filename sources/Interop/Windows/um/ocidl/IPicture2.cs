// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F5185DD8-2012-4B0B-AAD9-F052C6BD482B")]
    [NativeTypeName("struct IPicture2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPicture2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPicture2*, Guid*, void**, int>)(lpVtbl[0]))((IPicture2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPicture2*, uint>)(lpVtbl[1]))((IPicture2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPicture2*, uint>)(lpVtbl[2]))((IPicture2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int get_Handle([NativeTypeName("HHANDLE *")] IntPtr* pHandle)
        {
            return ((delegate* unmanaged<IPicture2*, IntPtr*, int>)(lpVtbl[3]))((IPicture2*)Unsafe.AsPointer(ref this), pHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int get_hPal([NativeTypeName("HHANDLE *")] IntPtr* phPal)
        {
            return ((delegate* unmanaged<IPicture2*, IntPtr*, int>)(lpVtbl[4]))((IPicture2*)Unsafe.AsPointer(ref this), phPal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int get_Type([NativeTypeName("SHORT *")] short* pType)
        {
            return ((delegate* unmanaged<IPicture2*, short*, int>)(lpVtbl[5]))((IPicture2*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int get_Width([NativeTypeName("OLE_XSIZE_HIMETRIC *")] int* pWidth)
        {
            return ((delegate* unmanaged<IPicture2*, int*, int>)(lpVtbl[6]))((IPicture2*)Unsafe.AsPointer(ref this), pWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_Height([NativeTypeName("OLE_YSIZE_HIMETRIC *")] int* pHeight)
        {
            return ((delegate* unmanaged<IPicture2*, int*, int>)(lpVtbl[7]))((IPicture2*)Unsafe.AsPointer(ref this), pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Render([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("LONG")] int x, [NativeTypeName("LONG")] int y, [NativeTypeName("LONG")] int cx, [NativeTypeName("LONG")] int cy, [NativeTypeName("OLE_XPOS_HIMETRIC")] int xSrc, [NativeTypeName("OLE_YPOS_HIMETRIC")] int ySrc, [NativeTypeName("OLE_XSIZE_HIMETRIC")] int cxSrc, [NativeTypeName("OLE_YSIZE_HIMETRIC")] int cySrc, [NativeTypeName("LPCRECT")] RECT* pRcWBounds)
        {
            return ((delegate* unmanaged<IPicture2*, IntPtr, int, int, int, int, int, int, int, int, RECT*, int>)(lpVtbl[8]))((IPicture2*)Unsafe.AsPointer(ref this), hDC, x, y, cx, cy, xSrc, ySrc, cxSrc, cySrc, pRcWBounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int set_hPal([NativeTypeName("HHANDLE")] IntPtr hPal)
        {
            return ((delegate* unmanaged<IPicture2*, IntPtr, int>)(lpVtbl[9]))((IPicture2*)Unsafe.AsPointer(ref this), hPal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurDC([NativeTypeName("HDC *")] IntPtr* phDC)
        {
            return ((delegate* unmanaged<IPicture2*, IntPtr*, int>)(lpVtbl[10]))((IPicture2*)Unsafe.AsPointer(ref this), phDC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int SelectPicture([NativeTypeName("HDC")] IntPtr hDCIn, [NativeTypeName("HDC *")] IntPtr* phDCOut, [NativeTypeName("HHANDLE *")] IntPtr* phBmpOut)
        {
            return ((delegate* unmanaged<IPicture2*, IntPtr, IntPtr*, IntPtr*, int>)(lpVtbl[11]))((IPicture2*)Unsafe.AsPointer(ref this), hDCIn, phDCOut, phBmpOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_KeepOriginalFormat(BOOL* pKeep)
        {
            return ((delegate* unmanaged<IPicture2*, BOOL*, int>)(lpVtbl[12]))((IPicture2*)Unsafe.AsPointer(ref this), pKeep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_KeepOriginalFormat(BOOL keep)
        {
            return ((delegate* unmanaged<IPicture2*, BOOL, int>)(lpVtbl[13]))((IPicture2*)Unsafe.AsPointer(ref this), keep);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int PictureChanged()
        {
            return ((delegate* unmanaged<IPicture2*, int>)(lpVtbl[14]))((IPicture2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int SaveAsFile([NativeTypeName("LPSTREAM")] IStream* pStream, BOOL fSaveMemCopy, [NativeTypeName("LONG *")] int* pCbSize)
        {
            return ((delegate* unmanaged<IPicture2*, IStream*, BOOL, int*, int>)(lpVtbl[15]))((IPicture2*)Unsafe.AsPointer(ref this), pStream, fSaveMemCopy, pCbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_Attributes([NativeTypeName("DWORD *")] uint* pDwAttr)
        {
            return ((delegate* unmanaged<IPicture2*, uint*, int>)(lpVtbl[16]))((IPicture2*)Unsafe.AsPointer(ref this), pDwAttr);
        }
    }
}
