// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IUISettingsController.xml' path='doc/member[@name="IUISettingsController"]/*' />
[Guid("78A51AC4-15C0-5A1B-A75B-ACBF9CB8BB9E")]
[NativeTypeName("struct IUISettingsController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUISettingsController : IUISettingsController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUISettingsController));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettingsController*, Guid*, void**, int>)(lpVtbl[0]))((IUISettingsController*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettingsController*, uint>)(lpVtbl[1]))((IUISettingsController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettingsController*, uint>)(lpVtbl[2]))((IUISettingsController*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettingsController*, uint*, Guid**, int>)(lpVtbl[3]))((IUISettingsController*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettingsController*, HSTRING*, int>)(lpVtbl[4]))((IUISettingsController*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettingsController*, TrustLevel*, int>)(lpVtbl[5]))((IUISettingsController*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUISettingsController.xml' path='doc/member[@name="IUISettingsController.SetAdvancedEffectsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAdvancedEffectsEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettingsController*, byte, int>)(lpVtbl[6]))((IUISettingsController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUISettingsController.xml' path='doc/member[@name="IUISettingsController.SetAnimationsEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetAnimationsEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettingsController*, byte, int>)(lpVtbl[7]))((IUISettingsController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUISettingsController.xml' path='doc/member[@name="IUISettingsController.SetAutoHideScrollBars"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetAutoHideScrollBars([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettingsController*, byte, int>)(lpVtbl[8]))((IUISettingsController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUISettingsController.xml' path='doc/member[@name="IUISettingsController.SetMessageDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetMessageDuration([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettingsController*, uint, int>)(lpVtbl[9]))((IUISettingsController*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUISettingsController.xml' path='doc/member[@name="IUISettingsController.SetTextScaleFactor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetTextScaleFactor(double value)
    {
        return ((delegate* unmanaged[MemberFunction]<IUISettingsController*, double, int>)(lpVtbl[10]))((IUISettingsController*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetAdvancedEffectsEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT SetAnimationsEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT SetAutoHideScrollBars([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT SetMessageDuration([NativeTypeName("UINT32")] uint value);

        [VtblIndex(10)]
        HRESULT SetTextScaleFactor(double value);
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> SetAdvancedEffectsEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> SetAnimationsEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> SetAutoHideScrollBars;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetMessageDuration;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> SetTextScaleFactor;
    }
}
