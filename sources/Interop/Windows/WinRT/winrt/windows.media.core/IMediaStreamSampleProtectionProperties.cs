// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaStreamSampleProtectionProperties.xml' path='doc/member[@name="IMediaStreamSampleProtectionProperties"]/*' />
[Guid("4EB88292-ECDF-493E-841D-DD4ADD7CACA2")]
[NativeTypeName("struct IMediaStreamSampleProtectionProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaStreamSampleProtectionProperties : IMediaStreamSampleProtectionProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaStreamSampleProtectionProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleProtectionProperties*, Guid*, void**, int>)(lpVtbl[0]))((IMediaStreamSampleProtectionProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleProtectionProperties*, uint>)(lpVtbl[1]))((IMediaStreamSampleProtectionProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleProtectionProperties*, uint>)(lpVtbl[2]))((IMediaStreamSampleProtectionProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleProtectionProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaStreamSampleProtectionProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleProtectionProperties*, HSTRING*, int>)(lpVtbl[4]))((IMediaStreamSampleProtectionProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleProtectionProperties*, TrustLevel*, int>)(lpVtbl[5]))((IMediaStreamSampleProtectionProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaStreamSampleProtectionProperties.xml' path='doc/member[@name="IMediaStreamSampleProtectionProperties.SetKeyIdentifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetKeyIdentifier([NativeTypeName("UINT32")] uint valueLength, byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleProtectionProperties*, uint, byte*, int>)(lpVtbl[6]))((IMediaStreamSampleProtectionProperties*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IMediaStreamSampleProtectionProperties.xml' path='doc/member[@name="IMediaStreamSampleProtectionProperties.GetKeyIdentifier"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetKeyIdentifier([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleProtectionProperties*, uint*, byte**, int>)(lpVtbl[7]))((IMediaStreamSampleProtectionProperties*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IMediaStreamSampleProtectionProperties.xml' path='doc/member[@name="IMediaStreamSampleProtectionProperties.SetInitializationVector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetInitializationVector([NativeTypeName("UINT32")] uint valueLength, byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleProtectionProperties*, uint, byte*, int>)(lpVtbl[8]))((IMediaStreamSampleProtectionProperties*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IMediaStreamSampleProtectionProperties.xml' path='doc/member[@name="IMediaStreamSampleProtectionProperties.GetInitializationVector"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetInitializationVector([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleProtectionProperties*, uint*, byte**, int>)(lpVtbl[9]))((IMediaStreamSampleProtectionProperties*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IMediaStreamSampleProtectionProperties.xml' path='doc/member[@name="IMediaStreamSampleProtectionProperties.SetSubSampleMapping"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetSubSampleMapping([NativeTypeName("UINT32")] uint valueLength, byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleProtectionProperties*, uint, byte*, int>)(lpVtbl[10]))((IMediaStreamSampleProtectionProperties*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IMediaStreamSampleProtectionProperties.xml' path='doc/member[@name="IMediaStreamSampleProtectionProperties.GetSubSampleMapping"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSubSampleMapping([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaStreamSampleProtectionProperties*, uint*, byte**, int>)(lpVtbl[11]))((IMediaStreamSampleProtectionProperties*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetKeyIdentifier([NativeTypeName("UINT32")] uint valueLength, byte* value);

        [VtblIndex(7)]
        HRESULT GetKeyIdentifier([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(8)]
        HRESULT SetInitializationVector([NativeTypeName("UINT32")] uint valueLength, byte* value);

        [VtblIndex(9)]
        HRESULT GetInitializationVector([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(10)]
        HRESULT SetSubSampleMapping([NativeTypeName("UINT32")] uint valueLength, byte* value);

        [VtblIndex(11)]
        HRESULT GetSubSampleMapping([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> SetKeyIdentifier;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, byte**, int> GetKeyIdentifier;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> SetInitializationVector;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, byte**, int> GetInitializationVector;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> SetSubSampleMapping;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, byte**, int> GetSubSampleMapping;
    }
}
