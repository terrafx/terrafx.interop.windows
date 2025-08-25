// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBounceEasingFunction.xml' path='doc/member[@name="IBounceEasingFunction"]/*' />
[Guid("E7FDB44B-AAD5-5174-9421-EEF8B75A6A43")]
[NativeTypeName("struct IBounceEasingFunction : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBounceEasingFunction : IBounceEasingFunction.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IBounceEasingFunction);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceEasingFunction*, Guid*, void**, int>)(lpVtbl[0]))((IBounceEasingFunction*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceEasingFunction*, uint>)(lpVtbl[1]))((IBounceEasingFunction*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceEasingFunction*, uint>)(lpVtbl[2]))((IBounceEasingFunction*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceEasingFunction*, uint*, Guid**, int>)(lpVtbl[3]))((IBounceEasingFunction*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceEasingFunction*, HSTRING*, int>)(lpVtbl[4]))((IBounceEasingFunction*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceEasingFunction*, TrustLevel*, int>)(lpVtbl[5]))((IBounceEasingFunction*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBounceEasingFunction.xml' path='doc/member[@name="IBounceEasingFunction.get_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Mode([NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode *")] CompositionEasingFunctionMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceEasingFunction*, CompositionEasingFunctionMode*, int>)(lpVtbl[6]))((IBounceEasingFunction*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBounceEasingFunction.xml' path='doc/member[@name="IBounceEasingFunction.get_Bounces"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Bounces([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceEasingFunction*, int*, int>)(lpVtbl[7]))((IBounceEasingFunction*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBounceEasingFunction.xml' path='doc/member[@name="IBounceEasingFunction.get_Bounciness"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Bounciness(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBounceEasingFunction*, float*, int>)(lpVtbl[8]))((IBounceEasingFunction*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Mode([NativeTypeName("ABI::Windows::UI::Composition::CompositionEasingFunctionMode *")] CompositionEasingFunctionMode* value);

        [VtblIndex(7)]
        HRESULT get_Bounces([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_Bounciness(float* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::Composition::CompositionEasingFunctionMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CompositionEasingFunctionMode*, int> get_Mode;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_Bounces;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Bounciness;
    }
}
