// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpotLight2.xml' path='doc/member[@name="ISpotLight2"]/*' />
[Guid("64EE615E-0686-4DEA-A9E8-BC3A8C701459")]
[NativeTypeName("struct ISpotLight2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpotLight2 : ISpotLight2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpotLight2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight2*, Guid*, void**, int>)(lpVtbl[0]))((ISpotLight2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight2*, uint>)(lpVtbl[1]))((ISpotLight2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight2*, uint>)(lpVtbl[2]))((ISpotLight2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight2*, uint*, Guid**, int>)(lpVtbl[3]))((ISpotLight2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight2*, HSTRING*, int>)(lpVtbl[4]))((ISpotLight2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight2*, TrustLevel*, int>)(lpVtbl[5]))((ISpotLight2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpotLight2.xml' path='doc/member[@name="ISpotLight2.get_InnerConeIntensity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InnerConeIntensity(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight2*, float*, int>)(lpVtbl[6]))((ISpotLight2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpotLight2.xml' path='doc/member[@name="ISpotLight2.put_InnerConeIntensity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_InnerConeIntensity(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight2*, float, int>)(lpVtbl[7]))((ISpotLight2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpotLight2.xml' path='doc/member[@name="ISpotLight2.get_OuterConeIntensity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OuterConeIntensity(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight2*, float*, int>)(lpVtbl[8]))((ISpotLight2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpotLight2.xml' path='doc/member[@name="ISpotLight2.put_OuterConeIntensity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_OuterConeIntensity(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpotLight2*, float, int>)(lpVtbl[9]))((ISpotLight2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InnerConeIntensity(float* value);

        [VtblIndex(7)]
        HRESULT put_InnerConeIntensity(float value);

        [VtblIndex(8)]
        HRESULT get_OuterConeIntensity(float* value);

        [VtblIndex(9)]
        HRESULT put_OuterConeIntensity(float value);
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

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_InnerConeIntensity;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_InnerConeIntensity;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_OuterConeIntensity;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_OuterConeIntensity;
    }
}
