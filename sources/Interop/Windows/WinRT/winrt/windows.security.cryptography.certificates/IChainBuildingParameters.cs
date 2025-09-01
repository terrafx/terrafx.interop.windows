// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IChainBuildingParameters.xml' path='doc/member[@name="IChainBuildingParameters"]/*' />
[Guid("422BA922-7C8D-47B7-B59B-B12703733AC3")]
[NativeTypeName("struct IChainBuildingParameters : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IChainBuildingParameters : IChainBuildingParameters.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IChainBuildingParameters);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, Guid*, void**, int>)(lpVtbl[0]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, uint>)(lpVtbl[1]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, uint>)(lpVtbl[2]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, uint*, Guid**, int>)(lpVtbl[3]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, HSTRING*, int>)(lpVtbl[4]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, TrustLevel*, int>)(lpVtbl[5]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IChainBuildingParameters.xml' path='doc/member[@name="IChainBuildingParameters.get_EnhancedKeyUsages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EnhancedKeyUsages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, IVector<HSTRING>**, int>)(lpVtbl[6]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IChainBuildingParameters.xml' path='doc/member[@name="IChainBuildingParameters.get_ValidationTimestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ValidationTimestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, WinRTDateTime*, int>)(lpVtbl[7]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IChainBuildingParameters.xml' path='doc/member[@name="IChainBuildingParameters.put_ValidationTimestamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ValidationTimestamp([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, WinRTDateTime, int>)(lpVtbl[8]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IChainBuildingParameters.xml' path='doc/member[@name="IChainBuildingParameters.get_RevocationCheckEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_RevocationCheckEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, byte*, int>)(lpVtbl[9]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IChainBuildingParameters.xml' path='doc/member[@name="IChainBuildingParameters.put_RevocationCheckEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_RevocationCheckEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, byte, int>)(lpVtbl[10]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IChainBuildingParameters.xml' path='doc/member[@name="IChainBuildingParameters.get_NetworkRetrievalEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_NetworkRetrievalEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, byte*, int>)(lpVtbl[11]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IChainBuildingParameters.xml' path='doc/member[@name="IChainBuildingParameters.put_NetworkRetrievalEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_NetworkRetrievalEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, byte, int>)(lpVtbl[12]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IChainBuildingParameters.xml' path='doc/member[@name="IChainBuildingParameters.get_AuthorityInformationAccessEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_AuthorityInformationAccessEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, byte*, int>)(lpVtbl[13]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IChainBuildingParameters.xml' path='doc/member[@name="IChainBuildingParameters.put_AuthorityInformationAccessEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_AuthorityInformationAccessEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, byte, int>)(lpVtbl[14]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IChainBuildingParameters.xml' path='doc/member[@name="IChainBuildingParameters.get_CurrentTimeValidationEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_CurrentTimeValidationEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, byte*, int>)(lpVtbl[15]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IChainBuildingParameters.xml' path='doc/member[@name="IChainBuildingParameters.put_CurrentTimeValidationEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_CurrentTimeValidationEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, byte, int>)(lpVtbl[16]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IChainBuildingParameters.xml' path='doc/member[@name="IChainBuildingParameters.get_ExclusiveTrustRoots"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ExclusiveTrustRoots([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **")] IVector<Pointer<ICertificate>>** certificates)
    {
        return ((delegate* unmanaged[MemberFunction]<IChainBuildingParameters*, IVector<Pointer<ICertificate>>**, int>)(lpVtbl[17]))((IChainBuildingParameters*)Unsafe.AsPointer(ref this), certificates);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EnhancedKeyUsages([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);

        [VtblIndex(7)]
        HRESULT get_ValidationTimestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(8)]
        HRESULT put_ValidationTimestamp([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value);

        [VtblIndex(9)]
        HRESULT get_RevocationCheckEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_RevocationCheckEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_NetworkRetrievalEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT put_NetworkRetrievalEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(13)]
        HRESULT get_AuthorityInformationAccessEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT put_AuthorityInformationAccessEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(15)]
        HRESULT get_CurrentTimeValidationEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT put_CurrentTimeValidationEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(17)]
        HRESULT get_ExclusiveTrustRoots([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **")] IVector<Pointer<ICertificate>>** certificates);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_EnhancedKeyUsages;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_ValidationTimestamp;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, int> put_ValidationTimestamp;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_RevocationCheckEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_RevocationCheckEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_NetworkRetrievalEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_NetworkRetrievalEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AuthorityInformationAccessEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AuthorityInformationAccessEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CurrentTimeValidationEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CurrentTimeValidationEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<ICertificate>>**, int> get_ExclusiveTrustRoots;
    }
}
