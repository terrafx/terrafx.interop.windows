// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardAppletIdGroupFactory.xml' path='doc/member[@name="ISmartCardAppletIdGroupFactory"]/*' />
[Guid("9105EB4D-4A65-4E41-8061-CBE83F3695E5")]
[NativeTypeName("struct ISmartCardAppletIdGroupFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardAppletIdGroupFactory : ISmartCardAppletIdGroupFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmartCardAppletIdGroupFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupFactory*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardAppletIdGroupFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupFactory*, uint>)(lpVtbl[1]))((ISmartCardAppletIdGroupFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupFactory*, uint>)(lpVtbl[2]))((ISmartCardAppletIdGroupFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardAppletIdGroupFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupFactory*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardAppletIdGroupFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupFactory*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardAppletIdGroupFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardAppletIdGroupFactory.xml' path='doc/member[@name="ISmartCardAppletIdGroupFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(HSTRING displayName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t *")] IVector<Pointer<IBuffer>>* appletIds, [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory")] SmartCardEmulationCategory emulationCategory, [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationType")] SmartCardEmulationType emulationType, [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroup **")] ISmartCardAppletIdGroup** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroupFactory*, HSTRING, IVector<Pointer<IBuffer>>*, SmartCardEmulationCategory, SmartCardEmulationType, ISmartCardAppletIdGroup**, int>)(lpVtbl[6]))((ISmartCardAppletIdGroupFactory*)Unsafe.AsPointer(ref this), displayName, appletIds, emulationCategory, emulationType, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(HSTRING displayName, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t *")] IVector<Pointer<IBuffer>>* appletIds, [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory")] SmartCardEmulationCategory emulationCategory, [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationType")] SmartCardEmulationType emulationType, [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroup **")] ISmartCardAppletIdGroup** result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t *, ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory, ABI::Windows::Devices::SmartCards::SmartCardEmulationType, ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IVector<Pointer<IBuffer>>*, SmartCardEmulationCategory, SmartCardEmulationType, ISmartCardAppletIdGroup**, int> Create;
    }
}
