// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IVirtualDesktopManager.xml' path='doc/member[@name="IVirtualDesktopManager"]/*' />
[Guid("A5CD92FF-29BE-454C-8D04-D82879FB3F1B")]
[NativeTypeName("struct IVirtualDesktopManager : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IVirtualDesktopManager : IVirtualDesktopManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVirtualDesktopManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualDesktopManager*, Guid*, void**, int>)(lpVtbl[0]))((IVirtualDesktopManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualDesktopManager*, uint>)(lpVtbl[1]))((IVirtualDesktopManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualDesktopManager*, uint>)(lpVtbl[2]))((IVirtualDesktopManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVirtualDesktopManager.xml' path='doc/member[@name="IVirtualDesktopManager.IsWindowOnCurrentVirtualDesktop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsWindowOnCurrentVirtualDesktop(HWND topLevelWindow, BOOL* onCurrentDesktop)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualDesktopManager*, HWND, BOOL*, int>)(lpVtbl[3]))((IVirtualDesktopManager*)Unsafe.AsPointer(ref this), topLevelWindow, onCurrentDesktop);
    }

    /// <include file='IVirtualDesktopManager.xml' path='doc/member[@name="IVirtualDesktopManager.GetWindowDesktopId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetWindowDesktopId(HWND topLevelWindow, Guid* desktopId)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualDesktopManager*, HWND, Guid*, int>)(lpVtbl[4]))((IVirtualDesktopManager*)Unsafe.AsPointer(ref this), topLevelWindow, desktopId);
    }

    /// <include file='IVirtualDesktopManager.xml' path='doc/member[@name="IVirtualDesktopManager.MoveWindowToDesktop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveWindowToDesktop(HWND topLevelWindow, [NativeTypeName("const GUID &")] Guid* desktopId)
    {
        return ((delegate* unmanaged[MemberFunction]<IVirtualDesktopManager*, HWND, Guid*, int>)(lpVtbl[5]))((IVirtualDesktopManager*)Unsafe.AsPointer(ref this), topLevelWindow, desktopId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsWindowOnCurrentVirtualDesktop(HWND topLevelWindow, BOOL* onCurrentDesktop);

        [VtblIndex(4)]
        HRESULT GetWindowDesktopId(HWND topLevelWindow, Guid* desktopId);

        [VtblIndex(5)]
        HRESULT MoveWindowToDesktop(HWND topLevelWindow, [NativeTypeName("const GUID &")] Guid* desktopId);
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

        [NativeTypeName("HRESULT (HWND, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, BOOL*, int> IsWindowOnCurrentVirtualDesktop;

        [NativeTypeName("HRESULT (HWND, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, Guid*, int> GetWindowDesktopId;

        [NativeTypeName("HRESULT (HWND, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, Guid*, int> MoveWindowToDesktop;
    }
}
