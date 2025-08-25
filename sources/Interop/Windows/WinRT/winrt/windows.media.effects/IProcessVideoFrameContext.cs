// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IProcessVideoFrameContext.xml' path='doc/member[@name="IProcessVideoFrameContext"]/*' />
[Guid("276F0E2B-6461-401E-BA78-0FDAD6114EEC")]
[NativeTypeName("struct IProcessVideoFrameContext : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProcessVideoFrameContext : IProcessVideoFrameContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IProcessVideoFrameContext);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessVideoFrameContext*, Guid*, void**, int>)(lpVtbl[0]))((IProcessVideoFrameContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessVideoFrameContext*, uint>)(lpVtbl[1]))((IProcessVideoFrameContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessVideoFrameContext*, uint>)(lpVtbl[2]))((IProcessVideoFrameContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessVideoFrameContext*, uint*, Guid**, int>)(lpVtbl[3]))((IProcessVideoFrameContext*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessVideoFrameContext*, HSTRING*, int>)(lpVtbl[4]))((IProcessVideoFrameContext*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessVideoFrameContext*, TrustLevel*, int>)(lpVtbl[5]))((IProcessVideoFrameContext*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProcessVideoFrameContext.xml' path='doc/member[@name="IProcessVideoFrameContext.get_InputFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InputFrame([NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessVideoFrameContext*, IVideoFrame**, int>)(lpVtbl[6]))((IProcessVideoFrameContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IProcessVideoFrameContext.xml' path='doc/member[@name="IProcessVideoFrameContext.get_OutputFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_OutputFrame([NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IProcessVideoFrameContext*, IVideoFrame**, int>)(lpVtbl[7]))((IProcessVideoFrameContext*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InputFrame([NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** value);

        [VtblIndex(7)]
        HRESULT get_OutputFrame([NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::IVideoFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoFrame**, int> get_InputFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Media::IVideoFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVideoFrame**, int> get_OutputFrame;
    }
}
