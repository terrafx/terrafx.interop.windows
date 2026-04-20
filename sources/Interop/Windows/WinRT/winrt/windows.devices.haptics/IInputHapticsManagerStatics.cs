// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IInputHapticsManagerStatics.xml' path='doc/member[@name="IInputHapticsManagerStatics"]/*' />
[Guid("7BB40F77-E187-5322-844E-AA58223C281A")]
[NativeTypeName("struct IInputHapticsManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IInputHapticsManagerStatics : IInputHapticsManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IInputHapticsManagerStatics);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IInputHapticsManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManagerStatics*, uint>)(lpVtbl[1]))((IInputHapticsManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManagerStatics*, uint>)(lpVtbl[2]))((IInputHapticsManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IInputHapticsManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IInputHapticsManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IInputHapticsManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IInputHapticsManagerStatics.xml' path='doc/member[@name="IInputHapticsManagerStatics.IsSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsSupported([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManagerStatics*, byte*, int>)(lpVtbl[6]))((IInputHapticsManagerStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IInputHapticsManagerStatics.xml' path='doc/member[@name="IInputHapticsManagerStatics.IsHapticDevicePresent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsHapticDevicePresent([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManagerStatics*, byte*, int>)(lpVtbl[7]))((IInputHapticsManagerStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IInputHapticsManagerStatics.xml' path='doc/member[@name="IInputHapticsManagerStatics.GetForCurrentThread"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetForCurrentThread([NativeTypeName("ABI::Windows::Devices::Haptics::IInputHapticsManager **")] IInputHapticsManager** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManagerStatics*, IInputHapticsManager**, int>)(lpVtbl[8]))((IInputHapticsManagerStatics*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IInputHapticsManagerStatics.xml' path='doc/member[@name="IInputHapticsManagerStatics.TryGetForThread"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TryGetForThread([NativeTypeName("UINT32")] uint ThreadId, [NativeTypeName("ABI::Windows::Devices::Haptics::IInputHapticsManager **")] IInputHapticsManager** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputHapticsManagerStatics*, uint, IInputHapticsManager**, int>)(lpVtbl[9]))((IInputHapticsManagerStatics*)Unsafe.AsPointer(ref this), ThreadId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsSupported([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(7)]
        HRESULT IsHapticDevicePresent([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(8)]
        HRESULT GetForCurrentThread([NativeTypeName("ABI::Windows::Devices::Haptics::IInputHapticsManager **")] IInputHapticsManager** result);

        [VtblIndex(9)]
        HRESULT TryGetForThread([NativeTypeName("UINT32")] uint ThreadId, [NativeTypeName("ABI::Windows::Devices::Haptics::IInputHapticsManager **")] IInputHapticsManager** result);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> IsSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> IsHapticDevicePresent;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Haptics::IInputHapticsManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputHapticsManager**, int> GetForCurrentThread;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Devices::Haptics::IInputHapticsManager **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IInputHapticsManager**, int> TryGetForThread;
    }
}
