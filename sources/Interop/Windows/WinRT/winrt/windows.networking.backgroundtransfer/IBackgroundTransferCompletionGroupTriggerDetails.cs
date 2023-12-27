// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundTransferCompletionGroupTriggerDetails.xml' path='doc/member[@name="IBackgroundTransferCompletionGroupTriggerDetails"]/*' />
[Guid("7B6BE286-6E47-5136-7FCB-FA4389F46F5B")]
[NativeTypeName("struct IBackgroundTransferCompletionGroupTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTransferCompletionGroupTriggerDetails : IBackgroundTransferCompletionGroupTriggerDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTransferCompletionGroupTriggerDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroupTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundTransferCompletionGroupTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroupTriggerDetails*, uint>)(lpVtbl[1]))((IBackgroundTransferCompletionGroupTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroupTriggerDetails*, uint>)(lpVtbl[2]))((IBackgroundTransferCompletionGroupTriggerDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroupTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundTransferCompletionGroupTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroupTriggerDetails*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundTransferCompletionGroupTriggerDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroupTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundTransferCompletionGroupTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundTransferCompletionGroupTriggerDetails.xml' path='doc/member[@name="IBackgroundTransferCompletionGroupTriggerDetails.get_Downloads"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Downloads([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **")] IVectorView<Pointer<IDownloadOperation>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroupTriggerDetails*, IVectorView<Pointer<IDownloadOperation>>**, int>)(lpVtbl[6]))((IBackgroundTransferCompletionGroupTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundTransferCompletionGroupTriggerDetails.xml' path='doc/member[@name="IBackgroundTransferCompletionGroupTriggerDetails.get_Uploads"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Uploads([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **")] IVectorView<Pointer<IUploadOperation>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundTransferCompletionGroupTriggerDetails*, IVectorView<Pointer<IUploadOperation>>**, int>)(lpVtbl[7]))((IBackgroundTransferCompletionGroupTriggerDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Downloads([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **")] IVectorView<Pointer<IDownloadOperation>>** value);

        [VtblIndex(7)]
        HRESULT get_Uploads([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **")] IVectorView<Pointer<IUploadOperation>>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IDownloadOperation>>**, int> get_Downloads;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IUploadOperation>>**, int> get_Uploads;
    }
}
