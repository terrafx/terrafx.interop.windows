// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar"]/*' />
[Guid("6E932C84-F644-541D-A2D7-0C262437842D")]
[NativeTypeName("struct IAppWindowTitleBar : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppWindowTitleBar : IAppWindowTitleBar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppWindowTitleBar));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, Guid*, void**, int>)(lpVtbl[0]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, uint>)(lpVtbl[1]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, uint>)(lpVtbl[2]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, uint*, Guid**, int>)(lpVtbl[3]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, HSTRING*, int>)(lpVtbl[4]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, TrustLevel*, int>)(lpVtbl[5]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.get_BackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>**, int>)(lpVtbl[6]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.put_BackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_BackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>*, int>)(lpVtbl[7]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.get_ButtonBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ButtonBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>**, int>)(lpVtbl[8]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.put_ButtonBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ButtonBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>*, int>)(lpVtbl[9]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.get_ButtonForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ButtonForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>**, int>)(lpVtbl[10]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.put_ButtonForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ButtonForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>*, int>)(lpVtbl[11]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.get_ButtonHoverBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ButtonHoverBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>**, int>)(lpVtbl[12]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.put_ButtonHoverBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_ButtonHoverBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>*, int>)(lpVtbl[13]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.get_ButtonHoverForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ButtonHoverForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>**, int>)(lpVtbl[14]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.put_ButtonHoverForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_ButtonHoverForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>*, int>)(lpVtbl[15]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.get_ButtonInactiveBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ButtonInactiveBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>**, int>)(lpVtbl[16]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.put_ButtonInactiveBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_ButtonInactiveBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>*, int>)(lpVtbl[17]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.get_ButtonInactiveForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_ButtonInactiveForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>**, int>)(lpVtbl[18]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.put_ButtonInactiveForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_ButtonInactiveForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>*, int>)(lpVtbl[19]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.get_ButtonPressedBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_ButtonPressedBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>**, int>)(lpVtbl[20]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.put_ButtonPressedBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_ButtonPressedBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>*, int>)(lpVtbl[21]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.get_ButtonPressedForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_ButtonPressedForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>**, int>)(lpVtbl[22]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.put_ButtonPressedForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_ButtonPressedForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>*, int>)(lpVtbl[23]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.get_ExtendsContentIntoTitleBar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_ExtendsContentIntoTitleBar([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, byte*, int>)(lpVtbl[24]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.put_ExtendsContentIntoTitleBar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_ExtendsContentIntoTitleBar([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, byte, int>)(lpVtbl[25]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.get_ForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_ForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>**, int>)(lpVtbl[26]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.put_ForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_ForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>*, int>)(lpVtbl[27]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.get_InactiveBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_InactiveBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>**, int>)(lpVtbl[28]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.put_InactiveBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_InactiveBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>*, int>)(lpVtbl[29]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.get_InactiveForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_InactiveForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>**, int>)(lpVtbl[30]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.put_InactiveForegroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_InactiveForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IReference<Color>*, int>)(lpVtbl[31]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.get_IsVisible"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, byte*, int>)(lpVtbl[32]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IAppWindowTitleBar.xml' path='doc/member[@name="IAppWindowTitleBar.GetTitleBarOcclusions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetTitleBarOcclusions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CAppWindowTitleBarOcclusion_t **")] IVectorView<Pointer<IAppWindowTitleBarOcclusion>>** result)
    {
        return ((delegate* unmanaged[MemberFunction]<IAppWindowTitleBar*, IVectorView<Pointer<IAppWindowTitleBarOcclusion>>**, int>)(lpVtbl[33]))((IAppWindowTitleBar*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(7)]
        HRESULT put_BackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);

        [VtblIndex(8)]
        HRESULT get_ButtonBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(9)]
        HRESULT put_ButtonBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);

        [VtblIndex(10)]
        HRESULT get_ButtonForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(11)]
        HRESULT put_ButtonForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);

        [VtblIndex(12)]
        HRESULT get_ButtonHoverBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(13)]
        HRESULT put_ButtonHoverBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);

        [VtblIndex(14)]
        HRESULT get_ButtonHoverForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(15)]
        HRESULT put_ButtonHoverForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);

        [VtblIndex(16)]
        HRESULT get_ButtonInactiveBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(17)]
        HRESULT put_ButtonInactiveBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);

        [VtblIndex(18)]
        HRESULT get_ButtonInactiveForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(19)]
        HRESULT put_ButtonInactiveForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);

        [VtblIndex(20)]
        HRESULT get_ButtonPressedBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(21)]
        HRESULT put_ButtonPressedBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);

        [VtblIndex(22)]
        HRESULT get_ButtonPressedForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(23)]
        HRESULT put_ButtonPressedForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);

        [VtblIndex(24)]
        HRESULT get_ExtendsContentIntoTitleBar([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(25)]
        HRESULT put_ExtendsContentIntoTitleBar([NativeTypeName("boolean")] byte value);

        [VtblIndex(26)]
        HRESULT get_ForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(27)]
        HRESULT put_ForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);

        [VtblIndex(28)]
        HRESULT get_InactiveBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(29)]
        HRESULT put_InactiveBackgroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);

        [VtblIndex(30)]
        HRESULT get_InactiveForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")] IReference<Color>** value);

        [VtblIndex(31)]
        HRESULT put_InactiveForegroundColor([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")] IReference<Color>* value);

        [VtblIndex(32)]
        HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(33)]
        HRESULT GetTitleBarOcclusions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CAppWindowTitleBarOcclusion_t **")] IVectorView<Pointer<IAppWindowTitleBarOcclusion>>** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_BackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_BackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_ButtonBackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_ButtonBackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_ButtonForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_ButtonForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_ButtonHoverBackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_ButtonHoverBackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_ButtonHoverForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_ButtonHoverForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_ButtonInactiveBackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_ButtonInactiveBackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_ButtonInactiveForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_ButtonInactiveForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_ButtonPressedBackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_ButtonPressedBackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_ButtonPressedForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_ButtonPressedForegroundColor;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_ExtendsContentIntoTitleBar;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_ExtendsContentIntoTitleBar;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_ForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_ForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_InactiveBackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_InactiveBackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>**, int> get_InactiveForegroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<Color>*, int> put_InactiveForegroundColor;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsVisible;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CAppWindowTitleBarOcclusion_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IAppWindowTitleBarOcclusion>>**, int> GetTitleBarOcclusions;
    }
}
