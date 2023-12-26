// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneCallInfo.xml' path='doc/member[@name="IPhoneCallInfo"]/*' />
[Guid("22B42577-3E4D-5DC6-89C2-469FE5FFC189")]
[NativeTypeName("struct IPhoneCallInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallInfo : IPhoneCallInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneCallInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallInfo*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneCallInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallInfo*, uint>)(lpVtbl[1]))((IPhoneCallInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallInfo*, uint>)(lpVtbl[2]))((IPhoneCallInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneCallInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallInfo*, HSTRING*, int>)(lpVtbl[4]))((IPhoneCallInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallInfo*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneCallInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneCallInfo.xml' path='doc/member[@name="IPhoneCallInfo.get_LineId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_LineId(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallInfo*, Guid*, int>)(lpVtbl[6]))((IPhoneCallInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallInfo.xml' path='doc/member[@name="IPhoneCallInfo.get_IsHoldSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsHoldSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallInfo*, byte*, int>)(lpVtbl[7]))((IPhoneCallInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallInfo.xml' path='doc/member[@name="IPhoneCallInfo.get_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallInfo*, DateTime*, int>)(lpVtbl[8]))((IPhoneCallInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallInfo.xml' path='doc/member[@name="IPhoneCallInfo.get_PhoneNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PhoneNumber(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallInfo*, HSTRING*, int>)(lpVtbl[9]))((IPhoneCallInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallInfo.xml' path='doc/member[@name="IPhoneCallInfo.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallInfo*, HSTRING*, int>)(lpVtbl[10]))((IPhoneCallInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallInfo.xml' path='doc/member[@name="IPhoneCallInfo.get_CallDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CallDirection([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallDirection *")] PhoneCallDirection* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallInfo*, PhoneCallDirection*, int>)(lpVtbl[11]))((IPhoneCallInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_LineId(Guid* value);

        [VtblIndex(7)]
        HRESULT get_IsHoldSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value);

        [VtblIndex(9)]
        HRESULT get_PhoneNumber(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_CallDirection([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallDirection *")] PhoneCallDirection* value);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_LineId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsHoldSupported;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DateTime*, int> get_StartTime;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PhoneNumber;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallDirection *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallDirection*, int> get_CallDirection;
    }
}
