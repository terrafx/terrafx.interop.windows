// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("6B7D8D73-B267-4F69-B32E-1CA321CE4F45")]
[NativeTypeName("struct ITfStatusSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfStatusSink : ITfStatusSink.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfStatusSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfStatusSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfStatusSink*, uint>)(lpVtbl[1]))((ITfStatusSink*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfStatusSink*, uint>)(lpVtbl[2]))((ITfStatusSink*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnStatusChange(ITfContext* pic, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITfStatusSink*, ITfContext*, uint, int>)(lpVtbl[3]))((ITfStatusSink*)Unsafe.AsPointer(ref this), pic, dwFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnStatusChange(ITfContext* pic, [NativeTypeName("DWORD")] uint dwFlags);
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

        [NativeTypeName("HRESULT (ITfContext *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext*, uint, int> OnStatusChange;
    }
}
