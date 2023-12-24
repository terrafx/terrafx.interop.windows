// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper"]/*' />
[Guid("B92B56A9-8B55-4E14-9A89-0199BBB6F93B")]
[NativeTypeName("struct IDesktopWallpaper : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDesktopWallpaper : IDesktopWallpaper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDesktopWallpaper));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, Guid*, void**, int>)(lpVtbl[0]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, uint>)(lpVtbl[1]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, uint>)(lpVtbl[2]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.SetWallpaper"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetWallpaper([NativeTypeName("LPCWSTR")] char* monitorID, [NativeTypeName("LPCWSTR")] char* wallpaper)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, char*, char*, int>)(lpVtbl[3]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), monitorID, wallpaper);
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.GetWallpaper"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetWallpaper([NativeTypeName("LPCWSTR")] char* monitorID, [NativeTypeName("LPWSTR *")] char** wallpaper)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, char*, char**, int>)(lpVtbl[4]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), monitorID, wallpaper);
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.GetMonitorDevicePathAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMonitorDevicePathAt(uint monitorIndex, [NativeTypeName("LPWSTR *")] char** monitorID)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, uint, char**, int>)(lpVtbl[5]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), monitorIndex, monitorID);
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.GetMonitorDevicePathCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMonitorDevicePathCount(uint* count)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, uint*, int>)(lpVtbl[6]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), count);
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.GetMonitorRECT"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMonitorRECT([NativeTypeName("LPCWSTR")] char* monitorID, RECT* displayRect)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, char*, RECT*, int>)(lpVtbl[7]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), monitorID, displayRect);
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.SetBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetBackgroundColor(COLORREF color)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, COLORREF, int>)(lpVtbl[8]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), color);
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.GetBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetBackgroundColor(COLORREF* color)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, COLORREF*, int>)(lpVtbl[9]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), color);
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.SetPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPosition(DESKTOP_WALLPAPER_POSITION position)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, DESKTOP_WALLPAPER_POSITION, int>)(lpVtbl[10]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), position);
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.GetPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetPosition(DESKTOP_WALLPAPER_POSITION* position)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, DESKTOP_WALLPAPER_POSITION*, int>)(lpVtbl[11]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), position);
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.SetSlideshow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetSlideshow(IShellItemArray* items)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, IShellItemArray*, int>)(lpVtbl[12]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), items);
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.GetSlideshow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetSlideshow(IShellItemArray** items)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, IShellItemArray**, int>)(lpVtbl[13]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), items);
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.SetSlideshowOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetSlideshowOptions(DESKTOP_SLIDESHOW_OPTIONS options, uint slideshowTick)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, DESKTOP_SLIDESHOW_OPTIONS, uint, int>)(lpVtbl[14]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), options, slideshowTick);
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.GetSlideshowOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetSlideshowOptions(DESKTOP_SLIDESHOW_OPTIONS* options, uint* slideshowTick)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, DESKTOP_SLIDESHOW_OPTIONS*, uint*, int>)(lpVtbl[15]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), options, slideshowTick);
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.AdvanceSlideshow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AdvanceSlideshow([NativeTypeName("LPCWSTR")] char* monitorID, DESKTOP_SLIDESHOW_DIRECTION direction)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, char*, DESKTOP_SLIDESHOW_DIRECTION, int>)(lpVtbl[16]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), monitorID, direction);
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.GetStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetStatus(DESKTOP_SLIDESHOW_STATE* state)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, DESKTOP_SLIDESHOW_STATE*, int>)(lpVtbl[17]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), state);
    }

    /// <include file='IDesktopWallpaper.xml' path='doc/member[@name="IDesktopWallpaper.Enable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT Enable(BOOL enable)
    {
        return ((delegate* unmanaged[MemberFunction]<IDesktopWallpaper*, BOOL, int>)(lpVtbl[18]))((IDesktopWallpaper*)Unsafe.AsPointer(ref this), enable);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetWallpaper([NativeTypeName("LPCWSTR")] char* monitorID, [NativeTypeName("LPCWSTR")] char* wallpaper);

        [VtblIndex(4)]
        HRESULT GetWallpaper([NativeTypeName("LPCWSTR")] char* monitorID, [NativeTypeName("LPWSTR *")] char** wallpaper);

        [VtblIndex(5)]
        HRESULT GetMonitorDevicePathAt(uint monitorIndex, [NativeTypeName("LPWSTR *")] char** monitorID);

        [VtblIndex(6)]
        HRESULT GetMonitorDevicePathCount(uint* count);

        [VtblIndex(7)]
        HRESULT GetMonitorRECT([NativeTypeName("LPCWSTR")] char* monitorID, RECT* displayRect);

        [VtblIndex(8)]
        HRESULT SetBackgroundColor(COLORREF color);

        [VtblIndex(9)]
        HRESULT GetBackgroundColor(COLORREF* color);

        [VtblIndex(10)]
        HRESULT SetPosition(DESKTOP_WALLPAPER_POSITION position);

        [VtblIndex(11)]
        HRESULT GetPosition(DESKTOP_WALLPAPER_POSITION* position);

        [VtblIndex(12)]
        HRESULT SetSlideshow(IShellItemArray* items);

        [VtblIndex(13)]
        HRESULT GetSlideshow(IShellItemArray** items);

        [VtblIndex(14)]
        HRESULT SetSlideshowOptions(DESKTOP_SLIDESHOW_OPTIONS options, uint slideshowTick);

        [VtblIndex(15)]
        HRESULT GetSlideshowOptions(DESKTOP_SLIDESHOW_OPTIONS* options, uint* slideshowTick);

        [VtblIndex(16)]
        HRESULT AdvanceSlideshow([NativeTypeName("LPCWSTR")] char* monitorID, DESKTOP_SLIDESHOW_DIRECTION direction);

        [VtblIndex(17)]
        HRESULT GetStatus(DESKTOP_SLIDESHOW_STATE* state);

        [VtblIndex(18)]
        HRESULT Enable(BOOL enable);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, int> SetWallpaper;

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, int> GetWallpaper;

        [NativeTypeName("HRESULT (UINT, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char**, int> GetMonitorDevicePathAt;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetMonitorDevicePathCount;

        [NativeTypeName("HRESULT (LPCWSTR, RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, RECT*, int> GetMonitorRECT;

        [NativeTypeName("HRESULT (COLORREF) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, COLORREF, int> SetBackgroundColor;

        [NativeTypeName("HRESULT (COLORREF *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, COLORREF*, int> GetBackgroundColor;

        [NativeTypeName("HRESULT (DESKTOP_WALLPAPER_POSITION) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DESKTOP_WALLPAPER_POSITION, int> SetPosition;

        [NativeTypeName("HRESULT (DESKTOP_WALLPAPER_POSITION *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DESKTOP_WALLPAPER_POSITION*, int> GetPosition;

        [NativeTypeName("HRESULT (IShellItemArray *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItemArray*, int> SetSlideshow;

        [NativeTypeName("HRESULT (IShellItemArray **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItemArray**, int> GetSlideshow;

        [NativeTypeName("HRESULT (DESKTOP_SLIDESHOW_OPTIONS, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DESKTOP_SLIDESHOW_OPTIONS, uint, int> SetSlideshowOptions;

        [NativeTypeName("HRESULT (DESKTOP_SLIDESHOW_OPTIONS *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DESKTOP_SLIDESHOW_OPTIONS*, uint*, int> GetSlideshowOptions;

        [NativeTypeName("HRESULT (LPCWSTR, DESKTOP_SLIDESHOW_DIRECTION) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, DESKTOP_SLIDESHOW_DIRECTION, int> AdvanceSlideshow;

        [NativeTypeName("HRESULT (DESKTOP_SLIDESHOW_STATE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DESKTOP_SLIDESHOW_STATE*, int> GetStatus;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, int> Enable;
    }
}
