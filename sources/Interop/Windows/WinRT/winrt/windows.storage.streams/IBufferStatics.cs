// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBufferStatics.xml' path='doc/member[@name="IBufferStatics"]/*' />
[Guid("E901E65B-D716-475A-A90A-AF7229B1E741")]
[NativeTypeName("struct IBufferStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBufferStatics : IBufferStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBufferStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBufferStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferStatics*, uint>)(lpVtbl[1]))((IBufferStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferStatics*, uint>)(lpVtbl[2]))((IBufferStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBufferStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferStatics*, HSTRING*, int>)(lpVtbl[4]))((IBufferStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBufferStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBufferStatics.xml' path='doc/member[@name="IBufferStatics.CreateCopyFromMemoryBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateCopyFromMemoryBuffer([NativeTypeName("ABI::Windows::Foundation::IMemoryBuffer *")] IMemoryBuffer* input, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferStatics*, IMemoryBuffer*, IBuffer**, int>)(lpVtbl[6]))((IBufferStatics*)Unsafe.AsPointer(ref this), input, value);
    }

    /// <include file='IBufferStatics.xml' path='doc/member[@name="IBufferStatics.CreateMemoryBufferOverIBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateMemoryBufferOverIBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* input, [NativeTypeName("ABI::Windows::Foundation::IMemoryBuffer **")] IMemoryBuffer** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBufferStatics*, IBuffer*, IMemoryBuffer**, int>)(lpVtbl[7]))((IBufferStatics*)Unsafe.AsPointer(ref this), input, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateCopyFromMemoryBuffer([NativeTypeName("ABI::Windows::Foundation::IMemoryBuffer *")] IMemoryBuffer* input, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** value);

        [VtblIndex(7)]
        HRESULT CreateMemoryBufferOverIBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* input, [NativeTypeName("ABI::Windows::Foundation::IMemoryBuffer **")] IMemoryBuffer** value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::IMemoryBuffer *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMemoryBuffer*, IBuffer**, int> CreateCopyFromMemoryBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::IMemoryBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, IMemoryBuffer**, int> CreateMemoryBufferOverIBuffer;
    }
}
