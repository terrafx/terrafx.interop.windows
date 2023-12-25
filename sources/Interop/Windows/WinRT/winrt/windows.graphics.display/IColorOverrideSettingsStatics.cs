// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IColorOverrideSettingsStatics.xml' path='doc/member[@name="IColorOverrideSettingsStatics"]/*' />
[Guid("B068E05F-C41F-4AC9-AFAB-827AB6248F9A")]
[NativeTypeName("struct IColorOverrideSettingsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IColorOverrideSettingsStatics : IColorOverrideSettingsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IColorOverrideSettingsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IColorOverrideSettingsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IColorOverrideSettingsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IColorOverrideSettingsStatics*, uint>)(lpVtbl[1]))((IColorOverrideSettingsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IColorOverrideSettingsStatics*, uint>)(lpVtbl[2]))((IColorOverrideSettingsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IColorOverrideSettingsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IColorOverrideSettingsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IColorOverrideSettingsStatics*, HSTRING*, int>)(lpVtbl[4]))((IColorOverrideSettingsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IColorOverrideSettingsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IColorOverrideSettingsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IColorOverrideSettingsStatics.xml' path='doc/member[@name="IColorOverrideSettingsStatics.CreateFromDisplayColorOverrideScenario"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromDisplayColorOverrideScenario([NativeTypeName("ABI::Windows::Graphics::Display::DisplayColorOverrideScenario")] DisplayColorOverrideScenario overrideScenario, [NativeTypeName("ABI::Windows::Graphics::Display::IColorOverrideSettings **")] IColorOverrideSettings** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IColorOverrideSettingsStatics*, DisplayColorOverrideScenario, IColorOverrideSettings**, int>)(lpVtbl[6]))((IColorOverrideSettingsStatics*)Unsafe.AsPointer(ref this), overrideScenario, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromDisplayColorOverrideScenario([NativeTypeName("ABI::Windows::Graphics::Display::DisplayColorOverrideScenario")] DisplayColorOverrideScenario overrideScenario, [NativeTypeName("ABI::Windows::Graphics::Display::IColorOverrideSettings **")] IColorOverrideSettings** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::DisplayColorOverrideScenario, ABI::Windows::Graphics::Display::IColorOverrideSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DisplayColorOverrideScenario, IColorOverrideSettings**, int> CreateFromDisplayColorOverrideScenario;
    }
}
