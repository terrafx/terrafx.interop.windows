// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDetectedPerson.xml' path='doc/member[@name="IDetectedPerson"]/*' />
[Guid("168CC0D9-3F05-5029-A0BF-CDCAB4BE3F9E")]
[NativeTypeName("struct IDetectedPerson : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDetectedPerson : IDetectedPerson.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDetectedPerson);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDetectedPerson*, Guid*, void**, int>)(lpVtbl[0]))((IDetectedPerson*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDetectedPerson*, uint>)(lpVtbl[1]))((IDetectedPerson*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDetectedPerson*, uint>)(lpVtbl[2]))((IDetectedPerson*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDetectedPerson*, uint*, Guid**, int>)(lpVtbl[3]))((IDetectedPerson*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDetectedPerson*, HSTRING*, int>)(lpVtbl[4]))((IDetectedPerson*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDetectedPerson*, TrustLevel*, int>)(lpVtbl[5]))((IDetectedPerson*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDetectedPerson.xml' path='doc/member[@name="IDetectedPerson.get_Engagement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Engagement([NativeTypeName("ABI::Windows::Devices::Sensors::HumanEngagement *")] HumanEngagement* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDetectedPerson*, HumanEngagement*, int>)(lpVtbl[6]))((IDetectedPerson*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDetectedPerson.xml' path='doc/member[@name="IDetectedPerson.get_DistanceInMillimeters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDetectedPerson*, IReference<uint>**, int>)(lpVtbl[7]))((IDetectedPerson*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDetectedPerson.xml' path='doc/member[@name="IDetectedPerson.get_HeadOrientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_HeadOrientation([NativeTypeName("ABI::Windows::Devices::Sensors::IHeadOrientation **")] IHeadOrientation** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDetectedPerson*, IHeadOrientation**, int>)(lpVtbl[8]))((IDetectedPerson*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDetectedPerson.xml' path='doc/member[@name="IDetectedPerson.get_HeadPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_HeadPosition([NativeTypeName("ABI::Windows::Devices::Sensors::IHeadPosition **")] IHeadPosition** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDetectedPerson*, IHeadPosition**, int>)(lpVtbl[9]))((IDetectedPerson*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDetectedPerson.xml' path='doc/member[@name="IDetectedPerson.get_PersonId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PersonId([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDetectedPerson*, IReference<int>**, int>)(lpVtbl[10]))((IDetectedPerson*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Engagement([NativeTypeName("ABI::Windows::Devices::Sensors::HumanEngagement *")] HumanEngagement* value);

        [VtblIndex(7)]
        HRESULT get_DistanceInMillimeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(8)]
        HRESULT get_HeadOrientation([NativeTypeName("ABI::Windows::Devices::Sensors::IHeadOrientation **")] IHeadOrientation** value);

        [VtblIndex(9)]
        HRESULT get_HeadPosition([NativeTypeName("ABI::Windows::Devices::Sensors::IHeadPosition **")] IHeadPosition** value);

        [VtblIndex(10)]
        HRESULT get_PersonId([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")] IReference<int>** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::HumanEngagement *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HumanEngagement*, int> get_Engagement;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_DistanceInMillimeters;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IHeadOrientation **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHeadOrientation**, int> get_HeadOrientation;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IHeadPosition **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHeadPosition**, int> get_HeadPosition;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<int>**, int> get_PersonId;
    }
}
