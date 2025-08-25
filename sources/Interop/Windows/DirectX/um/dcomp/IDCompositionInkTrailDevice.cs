// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDCompositionInkTrailDevice.xml' path='doc/member[@name="IDCompositionInkTrailDevice"]/*' />
[Guid("DF0C7CEC-CDEB-4D4A-B91C-721BF22F4E6C")]
[NativeTypeName("struct IDCompositionInkTrailDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDCompositionInkTrailDevice : IDCompositionInkTrailDevice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDCompositionInkTrailDevice);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionInkTrailDevice*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionInkTrailDevice*, uint>)(lpVtbl[1]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionInkTrailDevice*, uint>)(lpVtbl[2]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionInkTrailDevice.xml' path='doc/member[@name="IDCompositionInkTrailDevice.CreateDelegatedInkTrail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateDelegatedInkTrail(IDCompositionDelegatedInkTrail** inkTrail)
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionInkTrailDevice*, IDCompositionDelegatedInkTrail**, int>)(lpVtbl[3]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this), inkTrail);
    }

    /// <include file='IDCompositionInkTrailDevice.xml' path='doc/member[@name="IDCompositionInkTrailDevice.CreateDelegatedInkTrailForSwapChain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateDelegatedInkTrailForSwapChain(IUnknown* swapChain, IDCompositionDelegatedInkTrail** inkTrail)
    {
        return ((delegate* unmanaged[MemberFunction]<IDCompositionInkTrailDevice*, IUnknown*, IDCompositionDelegatedInkTrail**, int>)(lpVtbl[4]))((IDCompositionInkTrailDevice*)Unsafe.AsPointer(ref this), swapChain, inkTrail);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateDelegatedInkTrail(IDCompositionDelegatedInkTrail** inkTrail);

        [VtblIndex(4)]
        HRESULT CreateDelegatedInkTrailForSwapChain(IUnknown* swapChain, IDCompositionDelegatedInkTrail** inkTrail);
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

        [NativeTypeName("HRESULT (IDCompositionDelegatedInkTrail **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDCompositionDelegatedInkTrail**, int> CreateDelegatedInkTrail;

        [NativeTypeName("HRESULT (IUnknown *, IDCompositionDelegatedInkTrail **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, IDCompositionDelegatedInkTrail**, int> CreateDelegatedInkTrailForSwapChain;
    }
}
