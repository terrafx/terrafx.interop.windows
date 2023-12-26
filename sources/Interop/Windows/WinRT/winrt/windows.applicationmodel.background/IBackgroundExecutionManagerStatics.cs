// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundExecutionManagerStatics.xml' path='doc/member[@name="IBackgroundExecutionManagerStatics"]/*' />
[Guid("E826EA58-66A9-4D41-83D4-B4C18C87B846")]
[NativeTypeName("struct IBackgroundExecutionManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundExecutionManagerStatics : IBackgroundExecutionManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundExecutionManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundExecutionManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics*, uint>)(lpVtbl[1]))((IBackgroundExecutionManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics*, uint>)(lpVtbl[2]))((IBackgroundExecutionManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundExecutionManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundExecutionManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundExecutionManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundExecutionManagerStatics.xml' path='doc/member[@name="IBackgroundExecutionManagerStatics.RequestAccessAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CBackgroundAccessStatus_t **")] IAsyncOperation<BackgroundAccessStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics*, IAsyncOperation<BackgroundAccessStatus>**, int>)(lpVtbl[6]))((IBackgroundExecutionManagerStatics*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IBackgroundExecutionManagerStatics.xml' path='doc/member[@name="IBackgroundExecutionManagerStatics.RequestAccessForApplicationAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAccessForApplicationAsync(HSTRING applicationId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CBackgroundAccessStatus_t **")] IAsyncOperation<BackgroundAccessStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics*, HSTRING, IAsyncOperation<BackgroundAccessStatus>**, int>)(lpVtbl[7]))((IBackgroundExecutionManagerStatics*)Unsafe.AsPointer(ref this), applicationId, operation);
    }

    /// <include file='IBackgroundExecutionManagerStatics.xml' path='doc/member[@name="IBackgroundExecutionManagerStatics.RemoveAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveAccess()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics*, int>)(lpVtbl[8]))((IBackgroundExecutionManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBackgroundExecutionManagerStatics.xml' path='doc/member[@name="IBackgroundExecutionManagerStatics.RemoveAccessForApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveAccessForApplication(HSTRING applicationId)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics*, HSTRING, int>)(lpVtbl[9]))((IBackgroundExecutionManagerStatics*)Unsafe.AsPointer(ref this), applicationId);
    }

    /// <include file='IBackgroundExecutionManagerStatics.xml' path='doc/member[@name="IBackgroundExecutionManagerStatics.GetAccessStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetAccessStatus([NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")] BackgroundAccessStatus* status)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics*, BackgroundAccessStatus*, int>)(lpVtbl[10]))((IBackgroundExecutionManagerStatics*)Unsafe.AsPointer(ref this), status);
    }

    /// <include file='IBackgroundExecutionManagerStatics.xml' path='doc/member[@name="IBackgroundExecutionManagerStatics.GetAccessStatusForApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetAccessStatusForApplication(HSTRING applicationId, [NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")] BackgroundAccessStatus* status)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundExecutionManagerStatics*, HSTRING, BackgroundAccessStatus*, int>)(lpVtbl[11]))((IBackgroundExecutionManagerStatics*)Unsafe.AsPointer(ref this), applicationId, status);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CBackgroundAccessStatus_t **")] IAsyncOperation<BackgroundAccessStatus>** operation);

        [VtblIndex(7)]
        HRESULT RequestAccessForApplicationAsync(HSTRING applicationId, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CBackgroundAccessStatus_t **")] IAsyncOperation<BackgroundAccessStatus>** operation);

        [VtblIndex(8)]
        HRESULT RemoveAccess();

        [VtblIndex(9)]
        HRESULT RemoveAccessForApplication(HSTRING applicationId);

        [VtblIndex(10)]
        HRESULT GetAccessStatus([NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")] BackgroundAccessStatus* status);

        [VtblIndex(11)]
        HRESULT GetAccessStatusForApplication(HSTRING applicationId, [NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")] BackgroundAccessStatus* status);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CBackgroundAccessStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<BackgroundAccessStatus>**, int> RequestAccessAsync;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CBackgroundAccessStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<BackgroundAccessStatus>**, int> RequestAccessForApplicationAsync;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RemoveAccess;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> RemoveAccessForApplication;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BackgroundAccessStatus*, int> GetAccessStatus;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, BackgroundAccessStatus*, int> GetAccessStatusForApplication;
    }
}
