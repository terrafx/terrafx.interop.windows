// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWICDisplayAdaptationControl.xml' path='doc/member[@name="IWICDisplayAdaptationControl"]/*' />
[Guid("DE9D91D2-70B4-4F41-836C-25FCD39626D3")]
[NativeTypeName("struct IWICDisplayAdaptationControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICDisplayAdaptationControl : IWICDisplayAdaptationControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWICDisplayAdaptationControl);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl*, Guid*, void**, int>)(lpVtbl[0]))((IWICDisplayAdaptationControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl*, uint>)(lpVtbl[1]))((IWICDisplayAdaptationControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl*, uint>)(lpVtbl[2]))((IWICDisplayAdaptationControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICDisplayAdaptationControl.xml' path='doc/member[@name="IWICDisplayAdaptationControl.DoesSupportChangingMaxLuminance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DoesSupportChangingMaxLuminance([NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat, BOOL* pfIsSupported)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl*, Guid*, BOOL*, int>)(lpVtbl[3]))((IWICDisplayAdaptationControl*)Unsafe.AsPointer(ref this), pguidDstFormat, pfIsSupported);
    }

    /// <include file='IWICDisplayAdaptationControl.xml' path='doc/member[@name="IWICDisplayAdaptationControl.SetDisplayMaxLuminance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetDisplayMaxLuminance(float fLuminanceInNits)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl*, float, int>)(lpVtbl[4]))((IWICDisplayAdaptationControl*)Unsafe.AsPointer(ref this), fLuminanceInNits);
    }

    /// <include file='IWICDisplayAdaptationControl.xml' path='doc/member[@name="IWICDisplayAdaptationControl.GetDisplayMaxLuminance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDisplayMaxLuminance(float* pfLuminanceInNits)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICDisplayAdaptationControl*, float*, int>)(lpVtbl[5]))((IWICDisplayAdaptationControl*)Unsafe.AsPointer(ref this), pfLuminanceInNits);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DoesSupportChangingMaxLuminance([NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat, BOOL* pfIsSupported);

        [VtblIndex(4)]
        HRESULT SetDisplayMaxLuminance(float fLuminanceInNits);

        [VtblIndex(5)]
        HRESULT GetDisplayMaxLuminance(float* pfLuminanceInNits);
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

        [NativeTypeName("HRESULT (WICPixelFormatGUID *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, BOOL*, int> DoesSupportChangingMaxLuminance;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> SetDisplayMaxLuminance;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> GetDisplayMaxLuminance;
    }
}
