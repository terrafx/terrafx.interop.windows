// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGattDescriptorUuidsStatics.xml' path='doc/member[@name="IGattDescriptorUuidsStatics"]/*' />
[Guid("A6F862CE-9CFC-42F1-9185-FF37B75181D3")]
[NativeTypeName("struct IGattDescriptorUuidsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattDescriptorUuidsStatics : IGattDescriptorUuidsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattDescriptorUuidsStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorUuidsStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGattDescriptorUuidsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorUuidsStatics*, uint>)(lpVtbl[1]))((IGattDescriptorUuidsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorUuidsStatics*, uint>)(lpVtbl[2]))((IGattDescriptorUuidsStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorUuidsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGattDescriptorUuidsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorUuidsStatics*, HSTRING*, int>)(lpVtbl[4]))((IGattDescriptorUuidsStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorUuidsStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGattDescriptorUuidsStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IGattDescriptorUuidsStatics.xml' path='doc/member[@name="IGattDescriptorUuidsStatics.get_CharacteristicAggregateFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CharacteristicAggregateFormat(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorUuidsStatics*, Guid*, int>)(lpVtbl[6]))((IGattDescriptorUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDescriptorUuidsStatics.xml' path='doc/member[@name="IGattDescriptorUuidsStatics.get_CharacteristicExtendedProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CharacteristicExtendedProperties(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorUuidsStatics*, Guid*, int>)(lpVtbl[7]))((IGattDescriptorUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDescriptorUuidsStatics.xml' path='doc/member[@name="IGattDescriptorUuidsStatics.get_CharacteristicPresentationFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CharacteristicPresentationFormat(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorUuidsStatics*, Guid*, int>)(lpVtbl[8]))((IGattDescriptorUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDescriptorUuidsStatics.xml' path='doc/member[@name="IGattDescriptorUuidsStatics.get_CharacteristicUserDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CharacteristicUserDescription(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorUuidsStatics*, Guid*, int>)(lpVtbl[9]))((IGattDescriptorUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDescriptorUuidsStatics.xml' path='doc/member[@name="IGattDescriptorUuidsStatics.get_ClientCharacteristicConfiguration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ClientCharacteristicConfiguration(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorUuidsStatics*, Guid*, int>)(lpVtbl[10]))((IGattDescriptorUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IGattDescriptorUuidsStatics.xml' path='doc/member[@name="IGattDescriptorUuidsStatics.get_ServerCharacteristicConfiguration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ServerCharacteristicConfiguration(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGattDescriptorUuidsStatics*, Guid*, int>)(lpVtbl[11]))((IGattDescriptorUuidsStatics*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CharacteristicAggregateFormat(Guid* value);

        [VtblIndex(7)]
        HRESULT get_CharacteristicExtendedProperties(Guid* value);

        [VtblIndex(8)]
        HRESULT get_CharacteristicPresentationFormat(Guid* value);

        [VtblIndex(9)]
        HRESULT get_CharacteristicUserDescription(Guid* value);

        [VtblIndex(10)]
        HRESULT get_ClientCharacteristicConfiguration(Guid* value);

        [VtblIndex(11)]
        HRESULT get_ServerCharacteristicConfiguration(Guid* value);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_CharacteristicAggregateFormat;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_CharacteristicExtendedProperties;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_CharacteristicPresentationFormat;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_CharacteristicUserDescription;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_ClientCharacteristicConfiguration;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_ServerCharacteristicConfiguration;
    }
}
