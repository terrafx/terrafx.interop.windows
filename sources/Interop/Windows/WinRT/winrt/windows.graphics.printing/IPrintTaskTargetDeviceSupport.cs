// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrintTaskTargetDeviceSupport.xml' path='doc/member[@name="IPrintTaskTargetDeviceSupport"]/*' />
[Guid("295D70C0-C2CB-4B7D-B0EA-93095091A220")]
[NativeTypeName("struct IPrintTaskTargetDeviceSupport : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTaskTargetDeviceSupport : IPrintTaskTargetDeviceSupport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPrintTaskTargetDeviceSupport);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskTargetDeviceSupport*, Guid*, void**, int>)(lpVtbl[0]))((IPrintTaskTargetDeviceSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskTargetDeviceSupport*, uint>)(lpVtbl[1]))((IPrintTaskTargetDeviceSupport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskTargetDeviceSupport*, uint>)(lpVtbl[2]))((IPrintTaskTargetDeviceSupport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskTargetDeviceSupport*, uint*, Guid**, int>)(lpVtbl[3]))((IPrintTaskTargetDeviceSupport*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskTargetDeviceSupport*, HSTRING*, int>)(lpVtbl[4]))((IPrintTaskTargetDeviceSupport*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskTargetDeviceSupport*, TrustLevel*, int>)(lpVtbl[5]))((IPrintTaskTargetDeviceSupport*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrintTaskTargetDeviceSupport.xml' path='doc/member[@name="IPrintTaskTargetDeviceSupport.put_IsPrinterTargetEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_IsPrinterTargetEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskTargetDeviceSupport*, byte, int>)(lpVtbl[6]))((IPrintTaskTargetDeviceSupport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskTargetDeviceSupport.xml' path='doc/member[@name="IPrintTaskTargetDeviceSupport.get_IsPrinterTargetEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsPrinterTargetEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskTargetDeviceSupport*, byte*, int>)(lpVtbl[7]))((IPrintTaskTargetDeviceSupport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskTargetDeviceSupport.xml' path='doc/member[@name="IPrintTaskTargetDeviceSupport.put_Is3DManufacturingTargetEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Is3DManufacturingTargetEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskTargetDeviceSupport*, byte, int>)(lpVtbl[8]))((IPrintTaskTargetDeviceSupport*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrintTaskTargetDeviceSupport.xml' path='doc/member[@name="IPrintTaskTargetDeviceSupport.get_Is3DManufacturingTargetEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Is3DManufacturingTargetEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrintTaskTargetDeviceSupport*, byte*, int>)(lpVtbl[9]))((IPrintTaskTargetDeviceSupport*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_IsPrinterTargetEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT get_IsPrinterTargetEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT put_Is3DManufacturingTargetEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT get_Is3DManufacturingTargetEnabled([NativeTypeName("boolean *")] byte* value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsPrinterTargetEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsPrinterTargetEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_Is3DManufacturingTargetEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Is3DManufacturingTargetEnabled;
    }
}
