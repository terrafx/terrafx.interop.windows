// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBrightnessOverrideSettingsStatics.xml' path='doc/member[@name="IBrightnessOverrideSettingsStatics"]/*' />
[Guid("D487DC90-6F74-440B-B383-5FE96CF00B0F")]
[NativeTypeName("struct IBrightnessOverrideSettingsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBrightnessOverrideSettingsStatics : IBrightnessOverrideSettingsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBrightnessOverrideSettingsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideSettingsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBrightnessOverrideSettingsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideSettingsStatics*, uint>)(lpVtbl[1]))((IBrightnessOverrideSettingsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideSettingsStatics*, uint>)(lpVtbl[2]))((IBrightnessOverrideSettingsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideSettingsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBrightnessOverrideSettingsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideSettingsStatics*, HSTRING*, int>)(lpVtbl[4]))((IBrightnessOverrideSettingsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideSettingsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBrightnessOverrideSettingsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBrightnessOverrideSettingsStatics.xml' path='doc/member[@name="IBrightnessOverrideSettingsStatics.CreateFromLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromLevel(double level, [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")] IBrightnessOverrideSettings** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideSettingsStatics*, double, IBrightnessOverrideSettings**, int>)(lpVtbl[6]))((IBrightnessOverrideSettingsStatics*)Unsafe.AsPointer(ref this), level, result);
    }

    /// <include file='IBrightnessOverrideSettingsStatics.xml' path='doc/member[@name="IBrightnessOverrideSettingsStatics.CreateFromNits"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromNits(float nits, [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")] IBrightnessOverrideSettings** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideSettingsStatics*, float, IBrightnessOverrideSettings**, int>)(lpVtbl[7]))((IBrightnessOverrideSettingsStatics*)Unsafe.AsPointer(ref this), nits, result);
    }

    /// <include file='IBrightnessOverrideSettingsStatics.xml' path='doc/member[@name="IBrightnessOverrideSettingsStatics.CreateFromDisplayBrightnessOverrideScenario"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromDisplayBrightnessOverrideScenario([NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessOverrideScenario")] DisplayBrightnessOverrideScenario overrideScenario, [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")] IBrightnessOverrideSettings** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideSettingsStatics*, DisplayBrightnessOverrideScenario, IBrightnessOverrideSettings**, int>)(lpVtbl[8]))((IBrightnessOverrideSettingsStatics*)Unsafe.AsPointer(ref this), overrideScenario, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromLevel(double level, [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")] IBrightnessOverrideSettings** result);

        [VtblIndex(7)]
        HRESULT CreateFromNits(float nits, [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")] IBrightnessOverrideSettings** result);

        [VtblIndex(8)]
        HRESULT CreateFromDisplayBrightnessOverrideScenario([NativeTypeName("ABI::Windows::Graphics::Display::DisplayBrightnessOverrideScenario")] DisplayBrightnessOverrideScenario overrideScenario, [NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **")] IBrightnessOverrideSettings** result);
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

        [NativeTypeName("HRESULT (DOUBLE, ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, IBrightnessOverrideSettings**, int> CreateFromLevel;

        [NativeTypeName("HRESULT (FLOAT, ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, IBrightnessOverrideSettings**, int> CreateFromNits;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::DisplayBrightnessOverrideScenario, ABI::Windows::Graphics::Display::IBrightnessOverrideSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DisplayBrightnessOverrideScenario, IBrightnessOverrideSettings**, int> CreateFromDisplayBrightnessOverrideScenario;
    }
}
