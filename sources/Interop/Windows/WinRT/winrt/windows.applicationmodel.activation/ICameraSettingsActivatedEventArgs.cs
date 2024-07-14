// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICameraSettingsActivatedEventArgs.xml' path='doc/member[@name="ICameraSettingsActivatedEventArgs"]/*' />
[Guid("FB67A508-2DAD-490A-9170-DCA036EB114B")]
[NativeTypeName("struct ICameraSettingsActivatedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICameraSettingsActivatedEventArgs : ICameraSettingsActivatedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICameraSettingsActivatedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraSettingsActivatedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ICameraSettingsActivatedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraSettingsActivatedEventArgs*, uint>)(lpVtbl[1]))((ICameraSettingsActivatedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraSettingsActivatedEventArgs*, uint>)(lpVtbl[2]))((ICameraSettingsActivatedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraSettingsActivatedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ICameraSettingsActivatedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraSettingsActivatedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ICameraSettingsActivatedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraSettingsActivatedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ICameraSettingsActivatedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICameraSettingsActivatedEventArgs.xml' path='doc/member[@name="ICameraSettingsActivatedEventArgs.get_VideoDeviceController"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_VideoDeviceController(IInspectable** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraSettingsActivatedEventArgs*, IInspectable**, int>)(lpVtbl[6]))((ICameraSettingsActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraSettingsActivatedEventArgs.xml' path='doc/member[@name="ICameraSettingsActivatedEventArgs.get_VideoDeviceExtension"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VideoDeviceExtension(IInspectable** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraSettingsActivatedEventArgs*, IInspectable**, int>)(lpVtbl[7]))((ICameraSettingsActivatedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_VideoDeviceController(IInspectable** value);

        [VtblIndex(7)]
        HRESULT get_VideoDeviceExtension(IInspectable** value);
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

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> get_VideoDeviceController;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> get_VideoDeviceExtension;
    }
}
