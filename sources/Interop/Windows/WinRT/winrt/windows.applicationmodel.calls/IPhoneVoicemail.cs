// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneVoicemail.xml' path='doc/member[@name="IPhoneVoicemail"]/*' />
[Guid("C9CE77F6-6E9F-3A8B-B727-6E0CF6998224")]
[NativeTypeName("struct IPhoneVoicemail : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneVoicemail : IPhoneVoicemail.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneVoicemail));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneVoicemail*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneVoicemail*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneVoicemail*, uint>)(lpVtbl[1]))((IPhoneVoicemail*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneVoicemail*, uint>)(lpVtbl[2]))((IPhoneVoicemail*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneVoicemail*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneVoicemail*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneVoicemail*, HSTRING*, int>)(lpVtbl[4]))((IPhoneVoicemail*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneVoicemail*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneVoicemail*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneVoicemail.xml' path='doc/member[@name="IPhoneVoicemail.get_Number"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Number(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneVoicemail*, HSTRING*, int>)(lpVtbl[6]))((IPhoneVoicemail*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneVoicemail.xml' path='doc/member[@name="IPhoneVoicemail.get_MessageCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MessageCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneVoicemail*, int*, int>)(lpVtbl[7]))((IPhoneVoicemail*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneVoicemail.xml' path='doc/member[@name="IPhoneVoicemail.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Type([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneVoicemailType *")] PhoneVoicemailType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneVoicemail*, PhoneVoicemailType*, int>)(lpVtbl[8]))((IPhoneVoicemail*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneVoicemail.xml' path='doc/member[@name="IPhoneVoicemail.DialVoicemailAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DialVoicemailAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneVoicemail*, IAsyncAction**, int>)(lpVtbl[9]))((IPhoneVoicemail*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Number(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_MessageCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_Type([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneVoicemailType *")] PhoneVoicemailType* value);

        [VtblIndex(9)]
        HRESULT DialVoicemailAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** result);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Number;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MessageCount;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneVoicemailType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneVoicemailType*, int> get_Type;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> DialVoicemailAsync;
    }
}
