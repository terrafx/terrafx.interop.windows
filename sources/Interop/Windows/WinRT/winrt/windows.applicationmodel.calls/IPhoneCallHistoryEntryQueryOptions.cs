// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneCallHistoryEntryQueryOptions.xml' path='doc/member[@name="IPhoneCallHistoryEntryQueryOptions"]/*' />
[Guid("9C5FE15C-8BED-40CA-B06E-C4CA8EAE5C87")]
[NativeTypeName("struct IPhoneCallHistoryEntryQueryOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallHistoryEntryQueryOptions : IPhoneCallHistoryEntryQueryOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneCallHistoryEntryQueryOptions));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryQueryOptions*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneCallHistoryEntryQueryOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryQueryOptions*, uint>)(lpVtbl[1]))((IPhoneCallHistoryEntryQueryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryQueryOptions*, uint>)(lpVtbl[2]))((IPhoneCallHistoryEntryQueryOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryQueryOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneCallHistoryEntryQueryOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryQueryOptions*, HSTRING*, int>)(lpVtbl[4]))((IPhoneCallHistoryEntryQueryOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryQueryOptions*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneCallHistoryEntryQueryOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneCallHistoryEntryQueryOptions.xml' path='doc/member[@name="IPhoneCallHistoryEntryQueryOptions.get_DesiredMedia"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DesiredMedia([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryQueryDesiredMedia *")] PhoneCallHistoryEntryQueryDesiredMedia* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryQueryOptions*, PhoneCallHistoryEntryQueryDesiredMedia*, int>)(lpVtbl[6]))((IPhoneCallHistoryEntryQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntryQueryOptions.xml' path='doc/member[@name="IPhoneCallHistoryEntryQueryOptions.put_DesiredMedia"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DesiredMedia([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryQueryDesiredMedia")] PhoneCallHistoryEntryQueryDesiredMedia value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryQueryOptions*, PhoneCallHistoryEntryQueryDesiredMedia, int>)(lpVtbl[7]))((IPhoneCallHistoryEntryQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntryQueryOptions.xml' path='doc/member[@name="IPhoneCallHistoryEntryQueryOptions.get_SourceIds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SourceIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntryQueryOptions*, IVector<HSTRING>**, int>)(lpVtbl[8]))((IPhoneCallHistoryEntryQueryOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DesiredMedia([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryQueryDesiredMedia *")] PhoneCallHistoryEntryQueryDesiredMedia* value);

        [VtblIndex(7)]
        HRESULT put_DesiredMedia([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryQueryDesiredMedia")] PhoneCallHistoryEntryQueryDesiredMedia value);

        [VtblIndex(8)]
        HRESULT get_SourceIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryQueryDesiredMedia *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallHistoryEntryQueryDesiredMedia*, int> get_DesiredMedia;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryQueryDesiredMedia) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallHistoryEntryQueryDesiredMedia, int> put_DesiredMedia;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_SourceIds;
    }
}
