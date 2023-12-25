// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRadialControllerControlAcquiredEventArgs2.xml' path='doc/member[@name="IRadialControllerControlAcquiredEventArgs2"]/*' />
[Guid("3D577EF4-3CEE-11E6-B535-001BDC06AB3B")]
[NativeTypeName("struct IRadialControllerControlAcquiredEventArgs2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadialControllerControlAcquiredEventArgs2 : IRadialControllerControlAcquiredEventArgs2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRadialControllerControlAcquiredEventArgs2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerControlAcquiredEventArgs2*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerControlAcquiredEventArgs2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerControlAcquiredEventArgs2*, uint>)(lpVtbl[1]))((IRadialControllerControlAcquiredEventArgs2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerControlAcquiredEventArgs2*, uint>)(lpVtbl[2]))((IRadialControllerControlAcquiredEventArgs2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerControlAcquiredEventArgs2*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerControlAcquiredEventArgs2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerControlAcquiredEventArgs2*, HSTRING*, int>)(lpVtbl[4]))((IRadialControllerControlAcquiredEventArgs2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerControlAcquiredEventArgs2*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerControlAcquiredEventArgs2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRadialControllerControlAcquiredEventArgs2.xml' path='doc/member[@name="IRadialControllerControlAcquiredEventArgs2.get_IsButtonPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsButtonPressed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerControlAcquiredEventArgs2*, byte*, int>)(lpVtbl[6]))((IRadialControllerControlAcquiredEventArgs2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRadialControllerControlAcquiredEventArgs2.xml' path='doc/member[@name="IRadialControllerControlAcquiredEventArgs2.get_SimpleHapticsController"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SimpleHapticsController([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsController **")] ISimpleHapticsController** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRadialControllerControlAcquiredEventArgs2*, ISimpleHapticsController**, int>)(lpVtbl[7]))((IRadialControllerControlAcquiredEventArgs2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsButtonPressed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_SimpleHapticsController([NativeTypeName("ABI::Windows::Devices::Haptics::ISimpleHapticsController **")] ISimpleHapticsController** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsButtonPressed;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Haptics::ISimpleHapticsController **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISimpleHapticsController**, int> get_SimpleHapticsController;
    }
}
