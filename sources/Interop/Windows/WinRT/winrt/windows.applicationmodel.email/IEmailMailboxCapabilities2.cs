// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailboxCapabilities2.xml' path='doc/member[@name="IEmailMailboxCapabilities2"]/*' />
[Guid("69723EE4-2F21-4CBC-88AB-2E7602A4806B")]
[NativeTypeName("struct IEmailMailboxCapabilities2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxCapabilities2 : IEmailMailboxCapabilities2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMailboxCapabilities2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities2*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMailboxCapabilities2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities2*, uint>)(lpVtbl[1]))((IEmailMailboxCapabilities2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities2*, uint>)(lpVtbl[2]))((IEmailMailboxCapabilities2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities2*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMailboxCapabilities2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities2*, HSTRING*, int>)(lpVtbl[4]))((IEmailMailboxCapabilities2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities2*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMailboxCapabilities2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMailboxCapabilities2.xml' path='doc/member[@name="IEmailMailboxCapabilities2.get_CanResolveRecipients"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CanResolveRecipients([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities2*, byte*, int>)(lpVtbl[6]))((IEmailMailboxCapabilities2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities2.xml' path='doc/member[@name="IEmailMailboxCapabilities2.get_CanValidateCertificates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CanValidateCertificates([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities2*, byte*, int>)(lpVtbl[7]))((IEmailMailboxCapabilities2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities2.xml' path='doc/member[@name="IEmailMailboxCapabilities2.get_CanEmptyFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CanEmptyFolder([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities2*, byte*, int>)(lpVtbl[8]))((IEmailMailboxCapabilities2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities2.xml' path='doc/member[@name="IEmailMailboxCapabilities2.get_CanCreateFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CanCreateFolder([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities2*, byte*, int>)(lpVtbl[9]))((IEmailMailboxCapabilities2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities2.xml' path='doc/member[@name="IEmailMailboxCapabilities2.get_CanDeleteFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CanDeleteFolder([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities2*, byte*, int>)(lpVtbl[10]))((IEmailMailboxCapabilities2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxCapabilities2.xml' path='doc/member[@name="IEmailMailboxCapabilities2.get_CanMoveFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_CanMoveFolder([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxCapabilities2*, byte*, int>)(lpVtbl[11]))((IEmailMailboxCapabilities2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CanResolveRecipients([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_CanValidateCertificates([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_CanEmptyFolder([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_CanCreateFolder([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_CanDeleteFolder([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_CanMoveFolder([NativeTypeName("boolean *")] byte* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanResolveRecipients;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanValidateCertificates;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanEmptyFolder;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanCreateFolder;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanDeleteFolder;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanMoveFolder;
    }
}
