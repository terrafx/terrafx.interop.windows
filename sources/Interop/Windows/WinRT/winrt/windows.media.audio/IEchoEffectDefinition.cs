// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEchoEffectDefinition.xml' path='doc/member[@name="IEchoEffectDefinition"]/*' />
[Guid("0E4D3FAA-36B8-4C91-B9DA-11F44A8A6610")]
[NativeTypeName("struct IEchoEffectDefinition : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEchoEffectDefinition : IEchoEffectDefinition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEchoEffectDefinition));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEchoEffectDefinition*, Guid*, void**, int>)(lpVtbl[0]))((IEchoEffectDefinition*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEchoEffectDefinition*, uint>)(lpVtbl[1]))((IEchoEffectDefinition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEchoEffectDefinition*, uint>)(lpVtbl[2]))((IEchoEffectDefinition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEchoEffectDefinition*, uint*, Guid**, int>)(lpVtbl[3]))((IEchoEffectDefinition*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEchoEffectDefinition*, HSTRING*, int>)(lpVtbl[4]))((IEchoEffectDefinition*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEchoEffectDefinition*, TrustLevel*, int>)(lpVtbl[5]))((IEchoEffectDefinition*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEchoEffectDefinition.xml' path='doc/member[@name="IEchoEffectDefinition.put_WetDryMix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_WetDryMix(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEchoEffectDefinition*, double, int>)(lpVtbl[6]))((IEchoEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEchoEffectDefinition.xml' path='doc/member[@name="IEchoEffectDefinition.get_WetDryMix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_WetDryMix(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEchoEffectDefinition*, double*, int>)(lpVtbl[7]))((IEchoEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEchoEffectDefinition.xml' path='doc/member[@name="IEchoEffectDefinition.put_Feedback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Feedback(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEchoEffectDefinition*, double, int>)(lpVtbl[8]))((IEchoEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEchoEffectDefinition.xml' path='doc/member[@name="IEchoEffectDefinition.get_Feedback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Feedback(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEchoEffectDefinition*, double*, int>)(lpVtbl[9]))((IEchoEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEchoEffectDefinition.xml' path='doc/member[@name="IEchoEffectDefinition.put_Delay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Delay(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEchoEffectDefinition*, double, int>)(lpVtbl[10]))((IEchoEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IEchoEffectDefinition.xml' path='doc/member[@name="IEchoEffectDefinition.get_Delay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Delay(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEchoEffectDefinition*, double*, int>)(lpVtbl[11]))((IEchoEffectDefinition*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_WetDryMix(double value);

        [VtblIndex(7)]
        HRESULT get_WetDryMix(double* value);

        [VtblIndex(8)]
        HRESULT put_Feedback(double value);

        [VtblIndex(9)]
        HRESULT get_Feedback(double* value);

        [VtblIndex(10)]
        HRESULT put_Delay(double value);

        [VtblIndex(11)]
        HRESULT get_Delay(double* value);
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

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_WetDryMix;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_WetDryMix;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_Feedback;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Feedback;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_Delay;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Delay;
    }
}
