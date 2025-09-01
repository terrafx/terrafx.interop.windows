// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo"]/*' />
[Guid("90F52193-B1A0-4EBD-A6B6-DDCA55606E0E")]
[NativeTypeName("struct IEmailIrmInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailIrmInfo : IEmailIrmInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEmailIrmInfo);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, Guid*, void**, int>)(lpVtbl[0]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, uint>)(lpVtbl[1]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, uint>)(lpVtbl[2]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, HSTRING*, int>)(lpVtbl[4]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, TrustLevel*, int>)(lpVtbl[5]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.get_CanEdit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CanEdit([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte*, int>)(lpVtbl[6]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.put_CanEdit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CanEdit([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte, int>)(lpVtbl[7]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.get_CanExtractData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CanExtractData([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte*, int>)(lpVtbl[8]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.put_CanExtractData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CanExtractData([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte, int>)(lpVtbl[9]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.get_CanForward"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CanForward([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte*, int>)(lpVtbl[10]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.put_CanForward"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CanForward([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte, int>)(lpVtbl[11]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.get_CanModifyRecipientsOnResponse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CanModifyRecipientsOnResponse([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte*, int>)(lpVtbl[12]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.put_CanModifyRecipientsOnResponse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_CanModifyRecipientsOnResponse([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte, int>)(lpVtbl[13]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.get_CanPrintData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_CanPrintData([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte*, int>)(lpVtbl[14]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.put_CanPrintData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_CanPrintData([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte, int>)(lpVtbl[15]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.get_CanRemoveIrmOnResponse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_CanRemoveIrmOnResponse([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte*, int>)(lpVtbl[16]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.put_CanRemoveIrmOnResponse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_CanRemoveIrmOnResponse([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte, int>)(lpVtbl[17]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.get_CanReply"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_CanReply([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte*, int>)(lpVtbl[18]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.put_CanReply"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_CanReply([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte, int>)(lpVtbl[19]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.get_CanReplyAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_CanReplyAll([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte*, int>)(lpVtbl[20]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.put_CanReplyAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_CanReplyAll([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte, int>)(lpVtbl[21]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.get_ExpirationDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_ExpirationDate([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, WinRTDateTime*, int>)(lpVtbl[22]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.put_ExpirationDate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_ExpirationDate([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, WinRTDateTime, int>)(lpVtbl[23]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.get_IsIrmOriginator"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_IsIrmOriginator([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte*, int>)(lpVtbl[24]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.put_IsIrmOriginator"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_IsIrmOriginator([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte, int>)(lpVtbl[25]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.get_IsProgramaticAccessAllowed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_IsProgramaticAccessAllowed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte*, int>)(lpVtbl[26]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.put_IsProgramaticAccessAllowed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_IsProgramaticAccessAllowed([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, byte, int>)(lpVtbl[27]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.get_Template"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_Template([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailIrmTemplate **")] IEmailIrmTemplate** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, IEmailIrmTemplate**, int>)(lpVtbl[28]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailIrmInfo.xml' path='doc/member[@name="IEmailIrmInfo.put_Template"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_Template([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailIrmTemplate *")] IEmailIrmTemplate* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailIrmInfo*, IEmailIrmTemplate*, int>)(lpVtbl[29]))((IEmailIrmInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CanEdit([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_CanEdit([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_CanExtractData([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_CanExtractData([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_CanForward([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_CanForward([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_CanModifyRecipientsOnResponse([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_CanModifyRecipientsOnResponse([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT get_CanPrintData([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_CanPrintData([NativeTypeName("boolean")] byte value);

        [VtblIndex(16)]
        HRESULT get_CanRemoveIrmOnResponse([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT put_CanRemoveIrmOnResponse([NativeTypeName("boolean")] byte value);

        [VtblIndex(18)]
        HRESULT get_CanReply([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT put_CanReply([NativeTypeName("boolean")] byte value);

        [VtblIndex(20)]
        HRESULT get_CanReplyAll([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(21)]
        HRESULT put_CanReplyAll([NativeTypeName("boolean")] byte value);

        [VtblIndex(22)]
        HRESULT get_ExpirationDate([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(23)]
        HRESULT put_ExpirationDate([NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value);

        [VtblIndex(24)]
        HRESULT get_IsIrmOriginator([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(25)]
        HRESULT put_IsIrmOriginator([NativeTypeName("boolean")] byte value);

        [VtblIndex(26)]
        HRESULT get_IsProgramaticAccessAllowed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(27)]
        HRESULT put_IsProgramaticAccessAllowed([NativeTypeName("boolean")] byte value);

        [VtblIndex(28)]
        HRESULT get_Template([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailIrmTemplate **")] IEmailIrmTemplate** value);

        [VtblIndex(29)]
        HRESULT put_Template([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailIrmTemplate *")] IEmailIrmTemplate* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanEdit;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanEdit;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanExtractData;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanExtractData;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanForward;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanForward;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanModifyRecipientsOnResponse;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanModifyRecipientsOnResponse;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanPrintData;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanPrintData;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanRemoveIrmOnResponse;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanRemoveIrmOnResponse;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanReply;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanReply;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanReplyAll;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanReplyAll;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> get_ExpirationDate;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime, int> put_ExpirationDate;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsIrmOriginator;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsIrmOriginator;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsProgramaticAccessAllowed;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsProgramaticAccessAllowed;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailIrmTemplate **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailIrmTemplate**, int> get_Template;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailIrmTemplate *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailIrmTemplate*, int> put_Template;
    }
}
