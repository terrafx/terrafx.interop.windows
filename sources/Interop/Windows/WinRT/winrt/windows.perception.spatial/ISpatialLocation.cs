// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpatialLocation.xml' path='doc/member[@name="ISpatialLocation"]/*' />
[Guid("1D81D29D-24A1-37D5-8FA1-39B4F9AD67E2")]
[NativeTypeName("struct ISpatialLocation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialLocation : ISpatialLocation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpatialLocation);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocation*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialLocation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocation*, uint>)(lpVtbl[1]))((ISpatialLocation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocation*, uint>)(lpVtbl[2]))((ISpatialLocation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocation*, uint*, Guid**, int>)(lpVtbl[3]))((ISpatialLocation*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocation*, HSTRING*, int>)(lpVtbl[4]))((ISpatialLocation*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocation*, TrustLevel*, int>)(lpVtbl[5]))((ISpatialLocation*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpatialLocation.xml' path='doc/member[@name="ISpatialLocation.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocation*, Vector3*, int>)(lpVtbl[6]))((ISpatialLocation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialLocation.xml' path='doc/member[@name="ISpatialLocation.get_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Orientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocation*, Quaternion*, int>)(lpVtbl[7]))((ISpatialLocation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialLocation.xml' path='doc/member[@name="ISpatialLocation.get_AbsoluteLinearVelocity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AbsoluteLinearVelocity([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocation*, Vector3*, int>)(lpVtbl[8]))((ISpatialLocation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialLocation.xml' path='doc/member[@name="ISpatialLocation.get_AbsoluteLinearAcceleration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AbsoluteLinearAcceleration([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocation*, Vector3*, int>)(lpVtbl[9]))((ISpatialLocation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialLocation.xml' path='doc/member[@name="ISpatialLocation.get_AbsoluteAngularVelocity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("Use AbsoluteAngularVelocityAxisAngle instead of AbsoluteAngularVelocity. For more info, see MSDN.")]
    public HRESULT get_AbsoluteAngularVelocity([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocation*, Quaternion*, int>)(lpVtbl[10]))((ISpatialLocation*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpatialLocation.xml' path='doc/member[@name="ISpatialLocation.get_AbsoluteAngularAcceleration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("Use AbsoluteAngularAccelerationAxisAngle instead of AbsoluteAngularAcceleration. For more info, see MSDN.")]
    public HRESULT get_AbsoluteAngularAcceleration([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpatialLocation*, Quaternion*, int>)(lpVtbl[11]))((ISpatialLocation*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value);

        [VtblIndex(7)]
        HRESULT get_Orientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value);

        [VtblIndex(8)]
        HRESULT get_AbsoluteLinearVelocity([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value);

        [VtblIndex(9)]
        HRESULT get_AbsoluteLinearAcceleration([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value);

        [VtblIndex(10)]
        [Obsolete("Use AbsoluteAngularVelocityAxisAngle instead of AbsoluteAngularVelocity. For more info, see MSDN.")]
        HRESULT get_AbsoluteAngularVelocity([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value);

        [VtblIndex(11)]
        [Obsolete("Use AbsoluteAngularAccelerationAxisAngle instead of AbsoluteAngularAcceleration. For more info, see MSDN.")]
        HRESULT get_AbsoluteAngularAcceleration([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Quaternion *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Quaternion*, int> get_Orientation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3*, int> get_AbsoluteLinearVelocity;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3*, int> get_AbsoluteLinearAcceleration;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Quaternion *) __attribute__((stdcall))")]
        [Obsolete("Use AbsoluteAngularVelocityAxisAngle instead of AbsoluteAngularVelocity. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Quaternion*, int> get_AbsoluteAngularVelocity;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Quaternion *) __attribute__((stdcall))")]
        [Obsolete("Use AbsoluteAngularAccelerationAxisAngle instead of AbsoluteAngularAcceleration. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Quaternion*, int> get_AbsoluteAngularAcceleration;
    }
}
