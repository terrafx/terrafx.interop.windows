// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMouseWheelParameters.xml' path='doc/member[@name="IMouseWheelParameters"]/*' />
[Guid("EAD0CA44-9DED-4037-8149-5E4CC2564468")]
[NativeTypeName("struct IMouseWheelParameters : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMouseWheelParameters : IMouseWheelParameters.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMouseWheelParameters));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMouseWheelParameters*, Guid*, void**, int>)(lpVtbl[0]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMouseWheelParameters*, uint>)(lpVtbl[1]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMouseWheelParameters*, uint>)(lpVtbl[2]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMouseWheelParameters*, uint*, Guid**, int>)(lpVtbl[3]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMouseWheelParameters*, HSTRING*, int>)(lpVtbl[4]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMouseWheelParameters*, TrustLevel*, int>)(lpVtbl[5]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMouseWheelParameters.xml' path='doc/member[@name="IMouseWheelParameters.get_CharTranslation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CharTranslation([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMouseWheelParameters*, Point*, int>)(lpVtbl[6]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMouseWheelParameters.xml' path='doc/member[@name="IMouseWheelParameters.put_CharTranslation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CharTranslation([NativeTypeName("ABI::Windows::Foundation::Point")] Point value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMouseWheelParameters*, Point, int>)(lpVtbl[7]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMouseWheelParameters.xml' path='doc/member[@name="IMouseWheelParameters.get_DeltaScale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DeltaScale(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMouseWheelParameters*, float*, int>)(lpVtbl[8]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMouseWheelParameters.xml' path='doc/member[@name="IMouseWheelParameters.put_DeltaScale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DeltaScale(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMouseWheelParameters*, float, int>)(lpVtbl[9]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMouseWheelParameters.xml' path='doc/member[@name="IMouseWheelParameters.get_DeltaRotationAngle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DeltaRotationAngle(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMouseWheelParameters*, float*, int>)(lpVtbl[10]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMouseWheelParameters.xml' path='doc/member[@name="IMouseWheelParameters.put_DeltaRotationAngle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_DeltaRotationAngle(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMouseWheelParameters*, float, int>)(lpVtbl[11]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMouseWheelParameters.xml' path='doc/member[@name="IMouseWheelParameters.get_PageTranslation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PageTranslation([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMouseWheelParameters*, Point*, int>)(lpVtbl[12]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMouseWheelParameters.xml' path='doc/member[@name="IMouseWheelParameters.put_PageTranslation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_PageTranslation([NativeTypeName("ABI::Windows::Foundation::Point")] Point value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMouseWheelParameters*, Point, int>)(lpVtbl[13]))((IMouseWheelParameters*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CharTranslation([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(7)]
        HRESULT put_CharTranslation([NativeTypeName("ABI::Windows::Foundation::Point")] Point value);

        [VtblIndex(8)]
        HRESULT get_DeltaScale(float* value);

        [VtblIndex(9)]
        HRESULT put_DeltaScale(float value);

        [VtblIndex(10)]
        HRESULT get_DeltaRotationAngle(float* value);

        [VtblIndex(11)]
        HRESULT put_DeltaRotationAngle(float value);

        [VtblIndex(12)]
        HRESULT get_PageTranslation([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(13)]
        HRESULT put_PageTranslation([NativeTypeName("ABI::Windows::Foundation::Point")] Point value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point*, int> get_CharTranslation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point, int> put_CharTranslation;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_DeltaScale;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_DeltaScale;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_DeltaRotationAngle;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_DeltaRotationAngle;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point*, int> get_PageTranslation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point, int> put_PageTranslation;
    }
}
