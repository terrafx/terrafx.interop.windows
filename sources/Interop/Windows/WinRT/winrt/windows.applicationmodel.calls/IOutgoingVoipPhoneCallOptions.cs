// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IOutgoingVoipPhoneCallOptions.xml' path='doc/member[@name="IOutgoingVoipPhoneCallOptions"]/*' />
[Guid("D6C59B57-57BE-524F-9DC1-F2C12E5D1BCC")]
[NativeTypeName("struct IOutgoingVoipPhoneCallOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IOutgoingVoipPhoneCallOptions : IOutgoingVoipPhoneCallOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IOutgoingVoipPhoneCallOptions);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptions*, Guid*, void**, int>)(lpVtbl[0]))((IOutgoingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptions*, uint>)(lpVtbl[1]))((IOutgoingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptions*, uint>)(lpVtbl[2]))((IOutgoingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IOutgoingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[4]))((IOutgoingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptions*, TrustLevel*, int>)(lpVtbl[5]))((IOutgoingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IOutgoingVoipPhoneCallOptions.xml' path='doc/member[@name="IOutgoingVoipPhoneCallOptions.get_Context"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Context(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[6]))((IOutgoingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOutgoingVoipPhoneCallOptions.xml' path='doc/member[@name="IOutgoingVoipPhoneCallOptions.put_Context"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Context(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptions*, HSTRING, int>)(lpVtbl[7]))((IOutgoingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOutgoingVoipPhoneCallOptions.xml' path='doc/member[@name="IOutgoingVoipPhoneCallOptions.get_ContactName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ContactName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[8]))((IOutgoingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOutgoingVoipPhoneCallOptions.xml' path='doc/member[@name="IOutgoingVoipPhoneCallOptions.put_ContactName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ContactName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptions*, HSTRING, int>)(lpVtbl[9]))((IOutgoingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOutgoingVoipPhoneCallOptions.xml' path='doc/member[@name="IOutgoingVoipPhoneCallOptions.get_ServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ServiceName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptions*, HSTRING*, int>)(lpVtbl[10]))((IOutgoingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOutgoingVoipPhoneCallOptions.xml' path='doc/member[@name="IOutgoingVoipPhoneCallOptions.put_ServiceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ServiceName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptions*, HSTRING, int>)(lpVtbl[11]))((IOutgoingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOutgoingVoipPhoneCallOptions.xml' path='doc/member[@name="IOutgoingVoipPhoneCallOptions.get_Media"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia *")] VoipPhoneCallMedia* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptions*, VoipPhoneCallMedia*, int>)(lpVtbl[12]))((IOutgoingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOutgoingVoipPhoneCallOptions.xml' path='doc/member[@name="IOutgoingVoipPhoneCallOptions.put_Media"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptions*, VoipPhoneCallMedia, int>)(lpVtbl[13]))((IOutgoingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOutgoingVoipPhoneCallOptions.xml' path='doc/member[@name="IOutgoingVoipPhoneCallOptions.get_AssociatedDeviceIds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_AssociatedDeviceIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<HSTRING>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOutgoingVoipPhoneCallOptions*, IVector<HSTRING>**, int>)(lpVtbl[14]))((IOutgoingVoipPhoneCallOptions*)Unsafe.AsPointer(ref this), value);
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
        HRESULT get_ServiceName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_ServiceName(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia *")] VoipPhoneCallMedia* value);

        [VtblIndex(13)]
        HRESULT put_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::VoipPhoneCallMedia")] VoipPhoneCallMedia value);

        [VtblIndex(14)]
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
