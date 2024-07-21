// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTransferOperation.xml' path='doc/member[@name="IBackgroundTransferOperation"]/*' />
[Guid("DED06846-90CA-44FB-8FB1-124154C0D539")]
[NativeTypeName("struct IBackgroundTransferOperation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTransferOperation : IBackgroundTransferOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTransferOperation));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperation*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTransferOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperation*, uint>)(lpVtbl[1]))((IBackgroundTransferOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperation*, uint>)(lpVtbl[2]))((IBackgroundTransferOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperation*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundTransferOperation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperation*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundTransferOperation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperation*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundTransferOperation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundTransferOperation.xml' path='doc/member[@name="IBackgroundTransferOperation.get_Guid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Guid(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperation*, Guid*, int>)(lpVtbl[6]))((IBackgroundTransferOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferOperation.xml' path='doc/member[@name="IBackgroundTransferOperation.get_RequestedUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RequestedUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperation*, IUriRuntimeClass**, int>)(lpVtbl[7]))((IBackgroundTransferOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferOperation.xml' path='doc/member[@name="IBackgroundTransferOperation.get_Method"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Method(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperation*, HSTRING*, int>)(lpVtbl[8]))((IBackgroundTransferOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferOperation.xml' path='doc/member[@name="IBackgroundTransferOperation.get_Group"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.")]
    public HRESULT get_Group(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperation*, HSTRING*, int>)(lpVtbl[9]))((IBackgroundTransferOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferOperation.xml' path='doc/member[@name="IBackgroundTransferOperation.get_CostPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CostPolicy([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy *")] BackgroundTransferCostPolicy* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperation*, BackgroundTransferCostPolicy*, int>)(lpVtbl[10]))((IBackgroundTransferOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferOperation.xml' path='doc/member[@name="IBackgroundTransferOperation.put_CostPolicy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CostPolicy([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy")] BackgroundTransferCostPolicy value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperation*, BackgroundTransferCostPolicy, int>)(lpVtbl[11]))((IBackgroundTransferOperation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferOperation.xml' path='doc/member[@name="IBackgroundTransferOperation.GetResultStreamAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetResultStreamAt([NativeTypeName("UINT64")] ulong position, [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperation*, ulong, IInputStream**, int>)(lpVtbl[12]))((IBackgroundTransferOperation*)Unsafe.AsPointer(ref this), position, value);
    }

    /// <include file='IBackgroundTransferOperation.xml' path='doc/member[@name="IBackgroundTransferOperation.GetResponseInformation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetResponseInformation([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IResponseInformation **")] IResponseInformation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperation*, IResponseInformation**, int>)(lpVtbl[13]))((IBackgroundTransferOperation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Guid(Guid* value);

        [VtblIndex(7)]
        HRESULT get_RequestedUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(8)]
        HRESULT get_Method(HSTRING* value);

        [VtblIndex(9)]
        [Obsolete("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.")]
        HRESULT get_Group(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_CostPolicy([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy *")] BackgroundTransferCostPolicy* value);

        [VtblIndex(11)]
        HRESULT put_CostPolicy([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy")] BackgroundTransferCostPolicy value);

        [VtblIndex(12)]
        HRESULT GetResultStreamAt([NativeTypeName("UINT64")] ulong position, [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** value);

        [VtblIndex(13)]
        HRESULT GetResponseInformation([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::IResponseInformation **")] IResponseInformation** value);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_Guid;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_RequestedUri;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Method;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Group;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BackgroundTransferCostPolicy*, int> get_CostPolicy;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferCostPolicy) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BackgroundTransferCostPolicy, int> put_CostPolicy;

        [NativeTypeName("HRESULT (UINT64, ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, IInputStream**, int> GetResultStreamAt;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::IResponseInformation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IResponseInformation**, int> GetResponseInformation;
    }
}
