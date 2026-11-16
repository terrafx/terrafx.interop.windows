// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.haptics.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IKnownSimpleHapticsControllerWaveformsStatics3.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics3"]/*' />
[Guid("AE480CE4-4AB6-5B2F-AD0B-CB52F37D45FB")]
[NativeTypeName("struct IKnownSimpleHapticsControllerWaveformsStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKnownSimpleHapticsControllerWaveformsStatics3 : IKnownSimpleHapticsControllerWaveformsStatics3.Interface, INativeGuid
{
    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics3.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics3.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IKnownSimpleHapticsControllerWaveformsStatics3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownSimpleHapticsControllerWaveformsStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IKnownSimpleHapticsControllerWaveformsStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownSimpleHapticsControllerWaveformsStatics3*, uint>)(lpVtbl[1]))((IKnownSimpleHapticsControllerWaveformsStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownSimpleHapticsControllerWaveformsStatics3*, uint>)(lpVtbl[2]))((IKnownSimpleHapticsControllerWaveformsStatics3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownSimpleHapticsControllerWaveformsStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IKnownSimpleHapticsControllerWaveformsStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownSimpleHapticsControllerWaveformsStatics3*, HSTRING*, int>)(lpVtbl[4]))((IKnownSimpleHapticsControllerWaveformsStatics3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownSimpleHapticsControllerWaveformsStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IKnownSimpleHapticsControllerWaveformsStatics3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics3.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics3.get_Collide"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Collide([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownSimpleHapticsControllerWaveformsStatics3*, ushort*, int>)(lpVtbl[6]))((IKnownSimpleHapticsControllerWaveformsStatics3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics3.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics3.get_Align"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Align([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownSimpleHapticsControllerWaveformsStatics3*, ushort*, int>)(lpVtbl[7]))((IKnownSimpleHapticsControllerWaveformsStatics3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics3.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics3.get_Step"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Step([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownSimpleHapticsControllerWaveformsStatics3*, ushort*, int>)(lpVtbl[8]))((IKnownSimpleHapticsControllerWaveformsStatics3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IKnownSimpleHapticsControllerWaveformsStatics3.xml' path='doc/member[@name="IKnownSimpleHapticsControllerWaveformsStatics3.get_Grow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Grow([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IKnownSimpleHapticsControllerWaveformsStatics3*, ushort*, int>)(lpVtbl[9]))((IKnownSimpleHapticsControllerWaveformsStatics3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Collide([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(7)]
        HRESULT get_Align([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(8)]
        HRESULT get_Step([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(9)]
        HRESULT get_Grow([NativeTypeName("UINT16 *")] ushort* value);
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

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_Collide;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_Align;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_Step;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> get_Grow;
    }
}
