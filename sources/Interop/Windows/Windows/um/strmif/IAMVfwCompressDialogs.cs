// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("D8D715A3-6E5E-11D0-B3F0-00AA003761C5")]
[NativeTypeName("struct IAMVfwCompressDialogs : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMVfwCompressDialogs : IAMVfwCompressDialogs.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMVfwCompressDialogs*, Guid*, void**, int>)(lpVtbl[0]))((IAMVfwCompressDialogs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMVfwCompressDialogs*, uint>)(lpVtbl[1]))((IAMVfwCompressDialogs*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMVfwCompressDialogs*, uint>)(lpVtbl[2]))((IAMVfwCompressDialogs*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ShowDialog(int iDialog, HWND hwnd)
    {
        return ((delegate* unmanaged<IAMVfwCompressDialogs*, int, HWND, int>)(lpVtbl[3]))((IAMVfwCompressDialogs*)Unsafe.AsPointer(ref this), iDialog, hwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetState([NativeTypeName("LPVOID")] void* pState, int* pcbState)
    {
        return ((delegate* unmanaged<IAMVfwCompressDialogs*, void*, int*, int>)(lpVtbl[4]))((IAMVfwCompressDialogs*)Unsafe.AsPointer(ref this), pState, pcbState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetState([NativeTypeName("LPVOID")] void* pState, int cbState)
    {
        return ((delegate* unmanaged<IAMVfwCompressDialogs*, void*, int, int>)(lpVtbl[5]))((IAMVfwCompressDialogs*)Unsafe.AsPointer(ref this), pState, cbState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SendDriverMessage(int uMsg, [NativeTypeName("long")] int dw1, [NativeTypeName("long")] int dw2)
    {
        return ((delegate* unmanaged<IAMVfwCompressDialogs*, int, int, int, int>)(lpVtbl[6]))((IAMVfwCompressDialogs*)Unsafe.AsPointer(ref this), uMsg, dw1, dw2);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ShowDialog(int iDialog, HWND hwnd);

        [VtblIndex(4)]
        HRESULT GetState([NativeTypeName("LPVOID")] void* pState, int* pcbState);

        [VtblIndex(5)]
        HRESULT SetState([NativeTypeName("LPVOID")] void* pState, int cbState);

        [VtblIndex(6)]
        HRESULT SendDriverMessage(int uMsg, [NativeTypeName("long")] int dw1, [NativeTypeName("long")] int dw2);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAMVfwCompressDialogs*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAMVfwCompressDialogs*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAMVfwCompressDialogs*, uint> Release;

        [NativeTypeName("HRESULT (int, HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<IAMVfwCompressDialogs*, int, HWND, int> ShowDialog;

        [NativeTypeName("HRESULT (LPVOID, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAMVfwCompressDialogs*, void*, int*, int> GetState;

        [NativeTypeName("HRESULT (LPVOID, int) __attribute__((stdcall))")]
        public delegate* unmanaged<IAMVfwCompressDialogs*, void*, int, int> SetState;

        [NativeTypeName("HRESULT (int, long, long) __attribute__((stdcall))")]
        public delegate* unmanaged<IAMVfwCompressDialogs*, int, int, int, int> SendDriverMessage;
    }
}
