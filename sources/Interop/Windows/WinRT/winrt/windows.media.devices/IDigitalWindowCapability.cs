// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDigitalWindowCapability.xml' path='doc/member[@name="IDigitalWindowCapability"]/*' />
[Guid("D78BAD2C-F721-5244-A196-B56CCBEC606C")]
[NativeTypeName("struct IDigitalWindowCapability : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDigitalWindowCapability : IDigitalWindowCapability.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDigitalWindowCapability));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowCapability*, Guid*, void**, int>)(lpVtbl[0]))((IDigitalWindowCapability*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowCapability*, uint>)(lpVtbl[1]))((IDigitalWindowCapability*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowCapability*, uint>)(lpVtbl[2]))((IDigitalWindowCapability*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowCapability*, uint*, Guid**, int>)(lpVtbl[3]))((IDigitalWindowCapability*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowCapability*, HSTRING*, int>)(lpVtbl[4]))((IDigitalWindowCapability*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowCapability*, TrustLevel*, int>)(lpVtbl[5]))((IDigitalWindowCapability*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDigitalWindowCapability.xml' path='doc/member[@name="IDigitalWindowCapability.get_Width"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Width([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowCapability*, int*, int>)(lpVtbl[6]))((IDigitalWindowCapability*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDigitalWindowCapability.xml' path='doc/member[@name="IDigitalWindowCapability.get_Height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Height([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowCapability*, int*, int>)(lpVtbl[7]))((IDigitalWindowCapability*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDigitalWindowCapability.xml' path='doc/member[@name="IDigitalWindowCapability.get_MinScaleValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinScaleValue(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowCapability*, double*, int>)(lpVtbl[8]))((IDigitalWindowCapability*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDigitalWindowCapability.xml' path='doc/member[@name="IDigitalWindowCapability.get_MaxScaleValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MaxScaleValue(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowCapability*, double*, int>)(lpVtbl[9]))((IDigitalWindowCapability*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDigitalWindowCapability.xml' path='doc/member[@name="IDigitalWindowCapability.get_MinScaleValueWithoutUpsampling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MinScaleValueWithoutUpsampling(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowCapability*, double*, int>)(lpVtbl[10]))((IDigitalWindowCapability*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDigitalWindowCapability.xml' path='doc/member[@name="IDigitalWindowCapability.get_NormalizedFieldOfViewLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_NormalizedFieldOfViewLimit([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowCapability*, Rect*, int>)(lpVtbl[11]))((IDigitalWindowCapability*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Width([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_Height([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_MinScaleValue(double* value);

        [VtblIndex(9)]
        HRESULT get_MaxScaleValue(double* value);

        [VtblIndex(10)]
        HRESULT get_MinScaleValueWithoutUpsampling(double* value);

        [VtblIndex(11)]
        HRESULT get_NormalizedFieldOfViewLimit([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Width;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Height;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MinScaleValue;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MaxScaleValue;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_MinScaleValueWithoutUpsampling;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> get_NormalizedFieldOfViewLimit;
    }
}
