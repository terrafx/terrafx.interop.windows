// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailboxCapabilities3.xml' path='doc/member[@name="IEmailMailboxCapabilities3"]/*' />
[Guid("F690E944-56F2-45AA-872C-0CE9F3DB0B5C")]
[NativeTypeName("struct IEmailMailboxCapabilities3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxCapabilities3 : IEmailMailboxCapabilities3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMailboxCapabilities3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, uint>)(lpVtbl[1]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, uint>)(lpVtbl[2]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, HSTRING*, int>)(lpVtbl[4]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMailboxCapabilities3.xml' path='doc/member[@name="IEmailMailboxCapabilities3.put_CanForwardMeetings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_CanForwardMeetings([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, byte, int>)(lpVtbl[6]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities3.xml' path='doc/member[@name="IEmailMailboxCapabilities3.put_CanGetAndSetExternalAutoReplies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CanGetAndSetExternalAutoReplies([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, byte, int>)(lpVtbl[7]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities3.xml' path='doc/member[@name="IEmailMailboxCapabilities3.put_CanGetAndSetInternalAutoReplies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_CanGetAndSetInternalAutoReplies([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, byte, int>)(lpVtbl[8]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities3.xml' path='doc/member[@name="IEmailMailboxCapabilities3.put_CanUpdateMeetingResponses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CanUpdateMeetingResponses([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, byte, int>)(lpVtbl[9]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities3.xml' path='doc/member[@name="IEmailMailboxCapabilities3.put_CanServerSearchFolders"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_CanServerSearchFolders([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, byte, int>)(lpVtbl[10]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities3.xml' path='doc/member[@name="IEmailMailboxCapabilities3.put_CanServerSearchMailbox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CanServerSearchMailbox([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, byte, int>)(lpVtbl[11]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities3.xml' path='doc/member[@name="IEmailMailboxCapabilities3.put_CanProposeNewTimeForMeetings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_CanProposeNewTimeForMeetings([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, byte, int>)(lpVtbl[12]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities3.xml' path='doc/member[@name="IEmailMailboxCapabilities3.put_CanSmartSend"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_CanSmartSend([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, byte, int>)(lpVtbl[13]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities3.xml' path='doc/member[@name="IEmailMailboxCapabilities3.put_CanResolveRecipients"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_CanResolveRecipients([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, byte, int>)(lpVtbl[14]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities3.xml' path='doc/member[@name="IEmailMailboxCapabilities3.put_CanValidateCertificates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_CanValidateCertificates([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, byte, int>)(lpVtbl[15]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities3.xml' path='doc/member[@name="IEmailMailboxCapabilities3.put_CanEmptyFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_CanEmptyFolder([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, byte, int>)(lpVtbl[16]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities3.xml' path='doc/member[@name="IEmailMailboxCapabilities3.put_CanCreateFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_CanCreateFolder([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, byte, int>)(lpVtbl[17]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities3.xml' path='doc/member[@name="IEmailMailboxCapabilities3.put_CanDeleteFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_CanDeleteFolder([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, byte, int>)(lpVtbl[18]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities3.xml' path='doc/member[@name="IEmailMailboxCapabilities3.put_CanMoveFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_CanMoveFolder([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities3*, byte, int>)(lpVtbl[19]))((IEmailMailboxCapabilities3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_CanForwardMeetings([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT put_CanGetAndSetExternalAutoReplies([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT put_CanGetAndSetInternalAutoReplies([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT put_CanUpdateMeetingResponses([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT put_CanServerSearchFolders([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT put_CanServerSearchMailbox([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT put_CanProposeNewTimeForMeetings([NativeTypeName("boolean")] byte value);

        [VtblIndex(13)]
        HRESULT put_CanSmartSend([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT put_CanResolveRecipients([NativeTypeName("boolean")] byte value);

        [VtblIndex(15)]
        HRESULT put_CanValidateCertificates([NativeTypeName("boolean")] byte value);

        [VtblIndex(16)]
        HRESULT put_CanEmptyFolder([NativeTypeName("boolean")] byte value);

        [VtblIndex(17)]
        HRESULT put_CanCreateFolder([NativeTypeName("boolean")] byte value);

        [VtblIndex(18)]
        HRESULT put_CanDeleteFolder([NativeTypeName("boolean")] byte value);

        [VtblIndex(19)]
        HRESULT put_CanMoveFolder([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanForwardMeetings;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanGetAndSetExternalAutoReplies;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanGetAndSetInternalAutoReplies;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanUpdateMeetingResponses;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanServerSearchFolders;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanServerSearchMailbox;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanProposeNewTimeForMeetings;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanSmartSend;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanResolveRecipients;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanValidateCertificates;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanEmptyFolder;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanCreateFolder;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanDeleteFolder;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_CanMoveFolder;
    }
}
