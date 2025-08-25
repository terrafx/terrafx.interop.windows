// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISceneModeControl.xml' path='doc/member[@name="ISceneModeControl"]/*' />
[Guid("D48E5AF7-8D59-4854-8C62-12C70BA89B7C")]
[NativeTypeName("struct ISceneModeControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISceneModeControl : ISceneModeControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISceneModeControl);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneModeControl*, Guid*, void**, int>)(lpVtbl[0]))((ISceneModeControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneModeControl*, uint>)(lpVtbl[1]))((ISceneModeControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneModeControl*, uint>)(lpVtbl[2]))((ISceneModeControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneModeControl*, uint*, Guid**, int>)(lpVtbl[3]))((ISceneModeControl*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneModeControl*, HSTRING*, int>)(lpVtbl[4]))((ISceneModeControl*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneModeControl*, TrustLevel*, int>)(lpVtbl[5]))((ISceneModeControl*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISceneModeControl.xml' path='doc/member[@name="ISceneModeControl.get_SupportedModes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SupportedModes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CCaptureSceneMode_t **")] IVectorView<CaptureSceneMode>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneModeControl*, IVectorView<CaptureSceneMode>**, int>)(lpVtbl[6]))((ISceneModeControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISceneModeControl.xml' path='doc/member[@name="ISceneModeControl.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Value([NativeTypeName("ABI::Windows::Media::Devices::CaptureSceneMode *")] CaptureSceneMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneModeControl*, CaptureSceneMode*, int>)(lpVtbl[7]))((ISceneModeControl*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISceneModeControl.xml' path='doc/member[@name="ISceneModeControl.SetValueAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetValueAsync([NativeTypeName("ABI::Windows::Media::Devices::CaptureSceneMode")] CaptureSceneMode sceneMode, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ISceneModeControl*, CaptureSceneMode, IAsyncAction**, int>)(lpVtbl[8]))((ISceneModeControl*)Unsafe.AsPointer(ref this), sceneMode, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SupportedModes([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CCaptureSceneMode_t **")] IVectorView<CaptureSceneMode>** value);

        [VtblIndex(7)]
        HRESULT get_Value([NativeTypeName("ABI::Windows::Media::Devices::CaptureSceneMode *")] CaptureSceneMode* value);

        [VtblIndex(8)]
        HRESULT SetValueAsync([NativeTypeName("ABI::Windows::Media::Devices::CaptureSceneMode")] CaptureSceneMode sceneMode, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CCaptureSceneMode_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<CaptureSceneMode>**, int> get_SupportedModes;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::CaptureSceneMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CaptureSceneMode*, int> get_Value;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::CaptureSceneMode, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CaptureSceneMode, IAsyncAction**, int> SetValueAsync;
    }
}
