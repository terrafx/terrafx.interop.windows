// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet"]/*' />
[Guid("C9D6D202-5F67-4453-9117-9EADD430D3C2")]
[NativeTypeName("struct ICompositionPropertySet : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionPropertySet : ICompositionPropertySet.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionPropertySet));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, uint>)(lpVtbl[1]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, uint>)(lpVtbl[2]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING*, int>)(lpVtbl[4]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.InsertColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InsertColor(HSTRING propertyName, [NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, Color, int>)(lpVtbl[6]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.InsertMatrix3x2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertMatrix3x2(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2")] Matrix3x2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, Matrix3x2, int>)(lpVtbl[7]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.InsertMatrix4x4"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InsertMatrix4x4(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4")] Matrix4x4 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, Matrix4x4, int>)(lpVtbl[8]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.InsertQuaternion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InsertQuaternion(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, Quaternion, int>)(lpVtbl[9]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.InsertScalar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT InsertScalar(HSTRING propertyName, float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, float, int>)(lpVtbl[10]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.InsertVector2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT InsertVector2(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, Vector2, int>)(lpVtbl[11]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.InsertVector3"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT InsertVector3(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, Vector3, int>)(lpVtbl[12]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.InsertVector4"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT InsertVector4(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector4")] Vector4 value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, Vector4, int>)(lpVtbl[13]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.TryGetColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT TryGetColor(HSTRING propertyName, [NativeTypeName("ABI::Windows::UI::Color *")] Color* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, Color*, CompositionGetValueStatus*, int>)(lpVtbl[14]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value, result);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.TryGetMatrix3x2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT TryGetMatrix3x2(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2 *")] Matrix3x2* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, Matrix3x2*, CompositionGetValueStatus*, int>)(lpVtbl[15]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value, result);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.TryGetMatrix4x4"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT TryGetMatrix4x4(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4 *")] Matrix4x4* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, Matrix4x4*, CompositionGetValueStatus*, int>)(lpVtbl[16]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value, result);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.TryGetQuaternion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT TryGetQuaternion(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, Quaternion*, CompositionGetValueStatus*, int>)(lpVtbl[17]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value, result);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.TryGetScalar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT TryGetScalar(HSTRING propertyName, float* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, float*, CompositionGetValueStatus*, int>)(lpVtbl[18]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value, result);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.TryGetVector2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT TryGetVector2(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, Vector2*, CompositionGetValueStatus*, int>)(lpVtbl[19]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value, result);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.TryGetVector3"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT TryGetVector3(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, Vector3*, CompositionGetValueStatus*, int>)(lpVtbl[20]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value, result);
    }

    /// <include file='ICompositionPropertySet.xml' path='doc/member[@name="ICompositionPropertySet.TryGetVector4"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT TryGetVector4(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector4 *")] Vector4* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionPropertySet*, HSTRING, Vector4*, CompositionGetValueStatus*, int>)(lpVtbl[21]))((ICompositionPropertySet*)Unsafe.AsPointer(ref this), propertyName, value, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT InsertColor(HSTRING propertyName, [NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(7)]
        HRESULT InsertMatrix3x2(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2")] Matrix3x2 value);

        [VtblIndex(8)]
        HRESULT InsertMatrix4x4(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4")] Matrix4x4 value);

        [VtblIndex(9)]
        HRESULT InsertQuaternion(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value);

        [VtblIndex(10)]
        HRESULT InsertScalar(HSTRING propertyName, float value);

        [VtblIndex(11)]
        HRESULT InsertVector2(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value);

        [VtblIndex(12)]
        HRESULT InsertVector3(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value);

        [VtblIndex(13)]
        HRESULT InsertVector4(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector4")] Vector4 value);

        [VtblIndex(14)]
        HRESULT TryGetColor(HSTRING propertyName, [NativeTypeName("ABI::Windows::UI::Color *")] Color* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result);

        [VtblIndex(15)]
        HRESULT TryGetMatrix3x2(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2 *")] Matrix3x2* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result);

        [VtblIndex(16)]
        HRESULT TryGetMatrix4x4(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4 *")] Matrix4x4* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result);

        [VtblIndex(17)]
        HRESULT TryGetQuaternion(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result);

        [VtblIndex(18)]
        HRESULT TryGetScalar(HSTRING propertyName, float* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result);

        [VtblIndex(19)]
        HRESULT TryGetVector2(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result);

        [VtblIndex(20)]
        HRESULT TryGetVector3(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result);

        [VtblIndex(21)]
        HRESULT TryGetVector4(HSTRING propertyName, [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector4 *")] Vector4* value, [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")] CompositionGetValueStatus* result);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Color, int> InsertColor;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Matrix3x2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Matrix3x2, int> InsertMatrix3x2;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Matrix4x4) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Matrix4x4, int> InsertMatrix4x4;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Quaternion) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Quaternion, int> InsertQuaternion;

        [NativeTypeName("HRESULT (HSTRING, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, float, int> InsertScalar;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Vector2, int> InsertVector2;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Vector3, int> InsertVector3;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector4) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Vector4, int> InsertVector4;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Color *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Color*, CompositionGetValueStatus*, int> TryGetColor;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Matrix3x2 *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Matrix3x2*, CompositionGetValueStatus*, int> TryGetMatrix3x2;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Matrix4x4 *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Matrix4x4*, CompositionGetValueStatus*, int> TryGetMatrix4x4;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Quaternion *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Quaternion*, CompositionGetValueStatus*, int> TryGetQuaternion;

        [NativeTypeName("HRESULT (HSTRING, FLOAT *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, float*, CompositionGetValueStatus*, int> TryGetScalar;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector2 *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Vector2*, CompositionGetValueStatus*, int> TryGetVector2;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector3 *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Vector3*, CompositionGetValueStatus*, int> TryGetVector3;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector4 *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, Vector4*, CompositionGetValueStatus*, int> TryGetVector4;
    }
}
