// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/commoncontrols.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("192B9D83-50FC-457B-90A0-2B82A8B5DAE1")]
    [NativeTypeName("struct IImageList2 : IImageList")]
    [NativeInheritance("IImageList")]
    public unsafe partial struct IImageList2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IImageList2*, Guid*, void**, int>)(lpVtbl[0]))((IImageList2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IImageList2*, uint>)(lpVtbl[1]))((IImageList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IImageList2*, uint>)(lpVtbl[2]))((IImageList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Add([NativeTypeName("HBITMAP")] IntPtr hbmImage, [NativeTypeName("HBITMAP")] IntPtr hbmMask, int* pi)
        {
            return ((delegate* unmanaged<IImageList2*, IntPtr, IntPtr, int*, int>)(lpVtbl[3]))((IImageList2*)Unsafe.AsPointer(ref this), hbmImage, hbmMask, pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ReplaceIcon(int i, [NativeTypeName("HICON")] IntPtr hicon, int* pi)
        {
            return ((delegate* unmanaged<IImageList2*, int, IntPtr, int*, int>)(lpVtbl[4]))((IImageList2*)Unsafe.AsPointer(ref this), i, hicon, pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetOverlayImage(int iImage, int iOverlay)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, int>)(lpVtbl[5]))((IImageList2*)Unsafe.AsPointer(ref this), iImage, iOverlay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Replace(int i, [NativeTypeName("HBITMAP")] IntPtr hbmImage, [NativeTypeName("HBITMAP")] IntPtr hbmMask)
        {
            return ((delegate* unmanaged<IImageList2*, int, IntPtr, IntPtr, int>)(lpVtbl[6]))((IImageList2*)Unsafe.AsPointer(ref this), i, hbmImage, hbmMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int AddMasked([NativeTypeName("HBITMAP")] IntPtr hbmImage, [NativeTypeName("COLORREF")] uint crMask, int* pi)
        {
            return ((delegate* unmanaged<IImageList2*, IntPtr, uint, int*, int>)(lpVtbl[7]))((IImageList2*)Unsafe.AsPointer(ref this), hbmImage, crMask, pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Draw(IMAGELISTDRAWPARAMS* pimldp)
        {
            return ((delegate* unmanaged<IImageList2*, IMAGELISTDRAWPARAMS*, int>)(lpVtbl[8]))((IImageList2*)Unsafe.AsPointer(ref this), pimldp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Remove(int i)
        {
            return ((delegate* unmanaged<IImageList2*, int, int>)(lpVtbl[9]))((IImageList2*)Unsafe.AsPointer(ref this), i);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetIcon(int i, [NativeTypeName("UINT")] uint flags, [NativeTypeName("HICON *")] IntPtr* picon)
        {
            return ((delegate* unmanaged<IImageList2*, int, uint, IntPtr*, int>)(lpVtbl[10]))((IImageList2*)Unsafe.AsPointer(ref this), i, flags, picon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetImageInfo(int i, IMAGEINFO* pImageInfo)
        {
            return ((delegate* unmanaged<IImageList2*, int, IMAGEINFO*, int>)(lpVtbl[11]))((IImageList2*)Unsafe.AsPointer(ref this), i, pImageInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Copy(int iDst, IUnknown* punkSrc, int iSrc, [NativeTypeName("UINT")] uint uFlags)
        {
            return ((delegate* unmanaged<IImageList2*, int, IUnknown*, int, uint, int>)(lpVtbl[12]))((IImageList2*)Unsafe.AsPointer(ref this), iDst, punkSrc, iSrc, uFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int Merge(int i1, IUnknown* punk2, int i2, int dx, int dy, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IImageList2*, int, IUnknown*, int, int, int, Guid*, void**, int>)(lpVtbl[13]))((IImageList2*)Unsafe.AsPointer(ref this), i1, punk2, i2, dx, dy, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IImageList2*, Guid*, void**, int>)(lpVtbl[14]))((IImageList2*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetImageRect(int i, RECT* prc)
        {
            return ((delegate* unmanaged<IImageList2*, int, RECT*, int>)(lpVtbl[15]))((IImageList2*)Unsafe.AsPointer(ref this), i, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetIconSize(int* cx, int* cy)
        {
            return ((delegate* unmanaged<IImageList2*, int*, int*, int>)(lpVtbl[16]))((IImageList2*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int SetIconSize(int cx, int cy)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, int>)(lpVtbl[17]))((IImageList2*)Unsafe.AsPointer(ref this), cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetImageCount(int* pi)
        {
            return ((delegate* unmanaged<IImageList2*, int*, int>)(lpVtbl[18]))((IImageList2*)Unsafe.AsPointer(ref this), pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int SetImageCount([NativeTypeName("UINT")] uint uNewCount)
        {
            return ((delegate* unmanaged<IImageList2*, uint, int>)(lpVtbl[19]))((IImageList2*)Unsafe.AsPointer(ref this), uNewCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int SetBkColor([NativeTypeName("COLORREF")] uint clrBk, [NativeTypeName("COLORREF *")] uint* pclr)
        {
            return ((delegate* unmanaged<IImageList2*, uint, uint*, int>)(lpVtbl[20]))((IImageList2*)Unsafe.AsPointer(ref this), clrBk, pclr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int GetBkColor([NativeTypeName("COLORREF *")] uint* pclr)
        {
            return ((delegate* unmanaged<IImageList2*, uint*, int>)(lpVtbl[21]))((IImageList2*)Unsafe.AsPointer(ref this), pclr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int BeginDrag(int iTrack, int dxHotspot, int dyHotspot)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, int, int>)(lpVtbl[22]))((IImageList2*)Unsafe.AsPointer(ref this), iTrack, dxHotspot, dyHotspot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int EndDrag()
        {
            return ((delegate* unmanaged<IImageList2*, int>)(lpVtbl[23]))((IImageList2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int DragEnter([NativeTypeName("HWND")] IntPtr hwndLock, int x, int y)
        {
            return ((delegate* unmanaged<IImageList2*, IntPtr, int, int, int>)(lpVtbl[24]))((IImageList2*)Unsafe.AsPointer(ref this), hwndLock, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int DragLeave([NativeTypeName("HWND")] IntPtr hwndLock)
        {
            return ((delegate* unmanaged<IImageList2*, IntPtr, int>)(lpVtbl[25]))((IImageList2*)Unsafe.AsPointer(ref this), hwndLock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int DragMove(int x, int y)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, int>)(lpVtbl[26]))((IImageList2*)Unsafe.AsPointer(ref this), x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int SetDragCursorImage(IUnknown* punk, int iDrag, int dxHotspot, int dyHotspot)
        {
            return ((delegate* unmanaged<IImageList2*, IUnknown*, int, int, int, int>)(lpVtbl[27]))((IImageList2*)Unsafe.AsPointer(ref this), punk, iDrag, dxHotspot, dyHotspot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int DragShowNolock([NativeTypeName("BOOL")] int fShow)
        {
            return ((delegate* unmanaged<IImageList2*, int, int>)(lpVtbl[28]))((IImageList2*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int GetDragImage(POINT* ppt, POINT* pptHotspot, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IImageList2*, POINT*, POINT*, Guid*, void**, int>)(lpVtbl[29]))((IImageList2*)Unsafe.AsPointer(ref this), ppt, pptHotspot, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemFlags(int i, [NativeTypeName("DWORD *")] uint* dwFlags)
        {
            return ((delegate* unmanaged<IImageList2*, int, uint*, int>)(lpVtbl[30]))((IImageList2*)Unsafe.AsPointer(ref this), i, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int GetOverlayImage(int iOverlay, int* piIndex)
        {
            return ((delegate* unmanaged<IImageList2*, int, int*, int>)(lpVtbl[31]))((IImageList2*)Unsafe.AsPointer(ref this), iOverlay, piIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int Resize(int cxNewIconSize, int cyNewIconSize)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, int>)(lpVtbl[32]))((IImageList2*)Unsafe.AsPointer(ref this), cxNewIconSize, cyNewIconSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int GetOriginalSize(int iImage, [NativeTypeName("DWORD")] uint dwFlags, int* pcx, int* pcy)
        {
            return ((delegate* unmanaged<IImageList2*, int, uint, int*, int*, int>)(lpVtbl[33]))((IImageList2*)Unsafe.AsPointer(ref this), iImage, dwFlags, pcx, pcy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int SetOriginalSize(int iImage, int cx, int cy)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, int, int>)(lpVtbl[34]))((IImageList2*)Unsafe.AsPointer(ref this), iImage, cx, cy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int SetCallback(IUnknown* punk)
        {
            return ((delegate* unmanaged<IImageList2*, IUnknown*, int>)(lpVtbl[35]))((IImageList2*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int GetCallback([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IImageList2*, Guid*, void**, int>)(lpVtbl[36]))((IImageList2*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int ForceImagePresent(int iImage, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IImageList2*, int, uint, int>)(lpVtbl[37]))((IImageList2*)Unsafe.AsPointer(ref this), iImage, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int DiscardImages(int iFirstImage, int iLastImage, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, uint, int>)(lpVtbl[38]))((IImageList2*)Unsafe.AsPointer(ref this), iFirstImage, iLastImage, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int PreloadImages(IMAGELISTDRAWPARAMS* pimldp)
        {
            return ((delegate* unmanaged<IImageList2*, IMAGELISTDRAWPARAMS*, int>)(lpVtbl[39]))((IImageList2*)Unsafe.AsPointer(ref this), pimldp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatistics([NativeTypeName("IMAGELISTSTATS *")] IMAGELISTSTAT* pils)
        {
            return ((delegate* unmanaged<IImageList2*, IMAGELISTSTAT*, int>)(lpVtbl[40]))((IImageList2*)Unsafe.AsPointer(ref this), pils);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize(int cx, int cy, [NativeTypeName("UINT")] uint flags, int cInitial, int cGrow)
        {
            return ((delegate* unmanaged<IImageList2*, int, int, uint, int, int, int>)(lpVtbl[41]))((IImageList2*)Unsafe.AsPointer(ref this), cx, cy, flags, cInitial, cGrow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int Replace2(int i, [NativeTypeName("HBITMAP")] IntPtr hbmImage, [NativeTypeName("HBITMAP")] IntPtr hbmMask, IUnknown* punk, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IImageList2*, int, IntPtr, IntPtr, IUnknown*, uint, int>)(lpVtbl[42]))((IImageList2*)Unsafe.AsPointer(ref this), i, hbmImage, hbmMask, punk, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int ReplaceFromImageList(int i, IImageList* pil, int iSrc, IUnknown* punk, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IImageList2*, int, IImageList*, int, IUnknown*, uint, int>)(lpVtbl[43]))((IImageList2*)Unsafe.AsPointer(ref this), i, pil, iSrc, punk, dwFlags);
        }
    }
}
