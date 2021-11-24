// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PrintManagerInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

[Guid("C5435A42-8D43-4E7B-A68A-EF311E392087")]
[NativeTypeName("struct IPrintManagerInterop : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows8.0")]
public unsafe partial struct IPrintManagerInterop : IPrintManagerInterop.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrintManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintManagerInterop*, uint>)(lpVtbl[1]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintManagerInterop*, uint>)(lpVtbl[2]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IPrintManagerInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPrintManagerInterop*, HSTRING*, int>)(lpVtbl[4]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this), className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPrintManagerInterop*, TrustLevel*, int>)(lpVtbl[5]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForWindow(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** printManager)
    {
        return ((delegate* unmanaged<IPrintManagerInterop*, HWND, Guid*, void**, int>)(lpVtbl[6]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, printManager);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ShowPrintUIForWindowAsync(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
    {
        return ((delegate* unmanaged<IPrintManagerInterop*, HWND, Guid*, void**, int>)(lpVtbl[7]))((IPrintManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, asyncOperation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForWindow(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** printManager);

        [VtblIndex(7)]
        HRESULT ShowPrintUIForWindowAsync(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintManagerInterop*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintManagerInterop*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintManagerInterop*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintManagerInterop*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintManagerInterop*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintManagerInterop*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintManagerInterop*, HWND, Guid*, void**, int> GetForWindow;

        [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintManagerInterop*, HWND, Guid*, void**, int> ShowPrintUIForWindowAsync;
    }
}
