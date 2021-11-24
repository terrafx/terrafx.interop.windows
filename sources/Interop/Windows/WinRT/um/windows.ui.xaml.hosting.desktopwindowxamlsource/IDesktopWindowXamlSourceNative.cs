// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.hosting.desktopwindowxamlsource.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

[Guid("3CBCF1BF-2F76-4E9C-96AB-E84B37972554")]
[NativeTypeName("struct IDesktopWindowXamlSourceNative : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.18362.0")]
public unsafe partial struct IDesktopWindowXamlSourceNative : IDesktopWindowXamlSourceNative.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDesktopWindowXamlSourceNative*, Guid*, void**, int>)(lpVtbl[0]))((IDesktopWindowXamlSourceNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDesktopWindowXamlSourceNative*, uint>)(lpVtbl[1]))((IDesktopWindowXamlSourceNative*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDesktopWindowXamlSourceNative*, uint>)(lpVtbl[2]))((IDesktopWindowXamlSourceNative*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AttachToWindow(HWND parentWnd)
    {
        return ((delegate* unmanaged<IDesktopWindowXamlSourceNative*, HWND, int>)(lpVtbl[3]))((IDesktopWindowXamlSourceNative*)Unsafe.AsPointer(ref this), parentWnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_WindowHandle(HWND* hWnd)
    {
        return ((delegate* unmanaged<IDesktopWindowXamlSourceNative*, HWND*, int>)(lpVtbl[4]))((IDesktopWindowXamlSourceNative*)Unsafe.AsPointer(ref this), hWnd);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AttachToWindow(HWND parentWnd);

        [VtblIndex(4)]
        HRESULT get_WindowHandle(HWND* hWnd);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDesktopWindowXamlSourceNative*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDesktopWindowXamlSourceNative*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDesktopWindowXamlSourceNative*, uint> Release;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<IDesktopWindowXamlSourceNative*, HWND, int> AttachToWindow;

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDesktopWindowXamlSourceNative*, HWND*, int> get_WindowHandle;
    }
}
