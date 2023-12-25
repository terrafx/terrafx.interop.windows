// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IHumanPresenceSensorExtension.xml' path='doc/member[@name="IHumanPresenceSensorExtension"]/*' />
[Guid("3E526A71-2D1D-5D43-8A8E-A434A8242EF0")]
[NativeTypeName("struct IHumanPresenceSensorExtension : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHumanPresenceSensorExtension : IHumanPresenceSensorExtension.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHumanPresenceSensorExtension));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorExtension*, Guid*, void**, int>)(lpVtbl[0]))((IHumanPresenceSensorExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorExtension*, uint>)(lpVtbl[1]))((IHumanPresenceSensorExtension*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorExtension*, uint>)(lpVtbl[2]))((IHumanPresenceSensorExtension*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorExtension*, uint*, Guid**, int>)(lpVtbl[3]))((IHumanPresenceSensorExtension*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorExtension*, HSTRING*, int>)(lpVtbl[4]))((IHumanPresenceSensorExtension*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorExtension*, TrustLevel*, int>)(lpVtbl[5]))((IHumanPresenceSensorExtension*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IHumanPresenceSensorExtension.xml' path='doc/member[@name="IHumanPresenceSensorExtension.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Initialize(HSTRING deviceInterface)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorExtension*, HSTRING, int>)(lpVtbl[6]))((IHumanPresenceSensorExtension*)Unsafe.AsPointer(ref this), deviceInterface);
    }

    /// <include file='IHumanPresenceSensorExtension.xml' path='doc/member[@name="IHumanPresenceSensorExtension.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorExtension*, int>)(lpVtbl[7]))((IHumanPresenceSensorExtension*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHumanPresenceSensorExtension.xml' path='doc/member[@name="IHumanPresenceSensorExtension.ProcessReading"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ProcessReading([NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensorReading *")] IHumanPresenceSensorReading* reading, [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensorReadingUpdate **")] IHumanPresenceSensorReadingUpdate** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorExtension*, IHumanPresenceSensorReading*, IHumanPresenceSensorReadingUpdate**, int>)(lpVtbl[8]))((IHumanPresenceSensorExtension*)Unsafe.AsPointer(ref this), reading, result);
    }

    /// <include file='IHumanPresenceSensorExtension.xml' path='doc/member[@name="IHumanPresenceSensorExtension.ProcessReadingTimeoutExpired"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ProcessReadingTimeoutExpired([NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensorReading *")] IHumanPresenceSensorReading* reading)
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorExtension*, IHumanPresenceSensorReading*, int>)(lpVtbl[9]))((IHumanPresenceSensorExtension*)Unsafe.AsPointer(ref this), reading);
    }

    /// <include file='IHumanPresenceSensorExtension.xml' path='doc/member[@name="IHumanPresenceSensorExtension.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorExtension*, int>)(lpVtbl[10]))((IHumanPresenceSensorExtension*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHumanPresenceSensorExtension.xml' path='doc/member[@name="IHumanPresenceSensorExtension.Uninitialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Uninitialize()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorExtension*, int>)(lpVtbl[11]))((IHumanPresenceSensorExtension*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHumanPresenceSensorExtension.xml' path='doc/member[@name="IHumanPresenceSensorExtension.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged[MemberFunction]<IHumanPresenceSensorExtension*, int>)(lpVtbl[12]))((IHumanPresenceSensorExtension*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Initialize(HSTRING deviceInterface);

        [VtblIndex(7)]
        HRESULT Start();

        [VtblIndex(8)]
        HRESULT ProcessReading([NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensorReading *")] IHumanPresenceSensorReading* reading, [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensorReadingUpdate **")] IHumanPresenceSensorReadingUpdate** result);

        [VtblIndex(9)]
        HRESULT ProcessReadingTimeoutExpired([NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensorReading *")] IHumanPresenceSensorReading* reading);

        [VtblIndex(10)]
        HRESULT Stop();

        [VtblIndex(11)]
        HRESULT Uninitialize();

        [VtblIndex(12)]
        HRESULT Reset();
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

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> Initialize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Start;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IHumanPresenceSensorReading *, ABI::Windows::Devices::Sensors::IHumanPresenceSensorReadingUpdate **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHumanPresenceSensorReading*, IHumanPresenceSensorReadingUpdate**, int> ProcessReading;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::Sensors::IHumanPresenceSensorReading *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHumanPresenceSensorReading*, int> ProcessReadingTimeoutExpired;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Uninitialize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Reset;
    }
}
