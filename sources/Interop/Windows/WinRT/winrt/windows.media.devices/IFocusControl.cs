// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFocusControl.xml' path='doc/member[@name="IFocusControl"]/*' />
[Guid("C0D889F6-5228-4453-B153-85606592B238")]
[NativeTypeName("struct IFocusControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFocusControl : IFocusControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFocusControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, Guid*, void**, int>)(lpVtbl[0]))((IFocusControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, uint>)(lpVtbl[1]))((IFocusControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, uint>)(lpVtbl[2]))((IFocusControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, uint*, Guid**, int>)(lpVtbl[3]))((IFocusControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, HSTRING*, int>)(lpVtbl[4]))((IFocusControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, TrustLevel*, int>)(lpVtbl[5]))((IFocusControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFocusControl.xml' path='doc/member[@name="IFocusControl.get_Supported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, byte*, int>)(lpVtbl[6]))((IFocusControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusControl.xml' path='doc/member[@name="IFocusControl.get_SupportedPresets"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SupportedPresets([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CFocusPreset_t **")] IVectorView<FocusPreset>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, IVectorView<FocusPreset>**, int>)(lpVtbl[7]))((IFocusControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusControl.xml' path='doc/member[@name="IFocusControl.get_Preset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Preset([NativeTypeName("ABI::Windows::Media::Devices::FocusPreset *")] FocusPreset* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, FocusPreset*, int>)(lpVtbl[8]))((IFocusControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusControl.xml' path='doc/member[@name="IFocusControl.SetPresetAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetPresetAsync([NativeTypeName("ABI::Windows::Media::Devices::FocusPreset")] FocusPreset preset, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, FocusPreset, IAsyncAction**, int>)(lpVtbl[9]))((IFocusControl*)Unsafe.AsPointer(ref this), preset, asyncInfo);
    }

    /// <include file='IFocusControl.xml' path='doc/member[@name="IFocusControl.SetPresetWithCompletionOptionAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPresetWithCompletionOptionAsync([NativeTypeName("ABI::Windows::Media::Devices::FocusPreset")] FocusPreset preset, [NativeTypeName("boolean")] byte completeBeforeFocus, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, FocusPreset, byte, IAsyncAction**, int>)(lpVtbl[10]))((IFocusControl*)Unsafe.AsPointer(ref this), preset, completeBeforeFocus, asyncInfo);
    }

    /// <include file='IFocusControl.xml' path='doc/member[@name="IFocusControl.get_Min"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Min([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, uint*, int>)(lpVtbl[11]))((IFocusControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusControl.xml' path='doc/member[@name="IFocusControl.get_Max"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Max([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, uint*, int>)(lpVtbl[12]))((IFocusControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusControl.xml' path='doc/member[@name="IFocusControl.get_Step"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Step([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, uint*, int>)(lpVtbl[13]))((IFocusControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusControl.xml' path='doc/member[@name="IFocusControl.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Value([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, uint*, int>)(lpVtbl[14]))((IFocusControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusControl.xml' path='doc/member[@name="IFocusControl.SetValueAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetValueAsync([NativeTypeName("UINT32")] uint focus, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, uint, IAsyncAction**, int>)(lpVtbl[15]))((IFocusControl*)Unsafe.AsPointer(ref this), focus, asyncInfo);
    }

    /// <include file='IFocusControl.xml' path='doc/member[@name="IFocusControl.FocusAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT FocusAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusControl*, IAsyncAction**, int>)(lpVtbl[16]))((IFocusControl*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_SupportedPresets([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CFocusPreset_t **")] IVectorView<FocusPreset>** value);

        [VtblIndex(8)]
        HRESULT get_Preset([NativeTypeName("ABI::Windows::Media::Devices::FocusPreset *")] FocusPreset* value);

        [VtblIndex(9)]
        HRESULT SetPresetAsync([NativeTypeName("ABI::Windows::Media::Devices::FocusPreset")] FocusPreset preset, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(10)]
        HRESULT SetPresetWithCompletionOptionAsync([NativeTypeName("ABI::Windows::Media::Devices::FocusPreset")] FocusPreset preset, [NativeTypeName("boolean")] byte completeBeforeFocus, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(11)]
        HRESULT get_Min([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT get_Max([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT get_Step([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        HRESULT get_Value([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(15)]
        HRESULT SetValueAsync([NativeTypeName("UINT32")] uint focus, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);

        [VtblIndex(16)]
        HRESULT FocusAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Supported;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CFocusPreset_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<FocusPreset>**, int> get_SupportedPresets;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::FocusPreset *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FocusPreset*, int> get_Preset;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::FocusPreset, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FocusPreset, IAsyncAction**, int> SetPresetAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::FocusPreset, boolean, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FocusPreset, byte, IAsyncAction**, int> SetPresetWithCompletionOptionAsync;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Min;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Max;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Step;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_Value;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IAsyncAction**, int> SetValueAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncAction**, int> FocusAsync;
    }
}
