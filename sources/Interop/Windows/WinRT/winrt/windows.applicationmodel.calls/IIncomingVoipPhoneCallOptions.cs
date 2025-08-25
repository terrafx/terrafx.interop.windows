// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions"]/*' />
[Guid("4379FCD6-DDD0-5E9B-81D8-5110495764AE")]
[NativeTypeName("struct IIncomingVoipPhoneCallOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIncomingVoipPhoneCallOptions : IIncomingVoipPhoneCallOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IIncomingVoipPhoneCallOptions);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, Guid*, void**, int>)(lpVtbl[0]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, uint>)(lpVtbl[1]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, uint>)(lpVtbl[2]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[4]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, TrustLevel*, int>)(lpVtbl[5]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.get_Context"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Context(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[6]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.put_Context"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Context(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, HSTRING, int>)(lpVtbl[7]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.get_ContactName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ContactName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[8]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.put_ContactName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ContactName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, HSTRING, int>)(lpVtbl[9]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.get_ContactNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ContactNumber(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[10]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.put_ContactNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ContactNumber(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, HSTRING, int>)(lpVtbl[11]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.get_ContactImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ContactImage([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, IUriRuntimeClass**, int>)(lpVtbl[12]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.put_ContactImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_ContactImage([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, IUriRuntimeClass*, int>)(lpVtbl[13]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.get_ServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ServiceName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[14]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.put_ServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_ServiceName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, HSTRING, int>)(lpVtbl[15]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.get_BrandingImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_BrandingImage([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, IUriRuntimeClass**, int>)(lpVtbl[16]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.put_BrandingImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_BrandingImage([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, IUriRuntimeClass*, int>)(lpVtbl[17]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.get_CallDetails"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_CallDetails(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[18]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.put_CallDetails"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_CallDetails(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, HSTRING, int>)(lpVtbl[19]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.get_Ringtone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Ringtone([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, IUriRuntimeClass**, int>)(lpVtbl[20]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.put_Ringtone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_Ringtone([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, IUriRuntimeClass*, int>)(lpVtbl[21]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.get_Media"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia *")] VoipPhoneCallMedia* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, VoipPhoneCallMedia*, int>)(lpVtbl[22]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.put_Media"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, VoipPhoneCallMedia, int>)(lpVtbl[23]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.get_RingTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_RingTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, TimeSpan*, int>)(lpVtbl[24]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.put_RingTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_RingTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, TimeSpan, int>)(lpVtbl[25]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.get_ContactRemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_ContactRemoteId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[26]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.put_ContactRemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_ContactRemoteId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, HSTRING, int>)(lpVtbl[27]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IIncomingVoipPhoneCallOptions.xml' path='doc/member[@name="IIncomingVoipPhoneCallOptions.get_AssociatedDeviceIds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_AssociatedDeviceIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIncomingVoipPhoneCallOptions*, IVector<HSTRING>**, int>)(lpVtbl[28]))((IIncomingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Context(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Context(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_ContactName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_ContactName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_ContactNumber(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_ContactNumber(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_ContactImage([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(13)]
        HRESULT put_ContactImage([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);

        [VtblIndex(14)]
        HRESULT get_ServiceName(HSTRING* value);

        [VtblIndex(15)]
        HRESULT put_ServiceName(HSTRING value);

        [VtblIndex(16)]
        HRESULT get_BrandingImage([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(17)]
        HRESULT put_BrandingImage([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);

        [VtblIndex(18)]
        HRESULT get_CallDetails(HSTRING* value);

        [VtblIndex(19)]
        HRESULT put_CallDetails(HSTRING value);

        [VtblIndex(20)]
        HRESULT get_Ringtone([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value);

        [VtblIndex(21)]
        HRESULT put_Ringtone([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value);

        [VtblIndex(22)]
        HRESULT get_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia *")] VoipPhoneCallMedia* value);

        [VtblIndex(23)]
        HRESULT put_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia value);

        [VtblIndex(24)]
        HRESULT get_RingTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(25)]
        HRESULT put_RingTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(26)]
        HRESULT get_ContactRemoteId(HSTRING* value);

        [VtblIndex(27)]
        HRESULT put_ContactRemoteId(HSTRING value);

        [VtblIndex(28)]
        HRESULT get_AssociatedDeviceIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Context;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Context;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContactName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ContactName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContactNumber;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ContactNumber;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_ContactImage;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_ContactImage;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ServiceName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ServiceName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_BrandingImage;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_BrandingImage;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_CallDetails;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_CallDetails;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass**, int> get_Ringtone;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUriRuntimeClass*, int> put_Ringtone;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VoipPhoneCallMedia*, int> get_Media;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VoipPhoneCallMedia, int> put_Media;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_RingTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_RingTimeout;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContactRemoteId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ContactRemoteId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_AssociatedDeviceIds;
    }
}
