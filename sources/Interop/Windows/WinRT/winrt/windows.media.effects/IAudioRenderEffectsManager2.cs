// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioRenderEffectsManager2.xml' path='doc/member[@name="IAudioRenderEffectsManager2"]/*' />
[Guid("A844CD09-5ECC-44B3-BB4E-1DB07287139C")]
[NativeTypeName("struct IAudioRenderEffectsManager2 : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("Not supported starting in windows 10")]
public unsafe partial struct IAudioRenderEffectsManager2 : IAudioRenderEffectsManager2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioRenderEffectsManager2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager2*, Guid*, void**, int>)(lpVtbl[0]))((IAudioRenderEffectsManager2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager2*, uint>)(lpVtbl[1]))((IAudioRenderEffectsManager2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager2*, uint>)(lpVtbl[2]))((IAudioRenderEffectsManager2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager2*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioRenderEffectsManager2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager2*, HSTRING*, int>)(lpVtbl[4]))((IAudioRenderEffectsManager2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager2*, TrustLevel*, int>)(lpVtbl[5]))((IAudioRenderEffectsManager2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioRenderEffectsManager2.xml' path='doc/member[@name="IAudioRenderEffectsManager2.get_EffectsProviderThumbnail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Not supported starting in windows 10")]
    public HRESULT get_EffectsProviderThumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamWithContentType **")] IRandomAccessStreamWithContentType** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager2*, IRandomAccessStreamWithContentType**, int>)(lpVtbl[6]))((IAudioRenderEffectsManager2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioRenderEffectsManager2.xml' path='doc/member[@name="IAudioRenderEffectsManager2.get_EffectsProviderSettingsLabel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Not supported starting in windows 10")]
    public HRESULT get_EffectsProviderSettingsLabel(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager2*, HSTRING*, int>)(lpVtbl[7]))((IAudioRenderEffectsManager2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAudioRenderEffectsManager2.xml' path='doc/member[@name="IAudioRenderEffectsManager2.ShowSettingsUI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Not supported starting in windows 10")]
    public HRESULT ShowSettingsUI()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioRenderEffectsManager2*, int>)(lpVtbl[8]))((IAudioRenderEffectsManager2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Not supported starting in windows 10")]
        HRESULT get_EffectsProviderThumbnail([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamWithContentType **")] IRandomAccessStreamWithContentType** value);

        [VtblIndex(7)]
        [Obsolete("Not supported starting in windows 10")]
        HRESULT get_EffectsProviderSettingsLabel(HSTRING* value);

        [VtblIndex(8)]
        [Obsolete("Not supported starting in windows 10")]
        HRESULT ShowSettingsUI();
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamWithContentType **) __attribute__((stdcall))")]
        [Obsolete("Not supported starting in windows 10")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStreamWithContentType**, int> get_EffectsProviderThumbnail;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("Not supported starting in windows 10")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_EffectsProviderSettingsLabel;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        [Obsolete("Not supported starting in windows 10")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ShowSettingsUI;
    }
}
