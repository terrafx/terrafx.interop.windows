// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPhotoCapturedEventArgs.xml' path='doc/member[@name="IPhotoCapturedEventArgs"]/*' />
[Guid("373BFBC1-984E-4FF0-BF85-1C00AABC5A45")]
[NativeTypeName("struct IPhotoCapturedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhotoCapturedEventArgs : IPhotoCapturedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhotoCapturedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhotoCapturedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhotoCapturedEventArgs*, uint>)(lpVtbl[1]))((IPhotoCapturedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPhotoCapturedEventArgs*, uint>)(lpVtbl[2]))((IPhotoCapturedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhotoCapturedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhotoCapturedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IPhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhotoCapturedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPhotoCapturedEventArgs.xml' path='doc/member[@name="IPhotoCapturedEventArgs.get_Frame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Frame([NativeTypeName("ABI::Windows::Media::Capture::ICapturedFrame **")] ICapturedFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhotoCapturedEventArgs*, ICapturedFrame**, int>)(lpVtbl[6]))((IPhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhotoCapturedEventArgs.xml' path='doc/member[@name="IPhotoCapturedEventArgs.get_Thumbnail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Thumbnail([NativeTypeName("ABI::Windows::Media::Capture::ICapturedFrame **")] ICapturedFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhotoCapturedEventArgs*, ICapturedFrame**, int>)(lpVtbl[7]))((IPhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPhotoCapturedEventArgs.xml' path='doc/member[@name="IPhotoCapturedEventArgs.get_CaptureTimeOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CaptureTimeOffset([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPhotoCapturedEventArgs*, TimeSpan*, int>)(lpVtbl[8]))((IPhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Frame([NativeTypeName("ABI::Windows::Media::Capture::ICapturedFrame **")] ICapturedFrame** value);

        [VtblIndex(7)]
        HRESULT get_Thumbnail([NativeTypeName("ABI::Windows::Media::Capture::ICapturedFrame **")] ICapturedFrame** value);

        [VtblIndex(8)]
        HRESULT get_CaptureTimeOffset([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::ICapturedFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICapturedFrame**, int> get_Frame;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::ICapturedFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICapturedFrame**, int> get_Thumbnail;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_CaptureTimeOffset;
    }
}
