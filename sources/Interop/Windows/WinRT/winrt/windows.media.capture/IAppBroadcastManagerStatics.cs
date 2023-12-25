// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppBroadcastManagerStatics.xml' path='doc/member[@name="IAppBroadcastManagerStatics"]/*' />
[Guid("364E018B-1E4E-411F-AB3E-92959844C156")]
[NativeTypeName("struct IAppBroadcastManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastManagerStatics : IAppBroadcastManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IAppBroadcastManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastManagerStatics*, uint>)(lpVtbl[1]))((IAppBroadcastManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastManagerStatics*, uint>)(lpVtbl[2]))((IAppBroadcastManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IAppBroadcastManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IAppBroadcastManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IAppBroadcastManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppBroadcastManagerStatics.xml' path='doc/member[@name="IAppBroadcastManagerStatics.GetGlobalSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetGlobalSettings([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastGlobalSettings **")] IAppBroadcastGlobalSettings** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastManagerStatics*, IAppBroadcastGlobalSettings**, int>)(lpVtbl[6]))((IAppBroadcastManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastManagerStatics.xml' path='doc/member[@name="IAppBroadcastManagerStatics.ApplyGlobalSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ApplyGlobalSettings([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastGlobalSettings *")] IAppBroadcastGlobalSettings* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastManagerStatics*, IAppBroadcastGlobalSettings*, int>)(lpVtbl[7]))((IAppBroadcastManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastManagerStatics.xml' path='doc/member[@name="IAppBroadcastManagerStatics.GetProviderSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetProviderSettings([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastProviderSettings **")] IAppBroadcastProviderSettings** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastManagerStatics*, IAppBroadcastProviderSettings**, int>)(lpVtbl[8]))((IAppBroadcastManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppBroadcastManagerStatics.xml' path='doc/member[@name="IAppBroadcastManagerStatics.ApplyProviderSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ApplyProviderSettings([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastProviderSettings *")] IAppBroadcastProviderSettings* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppBroadcastManagerStatics*, IAppBroadcastProviderSettings*, int>)(lpVtbl[9]))((IAppBroadcastManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetGlobalSettings([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastGlobalSettings **")] IAppBroadcastGlobalSettings** value);

        [VtblIndex(7)]
        HRESULT ApplyGlobalSettings([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastGlobalSettings *")] IAppBroadcastGlobalSettings* value);

        [VtblIndex(8)]
        HRESULT GetProviderSettings([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastProviderSettings **")] IAppBroadcastProviderSettings** value);

        [VtblIndex(9)]
        HRESULT ApplyProviderSettings([NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastProviderSettings *")] IAppBroadcastProviderSettings* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastGlobalSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastGlobalSettings**, int> GetGlobalSettings;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastGlobalSettings *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastGlobalSettings*, int> ApplyGlobalSettings;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastProviderSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastProviderSettings**, int> GetProviderSettings;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::IAppBroadcastProviderSettings *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppBroadcastProviderSettings*, int> ApplyProviderSettings;
    }
}
