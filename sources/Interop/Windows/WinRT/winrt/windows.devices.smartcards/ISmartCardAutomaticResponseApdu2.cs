// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardAutomaticResponseApdu2.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu2"]/*' />
[Guid("44AEBB14-559D-4531-4E51-89DB6FA8A57A")]
[NativeTypeName("struct ISmartCardAutomaticResponseApdu2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardAutomaticResponseApdu2 : ISmartCardAutomaticResponseApdu2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardAutomaticResponseApdu2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu2*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardAutomaticResponseApdu2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu2*, uint>)(lpVtbl[1]))((ISmartCardAutomaticResponseApdu2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu2*, uint>)(lpVtbl[2]))((ISmartCardAutomaticResponseApdu2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu2*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardAutomaticResponseApdu2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu2*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardAutomaticResponseApdu2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu2*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardAutomaticResponseApdu2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardAutomaticResponseApdu2.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu2.get_InputState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InputState([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu2*, IReference<uint>**, int>)(lpVtbl[6]))((ISmartCardAutomaticResponseApdu2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAutomaticResponseApdu2.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu2.put_InputState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_InputState([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu2*, IReference<uint>*, int>)(lpVtbl[7]))((ISmartCardAutomaticResponseApdu2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAutomaticResponseApdu2.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu2.get_OutputState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OutputState([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu2*, IReference<uint>**, int>)(lpVtbl[8]))((ISmartCardAutomaticResponseApdu2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAutomaticResponseApdu2.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu2.put_OutputState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_OutputState([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu2*, IReference<uint>*, int>)(lpVtbl[9]))((ISmartCardAutomaticResponseApdu2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InputState([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(7)]
        HRESULT put_InputState([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value);

        [VtblIndex(8)]
        HRESULT get_OutputState([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(9)]
        HRESULT put_OutputState([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_InputState;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>*, int> put_InputState;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_OutputState;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>*, int> put_OutputState;
    }
}
