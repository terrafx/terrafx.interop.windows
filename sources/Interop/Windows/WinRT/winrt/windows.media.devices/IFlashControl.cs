// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFlashControl.xml' path='doc/member[@name="IFlashControl"]/*' />
[Guid("DEF41DBE-7D68-45E3-8C0F-BE7BB32837D0")]
[NativeTypeName("struct IFlashControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFlashControl : IFlashControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFlashControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, Guid*, void**, int>)(lpVtbl[0]))((IFlashControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, uint>)(lpVtbl[1]))((IFlashControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, uint>)(lpVtbl[2]))((IFlashControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, uint*, Guid**, int>)(lpVtbl[3]))((IFlashControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, HSTRING*, int>)(lpVtbl[4]))((IFlashControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, TrustLevel*, int>)(lpVtbl[5]))((IFlashControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFlashControl.xml' path='doc/member[@name="IFlashControl.get_Supported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, byte*, int>)(lpVtbl[6]))((IFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFlashControl.xml' path='doc/member[@name="IFlashControl.get_PowerSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PowerSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, byte*, int>)(lpVtbl[7]))((IFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFlashControl.xml' path='doc/member[@name="IFlashControl.get_RedEyeReductionSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RedEyeReductionSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, byte*, int>)(lpVtbl[8]))((IFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFlashControl.xml' path='doc/member[@name="IFlashControl.get_Enabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Enabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, byte*, int>)(lpVtbl[9]))((IFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFlashControl.xml' path='doc/member[@name="IFlashControl.put_Enabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Enabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, byte, int>)(lpVtbl[10]))((IFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFlashControl.xml' path='doc/member[@name="IFlashControl.get_Auto"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Auto([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, byte*, int>)(lpVtbl[11]))((IFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFlashControl.xml' path='doc/member[@name="IFlashControl.put_Auto"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Auto([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, byte, int>)(lpVtbl[12]))((IFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFlashControl.xml' path='doc/member[@name="IFlashControl.get_RedEyeReduction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_RedEyeReduction([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, byte*, int>)(lpVtbl[13]))((IFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFlashControl.xml' path='doc/member[@name="IFlashControl.put_RedEyeReduction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_RedEyeReduction([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, byte, int>)(lpVtbl[14]))((IFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFlashControl.xml' path='doc/member[@name="IFlashControl.get_PowerPercent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_PowerPercent(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, float*, int>)(lpVtbl[15]))((IFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFlashControl.xml' path='doc/member[@name="IFlashControl.put_PowerPercent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_PowerPercent(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFlashControl*, float, int>)(lpVtbl[16]))((IFlashControl*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_PowerSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_RedEyeReductionSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_Enabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT put_Enabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_Auto([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT put_Auto([NativeTypeName("boolean")] byte value);

        [VtblIndex(13)]
        HRESULT get_RedEyeReduction([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT put_RedEyeReduction([NativeTypeName("boolean")] byte value);

        [VtblIndex(15)]
        HRESULT get_PowerPercent(float* value);

        [VtblIndex(16)]
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Supported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_PowerSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_RedEyeReductionSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Enabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_Enabled;

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
