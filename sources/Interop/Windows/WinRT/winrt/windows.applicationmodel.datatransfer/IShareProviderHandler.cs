// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IShareProviderHandler.xml' path='doc/member[@name="IShareProviderHandler"]/*' />
[Guid("E7F9D9BA-E1BA-4E4D-BD65-D43845D3212F")]
[NativeTypeName("struct IShareProviderHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShareProviderHandler : IShareProviderHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IShareProviderHandler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProviderHandler*, Guid*, void**, int>)(lpVtbl[0]))((IShareProviderHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProviderHandler*, uint>)(lpVtbl[1]))((IShareProviderHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProviderHandler*, uint>)(lpVtbl[2]))((IShareProviderHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShareProviderHandler.xml' path='doc/member[@name="IShareProviderHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IShareProviderOperation *")] IShareProviderOperation* operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IShareProviderHandler*, IShareProviderOperation*, int>)(lpVtbl[3]))((IShareProviderHandler*)Unsafe.AsPointer(ref this), operation);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IShareProviderOperation *")] IShareProviderOperation* operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IShareProviderOperation *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShareProviderOperation*, int> Invoke;
    }
}
