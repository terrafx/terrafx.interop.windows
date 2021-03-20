// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("64B89265-D341-4922-B38A-DD4AF8808C4E")]
    [NativeTypeName("struct IDataWriter : IInspectable")]
    public unsafe partial struct IDataWriter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDataWriter*, Guid*, void**, int>)(lpVtbl[0]))((IDataWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDataWriter*, uint>)(lpVtbl[1]))((IDataWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDataWriter*, uint>)(lpVtbl[2]))((IDataWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IDataWriter*, uint*, Guid**, int>)(lpVtbl[3]))((IDataWriter*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IDataWriter*, IntPtr*, int>)(lpVtbl[4]))((IDataWriter*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IDataWriter*, TrustLevel*, int>)(lpVtbl[5]))((IDataWriter*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UnstoredBufferLength([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IDataWriter*, uint*, int>)(lpVtbl[6]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UnicodeEncoding([NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding *")] UnicodeEncoding* value)
        {
            return ((delegate* unmanaged<IDataWriter*, UnicodeEncoding*, int>)(lpVtbl[7]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_UnicodeEncoding([NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding value)
        {
            return ((delegate* unmanaged<IDataWriter*, UnicodeEncoding, int>)(lpVtbl[8]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ByteOrder([NativeTypeName("ABI::Windows::Storage::Streams::ByteOrder *")] ByteOrder* value)
        {
            return ((delegate* unmanaged<IDataWriter*, ByteOrder*, int>)(lpVtbl[9]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ByteOrder([NativeTypeName("ABI::Windows::Storage::Streams::ByteOrder")] ByteOrder value)
        {
            return ((delegate* unmanaged<IDataWriter*, ByteOrder, int>)(lpVtbl[10]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteByte([NativeTypeName("BYTE")] byte value)
        {
            return ((delegate* unmanaged<IDataWriter*, byte, int>)(lpVtbl[11]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteBytes([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("BYTE *")] byte* value)
        {
            return ((delegate* unmanaged<IDataWriter*, uint, byte*, int>)(lpVtbl[12]))((IDataWriter*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer)
        {
            return ((delegate* unmanaged<IDataWriter*, IBuffer*, int>)(lpVtbl[13]))((IDataWriter*)Unsafe.AsPointer(ref this), buffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteBufferRange([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* buffer, [NativeTypeName("UINT32")] uint start, [NativeTypeName("UINT32")] uint count)
        {
            return ((delegate* unmanaged<IDataWriter*, IBuffer*, uint, uint, int>)(lpVtbl[14]))((IDataWriter*)Unsafe.AsPointer(ref this), buffer, start, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteBoolean([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<IDataWriter*, byte, int>)(lpVtbl[15]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteGuid([NativeTypeName("GUID")] Guid value)
        {
            return ((delegate* unmanaged<IDataWriter*, Guid, int>)(lpVtbl[16]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteInt16([NativeTypeName("INT16")] short value)
        {
            return ((delegate* unmanaged<IDataWriter*, short, int>)(lpVtbl[17]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteInt32([NativeTypeName("INT32")] int value)
        {
            return ((delegate* unmanaged<IDataWriter*, int, int>)(lpVtbl[18]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteInt64([NativeTypeName("INT64")] long value)
        {
            return ((delegate* unmanaged<IDataWriter*, long, int>)(lpVtbl[19]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteUInt16([NativeTypeName("UINT16")] ushort value)
        {
            return ((delegate* unmanaged<IDataWriter*, ushort, int>)(lpVtbl[20]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteUInt32([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IDataWriter*, uint, int>)(lpVtbl[21]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteUInt64([NativeTypeName("UINT64")] ulong value)
        {
            return ((delegate* unmanaged<IDataWriter*, ulong, int>)(lpVtbl[22]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteSingle([NativeTypeName("FLOAT")] float value)
        {
            return ((delegate* unmanaged<IDataWriter*, float, int>)(lpVtbl[23]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteDouble([NativeTypeName("DOUBLE")] double value)
        {
            return ((delegate* unmanaged<IDataWriter*, double, int>)(lpVtbl[24]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteDateTime([NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime value)
        {
            return ((delegate* unmanaged<IDataWriter*, DateTime, int>)(lpVtbl[25]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteTimeSpan([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
        {
            return ((delegate* unmanaged<IDataWriter*, TimeSpan, int>)(lpVtbl[26]))((IDataWriter*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteString([NativeTypeName("HSTRING")] IntPtr value, [NativeTypeName("UINT32 *")] uint* codeUnitCount)
        {
            return ((delegate* unmanaged<IDataWriter*, IntPtr, uint*, int>)(lpVtbl[27]))((IDataWriter*)Unsafe.AsPointer(ref this), value, codeUnitCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MeasureString([NativeTypeName("HSTRING")] IntPtr value, [NativeTypeName("UINT32 *")] uint* codeUnitCount)
        {
            return ((delegate* unmanaged<IDataWriter*, IntPtr, uint*, int>)(lpVtbl[28]))((IDataWriter*)Unsafe.AsPointer(ref this), value, codeUnitCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StoreAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** operation)
        {
            return ((delegate* unmanaged<IDataWriter*, IAsyncOperation<uint>**, int>)(lpVtbl[29]))((IDataWriter*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FlushAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** operation)
        {
            return ((delegate* unmanaged<IDataWriter*, IAsyncOperation<byte>**, int>)(lpVtbl[30]))((IDataWriter*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DetachBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer)
        {
            return ((delegate* unmanaged<IDataWriter*, IBuffer**, int>)(lpVtbl[31]))((IDataWriter*)Unsafe.AsPointer(ref this), buffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DetachStream([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream** outputStream)
        {
            return ((delegate* unmanaged<IDataWriter*, IOutputStream**, int>)(lpVtbl[32]))((IDataWriter*)Unsafe.AsPointer(ref this), outputStream);
        }
    }
}
