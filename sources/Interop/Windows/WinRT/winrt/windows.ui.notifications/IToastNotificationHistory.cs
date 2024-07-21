// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IToastNotificationHistory.xml' path='doc/member[@name="IToastNotificationHistory"]/*' />
[Guid("5CADDC63-01D3-4C97-986F-0533483FEE14")]
[NativeTypeName("struct IToastNotificationHistory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IToastNotificationHistory : IToastNotificationHistory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IToastNotificationHistory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory*, Guid*, void**, int>)(lpVtbl[0]))((IToastNotificationHistory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory*, uint>)(lpVtbl[1]))((IToastNotificationHistory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory*, uint>)(lpVtbl[2]))((IToastNotificationHistory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory*, uint*, Guid**, int>)(lpVtbl[3]))((IToastNotificationHistory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory*, HSTRING*, int>)(lpVtbl[4]))((IToastNotificationHistory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory*, TrustLevel*, int>)(lpVtbl[5]))((IToastNotificationHistory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IToastNotificationHistory.xml' path='doc/member[@name="IToastNotificationHistory.RemoveGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveGroup(HSTRING group)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory*, HSTRING, int>)(lpVtbl[6]))((IToastNotificationHistory*)Unsafe.AsPointer(ref this), group);
    }

    /// <include file='IToastNotificationHistory.xml' path='doc/member[@name="IToastNotificationHistory.RemoveGroupWithId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveGroupWithId(HSTRING group, HSTRING applicationId)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory*, HSTRING, HSTRING, int>)(lpVtbl[7]))((IToastNotificationHistory*)Unsafe.AsPointer(ref this), group, applicationId);
    }

    /// <include file='IToastNotificationHistory.xml' path='doc/member[@name="IToastNotificationHistory.RemoveGroupedTagWithId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveGroupedTagWithId(HSTRING tag, HSTRING group, HSTRING applicationId)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory*, HSTRING, HSTRING, HSTRING, int>)(lpVtbl[8]))((IToastNotificationHistory*)Unsafe.AsPointer(ref this), tag, group, applicationId);
    }

    /// <include file='IToastNotificationHistory.xml' path='doc/member[@name="IToastNotificationHistory.RemoveGroupedTag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveGroupedTag(HSTRING tag, HSTRING group)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory*, HSTRING, HSTRING, int>)(lpVtbl[9]))((IToastNotificationHistory*)Unsafe.AsPointer(ref this), tag, group);
    }

    /// <include file='IToastNotificationHistory.xml' path='doc/member[@name="IToastNotificationHistory.Remove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Remove(HSTRING tag)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory*, HSTRING, int>)(lpVtbl[10]))((IToastNotificationHistory*)Unsafe.AsPointer(ref this), tag);
    }

    /// <include file='IToastNotificationHistory.xml' path='doc/member[@name="IToastNotificationHistory.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory*, int>)(lpVtbl[11]))((IToastNotificationHistory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IToastNotificationHistory.xml' path='doc/member[@name="IToastNotificationHistory.ClearWithId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ClearWithId(HSTRING applicationId)
    {
        return ((delegate* unmanaged[MemberFunction]<IToastNotificationHistory*, HSTRING, int>)(lpVtbl[12]))((IToastNotificationHistory*)Unsafe.AsPointer(ref this), applicationId);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RemoveGroup(HSTRING group);

        [VtblIndex(7)]
        HRESULT RemoveGroupWithId(HSTRING group, HSTRING applicationId);

        [VtblIndex(8)]
        HRESULT RemoveGroupedTagWithId(HSTRING tag, HSTRING group, HSTRING applicationId);

        [VtblIndex(9)]
        HRESULT RemoveGroupedTag(HSTRING tag, HSTRING group);

        [VtblIndex(10)]
        HRESULT Remove(HSTRING tag);

        [VtblIndex(11)]
        HRESULT Clear();

        [VtblIndex(12)]
        HRESULT ClearWithId(HSTRING applicationId);
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

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> RemoveGroup;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, int> RemoveGroupWithId;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, HSTRING, int> RemoveGroupedTagWithId;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, int> RemoveGroupedTag;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> Remove;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Clear;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> ClearWithId;
    }
}
