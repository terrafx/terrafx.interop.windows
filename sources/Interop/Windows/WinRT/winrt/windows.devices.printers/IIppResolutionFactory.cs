// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIppResolutionFactory.xml' path='doc/member[@name="IIppResolutionFactory"]/*' />
[Guid("E481C2AE-251A-5326-B173-95543ED99A35")]
[NativeTypeName("struct IIppResolutionFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppResolutionFactory : IIppResolutionFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIppResolutionFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppResolutionFactory*, Guid*, void**, int>)(lpVtbl[0]))((IIppResolutionFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppResolutionFactory*, uint>)(lpVtbl[1]))((IIppResolutionFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppResolutionFactory*, uint>)(lpVtbl[2]))((IIppResolutionFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppResolutionFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IIppResolutionFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppResolutionFactory*, HSTRING*, int>)(lpVtbl[4]))((IIppResolutionFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppResolutionFactory*, TrustLevel*, int>)(lpVtbl[5]))((IIppResolutionFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IIppResolutionFactory.xml' path='doc/member[@name="IIppResolutionFactory.CreateInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateInstance([NativeTypeName("INT32")] int width, [NativeTypeName("INT32")] int height, [NativeTypeName("ABI::Windows::Devices::Printers::IppResolutionUnit")] IppResolutionUnit unit, [NativeTypeName("ABI::Windows::Devices::Printers::IIppResolution **")] IIppResolution** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppResolutionFactory*, int, int, IppResolutionUnit, IIppResolution**, int>)(lpVtbl[6]))((IIppResolutionFactory*)Unsafe.AsPointer(ref this), width, height, unit, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateInstance([NativeTypeName("INT32")] int width, [NativeTypeName("INT32")] int height, [NativeTypeName("ABI::Windows::Devices::Printers::IppResolutionUnit")] IppResolutionUnit unit, [NativeTypeName("ABI::Windows::Devices::Printers::IIppResolution **")] IIppResolution** value);
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

        [NativeTypeName("HRESULT (INT32, INT32, ABI::Windows::Devices::Printers::IppResolutionUnit, ABI::Windows::Devices::Printers::IIppResolution **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, IppResolutionUnit, IIppResolution**, int> CreateInstance;
    }
}
