// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISmartCardAppletIdGroup.xml' path='doc/member[@name="ISmartCardAppletIdGroup"]/*' />
[Guid("7DB165E6-6264-56F4-5E03-C86385395EB1")]
[NativeTypeName("struct ISmartCardAppletIdGroup : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardAppletIdGroup : ISmartCardAppletIdGroup.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardAppletIdGroup));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup*, Guid*, void**, int>)(lpVtbl[0]))((ISmartCardAppletIdGroup*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup*, uint>)(lpVtbl[1]))((ISmartCardAppletIdGroup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup*, uint>)(lpVtbl[2]))((ISmartCardAppletIdGroup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup*, uint*, Guid**, int>)(lpVtbl[3]))((ISmartCardAppletIdGroup*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup*, HSTRING*, int>)(lpVtbl[4]))((ISmartCardAppletIdGroup*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup*, TrustLevel*, int>)(lpVtbl[5]))((ISmartCardAppletIdGroup*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISmartCardAppletIdGroup.xml' path='doc/member[@name="ISmartCardAppletIdGroup.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup*, HSTRING*, int>)(lpVtbl[6]))((ISmartCardAppletIdGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroup.xml' path='doc/member[@name="ISmartCardAppletIdGroup.put_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup*, HSTRING, int>)(lpVtbl[7]))((ISmartCardAppletIdGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroup.xml' path='doc/member[@name="ISmartCardAppletIdGroup.get_AppletIds"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AppletIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t **")] IVector<IntPtr>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup*, IVector<IntPtr>**, int>)(lpVtbl[8]))((ISmartCardAppletIdGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroup.xml' path='doc/member[@name="ISmartCardAppletIdGroup.get_SmartCardEmulationCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SmartCardEmulationCategory([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory *")] SmartCardEmulationCategory* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup*, SmartCardEmulationCategory*, int>)(lpVtbl[9]))((ISmartCardAppletIdGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroup.xml' path='doc/member[@name="ISmartCardAppletIdGroup.put_SmartCardEmulationCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_SmartCardEmulationCategory([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory")] SmartCardEmulationCategory value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup*, SmartCardEmulationCategory, int>)(lpVtbl[10]))((ISmartCardAppletIdGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroup.xml' path='doc/member[@name="ISmartCardAppletIdGroup.get_SmartCardEmulationType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SmartCardEmulationType([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationType *")] SmartCardEmulationType* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup*, SmartCardEmulationType*, int>)(lpVtbl[11]))((ISmartCardAppletIdGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroup.xml' path='doc/member[@name="ISmartCardAppletIdGroup.put_SmartCardEmulationType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_SmartCardEmulationType([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationType")] SmartCardEmulationType value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup*, SmartCardEmulationType, int>)(lpVtbl[12]))((ISmartCardAppletIdGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroup.xml' path='doc/member[@name="ISmartCardAppletIdGroup.get_AutomaticEnablement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_AutomaticEnablement([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup*, byte*, int>)(lpVtbl[13]))((ISmartCardAppletIdGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISmartCardAppletIdGroup.xml' path='doc/member[@name="ISmartCardAppletIdGroup.put_AutomaticEnablement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_AutomaticEnablement([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISmartCardAppletIdGroup*, byte, int>)(lpVtbl[14]))((ISmartCardAppletIdGroup*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_AppletIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t **")] IVector<IntPtr>** value);

        [VtblIndex(9)]
        HRESULT get_SmartCardEmulationCategory([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory *")] SmartCardEmulationCategory* value);

        [VtblIndex(10)]
        HRESULT put_SmartCardEmulationCategory([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory")] SmartCardEmulationCategory value);

        [VtblIndex(11)]
        HRESULT get_SmartCardEmulationType([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationType *")] SmartCardEmulationType* value);

        [VtblIndex(12)]
        HRESULT put_SmartCardEmulationType([NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationType")] SmartCardEmulationType value);

        [VtblIndex(13)]
        HRESULT get_AutomaticEnablement([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT put_AutomaticEnablement([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<IntPtr>**, int> get_AppletIds;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardEmulationCategory*, int> get_SmartCardEmulationCategory;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardEmulationCategory, int> put_SmartCardEmulationCategory;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardEmulationType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardEmulationType*, int> get_SmartCardEmulationType;

        [NativeTypeName("HRESULT (ABI::Windows::Devices::SmartCards::SmartCardEmulationType) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SmartCardEmulationType, int> put_SmartCardEmulationType;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_AutomaticEnablement;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_AutomaticEnablement;
    }
}
