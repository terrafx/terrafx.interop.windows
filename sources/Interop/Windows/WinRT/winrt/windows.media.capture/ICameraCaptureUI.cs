// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICameraCaptureUI.xml' path='doc/member[@name="ICameraCaptureUI"]/*' />
[Guid("48587540-6F93-4BB4-B8F3-E89E48948C91")]
[NativeTypeName("struct ICameraCaptureUI : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICameraCaptureUI : ICameraCaptureUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICameraCaptureUI));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUI*, Guid*, void**, int>)(lpVtbl[0]))((ICameraCaptureUI*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUI*, uint>)(lpVtbl[1]))((ICameraCaptureUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUI*, uint>)(lpVtbl[2]))((ICameraCaptureUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUI*, uint*, Guid**, int>)(lpVtbl[3]))((ICameraCaptureUI*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUI*, HSTRING*, int>)(lpVtbl[4]))((ICameraCaptureUI*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUI*, TrustLevel*, int>)(lpVtbl[5]))((ICameraCaptureUI*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICameraCaptureUI.xml' path='doc/member[@name="ICameraCaptureUI.get_PhotoSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PhotoSettings([NativeTypeName("ABI::Windows::Media::Capture::ICameraCaptureUIPhotoCaptureSettings **")] ICameraCaptureUIPhotoCaptureSettings** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUI*, ICameraCaptureUIPhotoCaptureSettings**, int>)(lpVtbl[6]))((ICameraCaptureUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUI.xml' path='doc/member[@name="ICameraCaptureUI.get_VideoSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VideoSettings([NativeTypeName("ABI::Windows::Media::Capture::ICameraCaptureUIVideoCaptureSettings **")] ICameraCaptureUIVideoCaptureSettings** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUI*, ICameraCaptureUIVideoCaptureSettings**, int>)(lpVtbl[7]))((ICameraCaptureUI*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraCaptureUI.xml' path='doc/member[@name="ICameraCaptureUI.CaptureFileAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CaptureFileAsync([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMode")] CameraCaptureUIMode mode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraCaptureUI*, CameraCaptureUIMode, IAsyncOperation<Pointer<IStorageFile>>**, int>)(lpVtbl[8]))((ICameraCaptureUI*)Unsafe.AsPointer(ref this), mode, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PhotoSettings([NativeTypeName("ABI::Windows::Media::Capture::ICameraCaptureUIPhotoCaptureSettings **")] ICameraCaptureUIPhotoCaptureSettings** value);

        [VtblIndex(7)]
        HRESULT get_VideoSettings([NativeTypeName("ABI::Windows::Media::Capture::ICameraCaptureUIVideoCaptureSettings **")] ICameraCaptureUIVideoCaptureSettings** value);

        [VtblIndex(8)]
        HRESULT CaptureFileAsync([NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMode")] CameraCaptureUIMode mode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<Pointer<IStorageFile>>** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::ICameraCaptureUIPhotoCaptureSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICameraCaptureUIPhotoCaptureSettings**, int> get_PhotoSettings;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::ICameraCaptureUIVideoCaptureSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICameraCaptureUIVideoCaptureSettings**, int> get_VideoSettings;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::CameraCaptureUIMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CameraCaptureUIMode, IAsyncOperation<Pointer<IStorageFile>>**, int> CaptureFileAsync;
    }
}
