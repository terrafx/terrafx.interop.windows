// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.spi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpiBusInfo.xml' path='doc/member[@name="ISpiBusInfo"]/*' />
[Guid("9929444A-54F2-48C6-B952-9C32FC02C669")]
[NativeTypeName("struct ISpiBusInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpiBusInfo : ISpiBusInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpiBusInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiBusInfo*, Guid*, void**, int>)(lpVtbl[0]))((ISpiBusInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiBusInfo*, uint>)(lpVtbl[1]))((ISpiBusInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiBusInfo*, uint>)(lpVtbl[2]))((ISpiBusInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiBusInfo*, uint*, Guid**, int>)(lpVtbl[3]))((ISpiBusInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiBusInfo*, HSTRING*, int>)(lpVtbl[4]))((ISpiBusInfo*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiBusInfo*, TrustLevel*, int>)(lpVtbl[5]))((ISpiBusInfo*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpiBusInfo.xml' path='doc/member[@name="ISpiBusInfo.get_ChipSelectLineCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChipSelectLineCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiBusInfo*, int*, int>)(lpVtbl[6]))((ISpiBusInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiBusInfo.xml' path='doc/member[@name="ISpiBusInfo.get_MinClockFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MinClockFrequency([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiBusInfo*, int*, int>)(lpVtbl[7]))((ISpiBusInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiBusInfo.xml' path='doc/member[@name="ISpiBusInfo.get_MaxClockFrequency"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxClockFrequency([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiBusInfo*, int*, int>)(lpVtbl[8]))((ISpiBusInfo*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpiBusInfo.xml' path='doc/member[@name="ISpiBusInfo.get_SupportedDataBitLengths"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SupportedDataBitLengths([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_int_t **")] IVectorView<int>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpiBusInfo*, IVectorView<int>**, int>)(lpVtbl[9]))((ISpiBusInfo*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ChipSelectLineCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_MinClockFrequency([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_MaxClockFrequency([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(9)]
        HRESULT get_SupportedDataBitLengths([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_int_t **")] IVectorView<int>** value);
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ChipSelectLineCount;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MinClockFrequency;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MaxClockFrequency;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_int_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<int>**, int> get_SupportedDataBitLengths;
    }
}
