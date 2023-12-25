// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundExecutionManagerStatics3.xml' path='doc/member[@name="IBackgroundExecutionManagerStatics3"]/*' />
[Guid("98A5D3F6-5A25-5B6C-9192-D77A43DFEDC4")]
[NativeTypeName("struct IBackgroundExecutionManagerStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundExecutionManagerStatics3 : IBackgroundExecutionManagerStatics3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundExecutionManagerStatics3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundExecutionManagerStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics3*, uint>)(lpVtbl[1]))((IBackgroundExecutionManagerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics3*, uint>)(lpVtbl[2]))((IBackgroundExecutionManagerStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundExecutionManagerStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics3*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundExecutionManagerStatics3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundExecutionManagerStatics3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundExecutionManagerStatics3.xml' path='doc/member[@name="IBackgroundExecutionManagerStatics3.RequestAccessKindForModernStandbyAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessKindForModernStandbyAsync([NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessRequestKind")] BackgroundAccessRequestKind requestedAccess, HSTRING reason, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics3*, BackgroundAccessRequestKind, HSTRING, IAsyncOperation<bool>**, int>)(lpVtbl[6]))((IBackgroundExecutionManagerStatics3*)Unsafe.AsPointer(ref this), requestedAccess, reason, operation);
    }

    /// <include file='IBackgroundExecutionManagerStatics3.xml' path='doc/member[@name="IBackgroundExecutionManagerStatics3.GetAccessStatusForModernStandby"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAccessStatusForModernStandby([NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")] BackgroundAccessStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics3*, BackgroundAccessStatus*, int>)(lpVtbl[7]))((IBackgroundExecutionManagerStatics3*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IBackgroundExecutionManagerStatics3.xml' path='doc/member[@name="IBackgroundExecutionManagerStatics3.GetAccessStatusForModernStandbyForApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAccessStatusForModernStandbyForApplication(HSTRING applicationId, [NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")] BackgroundAccessStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics3*, HSTRING, BackgroundAccessStatus*, int>)(lpVtbl[8]))((IBackgroundExecutionManagerStatics3*)Unsafe.AsPointer(ref this), applicationId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessKindForModernStandbyAsync([NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessRequestKind")] BackgroundAccessRequestKind requestedAccess, HSTRING reason, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);

        [VtblIndex(7)]
        HRESULT GetAccessStatusForModernStandby([NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")] BackgroundAccessStatus* result);

        [VtblIndex(8)]
        HRESULT GetAccessStatusForModernStandbyForApplication(HSTRING applicationId, [NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")] BackgroundAccessStatus* result);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::BackgroundAccessRequestKind, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BackgroundAccessRequestKind, HSTRING, IAsyncOperation<bool>**, int> RequestAccessKindForModernStandbyAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BackgroundAccessStatus*, int> GetAccessStatusForModernStandby;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, BackgroundAccessStatus*, int> GetAccessStatusForModernStandbyForApplication;
    }
}
