// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("64CE6CD5-7315-4328-86D6-10E303E010B4")]
    [NativeTypeName("struct IDiaSymbol7 : IDiaSymbol6")]
    [NativeInheritance("IDiaSymbol6")]
    public unsafe partial struct IDiaSymbol7
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, Guid*, void**, int>)(lpVtbl[0]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint>)(lpVtbl[1]))((IDiaSymbol7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint>)(lpVtbl[2]))((IDiaSymbol7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int get_symIndexId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[3]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int get_symTag([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[4]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int get_name([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ushort**, int>)(lpVtbl[5]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int get_lexicalParent(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaSymbol**, int>)(lpVtbl[6]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_classParent(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaSymbol**, int>)(lpVtbl[7]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_type(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaSymbol**, int>)(lpVtbl[8]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataKind([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[9]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_locationType([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[10]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_addressSection([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[11]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_addressOffset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[12]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[13]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ulong*, int>)(lpVtbl[14]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_registerId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[15]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_offset([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[16]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ulong*, int>)(lpVtbl[17]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_slot([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[18]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_volatileType([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[19]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_constType([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[20]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_unalignedType([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[21]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_access([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[22]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_libraryName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ushort**, int>)(lpVtbl[23]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_platform([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[24]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_language([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[25]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_editAndContinueEnabled([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[26]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_frontEndMajor([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[27]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_frontEndMinor([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[28]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_frontEndBuild([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[29]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_backEndMajor([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[30]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_backEndMinor([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[31]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_backEndBuild([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[32]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_sourceFileName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ushort**, int>)(lpVtbl[33]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_unused([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ushort**, int>)(lpVtbl[34]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_thunkOrdinal([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[35]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_thisAdjust([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[36]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_virtualBaseOffset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[37]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_virtual([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[38]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_intro([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[39]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_pure([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[40]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_callingConvention([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[41]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_value(VARIANT* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, VARIANT*, int>)(lpVtbl[42]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseType([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[43]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int get_token([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[44]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int get_timeStamp([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[45]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int get_guid([NativeTypeName("GUID *")] Guid* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, Guid*, int>)(lpVtbl[46]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int get_symbolsFileName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ushort**, int>)(lpVtbl[47]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int get_reference([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[48]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int get_count([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[49]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int get_bitPosition([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[50]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int get_arrayIndexType(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaSymbol**, int>)(lpVtbl[51]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int get_packed([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[52]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int get_constructor([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[53]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int get_overloadedOperator([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[54]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int get_nested([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[55]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasNestedTypes([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[56]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasAssignmentOperator([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[57]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasCastOperator([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[58]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int get_scoped([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[59]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int get_virtualBaseClass([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[60]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int get_indirectVirtualBaseClass([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[61]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int get_virtualBasePointerOffset([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[62]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int get_virtualTableShape(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaSymbol**, int>)(lpVtbl[63]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int get_lexicalParentId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[64]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int get_classParentId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[65]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int get_typeId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[66]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int get_arrayIndexTypeId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[67]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int get_virtualTableShapeId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[68]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int get_code([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[69]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int get_function([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[70]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int get_managed([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[71]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int get_msil([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[72]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int get_virtualBaseDispIndex([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[73]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int get_undecoratedName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ushort**, int>)(lpVtbl[74]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int get_age([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[75]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int get_signature([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[76]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int get_compilerGenerated([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[77]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int get_addressTaken([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[78]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int get_rank([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[79]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int get_lowerBound(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaSymbol**, int>)(lpVtbl[80]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int get_upperBound(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaSymbol**, int>)(lpVtbl[81]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int get_lowerBoundId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[82]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int get_upperBoundId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[83]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataBytes([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("BYTE *")] byte* pbData)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint, uint*, byte*, int>)(lpVtbl[84]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), cbData, pcbData, pbData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int findChildren([NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, SymTagEnum, ushort*, uint, IDiaEnumSymbols**, int>)(lpVtbl[85]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), symtag, name, compareFlags, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int findChildrenEx([NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, SymTagEnum, ushort*, uint, IDiaEnumSymbols**, int>)(lpVtbl[86]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), symtag, name, compareFlags, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int findChildrenExByAddr([NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, [NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, SymTagEnum, ushort*, uint, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[87]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), symtag, name, compareFlags, isect, offset, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int findChildrenExByVA([NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, [NativeTypeName("ULONGLONG")] ulong va, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, SymTagEnum, ushort*, uint, ulong, IDiaEnumSymbols**, int>)(lpVtbl[88]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), symtag, name, compareFlags, va, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int findChildrenExByRVA([NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, [NativeTypeName("DWORD")] uint rva, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, SymTagEnum, ushort*, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[89]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), symtag, name, compareFlags, rva, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("HRESULT")]
        public int get_targetSection([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[90]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        [return: NativeTypeName("HRESULT")]
        public int get_targetOffset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[91]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        [return: NativeTypeName("HRESULT")]
        public int get_targetRelativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[92]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        [return: NativeTypeName("HRESULT")]
        public int get_targetVirtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ulong*, int>)(lpVtbl[93]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        [return: NativeTypeName("HRESULT")]
        public int get_machineType([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[94]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        [return: NativeTypeName("HRESULT")]
        public int get_oemId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[95]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        [return: NativeTypeName("HRESULT")]
        public int get_oemSymbolId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[96]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        [return: NativeTypeName("HRESULT")]
        public int get_types([NativeTypeName("DWORD")] uint cTypes, [NativeTypeName("DWORD *")] uint* pcTypes, IDiaSymbol** pTypes)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint, uint*, IDiaSymbol**, int>)(lpVtbl[97]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), cTypes, pcTypes, pTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        [return: NativeTypeName("HRESULT")]
        public int get_typeIds([NativeTypeName("DWORD")] uint cTypeIds, [NativeTypeName("DWORD *")] uint* pcTypeIds, [NativeTypeName("DWORD *")] uint* pdwTypeIds)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint, uint*, uint*, int>)(lpVtbl[98]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), cTypeIds, pcTypeIds, pdwTypeIds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        [return: NativeTypeName("HRESULT")]
        public int get_objectPointerType(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaSymbol**, int>)(lpVtbl[99]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        [return: NativeTypeName("HRESULT")]
        public int get_udtKind([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[100]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        [return: NativeTypeName("HRESULT")]
        public int get_undecoratedNameEx([NativeTypeName("DWORD")] uint undecorateOptions, [NativeTypeName("BSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint, ushort**, int>)(lpVtbl[101]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), undecorateOptions, name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        [return: NativeTypeName("HRESULT")]
        public int get_noReturn([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[102]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        [return: NativeTypeName("HRESULT")]
        public int get_customCallingConvention([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[103]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        [return: NativeTypeName("HRESULT")]
        public int get_noInline([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[104]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        [return: NativeTypeName("HRESULT")]
        public int get_optimizedCodeDebugInfo([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[105]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        [return: NativeTypeName("HRESULT")]
        public int get_notReached([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[106]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        [return: NativeTypeName("HRESULT")]
        public int get_interruptReturn([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[107]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        [return: NativeTypeName("HRESULT")]
        public int get_farReturn([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[108]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        [return: NativeTypeName("HRESULT")]
        public int get_isStatic([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[109]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasDebugInfo([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[110]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        [return: NativeTypeName("HRESULT")]
        public int get_isLTCG([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[111]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        [return: NativeTypeName("HRESULT")]
        public int get_isDataAligned([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[112]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasSecurityChecks([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[113]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        [return: NativeTypeName("HRESULT")]
        public int get_compilerName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ushort**, int>)(lpVtbl[114]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(115)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasAlloca([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[115]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(116)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasSetJump([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[116]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(117)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasLongJump([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[117]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(118)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasInlAsm([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[118]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(119)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasEH([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[119]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(120)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasSEH([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[120]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(121)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasEHa([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[121]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(122)]
        [return: NativeTypeName("HRESULT")]
        public int get_isNaked([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[122]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(123)]
        [return: NativeTypeName("HRESULT")]
        public int get_isAggregated([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[123]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(124)]
        [return: NativeTypeName("HRESULT")]
        public int get_isSplitted([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[124]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(125)]
        [return: NativeTypeName("HRESULT")]
        public int get_container(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaSymbol**, int>)(lpVtbl[125]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(126)]
        [return: NativeTypeName("HRESULT")]
        public int get_inlSpec([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[126]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(127)]
        [return: NativeTypeName("HRESULT")]
        public int get_noStackOrdering([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[127]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(128)]
        [return: NativeTypeName("HRESULT")]
        public int get_virtualBaseTableType(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaSymbol**, int>)(lpVtbl[128]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(129)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasManagedCode([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[129]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(130)]
        [return: NativeTypeName("HRESULT")]
        public int get_isHotpatchable([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[130]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(131)]
        [return: NativeTypeName("HRESULT")]
        public int get_isCVTCIL([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[131]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(132)]
        [return: NativeTypeName("HRESULT")]
        public int get_isMSILNetmodule([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[132]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(133)]
        [return: NativeTypeName("HRESULT")]
        public int get_isCTypes([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[133]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(134)]
        [return: NativeTypeName("HRESULT")]
        public int get_isStripped([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[134]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(135)]
        [return: NativeTypeName("HRESULT")]
        public int get_frontEndQFE([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[135]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(136)]
        [return: NativeTypeName("HRESULT")]
        public int get_backEndQFE([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[136]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(137)]
        [return: NativeTypeName("HRESULT")]
        public int get_wasInlined([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[137]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(138)]
        [return: NativeTypeName("HRESULT")]
        public int get_strictGSCheck([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[138]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(139)]
        [return: NativeTypeName("HRESULT")]
        public int get_isCxxReturnUdt([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[139]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(140)]
        [return: NativeTypeName("HRESULT")]
        public int get_isConstructorVirtualBase([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[140]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(141)]
        [return: NativeTypeName("HRESULT")]
        public int get_RValueReference([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[141]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(142)]
        [return: NativeTypeName("HRESULT")]
        public int get_unmodifiedType(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaSymbol**, int>)(lpVtbl[142]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(143)]
        [return: NativeTypeName("HRESULT")]
        public int get_framePointerPresent([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[143]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(144)]
        [return: NativeTypeName("HRESULT")]
        public int get_isSafeBuffers([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[144]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(145)]
        [return: NativeTypeName("HRESULT")]
        public int get_intrinsic([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[145]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(146)]
        [return: NativeTypeName("HRESULT")]
        public int get_sealed([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[146]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(147)]
        [return: NativeTypeName("HRESULT")]
        public int get_hfaFloat([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[147]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(148)]
        [return: NativeTypeName("HRESULT")]
        public int get_hfaDouble([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[148]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(149)]
        [return: NativeTypeName("HRESULT")]
        public int get_liveRangeStartAddressSection([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[149]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(150)]
        [return: NativeTypeName("HRESULT")]
        public int get_liveRangeStartAddressOffset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[150]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(151)]
        [return: NativeTypeName("HRESULT")]
        public int get_liveRangeStartRelativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[151]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(152)]
        [return: NativeTypeName("HRESULT")]
        public int get_countLiveRanges([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[152]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(153)]
        [return: NativeTypeName("HRESULT")]
        public int get_liveRangeLength([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ulong*, int>)(lpVtbl[153]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(154)]
        [return: NativeTypeName("HRESULT")]
        public int get_offsetInUdt([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[154]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(155)]
        [return: NativeTypeName("HRESULT")]
        public int get_paramBasePointerRegisterId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[155]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(156)]
        [return: NativeTypeName("HRESULT")]
        public int get_localBasePointerRegisterId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[156]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(157)]
        [return: NativeTypeName("HRESULT")]
        public int get_isLocationControlFlowDependent([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[157]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(158)]
        [return: NativeTypeName("HRESULT")]
        public int get_stride([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[158]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(159)]
        [return: NativeTypeName("HRESULT")]
        public int get_numberOfRows([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[159]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(160)]
        [return: NativeTypeName("HRESULT")]
        public int get_numberOfColumns([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[160]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(161)]
        [return: NativeTypeName("HRESULT")]
        public int get_isMatrixRowMajor([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[161]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(162)]
        [return: NativeTypeName("HRESULT")]
        public int get_numericProperties([NativeTypeName("DWORD")] uint cnt, [NativeTypeName("DWORD *")] uint* pcnt, [NativeTypeName("DWORD *")] uint* pProperties)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint, uint*, uint*, int>)(lpVtbl[162]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), cnt, pcnt, pProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(163)]
        [return: NativeTypeName("HRESULT")]
        public int get_modifierValues([NativeTypeName("DWORD")] uint cnt, [NativeTypeName("DWORD *")] uint* pcnt, [NativeTypeName("WORD *")] ushort* pModifiers)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint, uint*, ushort*, int>)(lpVtbl[163]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), cnt, pcnt, pModifiers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(164)]
        [return: NativeTypeName("HRESULT")]
        public int get_isReturnValue([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[164]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(165)]
        [return: NativeTypeName("HRESULT")]
        public int get_isOptimizedAway([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[165]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(166)]
        [return: NativeTypeName("HRESULT")]
        public int get_builtInKind([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[166]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(167)]
        [return: NativeTypeName("HRESULT")]
        public int get_registerType([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[167]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(168)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseDataSlot([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[168]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(169)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseDataOffset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[169]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(170)]
        [return: NativeTypeName("HRESULT")]
        public int get_textureSlot([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[170]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(171)]
        [return: NativeTypeName("HRESULT")]
        public int get_samplerSlot([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[171]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(172)]
        [return: NativeTypeName("HRESULT")]
        public int get_uavSlot([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[172]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(173)]
        [return: NativeTypeName("HRESULT")]
        public int get_sizeInUdt([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[173]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(174)]
        [return: NativeTypeName("HRESULT")]
        public int get_memorySpaceKind([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[174]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(175)]
        [return: NativeTypeName("HRESULT")]
        public int get_unmodifiedTypeId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[175]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(176)]
        [return: NativeTypeName("HRESULT")]
        public int get_subTypeId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[176]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(177)]
        [return: NativeTypeName("HRESULT")]
        public int get_subType(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaSymbol**, int>)(lpVtbl[177]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(178)]
        [return: NativeTypeName("HRESULT")]
        public int get_numberOfModifiers([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[178]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(179)]
        [return: NativeTypeName("HRESULT")]
        public int get_numberOfRegisterIndices([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[179]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(180)]
        [return: NativeTypeName("HRESULT")]
        public int get_isHLSLData([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[180]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(181)]
        [return: NativeTypeName("HRESULT")]
        public int get_isPointerToDataMember([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[181]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(182)]
        [return: NativeTypeName("HRESULT")]
        public int get_isPointerToMemberFunction([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[182]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(183)]
        [return: NativeTypeName("HRESULT")]
        public int get_isSingleInheritance([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[183]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(184)]
        [return: NativeTypeName("HRESULT")]
        public int get_isMultipleInheritance([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[184]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(185)]
        [return: NativeTypeName("HRESULT")]
        public int get_isVirtualInheritance([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[185]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(186)]
        [return: NativeTypeName("HRESULT")]
        public int get_restrictedType([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[186]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(187)]
        [return: NativeTypeName("HRESULT")]
        public int get_isPointerBasedOnSymbolValue([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[187]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(188)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseSymbol(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaSymbol**, int>)(lpVtbl[188]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(189)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseSymbolId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[189]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(190)]
        [return: NativeTypeName("HRESULT")]
        public int get_objectFileName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ushort**, int>)(lpVtbl[190]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(191)]
        [return: NativeTypeName("HRESULT")]
        public int get_isAcceleratorGroupSharedLocal([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[191]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(192)]
        [return: NativeTypeName("HRESULT")]
        public int get_isAcceleratorPointerTagLiveRange([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[192]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(193)]
        [return: NativeTypeName("HRESULT")]
        public int get_isAcceleratorStubFunction([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[193]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(194)]
        [return: NativeTypeName("HRESULT")]
        public int get_numberOfAcceleratorPointerTags([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[194]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(195)]
        [return: NativeTypeName("HRESULT")]
        public int get_isSdl([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[195]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(196)]
        [return: NativeTypeName("HRESULT")]
        public int get_isWinRTPointer([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[196]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(197)]
        [return: NativeTypeName("HRESULT")]
        public int get_isRefUdt([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[197]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(198)]
        [return: NativeTypeName("HRESULT")]
        public int get_isValueUdt([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[198]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(199)]
        [return: NativeTypeName("HRESULT")]
        public int get_isInterfaceUdt([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[199]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(200)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineFramesByAddr([NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[200]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), isect, offset, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(201)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineFramesByRVA([NativeTypeName("DWORD")] uint rva, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint, IDiaEnumSymbols**, int>)(lpVtbl[201]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), rva, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(202)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineFramesByVA([NativeTypeName("ULONGLONG")] ulong va, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ulong, IDiaEnumSymbols**, int>)(lpVtbl[202]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), va, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(203)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineeLines(IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaEnumLineNumbers**, int>)(lpVtbl[203]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(204)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineeLinesByAddr([NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[204]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), isect, offset, length, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(205)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineeLinesByRVA([NativeTypeName("DWORD")] uint rva, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[205]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), rva, length, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(206)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineeLinesByVA([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ulong, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[206]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), va, length, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(207)]
        [return: NativeTypeName("HRESULT")]
        public int findSymbolsForAcceleratorPointerTag([NativeTypeName("DWORD")] uint tagValue, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint, IDiaEnumSymbols**, int>)(lpVtbl[207]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), tagValue, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(208)]
        [return: NativeTypeName("HRESULT")]
        public int findSymbolsByRVAForAcceleratorPointerTag([NativeTypeName("DWORD")] uint tagValue, [NativeTypeName("DWORD")] uint rva, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[208]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), tagValue, rva, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(209)]
        [return: NativeTypeName("HRESULT")]
        public int get_acceleratorPointerTags([NativeTypeName("DWORD")] uint cnt, [NativeTypeName("DWORD *")] uint* pcnt, [NativeTypeName("DWORD *")] uint* pPointerTags)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint, uint*, uint*, int>)(lpVtbl[209]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), cnt, pcnt, pPointerTags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(210)]
        [return: NativeTypeName("HRESULT")]
        public int getSrcLineOnTypeDefn(IDiaLineNumber** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaLineNumber**, int>)(lpVtbl[210]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(211)]
        [return: NativeTypeName("HRESULT")]
        public int get_isPGO([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[211]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(212)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasValidPGOCounts([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[212]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(213)]
        [return: NativeTypeName("HRESULT")]
        public int get_isOptimizedForSpeed([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[213]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(214)]
        [return: NativeTypeName("HRESULT")]
        public int get_PGOEntryCount([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[214]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(215)]
        [return: NativeTypeName("HRESULT")]
        public int get_PGOEdgeCount([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[215]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(216)]
        [return: NativeTypeName("HRESULT")]
        public int get_PGODynamicInstructionCount([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ulong*, int>)(lpVtbl[216]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(217)]
        [return: NativeTypeName("HRESULT")]
        public int get_staticSize([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[217]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(218)]
        [return: NativeTypeName("HRESULT")]
        public int get_finalLiveStaticSize([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[218]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(219)]
        [return: NativeTypeName("HRESULT")]
        public int get_phaseName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ushort**, int>)(lpVtbl[219]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(220)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasControlFlowCheck([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[220]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(221)]
        [return: NativeTypeName("HRESULT")]
        public int get_constantExport([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[221]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(222)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataExport([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[222]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(223)]
        [return: NativeTypeName("HRESULT")]
        public int get_privateExport([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[223]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(224)]
        [return: NativeTypeName("HRESULT")]
        public int get_noNameExport([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[224]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(225)]
        [return: NativeTypeName("HRESULT")]
        public int get_exportHasExplicitlyAssignedOrdinal([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[225]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(226)]
        [return: NativeTypeName("HRESULT")]
        public int get_exportIsForwarder([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[226]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(227)]
        [return: NativeTypeName("HRESULT")]
        public int get_ordinal([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[227]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(228)]
        [return: NativeTypeName("HRESULT")]
        public int get_frameSize([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[228]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(229)]
        [return: NativeTypeName("HRESULT")]
        public int get_exceptionHandlerAddressSection([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[229]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(230)]
        [return: NativeTypeName("HRESULT")]
        public int get_exceptionHandlerAddressOffset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[230]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(231)]
        [return: NativeTypeName("HRESULT")]
        public int get_exceptionHandlerRelativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[231]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(232)]
        [return: NativeTypeName("HRESULT")]
        public int get_exceptionHandlerVirtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, ulong*, int>)(lpVtbl[232]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(233)]
        [return: NativeTypeName("HRESULT")]
        public int findInputAssemblyFile(IDiaInputAssemblyFile** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaInputAssemblyFile**, int>)(lpVtbl[233]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(234)]
        [return: NativeTypeName("HRESULT")]
        public int get_characteristics([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[234]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(235)]
        [return: NativeTypeName("HRESULT")]
        public int get_coffGroup(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaSymbol**, int>)(lpVtbl[235]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(236)]
        [return: NativeTypeName("HRESULT")]
        public int get_bindID([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[236]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(237)]
        [return: NativeTypeName("HRESULT")]
        public int get_bindSpace([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[237]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(238)]
        [return: NativeTypeName("HRESULT")]
        public int get_bindSlot([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[238]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(239)]
        [return: NativeTypeName("HRESULT")]
        public int get_isObjCClass([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[239]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(240)]
        [return: NativeTypeName("HRESULT")]
        public int get_isObjCCategory([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[240]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(241)]
        [return: NativeTypeName("HRESULT")]
        public int get_isObjCProtocol([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[241]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(242)]
        [return: NativeTypeName("HRESULT")]
        public int get_inlinee(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, IDiaSymbol**, int>)(lpVtbl[242]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(243)]
        [return: NativeTypeName("HRESULT")]
        public int get_inlineeId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, uint*, int>)(lpVtbl[243]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(244)]
        [return: NativeTypeName("HRESULT")]
        public int get_noexcept([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[244]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(245)]
        [return: NativeTypeName("HRESULT")]
        public int get_hasAbsoluteAddress([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[245]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(246)]
        [return: NativeTypeName("HRESULT")]
        public int get_isStaticMemberFunc([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[246]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(247)]
        [return: NativeTypeName("HRESULT")]
        public int get_isSignRet([NativeTypeName("BOOL *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol7*, int*, int>)(lpVtbl[247]))((IDiaSymbol7*)Unsafe.AsPointer(ref this), pRetVal);
        }
    }
}
