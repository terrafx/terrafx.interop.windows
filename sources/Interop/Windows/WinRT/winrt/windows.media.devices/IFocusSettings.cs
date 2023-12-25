// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IFocusSettings.xml' path='doc/member[@name="IFocusSettings"]/*' />
[Guid("79958F6B-3263-4275-85D6-AEAE891C96EE")]
[NativeTypeName("struct IFocusSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFocusSettings : IFocusSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFocusSettings));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, Guid*, void**, int>)(lpVtbl[0]))((IFocusSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, uint>)(lpVtbl[1]))((IFocusSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, uint>)(lpVtbl[2]))((IFocusSettings*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, uint*, Guid**, int>)(lpVtbl[3]))((IFocusSettings*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, HSTRING*, int>)(lpVtbl[4]))((IFocusSettings*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, TrustLevel*, int>)(lpVtbl[5]))((IFocusSettings*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IFocusSettings.xml' path='doc/member[@name="IFocusSettings.get_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Devices::FocusMode *")] FocusMode* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, FocusMode*, int>)(lpVtbl[6]))((IFocusSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusSettings.xml' path='doc/member[@name="IFocusSettings.put_Mode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Mode([NativeTypeName("ABI::Windows::Media::Devices::FocusMode")] FocusMode value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, FocusMode, int>)(lpVtbl[7]))((IFocusSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusSettings.xml' path='doc/member[@name="IFocusSettings.get_AutoFocusRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AutoFocusRange([NativeTypeName("ABI::Windows::Media::Devices::AutoFocusRange *")] AutoFocusRange* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, AutoFocusRange*, int>)(lpVtbl[8]))((IFocusSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusSettings.xml' path='doc/member[@name="IFocusSettings.put_AutoFocusRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AutoFocusRange([NativeTypeName("ABI::Windows::Media::Devices::AutoFocusRange")] AutoFocusRange value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, AutoFocusRange, int>)(lpVtbl[9]))((IFocusSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusSettings.xml' path='doc/member[@name="IFocusSettings.get_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Value([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, IReference<uint>**, int>)(lpVtbl[10]))((IFocusSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusSettings.xml' path='doc/member[@name="IFocusSettings.put_Value"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Value([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, IReference<uint>*, int>)(lpVtbl[11]))((IFocusSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusSettings.xml' path='doc/member[@name="IFocusSettings.get_Distance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Distance([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CManualFocusDistance_t **")] IReference<ManualFocusDistance>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, IReference<ManualFocusDistance>**, int>)(lpVtbl[12]))((IFocusSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusSettings.xml' path='doc/member[@name="IFocusSettings.put_Distance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Distance([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CManualFocusDistance_t *")] IReference<ManualFocusDistance>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, IReference<ManualFocusDistance>*, int>)(lpVtbl[13]))((IFocusSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusSettings.xml' path='doc/member[@name="IFocusSettings.get_WaitForFocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_WaitForFocus([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, byte*, int>)(lpVtbl[14]))((IFocusSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusSettings.xml' path='doc/member[@name="IFocusSettings.put_WaitForFocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_WaitForFocus([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, byte, int>)(lpVtbl[15]))((IFocusSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusSettings.xml' path='doc/member[@name="IFocusSettings.get_DisableDriverFallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_DisableDriverFallback([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, byte*, int>)(lpVtbl[16]))((IFocusSettings*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IFocusSettings.xml' path='doc/member[@name="IFocusSettings.put_DisableDriverFallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_DisableDriverFallback([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IFocusSettings*, byte, int>)(lpVtbl[17]))((IFocusSettings*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Mode([NativeTypeName("ABI::Windows::Media::Devices::FocusMode *")] FocusMode* value);

        [VtblIndex(7)]
        HRESULT put_Mode([NativeTypeName("ABI::Windows::Media::Devices::FocusMode")] FocusMode value);

        [VtblIndex(8)]
        HRESULT get_AutoFocusRange([NativeTypeName("ABI::Windows::Media::Devices::AutoFocusRange *")] AutoFocusRange* value);

        [VtblIndex(9)]
        HRESULT put_AutoFocusRange([NativeTypeName("ABI::Windows::Media::Devices::AutoFocusRange")] AutoFocusRange value);

        [VtblIndex(10)]
        HRESULT get_Value([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(11)]
        HRESULT put_Value([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value);

        [VtblIndex(12)]
        HRESULT get_Distance([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CManualFocusDistance_t **")] IReference<ManualFocusDistance>** value);

        [VtblIndex(13)]
        HRESULT put_Distance([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CManualFocusDistance_t *")] IReference<ManualFocusDistance>* value);

        [VtblIndex(14)]
        HRESULT get_WaitForFocus([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_WaitForFocus([NativeTypeName("boolean")] byte value);

        [VtblIndex(16)]
        HRESULT get_DisableDriverFallback([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT put_DisableDriverFallback([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::FocusMode *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FocusMode*, int> get_Mode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::FocusMode) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, FocusMode, int> put_Mode;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::AutoFocusRange *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AutoFocusRange*, int> get_AutoFocusRange;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Devices::AutoFocusRange) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, AutoFocusRange, int> put_AutoFocusRange;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_Value;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>*, int> put_Value;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CManualFocusDistance_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<ManualFocusDistance>**, int> get_Distance;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CManualFocusDistance_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<ManualFocusDistance>*, int> put_Distance;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_WaitForFocus;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_WaitForFocus;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_DisableDriverFallback;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_DisableDriverFallback;
    }
}
