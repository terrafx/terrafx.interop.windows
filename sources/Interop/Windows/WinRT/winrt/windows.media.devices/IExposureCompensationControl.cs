// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IExposureCompensationControl.xml' path='doc/member[@name="IExposureCompensationControl"]/*' />
[Guid("81C8E834-DCEC-4011-A610-1F3847E64ACA")]
[NativeTypeName("struct IExposureCompensationControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IExposureCompensationControl : IExposureCompensationControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IExposureCompensationControl);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IExposureCompensationControl*, Guid*, void**, int>)(lpVtbl[0]))((IExposureCompensationControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IExposureCompensationControl*, uint>)(lpVtbl[1]))((IExposureCompensationControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IExposureCompensationControl*, uint>)(lpVtbl[2]))((IExposureCompensationControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IExposureCompensationControl*, uint*, Guid**, int>)(lpVtbl[3]))((IExposureCompensationControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IExposureCompensationControl*, HSTRING*, int>)(lpVtbl[4]))((IExposureCompensationControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IExposureCompensationControl*, TrustLevel*, int>)(lpVtbl[5]))((IExposureCompensationControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IExposureCompensationControl.xml' path='doc/member[@name="IExposureCompensationControl.get_Supported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IExposureCompensationControl*, byte*, int>)(lpVtbl[6]))((IExposureCompensationControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IExposureCompensationControl.xml' path='doc/member[@name="IExposureCompensationControl.get_Min"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Min(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IExposureCompensationControl*, float*, int>)(lpVtbl[7]))((IExposureCompensationControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IExposureCompensationControl.xml' path='doc/member[@name="IExposureCompensationControl.get_Max"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Max(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IExposureCompensationControl*, float*, int>)(lpVtbl[8]))((IExposureCompensationControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IExposureCompensationControl.xml' path='doc/member[@name="IExposureCompensationControl.get_Step"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Step(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IExposureCompensationControl*, float*, int>)(lpVtbl[9]))((IExposureCompensationControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IExposureCompensationControl.xml' path='doc/member[@name="IExposureCompensationControl.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Value(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IExposureCompensationControl*, float*, int>)(lpVtbl[10]))((IExposureCompensationControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IExposureCompensationControl.xml' path='doc/member[@name="IExposureCompensationControl.SetValueAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetValueAsync(float value, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IExposureCompensationControl*, float, IAsyncAction**, int>)(lpVtbl[11]))((IExposureCompensationControl*)Unsafe.AsPointer(ref this), value, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_Min(float* value);

        [VtblIndex(8)]
        HRESULT get_Max(float* value);

        [VtblIndex(9)]
        HRESULT get_Step(float* value);

        [VtblIndex(10)]
        HRESULT get_Value(float* value);

        [VtblIndex(11)]
        HRESULT SetValueAsync(float value, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);
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

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Min;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Max;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Step;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Value;

        [NativeTypeName("HRESULT (FLOAT, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, IAsyncAction**, int> SetValueAsync;
    }
}
