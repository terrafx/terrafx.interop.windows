// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailboxChangeTracker.xml' path='doc/member[@name="IEmailMailboxChangeTracker"]/*' />
[Guid("7AE48638-5166-42B7-8882-FD21C92BDD4B")]
[NativeTypeName("struct IEmailMailboxChangeTracker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxChangeTracker : IEmailMailboxChangeTracker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IEmailMailboxChangeTracker);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeTracker*, Guid*, void**, int>)(lpVtbl[0]))((IEmailMailboxChangeTracker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeTracker*, uint>)(lpVtbl[1]))((IEmailMailboxChangeTracker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeTracker*, uint>)(lpVtbl[2]))((IEmailMailboxChangeTracker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeTracker*, uint*, Guid**, int>)(lpVtbl[3]))((IEmailMailboxChangeTracker*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeTracker*, HSTRING*, int>)(lpVtbl[4]))((IEmailMailboxChangeTracker*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeTracker*, TrustLevel*, int>)(lpVtbl[5]))((IEmailMailboxChangeTracker*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEmailMailboxChangeTracker.xml' path='doc/member[@name="IEmailMailboxChangeTracker.get_IsTracking"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsTracking([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeTracker*, byte*, int>)(lpVtbl[6]))((IEmailMailboxChangeTracker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxChangeTracker.xml' path='doc/member[@name="IEmailMailboxChangeTracker.Enable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Enable()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeTracker*, int>)(lpVtbl[7]))((IEmailMailboxChangeTracker*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEmailMailboxChangeTracker.xml' path='doc/member[@name="IEmailMailboxChangeTracker.GetChangeReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetChangeReader([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxChangeReader **")] IEmailMailboxChangeReader** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeTracker*, IEmailMailboxChangeReader**, int>)(lpVtbl[8]))((IEmailMailboxChangeTracker*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEmailMailboxChangeTracker.xml' path='doc/member[@name="IEmailMailboxChangeTracker.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged[MemberFunction]<IEmailMailboxChangeTracker*, int>)(lpVtbl[9]))((IEmailMailboxChangeTracker*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsTracking([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT Enable();

        [VtblIndex(8)]
        HRESULT GetChangeReader([NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxChangeReader **")] IEmailMailboxChangeReader** value);

        [VtblIndex(9)]
        HRESULT Reset();
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsTracking;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Enable;

        [NativeTypeName("HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxChangeReader **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEmailMailboxChangeReader**, int> GetChangeReader;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Reset;
    }
}
