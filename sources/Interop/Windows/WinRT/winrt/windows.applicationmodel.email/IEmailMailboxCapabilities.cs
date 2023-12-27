// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailboxCapabilities.xml' path='doc/member[@name="IEmailMailboxCapabilities"]/*' />
[Guid("EEDEC3A6-89DB-4305-82C4-439E0A33DA11")]
[NativeTypeName("struct IEmailMailboxCapabilities : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxCapabilities : IEmailMailboxCapabilities.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMailboxCapabilities));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMailboxCapabilities*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities*, uint>)(lpVtbl[1]))((IEmailMailboxCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities*, uint>)(lpVtbl[2]))((IEmailMailboxCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMailboxCapabilities*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities*, HSTRING*, int>)(lpVtbl[4]))((IEmailMailboxCapabilities*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMailboxCapabilities*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMailboxCapabilities.xml' path='doc/member[@name="IEmailMailboxCapabilities.get_CanForwardMeetings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CanForwardMeetings([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities*, byte*, int>)(lpVtbl[6]))((IEmailMailboxCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities.xml' path='doc/member[@name="IEmailMailboxCapabilities.get_CanGetAndSetExternalAutoReplies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CanGetAndSetExternalAutoReplies([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities*, byte*, int>)(lpVtbl[7]))((IEmailMailboxCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities.xml' path='doc/member[@name="IEmailMailboxCapabilities.get_CanGetAndSetInternalAutoReplies"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CanGetAndSetInternalAutoReplies([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities*, byte*, int>)(lpVtbl[8]))((IEmailMailboxCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities.xml' path='doc/member[@name="IEmailMailboxCapabilities.get_CanUpdateMeetingResponses"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CanUpdateMeetingResponses([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities*, byte*, int>)(lpVtbl[9]))((IEmailMailboxCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities.xml' path='doc/member[@name="IEmailMailboxCapabilities.get_CanServerSearchFolders"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CanServerSearchFolders([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities*, byte*, int>)(lpVtbl[10]))((IEmailMailboxCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities.xml' path='doc/member[@name="IEmailMailboxCapabilities.get_CanServerSearchMailbox"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CanServerSearchMailbox([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities*, byte*, int>)(lpVtbl[11]))((IEmailMailboxCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities.xml' path='doc/member[@name="IEmailMailboxCapabilities.get_CanProposeNewTimeForMeetings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CanProposeNewTimeForMeetings([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities*, byte*, int>)(lpVtbl[12]))((IEmailMailboxCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities.xml' path='doc/member[@name="IEmailMailboxCapabilities.get_CanSmartSend"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_CanSmartSend([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities*, byte*, int>)(lpVtbl[13]))((IEmailMailboxCapabilities*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CanForwardMeetings([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_CanGetAndSetExternalAutoReplies([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_CanGetAndSetInternalAutoReplies([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_CanUpdateMeetingResponses([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_CanServerSearchFolders([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_CanServerSearchMailbox([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT get_CanProposeNewTimeForMeetings([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT get_CanSmartSend([NativeTypeName("boolean *")] byte* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanForwardMeetings;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanGetAndSetExternalAutoReplies;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanGetAndSetInternalAutoReplies;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanUpdateMeetingResponses;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanServerSearchFolders;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanServerSearchMailbox;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanProposeNewTimeForMeetings;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanSmartSend;
    }
}
