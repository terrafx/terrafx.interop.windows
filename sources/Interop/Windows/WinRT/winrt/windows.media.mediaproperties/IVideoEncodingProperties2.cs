// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IVideoEncodingProperties2.xml' path='doc/member[@name="IVideoEncodingProperties2"]/*' />
[Guid("F743A1EF-D465-4290-A94B-EF0F1528F8E3")]
[NativeTypeName("struct IVideoEncodingProperties2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoEncodingProperties2 : IVideoEncodingProperties2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoEncodingProperties2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingProperties2*, Guid*, void**, int>)(lpVtbl[0]))((IVideoEncodingProperties2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingProperties2*, uint>)(lpVtbl[1]))((IVideoEncodingProperties2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingProperties2*, uint>)(lpVtbl[2]))((IVideoEncodingProperties2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingProperties2*, uint*, Guid**, int>)(lpVtbl[3]))((IVideoEncodingProperties2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingProperties2*, HSTRING*, int>)(lpVtbl[4]))((IVideoEncodingProperties2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingProperties2*, TrustLevel*, int>)(lpVtbl[5]))((IVideoEncodingProperties2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IVideoEncodingProperties2.xml' path='doc/member[@name="IVideoEncodingProperties2.SetFormatUserData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetFormatUserData([NativeTypeName("UINT32")] uint valueLength, byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingProperties2*, uint, byte*, int>)(lpVtbl[6]))((IVideoEncodingProperties2*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IVideoEncodingProperties2.xml' path='doc/member[@name="IVideoEncodingProperties2.GetFormatUserData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFormatUserData([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingProperties2*, uint*, byte**, int>)(lpVtbl[7]))((IVideoEncodingProperties2*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IVideoEncodingProperties2.xml' path='doc/member[@name="IVideoEncodingProperties2.put_ProfileId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ProfileId([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingProperties2*, int, int>)(lpVtbl[8]))((IVideoEncodingProperties2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IVideoEncodingProperties2.xml' path='doc/member[@name="IVideoEncodingProperties2.get_ProfileId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ProfileId([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IVideoEncodingProperties2*, int*, int>)(lpVtbl[9]))((IVideoEncodingProperties2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetFormatUserData([NativeTypeName("UINT32")] uint valueLength, byte* value);

        [VtblIndex(7)]
        HRESULT GetFormatUserData([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(8)]
        HRESULT put_ProfileId([NativeTypeName("INT32")] int value);

        [VtblIndex(9)]
        HRESULT get_ProfileId([NativeTypeName("INT32 *")] int* value);
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

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> SetFormatUserData;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, byte**, int> GetFormatUserData;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_ProfileId;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ProfileId;
    }
}
