// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IOptionalReferencePhotoCapturedEventArgs.xml' path='doc/member[@name="IOptionalReferencePhotoCapturedEventArgs"]/*' />
[Guid("470F88B3-1E6D-4051-9C8B-F1D85AF047B7")]
[NativeTypeName("struct IOptionalReferencePhotoCapturedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IOptionalReferencePhotoCapturedEventArgs : IOptionalReferencePhotoCapturedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IOptionalReferencePhotoCapturedEventArgs);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IOptionalReferencePhotoCapturedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IOptionalReferencePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IOptionalReferencePhotoCapturedEventArgs*, uint>)(lpVtbl[1]))((IOptionalReferencePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IOptionalReferencePhotoCapturedEventArgs*, uint>)(lpVtbl[2]))((IOptionalReferencePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IOptionalReferencePhotoCapturedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IOptionalReferencePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IOptionalReferencePhotoCapturedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((IOptionalReferencePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IOptionalReferencePhotoCapturedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IOptionalReferencePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IOptionalReferencePhotoCapturedEventArgs.xml' path='doc/member[@name="IOptionalReferencePhotoCapturedEventArgs.get_Frame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Frame([NativeTypeName("ABI::Windows::Media::Capture::ICapturedFrame **")] ICapturedFrame** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOptionalReferencePhotoCapturedEventArgs*, ICapturedFrame**, int>)(lpVtbl[6]))((IOptionalReferencePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IOptionalReferencePhotoCapturedEventArgs.xml' path='doc/member[@name="IOptionalReferencePhotoCapturedEventArgs.get_Context"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Context(IInspectable** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IOptionalReferencePhotoCapturedEventArgs*, IInspectable**, int>)(lpVtbl[7]))((IOptionalReferencePhotoCapturedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Frame([NativeTypeName("ABI::Windows::Media::Capture::ICapturedFrame **")] ICapturedFrame** value);

        [VtblIndex(7)]
        HRESULT get_Context(IInspectable** value);
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

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> get_Context;
    }
}
