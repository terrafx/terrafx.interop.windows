// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry"]/*' />
[Guid("FAB0E129-32A4-4B85-83D1-F90D8C23A857")]
[NativeTypeName("struct IPhoneCallHistoryEntry : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallHistoryEntry : IPhoneCallHistoryEntry.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneCallHistoryEntry));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, Guid*, void**, int>)(lpVtbl[0]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, uint>)(lpVtbl[1]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, uint>)(lpVtbl[2]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, uint*, Guid**, int>)(lpVtbl[3]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, HSTRING*, int>)(lpVtbl[4]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, TrustLevel*, int>)(lpVtbl[5]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, HSTRING*, int>)(lpVtbl[6]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_Address"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Address([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryAddress **")] IPhoneCallHistoryEntryAddress** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, IPhoneCallHistoryEntryAddress**, int>)(lpVtbl[7]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_Address"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Address([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryAddress *")] IPhoneCallHistoryEntryAddress* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, IPhoneCallHistoryEntryAddress*, int>)(lpVtbl[8]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, IReference<TimeSpan>**, int>)(lpVtbl[9]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_Duration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, IReference<TimeSpan>*, int>)(lpVtbl[10]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_IsCallerIdBlocked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsCallerIdBlocked([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte*, int>)(lpVtbl[11]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_IsCallerIdBlocked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_IsCallerIdBlocked([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte, int>)(lpVtbl[12]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_IsEmergency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_IsEmergency([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte*, int>)(lpVtbl[13]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_IsEmergency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_IsEmergency([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte, int>)(lpVtbl[14]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_IsIncoming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsIncoming([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte*, int>)(lpVtbl[15]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_IsIncoming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_IsIncoming([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte, int>)(lpVtbl[16]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_IsMissed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_IsMissed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte*, int>)(lpVtbl[17]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_IsMissed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_IsMissed([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte, int>)(lpVtbl[18]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_IsRinging"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_IsRinging([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte*, int>)(lpVtbl[19]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_IsRinging"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_IsRinging([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte, int>)(lpVtbl[20]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_IsSeen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_IsSeen([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte*, int>)(lpVtbl[21]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_IsSeen"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_IsSeen([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte, int>)(lpVtbl[22]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_IsSuppressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_IsSuppressed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte*, int>)(lpVtbl[23]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_IsSuppressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_IsSuppressed([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte, int>)(lpVtbl[24]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_IsVoicemail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_IsVoicemail([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte*, int>)(lpVtbl[25]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_IsVoicemail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_IsVoicemail([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, byte, int>)(lpVtbl[26]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_Media"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryMedia *")] PhoneCallHistoryEntryMedia* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, PhoneCallHistoryEntryMedia*, int>)(lpVtbl[27]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_Media"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryMedia")] PhoneCallHistoryEntryMedia value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, PhoneCallHistoryEntryMedia, int>)(lpVtbl[28]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_OtherAppReadAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryOtherAppReadAccess *")] PhoneCallHistoryEntryOtherAppReadAccess* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, PhoneCallHistoryEntryOtherAppReadAccess*, int>)(lpVtbl[29]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_OtherAppReadAccess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryOtherAppReadAccess")] PhoneCallHistoryEntryOtherAppReadAccess value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, PhoneCallHistoryEntryOtherAppReadAccess, int>)(lpVtbl[30]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_RemoteId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, HSTRING*, int>)(lpVtbl[31]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_RemoteId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_RemoteId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, HSTRING, int>)(lpVtbl[32]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_SourceDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_SourceDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, HSTRING*, int>)(lpVtbl[33]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_SourceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_SourceId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, HSTRING*, int>)(lpVtbl[34]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_SourceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_SourceId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, HSTRING, int>)(lpVtbl[35]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_SourceIdKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_SourceIdKind([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistorySourceIdKind *")] PhoneCallHistorySourceIdKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, PhoneCallHistorySourceIdKind*, int>)(lpVtbl[36]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_SourceIdKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_SourceIdKind([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistorySourceIdKind")] PhoneCallHistorySourceIdKind value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, PhoneCallHistorySourceIdKind, int>)(lpVtbl[37]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.get_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, WinRTDateTime*, int>)(lpVtbl[38]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhoneCallHistoryEntry.xml' path='doc/member[@name="IPhoneCallHistoryEntry.put_StartTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhoneCallHistoryEntry*, WinRTDateTime, int>)(lpVtbl[39]))((IPhoneCallHistoryEntry*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Address([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryAddress **")] IPhoneCallHistoryEntryAddress** value);

        [VtblIndex(8)]
        HRESULT put_Address([NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryAddress *")] IPhoneCallHistoryEntryAddress* value);

        [VtblIndex(9)]
        HRESULT get_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **")] IReference<TimeSpan>** value);

        [VtblIndex(10)]
        HRESULT put_Duration([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *")] IReference<TimeSpan>* value);

        [VtblIndex(11)]
        HRESULT get_IsCallerIdBlocked([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT put_IsCallerIdBlocked([NativeTypeName("boolean")] byte value);

        [VtblIndex(13)]
        HRESULT get_IsEmergency([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT put_IsEmergency([NativeTypeName("boolean")] byte value);

        [VtblIndex(15)]
        HRESULT get_IsIncoming([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT put_IsIncoming([NativeTypeName("boolean")] byte value);

        [VtblIndex(17)]
        HRESULT get_IsMissed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(18)]
        HRESULT put_IsMissed([NativeTypeName("boolean")] byte value);

        [VtblIndex(19)]
        HRESULT get_IsRinging([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(20)]
        HRESULT put_IsRinging([NativeTypeName("boolean")] byte value);

        [VtblIndex(21)]
        HRESULT get_IsSeen([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(22)]
        HRESULT put_IsSeen([NativeTypeName("boolean")] byte value);

        [VtblIndex(23)]
        HRESULT get_IsSuppressed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(24)]
        HRESULT put_IsSuppressed([NativeTypeName("boolean")] byte value);

        [VtblIndex(25)]
        HRESULT get_IsVoicemail([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(26)]
        HRESULT put_IsVoicemail([NativeTypeName("boolean")] byte value);

        [VtblIndex(27)]
        HRESULT get_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryMedia *")] PhoneCallHistoryEntryMedia* value);

        [VtblIndex(28)]
        HRESULT put_Media([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryMedia")] PhoneCallHistoryEntryMedia value);

        [VtblIndex(29)]
        HRESULT get_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryOtherAppReadAccess *")] PhoneCallHistoryEntryOtherAppReadAccess* value);

        [VtblIndex(30)]
        HRESULT put_OtherAppReadAccess([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryOtherAppReadAccess")] PhoneCallHistoryEntryOtherAppReadAccess value);

        [VtblIndex(31)]
        HRESULT get_RemoteId(HSTRING* value);

        [VtblIndex(32)]
        HRESULT put_RemoteId(HSTRING value);

        [VtblIndex(33)]
        HRESULT get_SourceDisplayName(HSTRING* value);

        [VtblIndex(34)]
        HRESULT get_SourceId(HSTRING* value);

        [VtblIndex(35)]
        HRESULT put_SourceId(HSTRING value);

        [VtblIndex(36)]
        HRESULT get_SourceIdKind([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistorySourceIdKind *")] PhoneCallHistorySourceIdKind* value);

        [VtblIndex(37)]
        HRESULT put_SourceIdKind([NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneCallHistorySourceIdKind")] PhoneCallHistorySourceIdKind value);

        [VtblIndex(38)]
        HRESULT get_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(39)]
        HRESULT put_StartTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryAddress **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhoneCallHistoryEntryAddress**, int> get_Address;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryAddress *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IPhoneCallHistoryEntryAddress*, int> put_Address;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>**, int> get_Duration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<TimeSpan>*, int> put_Duration;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCallerIdBlocked;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsCallerIdBlocked;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEmergency;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsEmergency;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsIncoming;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsIncoming;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsMissed;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsMissed;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsRinging;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsRinging;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSeen;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsSeen;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSuppressed;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsSuppressed;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsVoicemail;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsVoicemail;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryMedia *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallHistoryEntryMedia*, int> get_Media;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryMedia) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallHistoryEntryMedia, int> put_Media;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryOtherAppReadAccess *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallHistoryEntryOtherAppReadAccess*, int> get_OtherAppReadAccess;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallHistoryEntryOtherAppReadAccess) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallHistoryEntryOtherAppReadAccess, int> put_OtherAppReadAccess;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_RemoteId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_RemoteId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SourceDisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_SourceId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_SourceId;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallHistorySourceIdKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallHistorySourceIdKind*, int> get_SourceIdKind;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneCallHistorySourceIdKind) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PhoneCallHistorySourceIdKind, int> put_SourceIdKind;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_StartTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, int> put_StartTime;
    }
}
