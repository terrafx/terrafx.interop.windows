// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITransportParametersUpdateHandler.xml' path='doc/member[@name="ITransportParametersUpdateHandler"]/*' />
[Guid("16FD02D5-DA61-49D7-AAB2-76867DD42DB7")]
[NativeTypeName("struct ITransportParametersUpdateHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITransportParametersUpdateHandler : ITransportParametersUpdateHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITransportParametersUpdateHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransportParametersUpdateHandler*, Guid*, void**, int>)(lpVtbl[0]))((ITransportParametersUpdateHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransportParametersUpdateHandler*, uint>)(lpVtbl[1]))((ITransportParametersUpdateHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITransportParametersUpdateHandler*, uint>)(lpVtbl[2]))((ITransportParametersUpdateHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITransportParametersUpdateHandler.xml' path='doc/member[@name="ITransportParametersUpdateHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Streaming::IMediaRenderer *")] IMediaRenderer* sender, [NativeTypeName("ABI::Windows::Media::Streaming::ITransportParameters *")] ITransportParameters* arg)
    {
        return ((delegate* unmanaged[MemberFunction]<ITransportParametersUpdateHandler*, IMediaRenderer*, ITransportParameters*, int>)(lpVtbl[3]))((ITransportParametersUpdateHandler*)Unsafe.AsPointer(ref this), sender, arg);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Streaming::IMediaRenderer *")] IMediaRenderer* sender, [NativeTypeName("ABI::Windows::Media::Streaming::ITransportParameters *")] ITransportParameters* arg);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::IMediaRenderer *, ABI::Windows::Media::Streaming::ITransportParameters *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaRenderer*, ITransportParameters*, int> Invoke;
    }
}
