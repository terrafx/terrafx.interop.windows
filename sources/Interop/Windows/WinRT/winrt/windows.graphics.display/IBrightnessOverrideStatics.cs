// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBrightnessOverrideStatics.xml' path='doc/member[@name="IBrightnessOverrideStatics"]/*' />
[Guid("03A7B9ED-E1F1-4A68-A11F-946AD8CE5393")]
[NativeTypeName("struct IBrightnessOverrideStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBrightnessOverrideStatics : IBrightnessOverrideStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBrightnessOverrideStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBrightnessOverrideStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideStatics*, uint>)(lpVtbl[1]))((IBrightnessOverrideStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideStatics*, uint>)(lpVtbl[2]))((IBrightnessOverrideStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBrightnessOverrideStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideStatics*, HSTRING*, int>)(lpVtbl[4]))((IBrightnessOverrideStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBrightnessOverrideStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBrightnessOverrideStatics.xml' path='doc/member[@name="IBrightnessOverrideStatics.GetDefaultForSystem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefaultForSystem([NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverride **")] IBrightnessOverride** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideStatics*, IBrightnessOverride**, int>)(lpVtbl[6]))((IBrightnessOverrideStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBrightnessOverrideStatics.xml' path='doc/member[@name="IBrightnessOverrideStatics.GetForCurrentView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetForCurrentView([NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverride **")] IBrightnessOverride** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideStatics*, IBrightnessOverride**, int>)(lpVtbl[7]))((IBrightnessOverrideStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBrightnessOverrideStatics.xml' path='doc/member[@name="IBrightnessOverrideStatics.SaveForSystemAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SaveForSystemAsync([NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverride *")] IBrightnessOverride* value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IBrightnessOverrideStatics*, IBrightnessOverride*, IAsyncOperation<bool>**, int>)(lpVtbl[8]))((IBrightnessOverrideStatics*)Unsafe.AsPointer(ref this), value, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDefaultForSystem([NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverride **")] IBrightnessOverride** value);

        [VtblIndex(7)]
        HRESULT GetForCurrentView([NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverride **")] IBrightnessOverride** value);

        [VtblIndex(8)]
        HRESULT SaveForSystemAsync([NativeTypeName("ABI::Windows::Graphics::Display::IBrightnessOverride *")] IBrightnessOverride* value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<bool>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::IBrightnessOverride **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBrightnessOverride**, int> GetDefaultForSystem;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::IBrightnessOverride **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBrightnessOverride**, int> GetForCurrentView;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::Display::IBrightnessOverride *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBrightnessOverride*, IAsyncOperation<bool>**, int> SaveForSystemAsync;
    }
}
