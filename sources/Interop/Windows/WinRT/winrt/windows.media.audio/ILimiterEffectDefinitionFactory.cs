// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ILimiterEffectDefinitionFactory.xml' path='doc/member[@name="ILimiterEffectDefinitionFactory"]/*' />
[Guid("ECBAE6F1-61FF-45EF-B8F5-48659A57C72D")]
[NativeTypeName("struct ILimiterEffectDefinitionFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILimiterEffectDefinitionFactory : ILimiterEffectDefinitionFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILimiterEffectDefinitionFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimiterEffectDefinitionFactory*, Guid*, void**, int>)(lpVtbl[0]))((ILimiterEffectDefinitionFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ILimiterEffectDefinitionFactory*, uint>)(lpVtbl[1]))((ILimiterEffectDefinitionFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ILimiterEffectDefinitionFactory*, uint>)(lpVtbl[2]))((ILimiterEffectDefinitionFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimiterEffectDefinitionFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ILimiterEffectDefinitionFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimiterEffectDefinitionFactory*, HSTRING*, int>)(lpVtbl[4]))((ILimiterEffectDefinitionFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimiterEffectDefinitionFactory*, TrustLevel*, int>)(lpVtbl[5]))((ILimiterEffectDefinitionFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ILimiterEffectDefinitionFactory.xml' path='doc/member[@name="ILimiterEffectDefinitionFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Media::Audio::IAudioGraph *")] IAudioGraph* audioGraph, [NativeTypeName("ABI::Windows::Media::Audio::ILimiterEffectDefinition **")] ILimiterEffectDefinition** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ILimiterEffectDefinitionFactory*, IAudioGraph*, ILimiterEffectDefinition**, int>)(lpVtbl[6]))((ILimiterEffectDefinitionFactory*)Unsafe.AsPointer(ref this), audioGraph, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Media::Audio::IAudioGraph *")] IAudioGraph* audioGraph, [NativeTypeName("ABI::Windows::Media::Audio::ILimiterEffectDefinition **")] ILimiterEffectDefinition** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioGraph *, ABI::Windows::Media::Audio::ILimiterEffectDefinition **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioGraph*, ILimiterEffectDefinition**, int> Create;
    }
}
