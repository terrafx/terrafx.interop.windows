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
    public unsafe partial struct IDesktopWallpaper
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, Guid*, void**, int>)(lpVtbl[0]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, uint>)(lpVtbl[1]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, uint>)(lpVtbl[2]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWallpaper([NativeTypeName("LPCWSTR")] ushort* monitorID, [NativeTypeName("LPCWSTR")] ushort* wallpaper)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, ushort*, ushort*, int>)(lpVtbl[3]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), monitorID, wallpaper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWallpaper([NativeTypeName("LPCWSTR")] ushort* monitorID, [NativeTypeName("LPWSTR *")] ushort** wallpaper)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, ushort*, ushort**, int>)(lpVtbl[4]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), monitorID, wallpaper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMonitorDevicePathAt([NativeTypeName("UINT")] uint monitorIndex, [NativeTypeName("LPWSTR *")] ushort** monitorID)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, uint, ushort**, int>)(lpVtbl[5]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), monitorIndex, monitorID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMonitorDevicePathCount([NativeTypeName("UINT *")] uint* count)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, uint*, int>)(lpVtbl[6]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMonitorRECT([NativeTypeName("LPCWSTR")] ushort* monitorID, RECT* displayRect)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, ushort*, RECT*, int>)(lpVtbl[7]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), monitorID, displayRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBackgroundColor([NativeTypeName("COLORREF")] uint color)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, uint, int>)(lpVtbl[8]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBackgroundColor([NativeTypeName("COLORREF *")] uint* color)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, uint*, int>)(lpVtbl[9]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPosition(DESKTOP_WALLPAPER_POSITION position)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, DESKTOP_WALLPAPER_POSITION, int>)(lpVtbl[10]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPosition(DESKTOP_WALLPAPER_POSITION* position)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, DESKTOP_WALLPAPER_POSITION*, int>)(lpVtbl[11]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSlideshow(IShellItemArray* items)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, IShellItemArray*, int>)(lpVtbl[12]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), items);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSlideshow(IShellItemArray** items)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, IShellItemArray**, int>)(lpVtbl[13]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), items);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSlideshowOptions(DESKTOP_SLIDESHOW_OPTIONS options, [NativeTypeName("UINT")] uint slideshowTick)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, DESKTOP_SLIDESHOW_OPTIONS, uint, int>)(lpVtbl[14]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), options, slideshowTick);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSlideshowOptions(DESKTOP_SLIDESHOW_OPTIONS* options, [NativeTypeName("UINT *")] uint* slideshowTick)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, DESKTOP_SLIDESHOW_OPTIONS*, uint*, int>)(lpVtbl[15]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), options, slideshowTick);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdvanceSlideshow([NativeTypeName("LPCWSTR")] ushort* monitorID, DESKTOP_SLIDESHOW_DIRECTION direction)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, ushort*, DESKTOP_SLIDESHOW_DIRECTION, int>)(lpVtbl[16]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), monitorID, direction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus(DESKTOP_SLIDESHOW_STATE* state)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, DESKTOP_SLIDESHOW_STATE*, int>)(lpVtbl[17]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), state);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Enable([NativeTypeName("BOOL")] int enable)
        {
            return ((delegate* unmanaged<IDesktopWallpaper*, int, int>)(lpVtbl[18]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), enable);
        }
    }
}
