// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITileUpdater2.xml' path='doc/member[@name="ITileUpdater2"]/*' />
[Guid("A2266E12-15EE-43ED-83F5-65B352BB1A84")]
[NativeTypeName("struct ITileUpdater2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITileUpdater2 : ITileUpdater2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITileUpdater2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater2*, Guid*, void**, int>)(lpVtbl[0]))((ITileUpdater2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater2*, uint>)(lpVtbl[1]))((ITileUpdater2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater2*, uint>)(lpVtbl[2]))((ITileUpdater2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater2*, uint*, Guid**, int>)(lpVtbl[3]))((ITileUpdater2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater2*, HSTRING*, int>)(lpVtbl[4]))((ITileUpdater2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater2*, TrustLevel*, int>)(lpVtbl[5]))((ITileUpdater2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITileUpdater2.xml' path='doc/member[@name="ITileUpdater2.EnableNotificationQueueForSquare150x150"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnableNotificationQueueForSquare150x150([NativeTypeName("boolean")] byte enable)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater2*, byte, int>)(lpVtbl[6]))((ITileUpdater2*)Unsafe.AsPointer(ref this), enable);
    }

    /// <include file='ITileUpdater2.xml' path='doc/member[@name="ITileUpdater2.EnableNotificationQueueForWide310x150"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnableNotificationQueueForWide310x150([NativeTypeName("boolean")] byte enable)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater2*, byte, int>)(lpVtbl[7]))((ITileUpdater2*)Unsafe.AsPointer(ref this), enable);
    }

    /// <include file='ITileUpdater2.xml' path='doc/member[@name="ITileUpdater2.EnableNotificationQueueForSquare310x310"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnableNotificationQueueForSquare310x310([NativeTypeName("boolean")] byte enable)
    {
        return ((delegate* unmanaged[MemberFunction]<ITileUpdater2*, byte, int>)(lpVtbl[8]))((ITileUpdater2*)Unsafe.AsPointer(ref this), enable);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT EnableNotificationQueueForSquare150x150([NativeTypeName("boolean")] byte enable);

        [VtblIndex(7)]
        HRESULT EnableNotificationQueueForWide310x150([NativeTypeName("boolean")] byte enable);

        [VtblIndex(8)]
        HRESULT EnableNotificationQueueForSquare310x310([NativeTypeName("boolean")] byte enable);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> EnableNotificationQueueForSquare150x150;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> EnableNotificationQueueForWide310x150;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> EnableNotificationQueueForSquare310x310;
    }
}
