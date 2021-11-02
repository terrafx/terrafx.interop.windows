// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B92B56A9-8B55-4E14-9A89-0199BBB6F93B")]
    [NativeTypeName("struct IDesktopWallpaper : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDesktopWallpaper
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, Guid*, void**, int>)(lpVtbl[0]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, uint>)(lpVtbl[1]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, uint>)(lpVtbl[2]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetWallpaper([NativeTypeName("LPCWSTR")] ushort* monitorID, [NativeTypeName("LPCWSTR")] ushort* wallpaper)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, ushort*, ushort*, int>)(lpVtbl[3]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), monitorID, wallpaper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetWallpaper([NativeTypeName("LPCWSTR")] ushort* monitorID, [NativeTypeName("LPWSTR *")] ushort** wallpaper)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, ushort*, ushort**, int>)(lpVtbl[4]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), monitorID, wallpaper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetMonitorDevicePathAt(uint monitorIndex, [NativeTypeName("LPWSTR *")] ushort** monitorID)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, uint, ushort**, int>)(lpVtbl[5]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), monitorIndex, monitorID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetMonitorDevicePathCount(uint* count)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, uint*, int>)(lpVtbl[6]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetMonitorRECT([NativeTypeName("LPCWSTR")] ushort* monitorID, RECT* displayRect)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, ushort*, RECT*, int>)(lpVtbl[7]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), monitorID, displayRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetBackgroundColor(COLORREF color)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, COLORREF, int>)(lpVtbl[8]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetBackgroundColor(COLORREF* color)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, COLORREF*, int>)(lpVtbl[9]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetPosition(DESKTOP_WALLPAPER_POSITION position)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, DESKTOP_WALLPAPER_POSITION, int>)(lpVtbl[10]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetPosition(DESKTOP_WALLPAPER_POSITION* position)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, DESKTOP_WALLPAPER_POSITION*, int>)(lpVtbl[11]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetSlideshow(IShellItemArray* items)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, IShellItemArray*, int>)(lpVtbl[12]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), items);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetSlideshow(IShellItemArray** items)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, IShellItemArray**, int>)(lpVtbl[13]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), items);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetSlideshowOptions(DESKTOP_SLIDESHOW_OPTIONS options, uint slideshowTick)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, DESKTOP_SLIDESHOW_OPTIONS, uint, int>)(lpVtbl[14]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), options, slideshowTick);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetSlideshowOptions(DESKTOP_SLIDESHOW_OPTIONS* options, uint* slideshowTick)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, DESKTOP_SLIDESHOW_OPTIONS*, uint*, int>)(lpVtbl[15]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), options, slideshowTick);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT AdvanceSlideshow([NativeTypeName("LPCWSTR")] ushort* monitorID, DESKTOP_SLIDESHOW_DIRECTION direction)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, ushort*, DESKTOP_SLIDESHOW_DIRECTION, int>)(lpVtbl[16]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), monitorID, direction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetStatus(DESKTOP_SLIDESHOW_STATE* state)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, DESKTOP_SLIDESHOW_STATE*, int>)(lpVtbl[17]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), state);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT Enable(BOOL enable)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, BOOL, int>)(lpVtbl[18]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), enable);
        }
    }
}
