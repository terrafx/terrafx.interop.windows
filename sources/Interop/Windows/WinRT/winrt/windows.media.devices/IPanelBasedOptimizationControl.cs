// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPanelBasedOptimizationControl.xml' path='doc/member[@name="IPanelBasedOptimizationControl"]/*' />
[Guid("33323223-6247-5419-A5A4-3D808645D917")]
[NativeTypeName("struct IPanelBasedOptimizationControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPanelBasedOptimizationControl : IPanelBasedOptimizationControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPanelBasedOptimizationControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPanelBasedOptimizationControl*, Guid*, void**, int>)(lpVtbl[0]))((IPanelBasedOptimizationControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPanelBasedOptimizationControl*, uint>)(lpVtbl[1]))((IPanelBasedOptimizationControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPanelBasedOptimizationControl*, uint>)(lpVtbl[2]))((IPanelBasedOptimizationControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPanelBasedOptimizationControl*, uint*, Guid**, int>)(lpVtbl[3]))((IPanelBasedOptimizationControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPanelBasedOptimizationControl*, HSTRING*, int>)(lpVtbl[4]))((IPanelBasedOptimizationControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPanelBasedOptimizationControl*, TrustLevel*, int>)(lpVtbl[5]))((IPanelBasedOptimizationControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPanelBasedOptimizationControl.xml' path='doc/member[@name="IPanelBasedOptimizationControl.get_IsSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPanelBasedOptimizationControl*, byte*, int>)(lpVtbl[6]))((IPanelBasedOptimizationControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPanelBasedOptimizationControl.xml' path='doc/member[@name="IPanelBasedOptimizationControl.get_Panel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Panel([NativeTypeName("ABI::Windows::Devices::Enumeration::Panel *")] Panel* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPanelBasedOptimizationControl*, Panel*, int>)(lpVtbl[7]))((IPanelBasedOptimizationControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPanelBasedOptimizationControl.xml' path='doc/member[@name="IPanelBasedOptimizationControl.put_Panel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Panel([NativeTypeName("ABI::Windows::Devices::Enumeration::Panel")] Panel value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPanelBasedOptimizationControl*, Panel, int>)(lpVtbl[8]))((IPanelBasedOptimizationControl*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_Panel([NativeTypeName("ABI::Windows::Devices::Enumeration::Panel *")] Panel* value);

        [VtblIndex(8)]
        HRESULT put_Panel([NativeTypeName("ABI::Windows::Devices::Enumeration::Panel")] Panel value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsSupported;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::Panel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Panel*, int> get_Panel;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Enumeration::Panel) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Panel, int> put_Panel;
    }
}
