// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionProjectedShadow.xml' path='doc/member[@name="ICompositionProjectedShadow"]/*' />
[Guid("285B8E72-4328-523F-BCF2-5557C52C3B25")]
[NativeTypeName("struct ICompositionProjectedShadow : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionProjectedShadow : ICompositionProjectedShadow.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionProjectedShadow));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, uint>)(lpVtbl[1]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, uint>)(lpVtbl[2]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, HSTRING*, int>)(lpVtbl[4]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionProjectedShadow.xml' path='doc/member[@name="ICompositionProjectedShadow.get_BlurRadiusMultiplier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BlurRadiusMultiplier(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, float*, int>)(lpVtbl[6]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadow.xml' path='doc/member[@name="ICompositionProjectedShadow.put_BlurRadiusMultiplier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_BlurRadiusMultiplier(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, float, int>)(lpVtbl[7]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadow.xml' path='doc/member[@name="ICompositionProjectedShadow.get_Casters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Casters([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCasterCollection **")] ICompositionProjectedShadowCasterCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, ICompositionProjectedShadowCasterCollection**, int>)(lpVtbl[8]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadow.xml' path='doc/member[@name="ICompositionProjectedShadow.get_LightSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_LightSource([NativeTypeName("ABI::Windows::UI::Composition::ICompositionLight **")] ICompositionLight** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, ICompositionLight**, int>)(lpVtbl[9]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadow.xml' path='doc/member[@name="ICompositionProjectedShadow.put_LightSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_LightSource([NativeTypeName("ABI::Windows::UI::Composition::ICompositionLight *")] ICompositionLight* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, ICompositionLight*, int>)(lpVtbl[10]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadow.xml' path='doc/member[@name="ICompositionProjectedShadow.get_MaxBlurRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MaxBlurRadius(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, float*, int>)(lpVtbl[11]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadow.xml' path='doc/member[@name="ICompositionProjectedShadow.put_MaxBlurRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_MaxBlurRadius(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, float, int>)(lpVtbl[12]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadow.xml' path='doc/member[@name="ICompositionProjectedShadow.get_MinBlurRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MinBlurRadius(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, float*, int>)(lpVtbl[13]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadow.xml' path='doc/member[@name="ICompositionProjectedShadow.put_MinBlurRadius"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_MinBlurRadius(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, float, int>)(lpVtbl[14]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionProjectedShadow.xml' path='doc/member[@name="ICompositionProjectedShadow.get_Receivers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Receivers([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiverUnorderedCollection **")] ICompositionProjectedShadowReceiverUnorderedCollection** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionProjectedShadow*, ICompositionProjectedShadowReceiverUnorderedCollection**, int>)(lpVtbl[15]))((ICompositionProjectedShadow*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BlurRadiusMultiplier(float* value);

        [VtblIndex(7)]
        HRESULT put_BlurRadiusMultiplier(float value);

        [VtblIndex(8)]
        HRESULT get_Casters([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowCasterCollection **")] ICompositionProjectedShadowCasterCollection** value);

        [VtblIndex(9)]
        HRESULT get_LightSource([NativeTypeName("ABI::Windows::UI::Composition::ICompositionLight **")] ICompositionLight** value);

        [VtblIndex(10)]
        HRESULT put_LightSource([NativeTypeName("ABI::Windows::UI::Composition::ICompositionLight *")] ICompositionLight* value);

        [VtblIndex(11)]
        HRESULT get_MaxBlurRadius(float* value);

        [VtblIndex(12)]
        HRESULT put_MaxBlurRadius(float value);

        [VtblIndex(13)]
        HRESULT get_MinBlurRadius(float* value);

        [VtblIndex(14)]
        HRESULT put_MinBlurRadius(float value);

        [VtblIndex(15)]
        HRESULT get_Receivers([NativeTypeName("ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiverUnorderedCollection **")] ICompositionProjectedShadowReceiverUnorderedCollection** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_BlurRadiusMultiplier;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_BlurRadiusMultiplier;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadowCasterCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionProjectedShadowCasterCollection**, int> get_Casters;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionLight **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionLight**, int> get_LightSource;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionLight *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionLight*, int> put_LightSource;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_MaxBlurRadius;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_MaxBlurRadius;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_MinBlurRadius;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_MinBlurRadius;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::ICompositionProjectedShadowReceiverUnorderedCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICompositionProjectedShadowReceiverUnorderedCollection**, int> get_Receivers;
    }
}
