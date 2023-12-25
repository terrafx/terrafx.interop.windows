// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAdaptiveMediaSourceAdvancedSettings.xml' path='doc/member[@name="IAdaptiveMediaSourceAdvancedSettings"]/*' />
[Guid("55DB1680-1AEB-47DC-AA08-9A11610BA45A")]
[NativeTypeName("struct IAdaptiveMediaSourceAdvancedSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveMediaSourceAdvancedSettings : IAdaptiveMediaSourceAdvancedSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdaptiveMediaSourceAdvancedSettings));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceAdvancedSettings*, Guid*, void**, int>)(lpVtbl[0]))((IAdaptiveMediaSourceAdvancedSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceAdvancedSettings*, uint>)(lpVtbl[1]))((IAdaptiveMediaSourceAdvancedSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceAdvancedSettings*, uint>)(lpVtbl[2]))((IAdaptiveMediaSourceAdvancedSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceAdvancedSettings*, uint*, Guid**, int>)(lpVtbl[3]))((IAdaptiveMediaSourceAdvancedSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceAdvancedSettings*, HSTRING*, int>)(lpVtbl[4]))((IAdaptiveMediaSourceAdvancedSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceAdvancedSettings*, TrustLevel*, int>)(lpVtbl[5]))((IAdaptiveMediaSourceAdvancedSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAdaptiveMediaSourceAdvancedSettings.xml' path='doc/member[@name="IAdaptiveMediaSourceAdvancedSettings.get_AllSegmentsIndependent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AllSegmentsIndependent([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceAdvancedSettings*, byte*, int>)(lpVtbl[6]))((IAdaptiveMediaSourceAdvancedSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceAdvancedSettings.xml' path='doc/member[@name="IAdaptiveMediaSourceAdvancedSettings.put_AllSegmentsIndependent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AllSegmentsIndependent([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceAdvancedSettings*, byte, int>)(lpVtbl[7]))((IAdaptiveMediaSourceAdvancedSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceAdvancedSettings.xml' path='doc/member[@name="IAdaptiveMediaSourceAdvancedSettings.get_DesiredBitrateHeadroomRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DesiredBitrateHeadroomRatio([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceAdvancedSettings*, IReference<double>**, int>)(lpVtbl[8]))((IAdaptiveMediaSourceAdvancedSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceAdvancedSettings.xml' path='doc/member[@name="IAdaptiveMediaSourceAdvancedSettings.put_DesiredBitrateHeadroomRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DesiredBitrateHeadroomRatio([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t *")] IReference<double>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceAdvancedSettings*, IReference<double>*, int>)(lpVtbl[9]))((IAdaptiveMediaSourceAdvancedSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceAdvancedSettings.xml' path='doc/member[@name="IAdaptiveMediaSourceAdvancedSettings.get_BitrateDowngradeTriggerRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BitrateDowngradeTriggerRatio([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceAdvancedSettings*, IReference<double>**, int>)(lpVtbl[10]))((IAdaptiveMediaSourceAdvancedSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAdaptiveMediaSourceAdvancedSettings.xml' path='doc/member[@name="IAdaptiveMediaSourceAdvancedSettings.put_BitrateDowngradeTriggerRatio"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_BitrateDowngradeTriggerRatio([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t *")] IReference<double>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAdaptiveMediaSourceAdvancedSettings*, IReference<double>*, int>)(lpVtbl[11]))((IAdaptiveMediaSourceAdvancedSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AllSegmentsIndependent([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_AllSegmentsIndependent([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_DesiredBitrateHeadroomRatio([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);

        [VtblIndex(9)]
        HRESULT put_DesiredBitrateHeadroomRatio([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t *")] IReference<double>* value);

        [VtblIndex(10)]
        HRESULT get_BitrateDowngradeTriggerRatio([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")] IReference<double>** value);

        [VtblIndex(11)]
        HRESULT put_BitrateDowngradeTriggerRatio([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t *")] IReference<double>* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AllSegmentsIndependent;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AllSegmentsIndependent;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_DesiredBitrateHeadroomRatio;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>*, int> put_DesiredBitrateHeadroomRatio;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>**, int> get_BitrateDowngradeTriggerRatio;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<double>*, int> put_BitrateDowngradeTriggerRatio;
    }
}
