// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHumanPresenceSensor3.xml' path='doc/member[@name="IHumanPresenceSensor3"]/*' />
[Guid("963F006D-090D-532C-9EAF-803A9F69285B")]
[NativeTypeName("struct IHumanPresenceSensor3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHumanPresenceSensor3 : IHumanPresenceSensor3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHumanPresenceSensor3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensor3*, Guid*, void**, int>)(lpVtbl[0]))((IHumanPresenceSensor3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensor3*, uint>)(lpVtbl[1]))((IHumanPresenceSensor3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensor3*, uint>)(lpVtbl[2]))((IHumanPresenceSensor3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensor3*, uint*, Guid**, int>)(lpVtbl[3]))((IHumanPresenceSensor3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensor3*, HSTRING*, int>)(lpVtbl[4]))((IHumanPresenceSensor3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensor3*, TrustLevel*, int>)(lpVtbl[5]))((IHumanPresenceSensor3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHumanPresenceSensor3.xml' path='doc/member[@name="IHumanPresenceSensor3.get_MaxDetectablePersons"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MaxDetectablePersons([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensor3*, int*, int>)(lpVtbl[6]))((IHumanPresenceSensor3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSensor3.xml' path='doc/member[@name="IHumanPresenceSensor3.get_MinDetectableAzimuthInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MinDetectableAzimuthInDegrees([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensor3*, IReference<double>**, int>)(lpVtbl[7]))((IHumanPresenceSensor3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSensor3.xml' path='doc/member[@name="IHumanPresenceSensor3.get_MaxDetectableAzimuthInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxDetectableAzimuthInDegrees([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensor3*, IReference<double>**, int>)(lpVtbl[8]))((IHumanPresenceSensor3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSensor3.xml' path='doc/member[@name="IHumanPresenceSensor3.get_MinDetectableAltitudeInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MinDetectableAltitudeInDegrees([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensor3*, IReference<double>**, int>)(lpVtbl[9]))((IHumanPresenceSensor3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IHumanPresenceSensor3.xml' path='doc/member[@name="IHumanPresenceSensor3.get_MaxDetectableAltitudeInDegrees"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MaxDetectableAltitudeInDegrees([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensor3*, IReference<double>**, int>)(lpVtbl[10]))((IHumanPresenceSensor3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MaxDetectablePersons([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_MinDetectableAzimuthInDegrees([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);

        [VtblIndex(8)]
        HRESULT get_MaxDetectableAzimuthInDegrees([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);

        [VtblIndex(9)]
        HRESULT get_MinDetectableAltitudeInDegrees([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);

        [VtblIndex(10)]
        HRESULT get_MaxDetectableAltitudeInDegrees([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MaxDetectablePersons;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_MinDetectableAzimuthInDegrees;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_MaxDetectableAzimuthInDegrees;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_MinDetectableAltitudeInDegrees;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_MaxDetectableAltitudeInDegrees;
    }
}
