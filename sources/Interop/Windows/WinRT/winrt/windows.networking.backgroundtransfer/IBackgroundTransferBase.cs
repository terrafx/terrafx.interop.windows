// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTransferBase.xml' path='doc/member[@name="IBackgroundTransferBase"]/*' />
[Guid("2A9DA250-C769-458C-AFE8-FEB8D4D3B2EF")]
[NativeTypeName("struct IBackgroundTransferBase : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTransferBase : IBackgroundTransferBase.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTransferBase));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, uint>)(lpVtbl[1]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, uint>)(lpVtbl[2]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundTransferBase.xml' path='doc/member[@name="IBackgroundTransferBase.SetRequestHeader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetRequestHeader(HSTRING headerName, HSTRING headerValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, HSTRING, HSTRING, int>)(lpVtbl[6]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this), headerName, headerValue);
    }

    /// <include file='IBackgroundTransferBase.xml' path='doc/member[@name="IBackgroundTransferBase.get_ServerCredential"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ServerCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")] IPasswordCredential** credential)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, IPasswordCredential**, int>)(lpVtbl[7]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this), credential);
    }

    /// <include file='IBackgroundTransferBase.xml' path='doc/member[@name="IBackgroundTransferBase.put_ServerCredential"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ServerCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* credential)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, IPasswordCredential*, int>)(lpVtbl[8]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this), credential);
    }

    /// <include file='IBackgroundTransferBase.xml' path='doc/member[@name="IBackgroundTransferBase.get_ProxyCredential"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ProxyCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")] IPasswordCredential** credential)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, IPasswordCredential**, int>)(lpVtbl[9]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this), credential);
    }

    /// <include file='IBackgroundTransferBase.xml' path='doc/member[@name="IBackgroundTransferBase.put_ProxyCredential"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ProxyCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* credential)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, IPasswordCredential*, int>)(lpVtbl[10]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this), credential);
    }

    /// <include file='IBackgroundTransferBase.xml' path='doc/member[@name="IBackgroundTransferBase.get_Method"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Method(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, HSTRING*, int>)(lpVtbl[11]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferBase.xml' path='doc/member[@name="IBackgroundTransferBase.put_Method"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Method(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, HSTRING, int>)(lpVtbl[12]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferBase.xml' path='doc/member[@name="IBackgroundTransferBase.get_Group"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.")]
    public HRESULT get_Group(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, HSTRING*, int>)(lpVtbl[13]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferBase.xml' path='doc/member[@name="IBackgroundTransferBase.put_Group"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.")]
    public HRESULT put_Group(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, HSTRING, int>)(lpVtbl[14]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferBase.xml' path='doc/member[@name="IBackgroundTransferBase.get_CostPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_CostPolicy([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy *")] BackgroundTransferCostPolicy* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, BackgroundTransferCostPolicy*, int>)(lpVtbl[15]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferBase.xml' path='doc/member[@name="IBackgroundTransferBase.put_CostPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_CostPolicy([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy")] BackgroundTransferCostPolicy value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferBase*, BackgroundTransferCostPolicy, int>)(lpVtbl[16]))((IBackgroundTransferBase*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetRequestHeader(HSTRING headerName, HSTRING headerValue);

        [VtblIndex(7)]
        HRESULT get_ServerCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")] IPasswordCredential** credential);

        [VtblIndex(8)]
        HRESULT put_ServerCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* credential);

        [VtblIndex(9)]
        HRESULT get_ProxyCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")] IPasswordCredential** credential);

        [VtblIndex(10)]
        HRESULT put_ProxyCredential([NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")] IPasswordCredential* credential);

        [VtblIndex(11)]
        HRESULT get_Method(HSTRING* value);

        [VtblIndex(12)]
        HRESULT put_Method(HSTRING value);

        [VtblIndex(13)]
        [Obsolete("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.")]
        HRESULT get_Group(HSTRING* value);

        [VtblIndex(14)]
        [Obsolete("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.")]
        HRESULT put_Group(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_CostPolicy([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy *")] BackgroundTransferCostPolicy* value);

        [VtblIndex(16)]
        HRESULT put_CostPolicy([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy")] BackgroundTransferCostPolicy value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, int> SetRequestHeader;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPasswordCredential**, int> get_ServerCredential;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPasswordCredential*, int> put_ServerCredential;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPasswordCredential**, int> get_ProxyCredential;

        [NativeTypeName("HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPasswordCredential*, int> put_ProxyCredential;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Method;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Method;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Group;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Group;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BackgroundTransferCostPolicy*, int> get_CostPolicy;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BackgroundTransferCostPolicy, int> put_CostPolicy;
    }
}
