// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFMediaEngineVideoRendererEffect.xml' path='doc/member[@name="IMFMediaEngineVideoRendererEffect"]/*' />
[Guid("6BDF1188-6EC8-44FF-8CCC-BFCA0D12AFA3")]
[NativeTypeName("struct IMFMediaEngineVideoRendererEffect : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaEngineVideoRendererEffect : IMFMediaEngineVideoRendererEffect.Interface, INativeGuid
{
    /// <include file='IMFMediaEngineVideoRendererEffect.xml' path='doc/member[@name="IMFMediaEngineVideoRendererEffect.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMFMediaEngineVideoRendererEffect);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaEngineVideoRendererEffect*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineVideoRendererEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaEngineVideoRendererEffect*, uint>)(lpVtbl[1]))((IMFMediaEngineVideoRendererEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaEngineVideoRendererEffect*, uint>)(lpVtbl[2]))((IMFMediaEngineVideoRendererEffect*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngineVideoRendererEffect.xml' path='doc/member[@name="IMFMediaEngineVideoRendererEffect.SetEffect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetEffect(IUnknown* pEffect)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaEngineVideoRendererEffect*, IUnknown*, int>)(lpVtbl[3]))((IMFMediaEngineVideoRendererEffect*)Unsafe.AsPointer(ref this), pEffect);
    }

    /// <include file='IMFMediaEngineVideoRendererEffect.xml' path='doc/member[@name="IMFMediaEngineVideoRendererEffect.ClearEffect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ClearEffect()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFMediaEngineVideoRendererEffect*, int>)(lpVtbl[4]))((IMFMediaEngineVideoRendererEffect*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetEffect(IUnknown* pEffect);

        [VtblIndex(4)]
        HRESULT ClearEffect();
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

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, int> SetEffect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ClearEffect;
    }
}
