// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppCaptureManagerStatics.xml' path='doc/member[@name="IAppCaptureManagerStatics"]/*' />
[Guid("7D9E3EA7-6282-4735-8D4E-AA45F90F6723")]
[NativeTypeName("struct IAppCaptureManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppCaptureManagerStatics : IAppCaptureManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppCaptureManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAppCaptureManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureManagerStatics*, uint>)(lpVtbl[1]))((IAppCaptureManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureManagerStatics*, uint>)(lpVtbl[2]))((IAppCaptureManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAppCaptureManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IAppCaptureManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAppCaptureManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppCaptureManagerStatics.xml' path='doc/member[@name="IAppCaptureManagerStatics.GetCurrentSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentSettings([NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureSettings **")] IAppCaptureSettings** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureManagerStatics*, IAppCaptureSettings**, int>)(lpVtbl[6]))((IAppCaptureManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppCaptureManagerStatics.xml' path='doc/member[@name="IAppCaptureManagerStatics.ApplySettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ApplySettings([NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureSettings *")] IAppCaptureSettings* appCaptureSettings)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppCaptureManagerStatics*, IAppCaptureSettings*, int>)(lpVtbl[7]))((IAppCaptureManagerStatics*)Unsafe.AsPointer(ref this), appCaptureSettings);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetCurrentSettings([NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureSettings **")] IAppCaptureSettings** value);

        [VtblIndex(7)]
        HRESULT ApplySettings([NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureSettings *")] IAppCaptureSettings* appCaptureSettings);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppCaptureSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppCaptureSettings**, int> GetCurrentSettings;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppCaptureSettings *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppCaptureSettings*, int> ApplySettings;
    }
}
