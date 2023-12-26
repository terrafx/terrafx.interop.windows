// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattDescriptorStatics.xml' path='doc/member[@name="IGattDescriptorStatics"]/*' />
[Guid("92055F2D-8084-4344-B4C2-284DE19A8506")]
[NativeTypeName("struct IGattDescriptorStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattDescriptorStatics : IGattDescriptorStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattDescriptorStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGattDescriptorStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorStatics*, uint>)(lpVtbl[1]))((IGattDescriptorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorStatics*, uint>)(lpVtbl[2]))((IGattDescriptorStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGattDescriptorStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorStatics*, HSTRING*, int>)(lpVtbl[4]))((IGattDescriptorStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGattDescriptorStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattDescriptorStatics.xml' path='doc/member[@name="IGattDescriptorStatics.ConvertShortIdToUuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.")]
    public HRESULT ConvertShortIdToUuid([NativeTypeName("UINT16")] ushort shortId, Guid* descriptorUuid)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorStatics*, ushort, Guid*, int>)(lpVtbl[6]))((IGattDescriptorStatics*)Unsafe.AsPointer(ref this), shortId, descriptorUuid);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.")]
        HRESULT ConvertShortIdToUuid([NativeTypeName("UINT16")] ushort shortId, Guid* descriptorUuid);
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

        [NativeTypeName("HRESULT (UINT16, GUID *) __attribute__((stdcall))")]
        [Obsolete("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, Guid*, int> ConvertShortIdToUuid;
    }
}
