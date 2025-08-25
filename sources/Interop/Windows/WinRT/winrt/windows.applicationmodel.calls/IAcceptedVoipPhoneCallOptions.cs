// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAcceptedVoipPhoneCallOptions.xml' path='doc/member[@name="IAcceptedVoipPhoneCallOptions"]/*' />
[Guid("E519C726-B86F-5ADD-8AE2-0F46ACD9232D")]
[NativeTypeName("struct IAcceptedVoipPhoneCallOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAcceptedVoipPhoneCallOptions : IAcceptedVoipPhoneCallOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IAcceptedVoipPhoneCallOptions);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, Guid*, void**, int>)(lpVtbl[0]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, uint>)(lpVtbl[1]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, uint>)(lpVtbl[2]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[4]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, TrustLevel*, int>)(lpVtbl[5]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAcceptedVoipPhoneCallOptions.xml' path='doc/member[@name="IAcceptedVoipPhoneCallOptions.get_Context"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Context(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[6]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAcceptedVoipPhoneCallOptions.xml' path='doc/member[@name="IAcceptedVoipPhoneCallOptions.put_Context"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Context(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, HSTRING, int>)(lpVtbl[7]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAcceptedVoipPhoneCallOptions.xml' path='doc/member[@name="IAcceptedVoipPhoneCallOptions.get_ContactName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ContactName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[8]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAcceptedVoipPhoneCallOptions.xml' path='doc/member[@name="IAcceptedVoipPhoneCallOptions.put_ContactName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ContactName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, HSTRING, int>)(lpVtbl[9]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAcceptedVoipPhoneCallOptions.xml' path='doc/member[@name="IAcceptedVoipPhoneCallOptions.get_ContactNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ContactNumber(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[10]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAcceptedVoipPhoneCallOptions.xml' path='doc/member[@name="IAcceptedVoipPhoneCallOptions.put_ContactNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ContactNumber(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, HSTRING, int>)(lpVtbl[11]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAcceptedVoipPhoneCallOptions.xml' path='doc/member[@name="IAcceptedVoipPhoneCallOptions.get_ServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ServiceName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[12]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAcceptedVoipPhoneCallOptions.xml' path='doc/member[@name="IAcceptedVoipPhoneCallOptions.put_ServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_ServiceName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, HSTRING, int>)(lpVtbl[13]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAcceptedVoipPhoneCallOptions.xml' path='doc/member[@name="IAcceptedVoipPhoneCallOptions.get_Media"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia *")] VoipPhoneCallMedia* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, VoipPhoneCallMedia*, int>)(lpVtbl[14]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAcceptedVoipPhoneCallOptions.xml' path='doc/member[@name="IAcceptedVoipPhoneCallOptions.put_Media"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, VoipPhoneCallMedia, int>)(lpVtbl[15]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAcceptedVoipPhoneCallOptions.xml' path='doc/member[@name="IAcceptedVoipPhoneCallOptions.get_AssociatedDeviceIds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_AssociatedDeviceIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAcceptedVoipPhoneCallOptions*, IVector<HSTRING>**, int>)(lpVtbl[16]))((IAcceptedVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
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
        HRESULT get_ServiceName(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_ServiceName(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia *")] VoipPhoneCallMedia* value);

        [VtblIndex(15)]
        HRESULT put_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia value);

        [VtblIndex(16)]
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ServiceName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ServiceName;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VoipPhoneCallMedia*, int> get_Media;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VoipPhoneCallMedia, int> put_Media;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<HSTRING>**, int> get_AssociatedDeviceIds;
    }
}
