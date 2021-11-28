// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("604D33D7-CF23-41D5-8224-5BBBB1A87475")]
[NativeTypeName("struct IMFVideoRendererEffectControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFVideoRendererEffectControl : IMFVideoRendererEffectControl.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFVideoRendererEffectControl*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoRendererEffectControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFVideoRendererEffectControl*, uint>)(lpVtbl[1]))((IMFVideoRendererEffectControl*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFVideoRendererEffectControl*, uint>)(lpVtbl[2]))((IMFVideoRendererEffectControl*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnAppServiceConnectionEstablished(IUnknown* pAppServiceConnection)
    {
        return ((delegate* unmanaged<IMFVideoRendererEffectControl*, IUnknown*, int>)(lpVtbl[3]))((IMFVideoRendererEffectControl*)Unsafe.AsPointer(ref this), pAppServiceConnection);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnAppServiceConnectionEstablished(IUnknown* pAppServiceConnection);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> OnAppServiceConnectionEstablished;
    }
}
