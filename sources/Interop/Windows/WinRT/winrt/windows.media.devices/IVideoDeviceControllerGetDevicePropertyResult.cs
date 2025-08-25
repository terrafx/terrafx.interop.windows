// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVideoDeviceControllerGetDevicePropertyResult.xml' path='doc/member[@name="IVideoDeviceControllerGetDevicePropertyResult"]/*' />
[Guid("C5D88395-6ED5-4790-8B5D-0EF13935D0F8")]
[NativeTypeName("struct IVideoDeviceControllerGetDevicePropertyResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoDeviceControllerGetDevicePropertyResult : IVideoDeviceControllerGetDevicePropertyResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IVideoDeviceControllerGetDevicePropertyResult);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceControllerGetDevicePropertyResult*, Guid*, void**, int>)(lpVtbl[0]))((IVideoDeviceControllerGetDevicePropertyResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceControllerGetDevicePropertyResult*, uint>)(lpVtbl[1]))((IVideoDeviceControllerGetDevicePropertyResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceControllerGetDevicePropertyResult*, uint>)(lpVtbl[2]))((IVideoDeviceControllerGetDevicePropertyResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceControllerGetDevicePropertyResult*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoDeviceControllerGetDevicePropertyResult*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceControllerGetDevicePropertyResult*, HSTRING*, int>)(lpVtbl[4]))((IVideoDeviceControllerGetDevicePropertyResult*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceControllerGetDevicePropertyResult*, TrustLevel*, int>)(lpVtbl[5]))((IVideoDeviceControllerGetDevicePropertyResult*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVideoDeviceControllerGetDevicePropertyResult.xml' path='doc/member[@name="IVideoDeviceControllerGetDevicePropertyResult.get_Status"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Devices::VideoDeviceControllerGetDevicePropertyStatus *")] VideoDeviceControllerGetDevicePropertyStatus* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceControllerGetDevicePropertyResult*, VideoDeviceControllerGetDevicePropertyStatus*, int>)(lpVtbl[6]))((IVideoDeviceControllerGetDevicePropertyResult*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoDeviceControllerGetDevicePropertyResult.xml' path='doc/member[@name="IVideoDeviceControllerGetDevicePropertyResult.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Value(IInspectable** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoDeviceControllerGetDevicePropertyResult*, IInspectable**, int>)(lpVtbl[7]))((IVideoDeviceControllerGetDevicePropertyResult*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status([NativeTypeName("ABI::Windows::Media::Devices::VideoDeviceControllerGetDevicePropertyStatus *")] VideoDeviceControllerGetDevicePropertyStatus* value);

        [VtblIndex(7)]
        HRESULT get_Value(IInspectable** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::VideoDeviceControllerGetDevicePropertyStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VideoDeviceControllerGetDevicePropertyStatus*, int> get_Status;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> get_Value;
    }
}
