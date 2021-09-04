// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/commoncontrols.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("46EB5926-582E-4017-9FDF-E8998DAA0950")]
    [NativeTypeName("struct IImageList : IUnknown")]
    public unsafe partial struct IImageList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IImageList*, Guid*, void**, int>)(lpVtbl[0]))((IImageList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IImageList*, uint>)(lpVtbl[1]))((IImageList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IImageList*, uint>)(lpVtbl[2]))((IImageList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Add([NativeTypeName("HBITMAP")] IntPtr hbmImage, [NativeTypeName("HBITMAP")] IntPtr hbmMask, int* pi)
        {
            return ((delegate* unmanaged<IImageList*, IntPtr, IntPtr, int*, int>)(lpVtbl[3]))((IImageList*)Unsafe.AsPointer(ref this), hbmImage, hbmMask, pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReplaceIcon(int i, [NativeTypeName("HICON")] IntPtr hicon, int* pi)
        {
            return ((delegate* unmanaged<IImageList*, int, IntPtr, int*, int>)(lpVtbl[4]))((IImageList*)Unsafe.AsPointer(ref this), i, hicon, pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOverlayImage(int iImage, int iOverlay)
        {
            return ((delegate* unmanaged<IImageList*, int, int, int>)(lpVtbl[5]))((IImageList*)Unsafe.AsPointer(ref this), iImage, iOverlay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Replace(int i, [NativeTypeName("HBITMAP")] IntPtr hbmImage, [NativeTypeName("HBITMAP")] IntPtr hbmMask)
        {
            return ((delegate* unmanaged<IImageList*, int, IntPtr, IntPtr, int>)(lpVtbl[6]))((IImageList*)Unsafe.AsPointer(ref this), i, hbmImage, hbmMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddMasked([NativeTypeName("HBITMAP")] IntPtr hbmImage, [NativeTypeName("COLORREF")] uint crMask, int* pi)
        {
            return ((delegate* unmanaged<IImageList*, IntPtr, uint, int*, int>)(lpVtbl[7]))((IImageList*)Unsafe.AsPointer(ref this), hbmImage, crMask, pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Draw(IMAGELISTDRAWPARAMS* pimldp)
        {
            return ((delegate* unmanaged<IImageList*, IMAGELISTDRAWPARAMS*, int>)(lpVtbl[8]))((IImageList*)Unsafe.AsPointer(ref this), pimldp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Remove(int i)
        {
            return ((delegate* unmanaged<IImageList*, int, int>)(lpVtbl[9]))((IImageList*)Unsafe.AsPointer(ref this), i);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIcon(int i, [NativeTypeName("UINT")] uint flags, [NativeTypeName("HICON *")] IntPtr* picon)
        {
            return ((delegate* unmanaged<IImageList*, int, uint, IntPtr*, int>)(lpVtbl[10]))((IImageList*)Unsafe.AsPointer(ref this), i, flags, picon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetImageInfo(int i, IMAGEINFO* pImageInfo)
        {
            return ((delegate* unmanaged<IImageList*, int, IMAGEINFO*, int>)(lpVtbl[11]))((IImageList*)Unsafe.AsPointer(ref this), i, pImageInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Copy(int iDst, IUnknown* punkSrc, int iSrc, [NativeTypeName("UINT")] uint uFlags)
        {
            return ((delegate* unmanaged<IImageList*, int, IUnknown*, int, uint, int>)(lpVtbl[12]))((IImageList*)Unsafe.AsPointer(ref this), iDst, punkSrc, iSrc, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Merge(int i1, IUnknown* punk2, int i2, int dx, int dy, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IImageList*, int, IUnknown*, int, int, int, Guid*, void**, int>)(lpVtbl[13]))((IImageList*)Unsafe.AsPointer(ref this), i1, punk2, i2, dx, dy, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IImageList*, Guid*, void**, int>)(lpVtbl[14]))((IImageList*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetImageRect(int i, RECT* prc)
        {
            return ((delegate* unmanaged<IImageList*, int, RECT*, int>)(lpVtbl[15]))((IImageList*)Unsafe.AsPointer(ref this), i, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIconSize(int* cx, int* cy)
        {
            return ((delegate* unmanaged<IImageList*, int*, int*, int>)(lpVtbl[16]))((IImageList*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIconSize(int cx, int cy)
        {
            return ((delegate* unmanaged<IImageList*, int, int, int>)(lpVtbl[17]))((IImageList*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetImageCount(int* pi)
        {
            return ((delegate* unmanaged<IImageList*, int*, int>)(lpVtbl[18]))((IImageList*)Unsafe.AsPointer(ref this), pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetImageCount([NativeTypeName("UINT")] uint uNewCount)
        {
            return ((delegate* unmanaged<IImageList*, uint, int>)(lpVtbl[19]))((IImageList*)Unsafe.AsPointer(ref this), uNewCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBkColor([NativeTypeName("COLORREF")] uint clrBk, [NativeTypeName("COLORREF *")] uint* pclr)
        {
            return ((delegate* unmanaged<IImageList*, uint, uint*, int>)(lpVtbl[20]))((IImageList*)Unsafe.AsPointer(ref this), clrBk, pclr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBkColor([NativeTypeName("COLORREF *")] uint* pclr)
        {
            return ((delegate* unmanaged<IImageList*, uint*, int>)(lpVtbl[21]))((IImageList*)Unsafe.AsPointer(ref this), pclr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginDrag(int iTrack, int dxHotspot, int dyHotspot)
        {
            return ((delegate* unmanaged<IImageList*, int, int, int, int>)(lpVtbl[22]))((IImageList*)Unsafe.AsPointer(ref this), iTrack, dxHotspot, dyHotspot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndDrag()
        {
            return ((delegate* unmanaged<IImageList*, int>)(lpVtbl[23]))((IImageList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DragEnter([NativeTypeName("HWND")] IntPtr hwndLock, int x, int y)
        {
            return ((delegate* unmanaged<IImageList*, IntPtr, int, int, int>)(lpVtbl[24]))((IImageList*)Unsafe.AsPointer(ref this), hwndLock, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DragLeave([NativeTypeName("HWND")] IntPtr hwndLock)
        {
            return ((delegate* unmanaged<IImageList*, IntPtr, int>)(lpVtbl[25]))((IImageList*)Unsafe.AsPointer(ref this), hwndLock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DragMove(int x, int y)
        {
            return ((delegate* unmanaged<IImageList*, int, int, int>)(lpVtbl[26]))((IImageList*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDragCursorImage(IUnknown* punk, int iDrag, int dxHotspot, int dyHotspot)
        {
            return ((delegate* unmanaged<IImageList*, IUnknown*, int, int, int, int>)(lpVtbl[27]))((IImageList*)Unsafe.AsPointer(ref this), punk, iDrag, dxHotspot, dyHotspot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DragShowNolock([NativeTypeName("BOOL")] int fShow)
        {
            return ((delegate* unmanaged<IImageList*, int, int>)(lpVtbl[28]))((IImageList*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDragImage(POINT* ppt, POINT* pptHotspot, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IImageList*, POINT*, POINT*, Guid*, void**, int>)(lpVtbl[29]))((IImageList*)Unsafe.AsPointer(ref this), ppt, pptHotspot, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemFlags(int i, [NativeTypeName("DWORD *")] uint* dwFlags)
        {
            return ((delegate* unmanaged<IImageList*, int, uint*, int>)(lpVtbl[30]))((IImageList*)Unsafe.AsPointer(ref this), i, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOverlayImage(int iOverlay, int* piIndex)
        {
            return ((delegate* unmanaged<IImageList*, int, int*, int>)(lpVtbl[31]))((IImageList*)Unsafe.AsPointer(ref this), iOverlay, piIndex);
        }
    }
}
