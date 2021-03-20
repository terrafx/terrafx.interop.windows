// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E2B50029-B4C1-4314-A4B8-FB813A2F275E")]
    [NativeTypeName("struct IDataReader : IInspectable")]
    public unsafe partial struct IDataReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDataReader*, Guid*, void**, int>)(lpVtbl[0]))((IDataReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDataReader*, uint>)(lpVtbl[1]))((IDataReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDataReader*, uint>)(lpVtbl[2]))((IDataReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IDataReader*, uint*, Guid**, int>)(lpVtbl[3]))((IDataReader*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IDataReader*, IntPtr*, int>)(lpVtbl[4]))((IDataReader*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IDataReader*, TrustLevel*, int>)(lpVtbl[5]))((IDataReader*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UnconsumedBufferLength([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IDataReader*, uint*, int>)(lpVtbl[6]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UnicodeEncoding([NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding *")] UnicodeEncoding* value)
        {
            return ((delegate* unmanaged<IDataReader*, UnicodeEncoding*, int>)(lpVtbl[7]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_UnicodeEncoding([NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding value)
        {
            return ((delegate* unmanaged<IDataReader*, UnicodeEncoding, int>)(lpVtbl[8]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ByteOrder([NativeTypeName("ABI::Windows::Storage::Streams::ByteOrder *")] ByteOrder* value)
        {
            return ((delegate* unmanaged<IDataReader*, ByteOrder*, int>)(lpVtbl[9]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ByteOrder([NativeTypeName("ABI::Windows::Storage::Streams::ByteOrder")] ByteOrder value)
        {
            return ((delegate* unmanaged<IDataReader*, ByteOrder, int>)(lpVtbl[10]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InputStreamOptions([NativeTypeName("ABI::Windows::Storage::Streams::InputStreamOptions *")] InputStreamOptions* value)
        {
            return ((delegate* unmanaged<IDataReader*, InputStreamOptions*, int>)(lpVtbl[11]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_InputStreamOptions([NativeTypeName("ABI::Windows::Storage::Streams::InputStreamOptions")] InputStreamOptions value)
        {
            return ((delegate* unmanaged<IDataReader*, InputStreamOptions, int>)(lpVtbl[12]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadByte([NativeTypeName("BYTE *")] byte* value)
        {
            return ((delegate* unmanaged<IDataReader*, byte*, int>)(lpVtbl[13]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadBytes([NativeTypeName("UINT32")] uint valueLength, [NativeTypeName("BYTE *")] byte* value)
        {
            return ((delegate* unmanaged<IDataReader*, uint, byte*, int>)(lpVtbl[14]))((IDataReader*)Unsafe.AsPointer(ref this), valueLength, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadBuffer([NativeTypeName("UINT32")] uint length, [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer)
        {
            return ((delegate* unmanaged<IDataReader*, uint, IBuffer**, int>)(lpVtbl[15]))((IDataReader*)Unsafe.AsPointer(ref this), length, buffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadBoolean([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IDataReader*, byte*, int>)(lpVtbl[16]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadGuid([NativeTypeName("GUID *")] Guid* value)
        {
            return ((delegate* unmanaged<IDataReader*, Guid*, int>)(lpVtbl[17]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadInt16([NativeTypeName("INT16 *")] short* value)
        {
            return ((delegate* unmanaged<IDataReader*, short*, int>)(lpVtbl[18]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadInt32([NativeTypeName("INT32 *")] int* value)
        {
            return ((delegate* unmanaged<IDataReader*, int*, int>)(lpVtbl[19]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadInt64([NativeTypeName("INT64 *")] long* value)
        {
            return ((delegate* unmanaged<IDataReader*, long*, int>)(lpVtbl[20]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadUInt16([NativeTypeName("UINT16 *")] ushort* value)
        {
            return ((delegate* unmanaged<IDataReader*, ushort*, int>)(lpVtbl[21]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadUInt32([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IDataReader*, uint*, int>)(lpVtbl[22]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadUInt64([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IDataReader*, ulong*, int>)(lpVtbl[23]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadSingle([NativeTypeName("FLOAT *")] float* value)
        {
            return ((delegate* unmanaged<IDataReader*, float*, int>)(lpVtbl[24]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadDouble([NativeTypeName("DOUBLE *")] double* value)
        {
            return ((delegate* unmanaged<IDataReader*, double*, int>)(lpVtbl[25]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadString([NativeTypeName("UINT32")] uint codeUnitCount, [NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IDataReader*, uint, IntPtr*, int>)(lpVtbl[26]))((IDataReader*)Unsafe.AsPointer(ref this), codeUnitCount, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadDateTime([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
        {
            return ((delegate* unmanaged<IDataReader*, DateTime*, int>)(lpVtbl[27]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadTimeSpan([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
        {
            return ((delegate* unmanaged<IDataReader*, TimeSpan*, int>)(lpVtbl[28]))((IDataReader*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadAsync([NativeTypeName("UINT32")] uint count, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** operation)
        {
            return ((delegate* unmanaged<IDataReader*, uint, IAsyncOperation<uint>**, int>)(lpVtbl[29]))((IDataReader*)Unsafe.AsPointer(ref this), count, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DetachBuffer([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer** buffer)
        {
            return ((delegate* unmanaged<IDataReader*, IBuffer**, int>)(lpVtbl[30]))((IDataReader*)Unsafe.AsPointer(ref this), buffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DetachStream([NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream** stream)
        {
            return ((delegate* unmanaged<IDataReader*, IInputStream**, int>)(lpVtbl[31]))((IDataReader*)Unsafe.AsPointer(ref this), stream);
        }
    }
}
