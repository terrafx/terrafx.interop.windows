// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27354135-7F64-5B0F-8F00-5D77AFBE261E")]
    [NativeTypeName("struct IWriteEngine2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IWriteEngine2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWriteEngine2*, Guid*, void**, int>)(lpVtbl[0]))((IWriteEngine2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWriteEngine2*, uint>)(lpVtbl[1]))((IWriteEngine2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWriteEngine2*, uint>)(lpVtbl[2]))((IWriteEngine2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IWriteEngine2*, uint*, int>)(lpVtbl[3]))((IWriteEngine2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IWriteEngine2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IWriteEngine2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IWriteEngine2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IWriteEngine2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IWriteEngine2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IWriteEngine2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int WriteSection(IStream* data, [NativeTypeName("LONG")] int startingBlockAddress, [NativeTypeName("LONG")] int numberOfBlocks)
        {
            return ((delegate* unmanaged<IWriteEngine2*, IStream*, int, int, int>)(lpVtbl[7]))((IWriteEngine2*)Unsafe.AsPointer(ref this), data, startingBlockAddress, numberOfBlocks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int CancelWrite()
        {
            return ((delegate* unmanaged<IWriteEngine2*, int>)(lpVtbl[8]))((IWriteEngine2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_Recorder(IDiscRecorder2Ex* value)
        {
            return ((delegate* unmanaged<IWriteEngine2*, IDiscRecorder2Ex*, int>)(lpVtbl[9]))((IWriteEngine2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_Recorder(IDiscRecorder2Ex** value)
        {
            return ((delegate* unmanaged<IWriteEngine2*, IDiscRecorder2Ex**, int>)(lpVtbl[10]))((IWriteEngine2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_UseStreamingWrite12([NativeTypeName("VARIANT_BOOL")] short value)
        {
            return ((delegate* unmanaged<IWriteEngine2*, short, int>)(lpVtbl[11]))((IWriteEngine2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_UseStreamingWrite12([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IWriteEngine2*, short*, int>)(lpVtbl[12]))((IWriteEngine2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_StartingSectorsPerSecond([NativeTypeName("LONG")] int value)
        {
            return ((delegate* unmanaged<IWriteEngine2*, int, int>)(lpVtbl[13]))((IWriteEngine2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_StartingSectorsPerSecond([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IWriteEngine2*, int*, int>)(lpVtbl[14]))((IWriteEngine2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_EndingSectorsPerSecond([NativeTypeName("LONG")] int value)
        {
            return ((delegate* unmanaged<IWriteEngine2*, int, int>)(lpVtbl[15]))((IWriteEngine2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_EndingSectorsPerSecond([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IWriteEngine2*, int*, int>)(lpVtbl[16]))((IWriteEngine2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_BytesPerSector([NativeTypeName("LONG")] int value)
        {
            return ((delegate* unmanaged<IWriteEngine2*, int, int>)(lpVtbl[17]))((IWriteEngine2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_BytesPerSector([NativeTypeName("LONG *")] int* value)
        {
            return ((delegate* unmanaged<IWriteEngine2*, int*, int>)(lpVtbl[18]))((IWriteEngine2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_WriteInProgress([NativeTypeName("VARIANT_BOOL *")] short* value)
        {
            return ((delegate* unmanaged<IWriteEngine2*, short*, int>)(lpVtbl[19]))((IWriteEngine2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
