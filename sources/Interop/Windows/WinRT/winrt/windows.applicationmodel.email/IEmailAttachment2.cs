// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailAttachment2.xml' path='doc/member[@name="IEmailAttachment2"]/*' />
[Guid("225F1070-B0FF-4571-9D54-A706C48D55C6")]
[NativeTypeName("struct IEmailAttachment2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailAttachment2 : IEmailAttachment2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEmailAttachment2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, Guid*, void**, int>)(lpVtbl[0]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, uint>)(lpVtbl[1]))((IEmailAttachment2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, uint>)(lpVtbl[2]))((IEmailAttachment2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, HSTRING*, int>)(lpVtbl[4]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, TrustLevel*, int>)(lpVtbl[5]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailAttachment2.xml' path='doc/member[@name="IEmailAttachment2.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, HSTRING*, int>)(lpVtbl[6]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailAttachment2.xml' path='doc/member[@name="IEmailAttachment2.get_ContentId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ContentId(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, HSTRING*, int>)(lpVtbl[7]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailAttachment2.xml' path='doc/member[@name="IEmailAttachment2.put_ContentId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ContentId(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, HSTRING, int>)(lpVtbl[8]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailAttachment2.xml' path='doc/member[@name="IEmailAttachment2.get_ContentLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ContentLocation(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, HSTRING*, int>)(lpVtbl[9]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailAttachment2.xml' path='doc/member[@name="IEmailAttachment2.put_ContentLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ContentLocation(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, HSTRING, int>)(lpVtbl[10]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailAttachment2.xml' path='doc/member[@name="IEmailAttachment2.get_DownloadState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DownloadState([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailAttachmentDownloadState *")] EmailAttachmentDownloadState* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, EmailAttachmentDownloadState*, int>)(lpVtbl[11]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailAttachment2.xml' path='doc/member[@name="IEmailAttachment2.put_DownloadState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_DownloadState([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailAttachmentDownloadState")] EmailAttachmentDownloadState value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, EmailAttachmentDownloadState, int>)(lpVtbl[12]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailAttachment2.xml' path='doc/member[@name="IEmailAttachment2.get_EstimatedDownloadSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_EstimatedDownloadSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, ulong*, int>)(lpVtbl[13]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailAttachment2.xml' path='doc/member[@name="IEmailAttachment2.put_EstimatedDownloadSizeInBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_EstimatedDownloadSizeInBytes([NativeTypeName("UINT64")] ulong value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, ulong, int>)(lpVtbl[14]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailAttachment2.xml' path='doc/member[@name="IEmailAttachment2.get_IsFromBaseMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsFromBaseMessage([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, byte*, int>)(lpVtbl[15]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailAttachment2.xml' path='doc/member[@name="IEmailAttachment2.get_IsInline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_IsInline([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, byte*, int>)(lpVtbl[16]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailAttachment2.xml' path='doc/member[@name="IEmailAttachment2.put_IsInline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_IsInline([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, byte, int>)(lpVtbl[17]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailAttachment2.xml' path='doc/member[@name="IEmailAttachment2.get_MimeType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_MimeType(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, HSTRING*, int>)(lpVtbl[18]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailAttachment2.xml' path='doc/member[@name="IEmailAttachment2.put_MimeType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_MimeType(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailAttachment2*, HSTRING, int>)(lpVtbl[19]))((IEmailAttachment2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ContentId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_ContentId(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_ContentLocation(HSTRING* value);

        [VtblIndex(10)]
        HRESULT put_ContentLocation(HSTRING value);

        [VtblIndex(11)]
        HRESULT get_DownloadState([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailAttachmentDownloadState *")] EmailAttachmentDownloadState* value);

        [VtblIndex(12)]
        HRESULT put_DownloadState([NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailAttachmentDownloadState")] EmailAttachmentDownloadState value);

        [VtblIndex(13)]
        HRESULT get_EstimatedDownloadSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(14)]
        HRESULT put_EstimatedDownloadSizeInBytes([NativeTypeName("UINT64")] ulong value);

        [VtblIndex(15)]
        HRESULT get_IsFromBaseMessage([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT get_IsInline([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT put_IsInline([NativeTypeName("boolean")] byte value);

        [VtblIndex(18)]
        HRESULT get_MimeType(HSTRING* value);

        [VtblIndex(19)]
        HRESULT put_MimeType(HSTRING value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContentId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ContentId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_ContentLocation;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_ContentLocation;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailAttachmentDownloadState *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailAttachmentDownloadState*, int> get_DownloadState;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::EmailAttachmentDownloadState) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EmailAttachmentDownloadState, int> put_DownloadState;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_EstimatedDownloadSizeInBytes;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, int> put_EstimatedDownloadSizeInBytes;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsFromBaseMessage;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsInline;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsInline;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_MimeType;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_MimeType;
    }
}
