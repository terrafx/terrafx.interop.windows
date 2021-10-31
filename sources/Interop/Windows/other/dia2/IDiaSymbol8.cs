// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7F2E041F-1294-41BD-B83A-E715972D2CE3")]
    [NativeTypeName("struct IDiaSymbol8 : IDiaSymbol7")]
    [NativeInheritance("IDiaSymbol7")]
    public unsafe partial struct IDiaSymbol8
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, Guid*, void**, int>)(lpVtbl[0]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint>)(lpVtbl[1]))((IDiaSymbol8*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint>)(lpVtbl[2]))((IDiaSymbol8*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_symIndexId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[3]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_symTag([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[4]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT get_name([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ushort**, int>)(lpVtbl[5]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT get_lexicalParent(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaSymbol**, int>)(lpVtbl[6]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_classParent(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaSymbol**, int>)(lpVtbl[7]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_type(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaSymbol**, int>)(lpVtbl[8]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_dataKind([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[9]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_locationType([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[10]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_addressSection([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[11]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_addressOffset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[12]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[13]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ulong*, int>)(lpVtbl[14]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_registerId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[15]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_offset([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, int*, int>)(lpVtbl[16]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_length([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ulong*, int>)(lpVtbl[17]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_slot([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[18]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_volatileType(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[19]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_constType(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[20]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_unalignedType(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[21]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_access([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[22]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_libraryName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ushort**, int>)(lpVtbl[23]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_platform([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[24]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_language([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[25]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_editAndContinueEnabled(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[26]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_frontEndMajor([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[27]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_frontEndMinor([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[28]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT get_frontEndBuild([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[29]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_backEndMajor([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[30]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT get_backEndMinor([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[31]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_backEndBuild([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[32]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT get_sourceFileName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ushort**, int>)(lpVtbl[33]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_unused([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ushort**, int>)(lpVtbl[34]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT get_thunkOrdinal([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[35]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT get_thisAdjust([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, int*, int>)(lpVtbl[36]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT get_virtualBaseOffset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[37]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT get_virtual(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[38]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT get_intro(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[39]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT get_pure(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[40]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT get_callingConvention([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[41]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT get_value(VARIANT* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, VARIANT*, int>)(lpVtbl[42]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT get_baseType([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[43]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT get_token([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[44]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT get_timeStamp([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[45]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT get_guid([NativeTypeName("GUID *")] Guid* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, Guid*, int>)(lpVtbl[46]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT get_symbolsFileName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ushort**, int>)(lpVtbl[47]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT get_reference(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[48]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT get_count([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[49]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT get_bitPosition([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[50]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT get_arrayIndexType(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaSymbol**, int>)(lpVtbl[51]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT get_packed(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[52]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT get_constructor(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[53]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT get_overloadedOperator(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[54]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT get_nested(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[55]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT get_hasNestedTypes(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[56]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT get_hasAssignmentOperator(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[57]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT get_hasCastOperator(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[58]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT get_scoped(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[59]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT get_virtualBaseClass(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[60]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT get_indirectVirtualBaseClass(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[61]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT get_virtualBasePointerOffset([NativeTypeName("LONG *")] int* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, int*, int>)(lpVtbl[62]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT get_virtualTableShape(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaSymbol**, int>)(lpVtbl[63]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT get_lexicalParentId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[64]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT get_classParentId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[65]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT get_typeId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[66]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT get_arrayIndexTypeId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[67]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT get_virtualTableShapeId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[68]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT get_code(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[69]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT get_function(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[70]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HRESULT get_managed(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[71]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public HRESULT get_msil(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[72]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public HRESULT get_virtualBaseDispIndex([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[73]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public HRESULT get_undecoratedName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ushort**, int>)(lpVtbl[74]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public HRESULT get_age([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[75]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public HRESULT get_signature([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[76]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public HRESULT get_compilerGenerated(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[77]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        public HRESULT get_addressTaken(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[78]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public HRESULT get_rank([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[79]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public HRESULT get_lowerBound(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaSymbol**, int>)(lpVtbl[80]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        public HRESULT get_upperBound(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaSymbol**, int>)(lpVtbl[81]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        public HRESULT get_lowerBoundId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[82]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public HRESULT get_upperBoundId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[83]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        public HRESULT get_dataBytes([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("BYTE *")] byte* pbData)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint, uint*, byte*, int>)(lpVtbl[84]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), cbData, pcbData, pbData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        public HRESULT findChildren([NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, SymTagEnum, ushort*, uint, IDiaEnumSymbols**, int>)(lpVtbl[85]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), symtag, name, compareFlags, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        public HRESULT findChildrenEx([NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, SymTagEnum, ushort*, uint, IDiaEnumSymbols**, int>)(lpVtbl[86]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), symtag, name, compareFlags, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        public HRESULT findChildrenExByAddr([NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, [NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, SymTagEnum, ushort*, uint, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[87]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), symtag, name, compareFlags, isect, offset, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        public HRESULT findChildrenExByVA([NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, [NativeTypeName("ULONGLONG")] ulong va, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, SymTagEnum, ushort*, uint, ulong, IDiaEnumSymbols**, int>)(lpVtbl[88]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), symtag, name, compareFlags, va, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        public HRESULT findChildrenExByRVA([NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, [NativeTypeName("DWORD")] uint rva, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, SymTagEnum, ushort*, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[89]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), symtag, name, compareFlags, rva, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        public HRESULT get_targetSection([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[90]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        public HRESULT get_targetOffset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[91]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        public HRESULT get_targetRelativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[92]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        public HRESULT get_targetVirtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ulong*, int>)(lpVtbl[93]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        public HRESULT get_machineType([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[94]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        public HRESULT get_oemId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[95]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        public HRESULT get_oemSymbolId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[96]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        public HRESULT get_types([NativeTypeName("DWORD")] uint cTypes, [NativeTypeName("DWORD *")] uint* pcTypes, IDiaSymbol** pTypes)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint, uint*, IDiaSymbol**, int>)(lpVtbl[97]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), cTypes, pcTypes, pTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        public HRESULT get_typeIds([NativeTypeName("DWORD")] uint cTypeIds, [NativeTypeName("DWORD *")] uint* pcTypeIds, [NativeTypeName("DWORD *")] uint* pdwTypeIds)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint, uint*, uint*, int>)(lpVtbl[98]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), cTypeIds, pcTypeIds, pdwTypeIds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        public HRESULT get_objectPointerType(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaSymbol**, int>)(lpVtbl[99]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        public HRESULT get_udtKind([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[100]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        public HRESULT get_undecoratedNameEx([NativeTypeName("DWORD")] uint undecorateOptions, [NativeTypeName("BSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint, ushort**, int>)(lpVtbl[101]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), undecorateOptions, name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        public HRESULT get_noReturn(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[102]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        public HRESULT get_customCallingConvention(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[103]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        public HRESULT get_noInline(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[104]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(105)]
        public HRESULT get_optimizedCodeDebugInfo(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[105]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(106)]
        public HRESULT get_notReached(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[106]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(107)]
        public HRESULT get_interruptReturn(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[107]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(108)]
        public HRESULT get_farReturn(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[108]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(109)]
        public HRESULT get_isStatic(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[109]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(110)]
        public HRESULT get_hasDebugInfo(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[110]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(111)]
        public HRESULT get_isLTCG(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[111]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(112)]
        public HRESULT get_isDataAligned(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[112]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(113)]
        public HRESULT get_hasSecurityChecks(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[113]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(114)]
        public HRESULT get_compilerName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ushort**, int>)(lpVtbl[114]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(115)]
        public HRESULT get_hasAlloca(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[115]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(116)]
        public HRESULT get_hasSetJump(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[116]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(117)]
        public HRESULT get_hasLongJump(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[117]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(118)]
        public HRESULT get_hasInlAsm(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[118]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(119)]
        public HRESULT get_hasEH(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[119]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(120)]
        public HRESULT get_hasSEH(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[120]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(121)]
        public HRESULT get_hasEHa(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[121]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(122)]
        public HRESULT get_isNaked(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[122]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(123)]
        public HRESULT get_isAggregated(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[123]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(124)]
        public HRESULT get_isSplitted(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[124]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(125)]
        public HRESULT get_container(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaSymbol**, int>)(lpVtbl[125]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(126)]
        public HRESULT get_inlSpec(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[126]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(127)]
        public HRESULT get_noStackOrdering(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[127]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(128)]
        public HRESULT get_virtualBaseTableType(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaSymbol**, int>)(lpVtbl[128]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(129)]
        public HRESULT get_hasManagedCode(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[129]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(130)]
        public HRESULT get_isHotpatchable(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[130]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(131)]
        public HRESULT get_isCVTCIL(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[131]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(132)]
        public HRESULT get_isMSILNetmodule(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[132]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(133)]
        public HRESULT get_isCTypes(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[133]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(134)]
        public HRESULT get_isStripped(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[134]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(135)]
        public HRESULT get_frontEndQFE([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[135]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(136)]
        public HRESULT get_backEndQFE([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[136]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(137)]
        public HRESULT get_wasInlined(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[137]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(138)]
        public HRESULT get_strictGSCheck(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[138]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(139)]
        public HRESULT get_isCxxReturnUdt(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[139]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(140)]
        public HRESULT get_isConstructorVirtualBase(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[140]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(141)]
        public HRESULT get_RValueReference(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[141]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(142)]
        public HRESULT get_unmodifiedType(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaSymbol**, int>)(lpVtbl[142]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(143)]
        public HRESULT get_framePointerPresent(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[143]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(144)]
        public HRESULT get_isSafeBuffers(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[144]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(145)]
        public HRESULT get_intrinsic(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[145]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(146)]
        public HRESULT get_sealed(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[146]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(147)]
        public HRESULT get_hfaFloat(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[147]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(148)]
        public HRESULT get_hfaDouble(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[148]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(149)]
        public HRESULT get_liveRangeStartAddressSection([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[149]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(150)]
        public HRESULT get_liveRangeStartAddressOffset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[150]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(151)]
        public HRESULT get_liveRangeStartRelativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[151]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(152)]
        public HRESULT get_countLiveRanges([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[152]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(153)]
        public HRESULT get_liveRangeLength([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ulong*, int>)(lpVtbl[153]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(154)]
        public HRESULT get_offsetInUdt([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[154]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(155)]
        public HRESULT get_paramBasePointerRegisterId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[155]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(156)]
        public HRESULT get_localBasePointerRegisterId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[156]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(157)]
        public HRESULT get_isLocationControlFlowDependent(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[157]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(158)]
        public HRESULT get_stride([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[158]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(159)]
        public HRESULT get_numberOfRows([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[159]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(160)]
        public HRESULT get_numberOfColumns([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[160]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(161)]
        public HRESULT get_isMatrixRowMajor(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[161]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(162)]
        public HRESULT get_numericProperties([NativeTypeName("DWORD")] uint cnt, [NativeTypeName("DWORD *")] uint* pcnt, [NativeTypeName("DWORD *")] uint* pProperties)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint, uint*, uint*, int>)(lpVtbl[162]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), cnt, pcnt, pProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(163)]
        public HRESULT get_modifierValues([NativeTypeName("DWORD")] uint cnt, [NativeTypeName("DWORD *")] uint* pcnt, [NativeTypeName("WORD *")] ushort* pModifiers)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint, uint*, ushort*, int>)(lpVtbl[163]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), cnt, pcnt, pModifiers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(164)]
        public HRESULT get_isReturnValue(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[164]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(165)]
        public HRESULT get_isOptimizedAway(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[165]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(166)]
        public HRESULT get_builtInKind([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[166]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(167)]
        public HRESULT get_registerType([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[167]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(168)]
        public HRESULT get_baseDataSlot([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[168]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(169)]
        public HRESULT get_baseDataOffset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[169]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(170)]
        public HRESULT get_textureSlot([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[170]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(171)]
        public HRESULT get_samplerSlot([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[171]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(172)]
        public HRESULT get_uavSlot([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[172]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(173)]
        public HRESULT get_sizeInUdt([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[173]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(174)]
        public HRESULT get_memorySpaceKind([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[174]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(175)]
        public HRESULT get_unmodifiedTypeId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[175]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(176)]
        public HRESULT get_subTypeId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[176]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(177)]
        public HRESULT get_subType(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaSymbol**, int>)(lpVtbl[177]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(178)]
        public HRESULT get_numberOfModifiers([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[178]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(179)]
        public HRESULT get_numberOfRegisterIndices([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[179]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(180)]
        public HRESULT get_isHLSLData(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[180]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(181)]
        public HRESULT get_isPointerToDataMember(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[181]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(182)]
        public HRESULT get_isPointerToMemberFunction(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[182]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(183)]
        public HRESULT get_isSingleInheritance(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[183]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(184)]
        public HRESULT get_isMultipleInheritance(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[184]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(185)]
        public HRESULT get_isVirtualInheritance(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[185]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(186)]
        public HRESULT get_restrictedType(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[186]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(187)]
        public HRESULT get_isPointerBasedOnSymbolValue(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[187]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(188)]
        public HRESULT get_baseSymbol(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaSymbol**, int>)(lpVtbl[188]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(189)]
        public HRESULT get_baseSymbolId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[189]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(190)]
        public HRESULT get_objectFileName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ushort**, int>)(lpVtbl[190]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(191)]
        public HRESULT get_isAcceleratorGroupSharedLocal(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[191]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(192)]
        public HRESULT get_isAcceleratorPointerTagLiveRange(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[192]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(193)]
        public HRESULT get_isAcceleratorStubFunction(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[193]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(194)]
        public HRESULT get_numberOfAcceleratorPointerTags([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[194]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(195)]
        public HRESULT get_isSdl(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[195]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(196)]
        public HRESULT get_isWinRTPointer(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[196]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(197)]
        public HRESULT get_isRefUdt(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[197]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(198)]
        public HRESULT get_isValueUdt(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[198]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(199)]
        public HRESULT get_isInterfaceUdt(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[199]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(200)]
        public HRESULT findInlineFramesByAddr([NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[200]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), isect, offset, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(201)]
        public HRESULT findInlineFramesByRVA([NativeTypeName("DWORD")] uint rva, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint, IDiaEnumSymbols**, int>)(lpVtbl[201]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), rva, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(202)]
        public HRESULT findInlineFramesByVA([NativeTypeName("ULONGLONG")] ulong va, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ulong, IDiaEnumSymbols**, int>)(lpVtbl[202]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), va, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(203)]
        public HRESULT findInlineeLines(IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaEnumLineNumbers**, int>)(lpVtbl[203]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(204)]
        public HRESULT findInlineeLinesByAddr([NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[204]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), isect, offset, length, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(205)]
        public HRESULT findInlineeLinesByRVA([NativeTypeName("DWORD")] uint rva, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[205]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), rva, length, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(206)]
        public HRESULT findInlineeLinesByVA([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ulong, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[206]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), va, length, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(207)]
        public HRESULT findSymbolsForAcceleratorPointerTag([NativeTypeName("DWORD")] uint tagValue, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint, IDiaEnumSymbols**, int>)(lpVtbl[207]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), tagValue, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(208)]
        public HRESULT findSymbolsByRVAForAcceleratorPointerTag([NativeTypeName("DWORD")] uint tagValue, [NativeTypeName("DWORD")] uint rva, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[208]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), tagValue, rva, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(209)]
        public HRESULT get_acceleratorPointerTags([NativeTypeName("DWORD")] uint cnt, [NativeTypeName("DWORD *")] uint* pcnt, [NativeTypeName("DWORD *")] uint* pPointerTags)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint, uint*, uint*, int>)(lpVtbl[209]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), cnt, pcnt, pPointerTags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(210)]
        public HRESULT getSrcLineOnTypeDefn(IDiaLineNumber** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaLineNumber**, int>)(lpVtbl[210]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(211)]
        public HRESULT get_isPGO(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[211]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(212)]
        public HRESULT get_hasValidPGOCounts(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[212]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(213)]
        public HRESULT get_isOptimizedForSpeed(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[213]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(214)]
        public HRESULT get_PGOEntryCount([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[214]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(215)]
        public HRESULT get_PGOEdgeCount([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[215]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(216)]
        public HRESULT get_PGODynamicInstructionCount([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ulong*, int>)(lpVtbl[216]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(217)]
        public HRESULT get_staticSize([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[217]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(218)]
        public HRESULT get_finalLiveStaticSize([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[218]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(219)]
        public HRESULT get_phaseName([NativeTypeName("BSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ushort**, int>)(lpVtbl[219]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(220)]
        public HRESULT get_hasControlFlowCheck(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[220]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(221)]
        public HRESULT get_constantExport(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[221]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(222)]
        public HRESULT get_dataExport(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[222]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(223)]
        public HRESULT get_privateExport(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[223]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(224)]
        public HRESULT get_noNameExport(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[224]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(225)]
        public HRESULT get_exportHasExplicitlyAssignedOrdinal(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[225]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(226)]
        public HRESULT get_exportIsForwarder(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[226]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(227)]
        public HRESULT get_ordinal([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[227]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(228)]
        public HRESULT get_frameSize([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[228]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(229)]
        public HRESULT get_exceptionHandlerAddressSection([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[229]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(230)]
        public HRESULT get_exceptionHandlerAddressOffset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[230]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(231)]
        public HRESULT get_exceptionHandlerRelativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[231]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(232)]
        public HRESULT get_exceptionHandlerVirtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ulong*, int>)(lpVtbl[232]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(233)]
        public HRESULT findInputAssemblyFile(IDiaInputAssemblyFile** ppResult)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaInputAssemblyFile**, int>)(lpVtbl[233]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(234)]
        public HRESULT get_characteristics([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[234]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(235)]
        public HRESULT get_coffGroup(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaSymbol**, int>)(lpVtbl[235]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(236)]
        public HRESULT get_bindID([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[236]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(237)]
        public HRESULT get_bindSpace([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[237]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(238)]
        public HRESULT get_bindSlot([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[238]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(239)]
        public HRESULT get_isObjCClass(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[239]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(240)]
        public HRESULT get_isObjCCategory(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[240]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(241)]
        public HRESULT get_isObjCProtocol(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[241]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(242)]
        public HRESULT get_inlinee(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, IDiaSymbol**, int>)(lpVtbl[242]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(243)]
        public HRESULT get_inlineeId([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[243]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(244)]
        public HRESULT get_noexcept(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[244]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(245)]
        public HRESULT get_hasAbsoluteAddress(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[245]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(246)]
        public HRESULT get_isStaticMemberFunc(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[246]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(247)]
        public HRESULT get_isSignRet(BOOL* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, BOOL*, int>)(lpVtbl[247]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(248)]
        public HRESULT get_coroutineKind([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[248]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(249)]
        public HRESULT get_associatedSymbolKind([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[249]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(250)]
        public HRESULT get_associatedSymbolSection([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[250]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(251)]
        public HRESULT get_associatedSymbolOffset([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[251]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(252)]
        public HRESULT get_associatedSymbolRva([NativeTypeName("DWORD *")] uint* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, uint*, int>)(lpVtbl[252]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(253)]
        public HRESULT get_associatedSymbolAddr([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSymbol8*, ulong*, int>)(lpVtbl[253]))((IDiaSymbol8*)Unsafe.AsPointer(ref this), pRetVal);
        }
    }
}
