// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IConnectionStatusHandler.xml' path='doc/member[@name="IConnectionStatusHandler"]/*' />
[Guid("B571C28C-A472-48D5-88D2-8ADCAF1B8813")]
[NativeTypeName("struct IConnectionStatusHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IConnectionStatusHandler : IConnectionStatusHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IConnectionStatusHandler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionStatusHandler*, Guid*, void**, int>)(lpVtbl[0]))((IConnectionStatusHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionStatusHandler*, uint>)(lpVtbl[1]))((IConnectionStatusHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionStatusHandler*, uint>)(lpVtbl[2]))((IConnectionStatusHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IConnectionStatusHandler.xml' path='doc/member[@name="IConnectionStatusHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice* sender, [NativeTypeName("ABI::Windows::Media::Streaming::ConnectionStatus")] ConnectionStatus arg)
    {
        return ((delegate* unmanaged[MemberFunction]<IConnectionStatusHandler*, IBasicDevice*, ConnectionStatus, int>)(lpVtbl[3]))((IConnectionStatusHandler*)Unsafe.AsPointer(ref this), sender, arg);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice* sender, [NativeTypeName("ABI::Windows::Media::Streaming::ConnectionStatus")] ConnectionStatus arg);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Streaming::IBasicDevice *, ABI::Windows::Media::Streaming::ConnectionStatus) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBasicDevice*, ConnectionStatus, int> Invoke;
    }
}
