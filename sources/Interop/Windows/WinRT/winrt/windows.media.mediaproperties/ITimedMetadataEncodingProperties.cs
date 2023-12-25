// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ITimedMetadataEncodingProperties.xml' path='doc/member[@name="ITimedMetadataEncodingProperties"]/*' />
[Guid("51CD30D3-D690-4CFA-97F4-4A398E9DB420")]
[NativeTypeName("struct ITimedMetadataEncodingProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedMetadataEncodingProperties : ITimedMetadataEncodingProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedMetadataEncodingProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingProperties*, Guid*, void**, int>)(lpVtbl[0]))((ITimedMetadataEncodingProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingProperties*, uint>)(lpVtbl[1]))((ITimedMetadataEncodingProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingProperties*, uint>)(lpVtbl[2]))((ITimedMetadataEncodingProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingProperties*, uint*, Guid**, int>)(lpVtbl[3]))((ITimedMetadataEncodingProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingProperties*, HSTRING*, int>)(lpVtbl[4]))((ITimedMetadataEncodingProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingProperties*, TrustLevel*, int>)(lpVtbl[5]))((ITimedMetadataEncodingProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ITimedMetadataEncodingProperties.xml' path='doc/member[@name="ITimedMetadataEncodingProperties.SetFormatUserData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetFormatUserData([NativeTypeName("UINT32")] uint valueLength, byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingProperties*, uint, byte*, int>)(lpVtbl[6]))((ITimedMetadataEncodingProperties*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='ITimedMetadataEncodingProperties.xml' path='doc/member[@name="ITimedMetadataEncodingProperties.GetFormatUserData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFormatUserData([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingProperties*, uint*, byte**, int>)(lpVtbl[7]))((ITimedMetadataEncodingProperties*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='ITimedMetadataEncodingProperties.xml' path='doc/member[@name="ITimedMetadataEncodingProperties.Copy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Copy([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")] IMediaEncodingProperties** result)
    {
        return ((delegate* unmanaged[MemberFunction]<ITimedMetadataEncodingProperties*, IMediaEncodingProperties**, int>)(lpVtbl[8]))((ITimedMetadataEncodingProperties*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetFormatUserData([NativeTypeName("UINT32")] uint valueLength, byte* value);

        [VtblIndex(7)]
        HRESULT GetFormatUserData([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(8)]
        HRESULT Copy([NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **")] IMediaEncodingProperties** result);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaEncodingProperties**, int> Copy;
    }
}
