// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaPlayerEffects.xml' path='doc/member[@name="IMediaPlayerEffects"]/*' />
[Guid("85A1DEDA-CAB6-4CC0-8BE3-6035F4DE2591")]
[NativeTypeName("struct IMediaPlayerEffects : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlayerEffects : IMediaPlayerEffects.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlayerEffects));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerEffects*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPlayerEffects*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerEffects*, uint>)(lpVtbl[1]))((IMediaPlayerEffects*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerEffects*, uint>)(lpVtbl[2]))((IMediaPlayerEffects*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerEffects*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaPlayerEffects*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerEffects*, HSTRING*, int>)(lpVtbl[4]))((IMediaPlayerEffects*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerEffects*, TrustLevel*, int>)(lpVtbl[5]))((IMediaPlayerEffects*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaPlayerEffects.xml' path='doc/member[@name="IMediaPlayerEffects.AddAudioEffect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddAudioEffect(HSTRING activatableClassId, [NativeTypeName("boolean")] byte effectOptional, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerEffects*, HSTRING, byte, IPropertySet*, int>)(lpVtbl[6]))((IMediaPlayerEffects*)Unsafe.AsPointer(ref this), activatableClassId, effectOptional, configuration);
    }

    /// <include file='IMediaPlayerEffects.xml' path='doc/member[@name="IMediaPlayerEffects.RemoveAllEffects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveAllEffects()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaPlayerEffects*, int>)(lpVtbl[7]))((IMediaPlayerEffects*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddAudioEffect(HSTRING activatableClassId, [NativeTypeName("boolean")] byte effectOptional, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* configuration);

        [VtblIndex(7)]
        HRESULT RemoveAllEffects();
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

        [NativeTypeName("HRESULT (HSTRING, boolean, ABI::Windows::Foundation::Collections::IPropertySet *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, byte, IPropertySet*, int> AddAudioEffect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> RemoveAllEffects;
    }
}
