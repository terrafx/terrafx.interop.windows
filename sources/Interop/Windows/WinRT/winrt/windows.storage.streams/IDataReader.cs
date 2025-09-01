// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IDataReader.xml' path='doc/member[@name="IDataReader"]/*' />
[Guid("E2B50029-B4C1-4314-A4B8-FB813A2F275E")]
[NativeTypeName("struct IDataReader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataReader : IDataReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDataReader);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, Guid*, void**, int>)(lpVtbl[0]))((IDataReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, uint>)(lpVtbl[1]))((IDataReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, uint>)(lpVtbl[2]))((IDataReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, uint*, Guid**, int>)(lpVtbl[3]))((IDataReader*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, HSTRING*, int>)(lpVtbl[4]))((IDataReader*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, TrustLevel*, int>)(lpVtbl[5]))((IDataReader*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.get_UnconsumedBufferLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_UnconsumedBufferLength([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, uint*, int>)(lpVtbl[6]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.get_UnicodeEncoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_UnicodeEncoding([NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding *")] UnicodeEncoding* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, UnicodeEncoding*, int>)(lpVtbl[7]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.put_UnicodeEncoding"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_UnicodeEncoding([NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, UnicodeEncoding, int>)(lpVtbl[8]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.get_ByteOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ByteOrder([NativeTypeName("ABI::Windows::Storage::Streams::ByteOrder *")] ByteOrder* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, ByteOrder*, int>)(lpVtbl[9]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.put_ByteOrder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ByteOrder([NativeTypeName("ABI::Windows::Storage::Streams::ByteOrder")] ByteOrder value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, ByteOrder, int>)(lpVtbl[10]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.get_InputStreamOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_InputStreamOptions([NativeTypeName("ABI::Windows::Storage::Streams::InputStreamOptions *")] InputStreamOptions* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, InputStreamOptions*, int>)(lpVtbl[11]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.put_InputStreamOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_InputStreamOptions([NativeTypeName("ABI::Windows::Storage::Streams::InputStreamOptions")] InputStreamOptions value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, InputStreamOptions, int>)(lpVtbl[12]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadByte"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ReadByte(byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, byte*, int>)(lpVtbl[13]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ReadBytes([NativeTypeName("UINT32")] uint valueLength, byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, uint, byte*, int>)(lpVtbl[14]))((IDataReader*)Unsafe.AsPointer(ref this), valueLength, value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ReadBuffer([NativeTypeName("UINT32")] uint length, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, uint, IBuffer**, int>)(lpVtbl[15]))((IDataReader*)Unsafe.AsPointer(ref this), length, buffer);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadBoolean"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ReadBoolean([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, byte*, int>)(lpVtbl[16]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadGuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ReadGuid(Guid* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, Guid*, int>)(lpVtbl[17]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadInt16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ReadInt16([NativeTypeName("INT16 *")] short* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, short*, int>)(lpVtbl[18]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadInt32"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ReadInt32([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, int*, int>)(lpVtbl[19]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadInt64"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT ReadInt64([NativeTypeName("INT64 *")] long* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, long*, int>)(lpVtbl[20]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadUInt16"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT ReadUInt16([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, ushort*, int>)(lpVtbl[21]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadUInt32"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT ReadUInt32([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, uint*, int>)(lpVtbl[22]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadUInt64"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT ReadUInt64([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, ulong*, int>)(lpVtbl[23]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadSingle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT ReadSingle(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, float*, int>)(lpVtbl[24]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadDouble"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT ReadDouble(double* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, double*, int>)(lpVtbl[25]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT ReadString([NativeTypeName("UINT32")] uint codeUnitCount, HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, uint, HSTRING*, int>)(lpVtbl[26]))((IDataReader*)Unsafe.AsPointer(ref this), codeUnitCount, value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadDateTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT ReadDateTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, WinRTDateTime*, int>)(lpVtbl[27]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.ReadTimeSpan"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT ReadTimeSpan([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, TimeSpan*, int>)(lpVtbl[28]))((IDataReader*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.LoadAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT LoadAsync([NativeTypeName("UINT32")] uint count, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, uint, IAsyncOperation<uint>**, int>)(lpVtbl[29]))((IDataReader*)Unsafe.AsPointer(ref this), count, operation);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.DetachBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT DetachBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, IBuffer**, int>)(lpVtbl[30]))((IDataReader*)Unsafe.AsPointer(ref this), buffer);
    }

    /// <include file='IDataReader.xml' path='doc/member[@name="IDataReader.DetachStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT DetachStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** stream)
    {
        return ((delegate* unmanaged[MemberFunction]<IDataReader*, IInputStream**, int>)(lpVtbl[31]))((IDataReader*)Unsafe.AsPointer(ref this), stream);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_UnconsumedBufferLength([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_UnicodeEncoding([NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding *")] UnicodeEncoding* value);

        [VtblIndex(8)]
        HRESULT put_UnicodeEncoding([NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding value);

        [VtblIndex(9)]
        HRESULT get_ByteOrder([NativeTypeName("ABI::Windows::Storage::Streams::ByteOrder *")] ByteOrder* value);

        [VtblIndex(10)]
        HRESULT put_ByteOrder([NativeTypeName("ABI::Windows::Storage::Streams::ByteOrder")] ByteOrder value);

        [VtblIndex(11)]
        HRESULT get_InputStreamOptions([NativeTypeName("ABI::Windows::Storage::Streams::InputStreamOptions *")] InputStreamOptions* value);

        [VtblIndex(12)]
        HRESULT put_InputStreamOptions([NativeTypeName("ABI::Windows::Storage::Streams::InputStreamOptions")] InputStreamOptions value);

        [VtblIndex(13)]
        HRESULT ReadByte(byte* value);

        [VtblIndex(14)]
        HRESULT ReadBytes([NativeTypeName("UINT32")] uint valueLength, byte* value);

        [VtblIndex(15)]
        HRESULT ReadBuffer([NativeTypeName("UINT32")] uint length, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer);

        [VtblIndex(16)]
        HRESULT ReadBoolean([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT ReadGuid(Guid* value);

        [VtblIndex(18)]
        HRESULT ReadInt16([NativeTypeName("INT16 *")] short* value);

        [VtblIndex(19)]
        HRESULT ReadInt32([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(20)]
        HRESULT ReadInt64([NativeTypeName("INT64 *")] long* value);

        [VtblIndex(21)]
        HRESULT ReadUInt16([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(22)]
        HRESULT ReadUInt32([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(23)]
        HRESULT ReadUInt64([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(24)]
        HRESULT ReadSingle(float* value);

        [VtblIndex(25)]
        HRESULT ReadDouble(double* value);

        [VtblIndex(26)]
        HRESULT ReadString([NativeTypeName("UINT32")] uint codeUnitCount, HSTRING* value);

        [VtblIndex(27)]
        HRESULT ReadDateTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value);

        [VtblIndex(28)]
        HRESULT ReadTimeSpan([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(29)]
        HRESULT LoadAsync([NativeTypeName("UINT32")] uint count, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** operation);

        [VtblIndex(30)]
        HRESULT DetachBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer);

        [VtblIndex(31)]
        HRESULT DetachStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** stream);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_UnconsumedBufferLength;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::UnicodeEncoding *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UnicodeEncoding*, int> get_UnicodeEncoding;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::UnicodeEncoding) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, UnicodeEncoding, int> put_UnicodeEncoding;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::ByteOrder *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ByteOrder*, int> get_ByteOrder;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::ByteOrder) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ByteOrder, int> put_ByteOrder;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::InputStreamOptions *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, InputStreamOptions*, int> get_InputStreamOptions;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::InputStreamOptions) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, InputStreamOptions, int> put_InputStreamOptions;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> ReadByte;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, byte*, int> ReadBytes;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IBuffer**, int> ReadBuffer;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> ReadBoolean;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> ReadGuid;

        [NativeTypeName("HRESULT (INT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, short*, int> ReadInt16;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> ReadInt32;

        [NativeTypeName("HRESULT (INT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, long*, int> ReadInt64;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort*, int> ReadUInt16;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> ReadUInt32;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> ReadUInt64;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> ReadSingle;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> ReadDouble;

        [NativeTypeName("HRESULT (UINT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, HSTRING*, int> ReadString;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WinRTDateTime*, int> ReadDateTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> ReadTimeSpan;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IAsyncOperation<uint>**, int> LoadAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer**, int> DetachBuffer;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInputStream**, int> DetachStream;
    }
}
