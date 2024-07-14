// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVariablePhotoCapturedEventArgs.xml' path='doc/member[@name="IVariablePhotoCapturedEventArgs"]/*' />
[Guid("D1EB4C5C-1B53-4E4A-8B5C-DB7887AC949B")]
[NativeTypeName("struct IVariablePhotoCapturedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVariablePhotoCapturedEventArgs : IVariablePhotoCapturedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVariablePhotoCapturedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoCapturedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IVariablePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoCapturedEventArgs*, uint>)(lpVtbl[1]))((IVariablePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoCapturedEventArgs*, uint>)(lpVtbl[2]))((IVariablePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoCapturedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IVariablePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoCapturedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IVariablePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoCapturedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IVariablePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVariablePhotoCapturedEventArgs.xml' path='doc/member[@name="IVariablePhotoCapturedEventArgs.get_Frame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Frame([NativeTypeName("ABI::Windows::Media::Capture::ICapturedFrame **")] ICapturedFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoCapturedEventArgs*, ICapturedFrame**, int>)(lpVtbl[6]))((IVariablePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVariablePhotoCapturedEventArgs.xml' path='doc/member[@name="IVariablePhotoCapturedEventArgs.get_CaptureTimeOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CaptureTimeOffset([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoCapturedEventArgs*, TimeSpan*, int>)(lpVtbl[7]))((IVariablePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVariablePhotoCapturedEventArgs.xml' path='doc/member[@name="IVariablePhotoCapturedEventArgs.get_UsedFrameControllerIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_UsedFrameControllerIndex([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoCapturedEventArgs*, IReference<uint>**, int>)(lpVtbl[8]))((IVariablePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVariablePhotoCapturedEventArgs.xml' path='doc/member[@name="IVariablePhotoCapturedEventArgs.get_CapturedFrameControlValues"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CapturedFrameControlValues([NativeTypeName("ABI::Windows::Media::Capture::ICapturedFrameControlValues **")] ICapturedFrameControlValues** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVariablePhotoCapturedEventArgs*, ICapturedFrameControlValues**, int>)(lpVtbl[9]))((IVariablePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Frame([NativeTypeName("ABI::Windows::Media::Capture::ICapturedFrame **")] ICapturedFrame** value);

        [VtblIndex(7)]
        HRESULT get_CaptureTimeOffset([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(8)]
        HRESULT get_UsedFrameControllerIndex([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value);

        [VtblIndex(9)]
        HRESULT get_CapturedFrameControlValues([NativeTypeName("ABI::Windows::Media::Capture::ICapturedFrameControlValues **")] ICapturedFrameControlValues** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::ICapturedFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICapturedFrame**, int> get_Frame;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_CaptureTimeOffset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IReference<uint>**, int> get_UsedFrameControllerIndex;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Capture::ICapturedFrameControlValues **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICapturedFrameControlValues**, int> get_CapturedFrameControlValues;
    }
}
