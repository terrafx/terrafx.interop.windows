// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioNodeEmitterShapeStatics.xml' path='doc/member[@name="IAudioNodeEmitterShapeStatics"]/*' />
[Guid("57BB2771-FFA5-4B86-A779-E264AEB9145F")]
[NativeTypeName("struct IAudioNodeEmitterShapeStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioNodeEmitterShapeStatics : IAudioNodeEmitterShapeStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioNodeEmitterShapeStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShapeStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAudioNodeEmitterShapeStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShapeStatics*, uint>)(lpVtbl[1]))((IAudioNodeEmitterShapeStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShapeStatics*, uint>)(lpVtbl[2]))((IAudioNodeEmitterShapeStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShapeStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioNodeEmitterShapeStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShapeStatics*, HSTRING*, int>)(lpVtbl[4]))((IAudioNodeEmitterShapeStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShapeStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAudioNodeEmitterShapeStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioNodeEmitterShapeStatics.xml' path='doc/member[@name="IAudioNodeEmitterShapeStatics.CreateCone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateCone(double innerAngle, double outerAngle, double outerAngleGain, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterShape **")] IAudioNodeEmitterShape** shape)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShapeStatics*, double, double, double, IAudioNodeEmitterShape**, int>)(lpVtbl[6]))((IAudioNodeEmitterShapeStatics*)Unsafe.AsPointer(ref this), innerAngle, outerAngle, outerAngleGain, shape);
    }

    /// <include file='IAudioNodeEmitterShapeStatics.xml' path='doc/member[@name="IAudioNodeEmitterShapeStatics.CreateOmnidirectional"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateOmnidirectional([NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterShape **")] IAudioNodeEmitterShape** shape)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeEmitterShapeStatics*, IAudioNodeEmitterShape**, int>)(lpVtbl[7]))((IAudioNodeEmitterShapeStatics*)Unsafe.AsPointer(ref this), shape);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateCone(double innerAngle, double outerAngle, double outerAngleGain, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterShape **")] IAudioNodeEmitterShape** shape);

        [VtblIndex(7)]
        HRESULT CreateOmnidirectional([NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterShape **")] IAudioNodeEmitterShape** shape);
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

        [NativeTypeName("HRESULT (DOUBLE, DOUBLE, DOUBLE, ABI::Windows::Media::Audio::IAudioNodeEmitterShape **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, double, double, IAudioNodeEmitterShape**, int> CreateCone;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioNodeEmitterShape **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioNodeEmitterShape**, int> CreateOmnidirectional;
    }
}
