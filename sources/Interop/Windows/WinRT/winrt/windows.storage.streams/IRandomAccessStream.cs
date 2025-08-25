// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IRandomAccessStream.xml' path='doc/member[@name="IRandomAccessStream"]/*' />
[Guid("905A0FE1-BC53-11DF-8C49-001E4FC686DA")]
[NativeTypeName("struct IRandomAccessStream : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRandomAccessStream : IRandomAccessStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IRandomAccessStream);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStream*, Guid*, void**, int>)(lpVtbl[0]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStream*, uint>)(lpVtbl[1]))((IRandomAccessStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStream*, uint>)(lpVtbl[2]))((IRandomAccessStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStream*, uint*, Guid**, int>)(lpVtbl[3]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStream*, HSTRING*, int>)(lpVtbl[4]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStream*, TrustLevel*, int>)(lpVtbl[5]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IRandomAccessStream.xml' path='doc/member[@name="IRandomAccessStream.get_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Size([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStream*, ulong*, int>)(lpVtbl[6]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRandomAccessStream.xml' path='doc/member[@name="IRandomAccessStream.put_Size"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Size([NativeTypeName("UINT64")] ulong value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStream*, ulong, int>)(lpVtbl[7]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRandomAccessStream.xml' path='doc/member[@name="IRandomAccessStream.GetInputStreamAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetInputStreamAt([NativeTypeName("UINT64")] ulong position, [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** stream)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStream*, ulong, IInputStream**, int>)(lpVtbl[8]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), position, stream);
    }

    /// <include file='IRandomAccessStream.xml' path='doc/member[@name="IRandomAccessStream.GetOutputStreamAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetOutputStreamAt([NativeTypeName("UINT64")] ulong position, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** stream)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStream*, ulong, IOutputStream**, int>)(lpVtbl[9]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), position, stream);
    }

    /// <include file='IRandomAccessStream.xml' path='doc/member[@name="IRandomAccessStream.get_Position"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Position([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStream*, ulong*, int>)(lpVtbl[10]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRandomAccessStream.xml' path='doc/member[@name="IRandomAccessStream.Seek"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Seek([NativeTypeName("UINT64")] ulong position)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStream*, ulong, int>)(lpVtbl[11]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), position);
    }

    /// <include file='IRandomAccessStream.xml' path='doc/member[@name="IRandomAccessStream.CloneStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CloneStream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")] IRandomAccessStream** stream)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStream*, IRandomAccessStream**, int>)(lpVtbl[12]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), stream);
    }

    /// <include file='IRandomAccessStream.xml' path='doc/member[@name="IRandomAccessStream.get_CanRead"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_CanRead([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStream*, byte*, int>)(lpVtbl[13]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IRandomAccessStream.xml' path='doc/member[@name="IRandomAccessStream.get_CanWrite"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_CanWrite([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IRandomAccessStream*, byte*, int>)(lpVtbl[14]))((IRandomAccessStream*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Size([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        HRESULT put_Size([NativeTypeName("UINT64")] ulong value);

        [VtblIndex(8)]
        HRESULT GetInputStreamAt([NativeTypeName("UINT64")] ulong position, [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** stream);

        [VtblIndex(9)]
        HRESULT GetOutputStreamAt([NativeTypeName("UINT64")] ulong position, [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** stream);

        [VtblIndex(10)]
        HRESULT get_Position([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(11)]
        HRESULT Seek([NativeTypeName("UINT64")] ulong position);

        [VtblIndex(12)]
        HRESULT CloneStream([NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")] IRandomAccessStream** stream);

        [VtblIndex(13)]
        HRESULT get_CanRead([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT get_CanWrite([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_Size;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, int> put_Size;

        [NativeTypeName("HRESULT (UINT64, ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, IInputStream**, int> GetInputStreamAt;

        [NativeTypeName("HRESULT (UINT64, ABI::Windows::Storage::Streams::IOutputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, IOutputStream**, int> GetOutputStreamAt;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_Position;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, int> Seek;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IRandomAccessStream**, int> CloneStream;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanRead;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_CanWrite;
    }
}
