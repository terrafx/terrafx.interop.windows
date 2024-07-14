// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAlarmApplicationManagerStatics.xml' path='doc/member[@name="IAlarmApplicationManagerStatics"]/*' />
[Guid("CA03FA3B-CCE6-4DE2-B09B-9628BD33BBBE")]
[NativeTypeName("struct IAlarmApplicationManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAlarmApplicationManagerStatics : IAlarmApplicationManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAlarmApplicationManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAlarmApplicationManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAlarmApplicationManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAlarmApplicationManagerStatics*, uint>)(lpVtbl[1]))((IAlarmApplicationManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAlarmApplicationManagerStatics*, uint>)(lpVtbl[2]))((IAlarmApplicationManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAlarmApplicationManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAlarmApplicationManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAlarmApplicationManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IAlarmApplicationManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAlarmApplicationManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAlarmApplicationManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAlarmApplicationManagerStatics.xml' path='doc/member[@name="IAlarmApplicationManagerStatics.RequestAccessAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CAlarmAccessStatus_t **")] IAsyncOperation<AlarmAccessStatus>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAlarmApplicationManagerStatics*, IAsyncOperation<AlarmAccessStatus>**, int>)(lpVtbl[6]))((IAlarmApplicationManagerStatics*)Unsafe.AsPointer(ref this), operation);
    }

    /// <include file='IAlarmApplicationManagerStatics.xml' path='doc/member[@name="IAlarmApplicationManagerStatics.GetAccessStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAccessStatus([NativeTypeName("ABI::Windows::ApplicationModel::Background::AlarmAccessStatus *")] AlarmAccessStatus* status)
    {
        return ((delegate* unmanaged[MemberFunction]<IAlarmApplicationManagerStatics*, AlarmAccessStatus*, int>)(lpVtbl[7]))((IAlarmApplicationManagerStatics*)Unsafe.AsPointer(ref this), status);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CAlarmAccessStatus_t **")] IAsyncOperation<AlarmAccessStatus>** operation);

        [VtblIndex(7)]
        HRESULT GetAccessStatus([NativeTypeName("ABI::Windows::ApplicationModel::Background::AlarmAccessStatus *")] AlarmAccessStatus* status);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CAlarmAccessStatus_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<AlarmAccessStatus>**, int> RequestAccessAsync;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Background::AlarmAccessStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AlarmAccessStatus*, int> GetAccessStatus;
    }
}
