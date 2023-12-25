// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISensorRotationMatrix.xml' path='doc/member[@name="ISensorRotationMatrix"]/*' />
[Guid("0A3D5A67-22F4-4392-9538-65D0BD064AA6")]
[NativeTypeName("struct ISensorRotationMatrix : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISensorRotationMatrix : ISensorRotationMatrix.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISensorRotationMatrix));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorRotationMatrix*, Guid*, void**, int>)(lpVtbl[0]))((ISensorRotationMatrix*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorRotationMatrix*, uint>)(lpVtbl[1]))((ISensorRotationMatrix*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorRotationMatrix*, uint>)(lpVtbl[2]))((ISensorRotationMatrix*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorRotationMatrix*, uint*, Guid**, int>)(lpVtbl[3]))((ISensorRotationMatrix*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorRotationMatrix*, HSTRING*, int>)(lpVtbl[4]))((ISensorRotationMatrix*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorRotationMatrix*, TrustLevel*, int>)(lpVtbl[5]))((ISensorRotationMatrix*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISensorRotationMatrix.xml' path='doc/member[@name="ISensorRotationMatrix.get_M11"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_M11(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorRotationMatrix*, float*, int>)(lpVtbl[6]))((ISensorRotationMatrix*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISensorRotationMatrix.xml' path='doc/member[@name="ISensorRotationMatrix.get_M12"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_M12(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorRotationMatrix*, float*, int>)(lpVtbl[7]))((ISensorRotationMatrix*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISensorRotationMatrix.xml' path='doc/member[@name="ISensorRotationMatrix.get_M13"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_M13(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorRotationMatrix*, float*, int>)(lpVtbl[8]))((ISensorRotationMatrix*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISensorRotationMatrix.xml' path='doc/member[@name="ISensorRotationMatrix.get_M21"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_M21(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorRotationMatrix*, float*, int>)(lpVtbl[9]))((ISensorRotationMatrix*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISensorRotationMatrix.xml' path='doc/member[@name="ISensorRotationMatrix.get_M22"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_M22(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorRotationMatrix*, float*, int>)(lpVtbl[10]))((ISensorRotationMatrix*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISensorRotationMatrix.xml' path='doc/member[@name="ISensorRotationMatrix.get_M23"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_M23(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorRotationMatrix*, float*, int>)(lpVtbl[11]))((ISensorRotationMatrix*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISensorRotationMatrix.xml' path='doc/member[@name="ISensorRotationMatrix.get_M31"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_M31(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorRotationMatrix*, float*, int>)(lpVtbl[12]))((ISensorRotationMatrix*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISensorRotationMatrix.xml' path='doc/member[@name="ISensorRotationMatrix.get_M32"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_M32(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorRotationMatrix*, float*, int>)(lpVtbl[13]))((ISensorRotationMatrix*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISensorRotationMatrix.xml' path='doc/member[@name="ISensorRotationMatrix.get_M33"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_M33(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISensorRotationMatrix*, float*, int>)(lpVtbl[14]))((ISensorRotationMatrix*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_M11(float* value);

        [VtblIndex(7)]
        HRESULT get_M12(float* value);

        [VtblIndex(8)]
        HRESULT get_M13(float* value);

        [VtblIndex(9)]
        HRESULT get_M21(float* value);

        [VtblIndex(10)]
        HRESULT get_M22(float* value);

        [VtblIndex(11)]
        HRESULT get_M23(float* value);

        [VtblIndex(12)]
        HRESULT get_M31(float* value);

        [VtblIndex(13)]
        HRESULT get_M32(float* value);

        [VtblIndex(14)]
        HRESULT get_M33(float* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_M11;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_M12;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_M13;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_M21;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_M22;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_M23;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_M31;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_M32;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_M33;
    }
}
