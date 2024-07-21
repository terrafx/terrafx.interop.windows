// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDataProviderHandler.xml' path='doc/member[@name="IDataProviderHandler"]/*' />
[Guid("E7ECD720-F2F4-4A2D-920E-170A2F482A27")]
[NativeTypeName("struct IDataProviderHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDataProviderHandler : IDataProviderHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataProviderHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProviderHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDataProviderHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProviderHandler*, uint>)(lpVtbl[1]))((IDataProviderHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProviderHandler*, uint>)(lpVtbl[2]))((IDataProviderHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDataProviderHandler.xml' path='doc/member[@name="IDataProviderHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataProviderRequest *")] IDataProviderRequest* request)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataProviderHandler*, IDataProviderRequest*, int>)(lpVtbl[3]))((IDataProviderHandler*)Unsafe.AsPointer(ref this), request);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataProviderRequest *")] IDataProviderRequest* request);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataProviderRequest *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDataProviderRequest*, int> Invoke;
    }
}
