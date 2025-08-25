// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardAutomaticResponseApdu3.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu3"]/*' />
[Guid("BF43DA74-6576-4392-9367-FE3BC9E2D496")]
[NativeTypeName("struct ISmartCardAutomaticResponseApdu3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardAutomaticResponseApdu3 : ISmartCardAutomaticResponseApdu3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISmartCardAutomaticResponseApdu3);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu3*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardAutomaticResponseApdu3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu3*, uint>)(lpVtbl[1]))((ISmartCardAutomaticResponseApdu3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu3*, uint>)(lpVtbl[2]))((ISmartCardAutomaticResponseApdu3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu3*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardAutomaticResponseApdu3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu3*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardAutomaticResponseApdu3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu3*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardAutomaticResponseApdu3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardAutomaticResponseApdu3.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu3.get_AllowWhenCryptogramGeneratorNotPrepared"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AllowWhenCryptogramGeneratorNotPrepared([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu3*, byte*, int>)(lpVtbl[6]))((ISmartCardAutomaticResponseApdu3*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAutomaticResponseApdu3.xml' path='doc/member[@name="ISmartCardAutomaticResponseApdu3.put_AllowWhenCryptogramGeneratorNotPrepared"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AllowWhenCryptogramGeneratorNotPrepared([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAutomaticResponseApdu3*, byte, int>)(lpVtbl[7]))((ISmartCardAutomaticResponseApdu3*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AllowWhenCryptogramGeneratorNotPrepared([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_AllowWhenCryptogramGeneratorNotPrepared([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AllowWhenCryptogramGeneratorNotPrepared;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AllowWhenCryptogramGeneratorNotPrepared;
    }
}
