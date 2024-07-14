// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICapturedFrameWithSoftwareBitmap.xml' path='doc/member[@name="ICapturedFrameWithSoftwareBitmap"]/*' />
[Guid("B58E8B6E-8503-49B5-9E86-897D26A3FF3D")]
[NativeTypeName("struct ICapturedFrameWithSoftwareBitmap : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICapturedFrameWithSoftwareBitmap : ICapturedFrameWithSoftwareBitmap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICapturedFrameWithSoftwareBitmap));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameWithSoftwareBitmap*, Guid*, void**, int>)(lpVtbl[0]))((ICapturedFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameWithSoftwareBitmap*, uint>)(lpVtbl[1]))((ICapturedFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameWithSoftwareBitmap*, uint>)(lpVtbl[2]))((ICapturedFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameWithSoftwareBitmap*, uint*, Guid**, int>)(lpVtbl[3]))((ICapturedFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameWithSoftwareBitmap*, HSTRING*, int>)(lpVtbl[4]))((ICapturedFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameWithSoftwareBitmap*, TrustLevel*, int>)(lpVtbl[5]))((ICapturedFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICapturedFrameWithSoftwareBitmap.xml' path='doc/member[@name="ICapturedFrameWithSoftwareBitmap.get_SoftwareBitmap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SoftwareBitmap([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICapturedFrameWithSoftwareBitmap*, ISoftwareBitmap**, int>)(lpVtbl[6]))((ICapturedFrameWithSoftwareBitmap*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SoftwareBitmap([NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")] ISoftwareBitmap** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISoftwareBitmap**, int> get_SoftwareBitmap;
    }
}
