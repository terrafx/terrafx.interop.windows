// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IApplicationData.xml' path='doc/member[@name="IApplicationData"]/*' />
[Guid("C3DA6FB7-B744-4B45-B0B8-223A0938D0DC")]
[NativeTypeName("struct IApplicationData : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationData : IApplicationData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationData));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationData*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, uint>)(lpVtbl[1]))((IApplicationData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, uint>)(lpVtbl[2]))((IApplicationData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, uint*, Guid**, int>)(lpVtbl[3]))((IApplicationData*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, HSTRING*, int>)(lpVtbl[4]))((IApplicationData*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, TrustLevel*, int>)(lpVtbl[5]))((IApplicationData*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IApplicationData.xml' path='doc/member[@name="IApplicationData.get_Version"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Version([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, uint*, int>)(lpVtbl[6]))((IApplicationData*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationData.xml' path='doc/member[@name="IApplicationData.SetVersionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetVersionAsync([NativeTypeName("UINT32")] uint desiredVersion, [NativeTypeName("ABI::Windows::Storage::IApplicationDataSetVersionHandler *")] IApplicationDataSetVersionHandler* handler, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** setVersionOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, uint, IApplicationDataSetVersionHandler*, IAsyncAction**, int>)(lpVtbl[7]))((IApplicationData*)Unsafe.AsPointer(ref this), desiredVersion, handler, setVersionOperation);
    }

    /// <include file='IApplicationData.xml' path='doc/member[@name="IApplicationData.ClearAllAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ClearAllAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** clearOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, IAsyncAction**, int>)(lpVtbl[8]))((IApplicationData*)Unsafe.AsPointer(ref this), clearOperation);
    }

    /// <include file='IApplicationData.xml' path='doc/member[@name="IApplicationData.ClearAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ClearAsync([NativeTypeName("ABI::Windows::Storage::ApplicationDataLocality")] ApplicationDataLocality locality, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** clearOperation)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, ApplicationDataLocality, IAsyncAction**, int>)(lpVtbl[9]))((IApplicationData*)Unsafe.AsPointer(ref this), locality, clearOperation);
    }

    /// <include file='IApplicationData.xml' path='doc/member[@name="IApplicationData.get_LocalSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_LocalSettings([NativeTypeName("ABI::Windows::Storage::IApplicationDataContainer **")] IApplicationDataContainer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, IApplicationDataContainer**, int>)(lpVtbl[10]))((IApplicationData*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationData.xml' path='doc/member[@name="IApplicationData.get_RoamingSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_RoamingSettings([NativeTypeName("ABI::Windows::Storage::IApplicationDataContainer **")] IApplicationDataContainer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, IApplicationDataContainer**, int>)(lpVtbl[11]))((IApplicationData*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationData.xml' path='doc/member[@name="IApplicationData.get_LocalFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_LocalFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, IStorageFolder**, int>)(lpVtbl[12]))((IApplicationData*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationData.xml' path='doc/member[@name="IApplicationData.get_RoamingFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_RoamingFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, IStorageFolder**, int>)(lpVtbl[13]))((IApplicationData*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationData.xml' path='doc/member[@name="IApplicationData.get_TemporaryFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_TemporaryFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, IStorageFolder**, int>)(lpVtbl[14]))((IApplicationData*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IApplicationData.xml' path='doc/member[@name="IApplicationData.add_DataChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_DataChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CApplicationData_IInspectable_t *")] ITypedEventHandler<Pointer<IApplicationData>, Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, ITypedEventHandler<Pointer<IApplicationData>, Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IApplicationData*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IApplicationData.xml' path='doc/member[@name="IApplicationData.remove_DataChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_DataChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, EventRegistrationToken, int>)(lpVtbl[16]))((IApplicationData*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IApplicationData.xml' path='doc/member[@name="IApplicationData.SignalDataChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SignalDataChanged()
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, int>)(lpVtbl[17]))((IApplicationData*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IApplicationData.xml' path='doc/member[@name="IApplicationData.get_RoamingStorageQuota"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_RoamingStorageQuota([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IApplicationData*, ulong*, int>)(lpVtbl[18]))((IApplicationData*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Version([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT SetVersionAsync([NativeTypeName("UINT32")] uint desiredVersion, [NativeTypeName("ABI::Windows::Storage::IApplicationDataSetVersionHandler *")] IApplicationDataSetVersionHandler* handler, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** setVersionOperation);

        [VtblIndex(8)]
        HRESULT ClearAllAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** clearOperation);

        [VtblIndex(9)]
        HRESULT ClearAsync([NativeTypeName("ABI::Windows::Storage::ApplicationDataLocality")] ApplicationDataLocality locality, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** clearOperation);

        [VtblIndex(10)]
        HRESULT get_LocalSettings([NativeTypeName("ABI::Windows::Storage::IApplicationDataContainer **")] IApplicationDataContainer** value);

        [VtblIndex(11)]
        HRESULT get_RoamingSettings([NativeTypeName("ABI::Windows::Storage::IApplicationDataContainer **")] IApplicationDataContainer** value);

        [VtblIndex(12)]
        HRESULT get_LocalFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(13)]
        HRESULT get_RoamingFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(14)]
        HRESULT get_TemporaryFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value);

        [VtblIndex(15)]
        HRESULT add_DataChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CApplicationData_IInspectable_t *")] ITypedEventHandler<Pointer<IApplicationData>, Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(16)]
        HRESULT remove_DataChanged(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT SignalDataChanged();

        [VtblIndex(18)]
        HRESULT get_RoamingStorageQuota([NativeTypeName("UINT64 *")] ulong* value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Version;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Storage::IApplicationDataSetVersionHandler *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IApplicationDataSetVersionHandler*, IAsyncAction**, int> SetVersionAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> ClearAllAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::ApplicationDataLocality, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ApplicationDataLocality, IAsyncAction**, int> ClearAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IApplicationDataContainer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IApplicationDataContainer**, int> get_LocalSettings;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IApplicationDataContainer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IApplicationDataContainer**, int> get_RoamingSettings;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_LocalFolder;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_RoamingFolder;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStorageFolder**, int> get_TemporaryFolder;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CApplicationData_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<IApplicationData>, Pointer<IInspectable>>*, EventRegistrationToken*, int> add_DataChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_DataChanged;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> SignalDataChanged;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_RoamingStorageQuota;
    }
}
