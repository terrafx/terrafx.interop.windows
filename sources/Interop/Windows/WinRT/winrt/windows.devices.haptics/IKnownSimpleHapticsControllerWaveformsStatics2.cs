// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKnownSimpleHapticsControllerWaveformsStatics2.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics2"]/*' />
[Guid("A7D24C27-B79D-510A-BF79-FF6D49173E1D")]
[NativeTypeName("struct IKnownSimpleHapticsControllerWaveformsStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKnownSimpleHapticsControllerWaveformsStatics2 : IKnownSimpleHapticsControllerWaveformsStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKnownSimpleHapticsControllerWaveformsStatics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, uint>)(lpVtbl[1]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, uint>)(lpVtbl[2]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, HSTRING*, int>)(lpVtbl[4]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics2.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics2.get_BrushContinuous"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BrushContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, ushort*, int>)(lpVtbl[6]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics2.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics2.get_ChiselMarkerContinuous"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ChiselMarkerContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, ushort*, int>)(lpVtbl[7]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics2.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics2.get_EraserContinuous"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_EraserContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, ushort*, int>)(lpVtbl[8]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics2.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics2.get_Error"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Error([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, ushort*, int>)(lpVtbl[9]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics2.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics2.get_GalaxyPenContinuous"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_GalaxyPenContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, ushort*, int>)(lpVtbl[10]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics2.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics2.get_Hover"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Hover([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, ushort*, int>)(lpVtbl[11]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics2.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics2.get_InkContinuous"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_InkContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, ushort*, int>)(lpVtbl[12]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics2.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics2.get_MarkerContinuous"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MarkerContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, ushort*, int>)(lpVtbl[13]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics2.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics2.get_PencilContinuous"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PencilContinuous([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, ushort*, int>)(lpVtbl[14]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics2.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics2.get_Success"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Success([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IKnownSimpleHapticsControllerWaveformsStatics2*, ushort*, int>)(lpVtbl[15]))((IKnownSimpleHapticsControllerWaveformsStatics2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BrushContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(7)]
        HRESULT get_ChiselMarkerContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(8)]
        HRESULT get_EraserContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(9)]
        HRESULT get_Error([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(10)]
        HRESULT get_GalaxyPenContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(11)]
        HRESULT get_Hover([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(12)]
        HRESULT get_InkContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(13)]
        HRESULT get_MarkerContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(14)]
        HRESULT get_PencilContinuous([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(15)]
        HRESULT get_Success([NativeTypeName("UINT16 *")] ushort* value);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_BrushContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_ChiselMarkerContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_EraserContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Error;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_GalaxyPenContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Hover;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_InkContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_MarkerContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_PencilContinuous;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_Success;
    }
}
