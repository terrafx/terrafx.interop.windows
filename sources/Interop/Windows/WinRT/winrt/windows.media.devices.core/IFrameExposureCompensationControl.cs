// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFrameExposureCompensationControl.xml' path='doc/member[@name="IFrameExposureCompensationControl"]/*' />
[Guid("E95896C9-F7F9-48CA-8591-A26531CB1578")]
[NativeTypeName("struct IFrameExposureCompensationControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFrameExposureCompensationControl : IFrameExposureCompensationControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFrameExposureCompensationControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCompensationControl*, Guid*, void**, int>)(lpVtbl[0]))((IFrameExposureCompensationControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCompensationControl*, uint>)(lpVtbl[1]))((IFrameExposureCompensationControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCompensationControl*, uint>)(lpVtbl[2]))((IFrameExposureCompensationControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCompensationControl*, uint*, Guid**, int>)(lpVtbl[3]))((IFrameExposureCompensationControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCompensationControl*, HSTRING*, int>)(lpVtbl[4]))((IFrameExposureCompensationControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCompensationControl*, TrustLevel*, int>)(lpVtbl[5]))((IFrameExposureCompensationControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFrameExposureCompensationControl.xml' path='doc/member[@name="IFrameExposureCompensationControl.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Value([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")] IReference<float>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCompensationControl*, IReference<float>**, int>)(lpVtbl[6]))((IFrameExposureCompensationControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFrameExposureCompensationControl.xml' path='doc/member[@name="IFrameExposureCompensationControl.put_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Value([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t *")] IReference<float>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFrameExposureCompensationControl*, IReference<float>*, int>)(lpVtbl[7]))((IFrameExposureCompensationControl*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Value([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")] IReference<float>** value);

        [VtblIndex(7)]
        HRESULT put_Value([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t *")] IReference<float>* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<float>**, int> get_Value;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<float>*, int> put_Value;
    }
}
