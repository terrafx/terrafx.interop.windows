// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties"]/*' />
[Guid("C79D8A4B-C163-4EE7-803F-67CE79F9972D")]
[NativeTypeName("struct IPointerPointProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPointerPointProperties : IPointerPointProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IPointerPointProperties);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, Guid*, void**, int>)(lpVtbl[0]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, uint>)(lpVtbl[1]))((IPointerPointProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, uint>)(lpVtbl[2]))((IPointerPointProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, HSTRING*, int>)(lpVtbl[4]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, TrustLevel*, int>)(lpVtbl[5]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_Pressure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Pressure(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, float*, int>)(lpVtbl[6]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_IsInverted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsInverted([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, byte*, int>)(lpVtbl[7]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_IsEraser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsEraser([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, byte*, int>)(lpVtbl[8]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_Orientation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Orientation(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, float*, int>)(lpVtbl[9]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_XTilt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_XTilt(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, float*, int>)(lpVtbl[10]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_YTilt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_YTilt(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, float*, int>)(lpVtbl[11]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_Twist"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Twist(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, float*, int>)(lpVtbl[12]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_ContactRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ContactRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, Rect*, int>)(lpVtbl[13]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_ContactRectRaw"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ContactRectRaw([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, Rect*, int>)(lpVtbl[14]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_TouchConfidence"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_TouchConfidence([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, byte*, int>)(lpVtbl[15]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_IsLeftButtonPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_IsLeftButtonPressed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, byte*, int>)(lpVtbl[16]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_IsRightButtonPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_IsRightButtonPressed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, byte*, int>)(lpVtbl[17]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_IsMiddleButtonPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_IsMiddleButtonPressed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, byte*, int>)(lpVtbl[18]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_MouseWheelDelta"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_MouseWheelDelta([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, int*, int>)(lpVtbl[19]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_IsHorizontalMouseWheel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_IsHorizontalMouseWheel([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, byte*, int>)(lpVtbl[20]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_IsPrimary"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_IsPrimary([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, byte*, int>)(lpVtbl[21]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_IsInRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_IsInRange([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, byte*, int>)(lpVtbl[22]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_IsCanceled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, byte*, int>)(lpVtbl[23]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_IsBarrelButtonPressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_IsBarrelButtonPressed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, byte*, int>)(lpVtbl[24]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_IsXButton1Pressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_IsXButton1Pressed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, byte*, int>)(lpVtbl[25]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_IsXButton2Pressed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_IsXButton2Pressed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, byte*, int>)(lpVtbl[26]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.get_PointerUpdateKind"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_PointerUpdateKind([NativeTypeName("ABI::Windows::UI::Input::PointerUpdateKind *")] PointerUpdateKind* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, PointerUpdateKind*, int>)(lpVtbl[27]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.HasUsage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT HasUsage([NativeTypeName("UINT32")] uint usagePage, [NativeTypeName("UINT32")] uint usageId, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, uint, uint, byte*, int>)(lpVtbl[28]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), usagePage, usageId, value);
    }

    /// <include file='IPointerPointProperties.xml' path='doc/member[@name="IPointerPointProperties.GetUsageValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetUsageValue([NativeTypeName("UINT32")] uint usagePage, [NativeTypeName("UINT32")] uint usageId, [NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPointerPointProperties*, uint, uint, int*, int>)(lpVtbl[29]))((IPointerPointProperties*)Unsafe.AsPointer(ref this), usagePage, usageId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Pressure(float* value);

        [VtblIndex(7)]
        HRESULT get_IsInverted([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_IsEraser([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_Orientation(float* value);

        [VtblIndex(10)]
        HRESULT get_XTilt(float* value);

        [VtblIndex(11)]
        HRESULT get_YTilt(float* value);

        [VtblIndex(12)]
        HRESULT get_Twist(float* value);

        [VtblIndex(13)]
        HRESULT get_ContactRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(14)]
        HRESULT get_ContactRectRaw([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(15)]
        HRESULT get_TouchConfidence([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT get_IsLeftButtonPressed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT get_IsRightButtonPressed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(18)]
        HRESULT get_IsMiddleButtonPressed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT get_MouseWheelDelta([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(20)]
        HRESULT get_IsHorizontalMouseWheel([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(21)]
        HRESULT get_IsPrimary([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(22)]
        HRESULT get_IsInRange([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(23)]
        HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(24)]
        HRESULT get_IsBarrelButtonPressed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(25)]
        HRESULT get_IsXButton1Pressed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(26)]
        HRESULT get_IsXButton2Pressed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(27)]
        HRESULT get_PointerUpdateKind([NativeTypeName("ABI::Windows::UI::Input::PointerUpdateKind *")] PointerUpdateKind* value);

        [VtblIndex(28)]
        HRESULT HasUsage([NativeTypeName("UINT32")] uint usagePage, [NativeTypeName("UINT32")] uint usageId, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(29)]
        HRESULT GetUsageValue([NativeTypeName("UINT32")] uint usagePage, [NativeTypeName("UINT32")] uint usageId, [NativeTypeName("INT32 *")] int* value);
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

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Pressure;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsInverted;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsEraser;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Orientation;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_XTilt;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_YTilt;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_Twist;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> get_ContactRect;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Rect*, int> get_ContactRectRaw;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_TouchConfidence;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsLeftButtonPressed;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsRightButtonPressed;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsMiddleButtonPressed;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_MouseWheelDelta;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsHorizontalMouseWheel;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsPrimary;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsInRange;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsCanceled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsBarrelButtonPressed;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsXButton1Pressed;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsXButton2Pressed;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Input::PointerUpdateKind *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, PointerUpdateKind*, int> get_PointerUpdateKind;

        [NativeTypeName("HRESULT (UINT32, UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, byte*, int> HasUsage;

        [NativeTypeName("HRESULT (UINT32, UINT32, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, int*, int> GetUsageValue;
    }
}
