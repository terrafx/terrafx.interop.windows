// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioNodeListener.xml' path='doc/member[@name="IAudioNodeListener"]/*' />
[Guid("D9722E16-0C0A-41DA-B755-6C77835FB1EB")]
[NativeTypeName("struct IAudioNodeListener : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioNodeListener : IAudioNodeListener.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioNodeListener));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeListener*, Guid*, void**, int>)(lpVtbl[0]))((IAudioNodeListener*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeListener*, uint>)(lpVtbl[1]))((IAudioNodeListener*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeListener*, uint>)(lpVtbl[2]))((IAudioNodeListener*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeListener*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioNodeListener*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeListener*, HSTRING*, int>)(lpVtbl[4]))((IAudioNodeListener*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeListener*, TrustLevel*, int>)(lpVtbl[5]))((IAudioNodeListener*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioNodeListener.xml' path='doc/member[@name="IAudioNodeListener.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeListener*, Vector3*, int>)(lpVtbl[6]))((IAudioNodeListener*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNodeListener.xml' path='doc/member[@name="IAudioNodeListener.put_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Position([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeListener*, Vector3, int>)(lpVtbl[7]))((IAudioNodeListener*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNodeListener.xml' path='doc/member[@name="IAudioNodeListener.get_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Orientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeListener*, Quaternion*, int>)(lpVtbl[8]))((IAudioNodeListener*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNodeListener.xml' path='doc/member[@name="IAudioNodeListener.put_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Orientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeListener*, Quaternion, int>)(lpVtbl[9]))((IAudioNodeListener*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNodeListener.xml' path='doc/member[@name="IAudioNodeListener.get_SpeedOfSound"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SpeedOfSound(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeListener*, double*, int>)(lpVtbl[10]))((IAudioNodeListener*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNodeListener.xml' path='doc/member[@name="IAudioNodeListener.put_SpeedOfSound"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_SpeedOfSound(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeListener*, double, int>)(lpVtbl[11]))((IAudioNodeListener*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNodeListener.xml' path='doc/member[@name="IAudioNodeListener.get_DopplerVelocity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DopplerVelocity([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeListener*, Vector3*, int>)(lpVtbl[12]))((IAudioNodeListener*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioNodeListener.xml' path='doc/member[@name="IAudioNodeListener.put_DopplerVelocity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_DopplerVelocity([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioNodeListener*, Vector3, int>)(lpVtbl[13]))((IAudioNodeListener*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Position([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value);

        [VtblIndex(7)]
        HRESULT put_Position([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value);

        [VtblIndex(8)]
        HRESULT get_Orientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value);

        [VtblIndex(9)]
        HRESULT put_Orientation([NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value);

        [VtblIndex(10)]
        HRESULT get_SpeedOfSound(double* value);

        [VtblIndex(11)]
        HRESULT put_SpeedOfSound(double value);

        [VtblIndex(12)]
        HRESULT get_DopplerVelocity([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value);

        [VtblIndex(13)]
        HRESULT put_DopplerVelocity([NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3*, int> get_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, int> put_Position;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Quaternion *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Quaternion*, int> get_Orientation;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Quaternion) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Quaternion, int> put_Orientation;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_SpeedOfSound;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_SpeedOfSound;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3*, int> get_DopplerVelocity;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Vector3, int> put_DopplerVelocity;
    }
}
