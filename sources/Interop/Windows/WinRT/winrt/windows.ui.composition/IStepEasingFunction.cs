// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStepEasingFunction.xml' path='doc/member[@name="IStepEasingFunction"]/*' />
[Guid("D0CAA74B-560C-4A0B-A5F6-206CA8C3ECD6")]
[NativeTypeName("struct IStepEasingFunction : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStepEasingFunction : IStepEasingFunction.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStepEasingFunction));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, Guid*, void**, int>)(lpVtbl[0]))((IStepEasingFunction*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, uint>)(lpVtbl[1]))((IStepEasingFunction*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, uint>)(lpVtbl[2]))((IStepEasingFunction*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, uint*, Guid**, int>)(lpVtbl[3]))((IStepEasingFunction*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, HSTRING*, int>)(lpVtbl[4]))((IStepEasingFunction*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, TrustLevel*, int>)(lpVtbl[5]))((IStepEasingFunction*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IStepEasingFunction.xml' path='doc/member[@name="IStepEasingFunction.get_FinalStep"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FinalStep([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, int*, int>)(lpVtbl[6]))((IStepEasingFunction*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStepEasingFunction.xml' path='doc/member[@name="IStepEasingFunction.put_FinalStep"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_FinalStep([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, int, int>)(lpVtbl[7]))((IStepEasingFunction*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStepEasingFunction.xml' path='doc/member[@name="IStepEasingFunction.get_InitialStep"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InitialStep([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, int*, int>)(lpVtbl[8]))((IStepEasingFunction*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStepEasingFunction.xml' path='doc/member[@name="IStepEasingFunction.put_InitialStep"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_InitialStep([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, int, int>)(lpVtbl[9]))((IStepEasingFunction*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStepEasingFunction.xml' path='doc/member[@name="IStepEasingFunction.get_IsFinalStepSingleFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsFinalStepSingleFrame([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, byte*, int>)(lpVtbl[10]))((IStepEasingFunction*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStepEasingFunction.xml' path='doc/member[@name="IStepEasingFunction.put_IsFinalStepSingleFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IsFinalStepSingleFrame([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, byte, int>)(lpVtbl[11]))((IStepEasingFunction*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStepEasingFunction.xml' path='doc/member[@name="IStepEasingFunction.get_IsInitialStepSingleFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsInitialStepSingleFrame([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, byte*, int>)(lpVtbl[12]))((IStepEasingFunction*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStepEasingFunction.xml' path='doc/member[@name="IStepEasingFunction.put_IsInitialStepSingleFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_IsInitialStepSingleFrame([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, byte, int>)(lpVtbl[13]))((IStepEasingFunction*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStepEasingFunction.xml' path='doc/member[@name="IStepEasingFunction.get_StepCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_StepCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, int*, int>)(lpVtbl[14]))((IStepEasingFunction*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IStepEasingFunction.xml' path='doc/member[@name="IStepEasingFunction.put_StepCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_StepCount([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<IStepEasingFunction*, int, int>)(lpVtbl[15]))((IStepEasingFunction*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FinalStep([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT put_FinalStep([NativeTypeName("INT32")] int value);

        [VtblIndex(8)]
        HRESULT get_InitialStep([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(9)]
        HRESULT put_InitialStep([NativeTypeName("INT32")] int value);

        [VtblIndex(10)]
        HRESULT get_IsFinalStepSingleFrame([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_IsFinalStepSingleFrame([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_IsInitialStepSingleFrame([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_IsInitialStepSingleFrame([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT get_StepCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(15)]
        HRESULT put_StepCount([NativeTypeName("INT32")] int value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_FinalStep;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_FinalStep;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_InitialStep;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_InitialStep;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsFinalStepSingleFrame;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsFinalStepSingleFrame;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsInitialStepSingleFrame;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsInitialStepSingleFrame;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_StepCount;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_StepCount;
    }
}
