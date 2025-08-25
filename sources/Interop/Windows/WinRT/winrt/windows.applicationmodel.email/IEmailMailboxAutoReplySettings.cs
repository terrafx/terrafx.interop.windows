// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailboxAutoReplySettings.xml' path='doc/member[@name="IEmailMailboxAutoReplySettings"]/*' />
[Guid("A87A9FA8-0AC6-4B77-BA77-A6B99E9A27B8")]
[NativeTypeName("struct IEmailMailboxAutoReplySettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxAutoReplySettings : IEmailMailboxAutoReplySettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEmailMailboxAutoReplySettings);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, uint>)(lpVtbl[1]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, uint>)(lpVtbl[2]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, HSTRING*, int>)(lpVtbl[4]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMailboxAutoReplySettings.xml' path='doc/member[@name="IEmailMailboxAutoReplySettings.get_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, byte*, int>)(lpVtbl[6]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxAutoReplySettings.xml' path='doc/member[@name="IEmailMailboxAutoReplySettings.put_IsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, byte, int>)(lpVtbl[7]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxAutoReplySettings.xml' path='doc/member[@name="IEmailMailboxAutoReplySettings.get_ResponseKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ResponseKind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind *")] EmailMailboxAutoReplyMessageResponseKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, EmailMailboxAutoReplyMessageResponseKind*, int>)(lpVtbl[8]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxAutoReplySettings.xml' path='doc/member[@name="IEmailMailboxAutoReplySettings.put_ResponseKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ResponseKind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind")] EmailMailboxAutoReplyMessageResponseKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, EmailMailboxAutoReplyMessageResponseKind, int>)(lpVtbl[9]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxAutoReplySettings.xml' path='doc/member[@name="IEmailMailboxAutoReplySettings.get_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, IReference<DateTime>**, int>)(lpVtbl[10]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxAutoReplySettings.xml' path='doc/member[@name="IEmailMailboxAutoReplySettings.put_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_StartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, IReference<DateTime>*, int>)(lpVtbl[11]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxAutoReplySettings.xml' path='doc/member[@name="IEmailMailboxAutoReplySettings.get_EndTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_EndTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, IReference<DateTime>**, int>)(lpVtbl[12]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxAutoReplySettings.xml' path='doc/member[@name="IEmailMailboxAutoReplySettings.put_EndTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_EndTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, IReference<DateTime>*, int>)(lpVtbl[13]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxAutoReplySettings.xml' path='doc/member[@name="IEmailMailboxAutoReplySettings.get_InternalReply"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_InternalReply([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **")] IEmailMailboxAutoReply** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, IEmailMailboxAutoReply**, int>)(lpVtbl[14]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxAutoReplySettings.xml' path='doc/member[@name="IEmailMailboxAutoReplySettings.get_KnownExternalReply"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_KnownExternalReply([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **")] IEmailMailboxAutoReply** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, IEmailMailboxAutoReply**, int>)(lpVtbl[15]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxAutoReplySettings.xml' path='doc/member[@name="IEmailMailboxAutoReplySettings.get_UnknownExternalReply"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_UnknownExternalReply([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **")] IEmailMailboxAutoReply** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxAutoReplySettings*, IEmailMailboxAutoReply**, int>)(lpVtbl[16]))((IEmailMailboxAutoReplySettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_ResponseKind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind *")] EmailMailboxAutoReplyMessageResponseKind* value);

        [VtblIndex(9)]
        HRESULT put_ResponseKind([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind")] EmailMailboxAutoReplyMessageResponseKind value);

        [VtblIndex(10)]
        HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(11)]
        HRESULT put_StartTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(12)]
        HRESULT get_EndTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value);

        [VtblIndex(13)]
        HRESULT put_EndTime([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *")] IReference<DateTime>* value);

        [VtblIndex(14)]
        HRESULT get_InternalReply([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **")] IEmailMailboxAutoReply** value);

        [VtblIndex(15)]
        HRESULT get_KnownExternalReply([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **")] IEmailMailboxAutoReply** value);

        [VtblIndex(16)]
        HRESULT get_UnknownExternalReply([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **")] IEmailMailboxAutoReply** value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMailboxAutoReplyMessageResponseKind*, int> get_ResponseKind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailMailboxAutoReplyMessageResponseKind, int> put_ResponseKind;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>**, int> get_EndTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<DateTime>*, int> put_EndTime;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMailboxAutoReply**, int> get_InternalReply;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMailboxAutoReply**, int> get_KnownExternalReply;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReply **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMailboxAutoReply**, int> get_UnknownExternalReply;
    }
}
