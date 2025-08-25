// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.extensions.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintNotificationEventDetails.xml' path='doc/member[@name="IPrintNotificationEventDetails"]/*' />
[Guid("E00E4C8A-4828-4DA1-8BB8-8672DF8515E7")]
[NativeTypeName("struct IPrintNotificationEventDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintNotificationEventDetails : IPrintNotificationEventDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintNotificationEventDetails);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintNotificationEventDetails*, Guid*, void**, int>)(lpVtbl[0]))((IPrintNotificationEventDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintNotificationEventDetails*, uint>)(lpVtbl[1]))((IPrintNotificationEventDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintNotificationEventDetails*, uint>)(lpVtbl[2]))((IPrintNotificationEventDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintNotificationEventDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintNotificationEventDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintNotificationEventDetails*, HSTRING*, int>)(lpVtbl[4]))((IPrintNotificationEventDetails*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintNotificationEventDetails*, TrustLevel*, int>)(lpVtbl[5]))((IPrintNotificationEventDetails*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintNotificationEventDetails.xml' path='doc/member[@name="IPrintNotificationEventDetails.get_PrinterName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PrinterName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintNotificationEventDetails*, HSTRING*, int>)(lpVtbl[6]))((IPrintNotificationEventDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintNotificationEventDetails.xml' path='doc/member[@name="IPrintNotificationEventDetails.get_EventData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_EventData(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintNotificationEventDetails*, HSTRING*, int>)(lpVtbl[7]))((IPrintNotificationEventDetails*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintNotificationEventDetails.xml' path='doc/member[@name="IPrintNotificationEventDetails.put_EventData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_EventData(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintNotificationEventDetails*, HSTRING, int>)(lpVtbl[8]))((IPrintNotificationEventDetails*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PrinterName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_EventData(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_EventData(HSTRING value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_PrinterName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_EventData;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_EventData;
    }
}
