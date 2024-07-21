// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDialRequestedEventHandler.xml' path='doc/member[@name="IDialRequestedEventHandler"]/*' />
[Guid("5ABBFFDB-C21F-4BC4-891B-257E28C1B1A4")]
[NativeTypeName("struct IDialRequestedEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDialRequestedEventHandler : IDialRequestedEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDialRequestedEventHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDialRequestedEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDialRequestedEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDialRequestedEventHandler*, uint>)(lpVtbl[1]))((IDialRequestedEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDialRequestedEventHandler*, uint>)(lpVtbl[2]))((IDialRequestedEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDialRequestedEventHandler.xml' path='doc/member[@name="IDialRequestedEventHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Devices::ICallControl *")] ICallControl* sender, [NativeTypeName("ABI::Windows::Media::Devices::IDialRequestedEventArgs *")] IDialRequestedEventArgs* e)
    {
        return ((delegate* unmanaged[MemberFunction]<IDialRequestedEventHandler*, ICallControl*, IDialRequestedEventArgs*, int>)(lpVtbl[3]))((IDialRequestedEventHandler*)Unsafe.AsPointer(ref this), sender, e);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Media::Devices::ICallControl *")] ICallControl* sender, [NativeTypeName("ABI::Windows::Media::Devices::IDialRequestedEventArgs *")] IDialRequestedEventArgs* e);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::ICallControl *, ABI::Windows::Media::Devices::IDialRequestedEventArgs *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICallControl*, IDialRequestedEventArgs*, int> Invoke;
    }
}
