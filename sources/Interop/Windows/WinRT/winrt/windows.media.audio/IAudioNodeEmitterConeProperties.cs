// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioNodeEmitterConeProperties.xml' path='doc/member[@name="IAudioNodeEmitterConeProperties"]/*' />
[Guid("E99B2CEE-02CA-4375-9326-0C6AE4BCDFB5")]
[NativeTypeName("struct IAudioNodeEmitterConeProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioNodeEmitterConeProperties : IAudioNodeEmitterConeProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioNodeEmitterConeProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterConeProperties*, Guid*, void**, int>)(lpVtbl[0]))((IAudioNodeEmitterConeProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterConeProperties*, uint>)(lpVtbl[1]))((IAudioNodeEmitterConeProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterConeProperties*, uint>)(lpVtbl[2]))((IAudioNodeEmitterConeProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterConeProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioNodeEmitterConeProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterConeProperties*, HSTRING*, int>)(lpVtbl[4]))((IAudioNodeEmitterConeProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterConeProperties*, TrustLevel*, int>)(lpVtbl[5]))((IAudioNodeEmitterConeProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioNodeEmitterConeProperties.xml' path='doc/member[@name="IAudioNodeEmitterConeProperties.get_InnerAngle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InnerAngle(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterConeProperties*, double*, int>)(lpVtbl[6]))((IAudioNodeEmitterConeProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNodeEmitterConeProperties.xml' path='doc/member[@name="IAudioNodeEmitterConeProperties.get_OuterAngle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_OuterAngle(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterConeProperties*, double*, int>)(lpVtbl[7]))((IAudioNodeEmitterConeProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNodeEmitterConeProperties.xml' path='doc/member[@name="IAudioNodeEmitterConeProperties.get_OuterAngleGain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OuterAngleGain(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterConeProperties*, double*, int>)(lpVtbl[8]))((IAudioNodeEmitterConeProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InnerAngle(double* value);

        [VtblIndex(7)]
        HRESULT get_OuterAngle(double* value);

        [VtblIndex(8)]
        HRESULT get_OuterAngleGain(double* value);
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

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_InnerAngle;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_OuterAngle;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_OuterAngleGain;
    }
}
