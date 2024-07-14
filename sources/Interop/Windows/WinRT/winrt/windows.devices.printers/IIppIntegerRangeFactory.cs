// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IIppIntegerRangeFactory.xml' path='doc/member[@name="IIppIntegerRangeFactory"]/*' />
[Guid("75D4ECAE-F87E-54AD-B5D0-465204DB7553")]
[NativeTypeName("struct IIppIntegerRangeFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppIntegerRangeFactory : IIppIntegerRangeFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIppIntegerRangeFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppIntegerRangeFactory*, Guid*, void**, int>)(lpVtbl[0]))((IIppIntegerRangeFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppIntegerRangeFactory*, uint>)(lpVtbl[1]))((IIppIntegerRangeFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IIppIntegerRangeFactory*, uint>)(lpVtbl[2]))((IIppIntegerRangeFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppIntegerRangeFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IIppIntegerRangeFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppIntegerRangeFactory*, HSTRING*, int>)(lpVtbl[4]))((IIppIntegerRangeFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppIntegerRangeFactory*, TrustLevel*, int>)(lpVtbl[5]))((IIppIntegerRangeFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IIppIntegerRangeFactory.xml' path='doc/member[@name="IIppIntegerRangeFactory.CreateInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateInstance([NativeTypeName("INT32")] int start, [NativeTypeName("INT32")] int end, [NativeTypeName("ABI::Windows::Devices::Printers::IIppIntegerRange **")] IIppIntegerRange** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IIppIntegerRangeFactory*, int, int, IIppIntegerRange**, int>)(lpVtbl[6]))((IIppIntegerRangeFactory*)Unsafe.AsPointer(ref this), start, end, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateInstance([NativeTypeName("INT32")] int start, [NativeTypeName("INT32")] int end, [NativeTypeName("ABI::Windows::Devices::Printers::IIppIntegerRange **")] IIppIntegerRange** value);
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

        [NativeTypeName("HRESULT (INT32, INT32, ABI::Windows::Devices::Printers::IIppIntegerRange **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, IIppIntegerRange**, int> CreateInstance;
    }
}
