// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTransferOperationPriority.xml' path='doc/member[@name="IBackgroundTransferOperationPriority"]/*' />
[Guid("04854327-5254-4B3A-915E-0AA49275C0F9")]
[NativeTypeName("struct IBackgroundTransferOperationPriority : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTransferOperationPriority : IBackgroundTransferOperationPriority.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBackgroundTransferOperationPriority);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperationPriority*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTransferOperationPriority*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperationPriority*, uint>)(lpVtbl[1]))((IBackgroundTransferOperationPriority*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperationPriority*, uint>)(lpVtbl[2]))((IBackgroundTransferOperationPriority*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperationPriority*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundTransferOperationPriority*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperationPriority*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundTransferOperationPriority*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperationPriority*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundTransferOperationPriority*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundTransferOperationPriority.xml' path='doc/member[@name="IBackgroundTransferOperationPriority.get_Priority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Priority([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferPriority *")] BackgroundTransferPriority* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperationPriority*, BackgroundTransferPriority*, int>)(lpVtbl[6]))((IBackgroundTransferOperationPriority*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferOperationPriority.xml' path='doc/member[@name="IBackgroundTransferOperationPriority.put_Priority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Priority([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferPriority")] BackgroundTransferPriority value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferOperationPriority*, BackgroundTransferPriority, int>)(lpVtbl[7]))((IBackgroundTransferOperationPriority*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Priority([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferPriority *")] BackgroundTransferPriority* value);

        [VtblIndex(7)]
        HRESULT put_Priority([NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferPriority")] BackgroundTransferPriority value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferPriority *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BackgroundTransferPriority*, int> get_Priority;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferPriority) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BackgroundTransferPriority, int> put_Priority;
    }
}
