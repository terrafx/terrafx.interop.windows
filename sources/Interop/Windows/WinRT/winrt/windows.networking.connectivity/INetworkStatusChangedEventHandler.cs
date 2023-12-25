// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='INetworkStatusChangedEventHandler.xml' path='doc/member[@name="INetworkStatusChangedEventHandler"]/*' />
[Guid("71BA143F-598E-49D0-84EB-8FEBAEDCC195")]
[NativeTypeName("struct INetworkStatusChangedEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INetworkStatusChangedEventHandler : INetworkStatusChangedEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INetworkStatusChangedEventHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStatusChangedEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((INetworkStatusChangedEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStatusChangedEventHandler*, uint>)(lpVtbl[1]))((INetworkStatusChangedEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStatusChangedEventHandler*, uint>)(lpVtbl[2]))((INetworkStatusChangedEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='INetworkStatusChangedEventHandler.xml' path='doc/member[@name="INetworkStatusChangedEventHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke(IInspectable* sender)
    {
        return ((delegate* unmanaged[MemberFunction]<INetworkStatusChangedEventHandler*, IInspectable*, int>)(lpVtbl[3]))((INetworkStatusChangedEventHandler*)Unsafe.AsPointer(ref this), sender);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke(IInspectable* sender);
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

        [NativeTypeName("HRESULT (IInspectable *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable*, int> Invoke;
    }
}
