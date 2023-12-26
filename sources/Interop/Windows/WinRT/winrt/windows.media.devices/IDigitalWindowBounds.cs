// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDigitalWindowBounds.xml' path='doc/member[@name="IDigitalWindowBounds"]/*' />
[Guid("DD4F21DD-D173-5C6B-8C25-BDD26D5122B1")]
[NativeTypeName("struct IDigitalWindowBounds : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDigitalWindowBounds : IDigitalWindowBounds.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDigitalWindowBounds));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowBounds*, Guid*, void**, int>)(lpVtbl[0]))((IDigitalWindowBounds*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowBounds*, uint>)(lpVtbl[1]))((IDigitalWindowBounds*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowBounds*, uint>)(lpVtbl[2]))((IDigitalWindowBounds*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowBounds*, uint*, Guid**, int>)(lpVtbl[3]))((IDigitalWindowBounds*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowBounds*, HSTRING*, int>)(lpVtbl[4]))((IDigitalWindowBounds*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowBounds*, TrustLevel*, int>)(lpVtbl[5]))((IDigitalWindowBounds*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDigitalWindowBounds.xml' path='doc/member[@name="IDigitalWindowBounds.get_NormalizedOriginTop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NormalizedOriginTop(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowBounds*, double*, int>)(lpVtbl[6]))((IDigitalWindowBounds*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDigitalWindowBounds.xml' path='doc/member[@name="IDigitalWindowBounds.put_NormalizedOriginTop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_NormalizedOriginTop(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowBounds*, double, int>)(lpVtbl[7]))((IDigitalWindowBounds*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDigitalWindowBounds.xml' path='doc/member[@name="IDigitalWindowBounds.get_NormalizedOriginLeft"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_NormalizedOriginLeft(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowBounds*, double*, int>)(lpVtbl[8]))((IDigitalWindowBounds*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDigitalWindowBounds.xml' path='doc/member[@name="IDigitalWindowBounds.put_NormalizedOriginLeft"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_NormalizedOriginLeft(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowBounds*, double, int>)(lpVtbl[9]))((IDigitalWindowBounds*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDigitalWindowBounds.xml' path='doc/member[@name="IDigitalWindowBounds.get_Scale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Scale(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowBounds*, double*, int>)(lpVtbl[10]))((IDigitalWindowBounds*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDigitalWindowBounds.xml' path='doc/member[@name="IDigitalWindowBounds.put_Scale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Scale(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDigitalWindowBounds*, double, int>)(lpVtbl[11]))((IDigitalWindowBounds*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NormalizedOriginTop(double* value);

        [VtblIndex(7)]
        HRESULT put_NormalizedOriginTop(double value);

        [VtblIndex(8)]
        HRESULT get_NormalizedOriginLeft(double* value);

        [VtblIndex(9)]
        HRESULT put_NormalizedOriginLeft(double value);

        [VtblIndex(10)]
        HRESULT get_Scale(double* value);

        [VtblIndex(11)]
        HRESULT put_Scale(double value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_NormalizedOriginTop;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_NormalizedOriginTop;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_NormalizedOriginLeft;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_NormalizedOriginLeft;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> get_Scale;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> put_Scale;
    }
}
