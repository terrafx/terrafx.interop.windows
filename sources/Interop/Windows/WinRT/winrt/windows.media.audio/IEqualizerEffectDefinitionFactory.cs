// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IEqualizerEffectDefinitionFactory.xml' path='doc/member[@name="IEqualizerEffectDefinitionFactory"]/*' />
[Guid("D2876FC4-D410-4EB5-9E69-C9AA1277EAF0")]
[NativeTypeName("struct IEqualizerEffectDefinitionFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEqualizerEffectDefinitionFactory : IEqualizerEffectDefinitionFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEqualizerEffectDefinitionFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerEffectDefinitionFactory*, Guid*, void**, int>)(lpVtbl[0]))((IEqualizerEffectDefinitionFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerEffectDefinitionFactory*, uint>)(lpVtbl[1]))((IEqualizerEffectDefinitionFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerEffectDefinitionFactory*, uint>)(lpVtbl[2]))((IEqualizerEffectDefinitionFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerEffectDefinitionFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IEqualizerEffectDefinitionFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerEffectDefinitionFactory*, HSTRING*, int>)(lpVtbl[4]))((IEqualizerEffectDefinitionFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerEffectDefinitionFactory*, TrustLevel*, int>)(lpVtbl[5]))((IEqualizerEffectDefinitionFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IEqualizerEffectDefinitionFactory.xml' path='doc/member[@name="IEqualizerEffectDefinitionFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create([NativeTypeName("ABI::Windows::Media::Audio::IAudioGraph *")] IAudioGraph* audioGraph, [NativeTypeName("ABI::Windows::Media::Audio::IEqualizerEffectDefinition **")] IEqualizerEffectDefinition** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IEqualizerEffectDefinitionFactory*, IAudioGraph*, IEqualizerEffectDefinition**, int>)(lpVtbl[6]))((IEqualizerEffectDefinitionFactory*)Unsafe.AsPointer(ref this), audioGraph, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create([NativeTypeName("ABI::Windows::Media::Audio::IAudioGraph *")] IAudioGraph* audioGraph, [NativeTypeName("ABI::Windows::Media::Audio::IEqualizerEffectDefinition **")] IEqualizerEffectDefinition** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Audio::IAudioGraph *, ABI::Windows::Media::Audio::IEqualizerEffectDefinition **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAudioGraph*, IEqualizerEffectDefinition**, int> Create;
    }
}
