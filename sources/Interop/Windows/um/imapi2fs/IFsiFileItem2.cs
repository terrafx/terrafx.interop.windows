// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("199D0C19-11E1-40EB-8EC2-C8C822A07792")]
    [NativeTypeName("struct IFsiFileItem2 : IFsiFileItem")]
    [NativeInheritance("IFsiFileItem")]
    public unsafe partial struct IFsiFileItem2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, Guid*, void**, int>)(lpVtbl[0]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFsiFileItem2*, uint>)(lpVtbl[1]))((IFsiFileItem2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFsiFileItem2*, uint>)(lpVtbl[2]))((IFsiFileItem2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, uint*, int>)(lpVtbl[3]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, ushort**, int>)(lpVtbl[7]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_FullPath([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, ushort**, int>)(lpVtbl[8]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_CreationTime([NativeTypeName("DATE *")] double* pVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, double*, int>)(lpVtbl[9]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int put_CreationTime([NativeTypeName("DATE")] double newVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, double, int>)(lpVtbl[10]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_LastAccessedTime([NativeTypeName("DATE *")] double* pVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, double*, int>)(lpVtbl[11]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int put_LastAccessedTime([NativeTypeName("DATE")] double newVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, double, int>)(lpVtbl[12]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_LastModifiedTime([NativeTypeName("DATE *")] double* pVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, double*, int>)(lpVtbl[13]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int put_LastModifiedTime([NativeTypeName("DATE")] double newVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, double, int>)(lpVtbl[14]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsHidden([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, short*, int>)(lpVtbl[15]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_IsHidden([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, short, int>)(lpVtbl[16]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int FileSystemName(FsiFileSystems fileSystem, [NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, FsiFileSystems, ushort**, int>)(lpVtbl[17]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), fileSystem, pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int FileSystemPath(FsiFileSystems fileSystem, [NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, FsiFileSystems, ushort**, int>)(lpVtbl[18]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), fileSystem, pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_DataSize([NativeTypeName("LONGLONG *")] long* pVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, long*, int>)(lpVtbl[19]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_DataSize32BitLow([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, int*, int>)(lpVtbl[20]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_DataSize32BitHigh([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, int*, int>)(lpVtbl[21]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_Data(IStream** pVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, IStream**, int>)(lpVtbl[22]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_Data(IStream* newVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, IStream*, int>)(lpVtbl[23]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_FsiNamedStreams(IFsiNamedStreams** streams)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, IFsiNamedStreams**, int>)(lpVtbl[24]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), streams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsNamedStream([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, short*, int>)(lpVtbl[25]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int AddStream([NativeTypeName("BSTR")] ushort* name, IStream* streamData)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, ushort*, IStream*, int>)(lpVtbl[26]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), name, streamData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveStream([NativeTypeName("BSTR")] ushort* name)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, ushort*, int>)(lpVtbl[27]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsRealTime([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, short*, int>)(lpVtbl[28]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_IsRealTime([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFsiFileItem2*, short, int>)(lpVtbl[29]))((IFsiFileItem2*)Unsafe.AsPointer(ref this), newVal);
        }
    }
}
