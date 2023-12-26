// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFrameFlashControl.xml' path='doc/member[@name="IFrameFlashControl"]/*' />
[Guid("75D5F6C7-BD45-4FAB-9375-45AC04B332C2")]
[NativeTypeName("struct IFrameFlashControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFrameFlashControl : IFrameFlashControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFrameFlashControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFlashControl*, Guid*, void**, int>)(lpVtbl[0]))((IFrameFlashControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFlashControl*, uint>)(lpVtbl[1]))((IFrameFlashControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFlashControl*, uint>)(lpVtbl[2]))((IFrameFlashControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFlashControl*, uint*, Guid**, int>)(lpVtbl[3]))((IFrameFlashControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFlashControl*, HSTRING*, int>)(lpVtbl[4]))((IFrameFlashControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFlashControl*, TrustLevel*, int>)(lpVtbl[5]))((IFrameFlashControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFrameFlashControl.xml' path='doc/member[@name="IFrameFlashControl.get_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Devices::Core::FrameFlashMode *")] FrameFlashMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFlashControl*, FrameFlashMode*, int>)(lpVtbl[6]))((IFrameFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameFlashControl.xml' path='doc/member[@name="IFrameFlashControl.put_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Mode([NativeTypeName("ABI::Windows::Media::Devices::Core::FrameFlashMode")] FrameFlashMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFlashControl*, FrameFlashMode, int>)(lpVtbl[7]))((IFrameFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameFlashControl.xml' path='doc/member[@name="IFrameFlashControl.get_Auto"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Auto([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFlashControl*, byte*, int>)(lpVtbl[8]))((IFrameFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameFlashControl.xml' path='doc/member[@name="IFrameFlashControl.put_Auto"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Auto([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFlashControl*, byte, int>)(lpVtbl[9]))((IFrameFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameFlashControl.xml' path='doc/member[@name="IFrameFlashControl.get_RedEyeReduction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RedEyeReduction([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFlashControl*, byte*, int>)(lpVtbl[10]))((IFrameFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameFlashControl.xml' path='doc/member[@name="IFrameFlashControl.put_RedEyeReduction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_RedEyeReduction([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFlashControl*, byte, int>)(lpVtbl[11]))((IFrameFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameFlashControl.xml' path='doc/member[@name="IFrameFlashControl.get_PowerPercent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PowerPercent(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFlashControl*, float*, int>)(lpVtbl[12]))((IFrameFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameFlashControl.xml' path='doc/member[@name="IFrameFlashControl.put_PowerPercent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_PowerPercent(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameFlashControl*, float, int>)(lpVtbl[13]))((IFrameFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Devices::Core::FrameFlashMode *")] FrameFlashMode* value);

        [VtblIndex(7)]
        HRESULT put_Mode([NativeTypeName("ABI::Windows::Media::Devices::Core::FrameFlashMode")] FrameFlashMode value);

        [VtblIndex(8)]
        HRESULT get_Auto([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_Auto([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_RedEyeReduction([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_RedEyeReduction([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_PowerPercent(float* value);

        [VtblIndex(13)]
        HRESULT put_PowerPercent(float value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::Core::FrameFlashMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FrameFlashMode*, int> get_Mode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::Core::FrameFlashMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FrameFlashMode, int> put_Mode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Auto;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_Auto;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_RedEyeReduction;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_RedEyeReduction;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_PowerPercent;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_PowerPercent;
    }
}
