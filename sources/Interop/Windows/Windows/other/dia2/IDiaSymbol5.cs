// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaSymbol5.xml' path='doc/member[@name="IDiaSymbol5"]/*' />
[Guid("ABE2DE00-DC2D-4793-AF9A-EF1D90832644")]
[NativeTypeName("struct IDiaSymbol5 : IDiaSymbol4")]
[NativeInheritance("IDiaSymbol4")]
public unsafe partial struct IDiaSymbol5 : IDiaSymbol5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaSymbol5));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, Guid*, void**, int>)(lpVtbl[0]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint>)(lpVtbl[1]))((IDiaSymbol5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint>)(lpVtbl[2]))((IDiaSymbol5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDiaSymbol.get_symIndexId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_symIndexId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[3]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_symTag" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_symTag([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[4]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_name" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_name([NativeTypeName("BSTR *")] char** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, char**, int>)(lpVtbl[5]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_lexicalParent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_lexicalParent(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaSymbol**, int>)(lpVtbl[6]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_classParent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_classParent(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaSymbol**, int>)(lpVtbl[7]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_type" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_type(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaSymbol**, int>)(lpVtbl[8]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_dataKind" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_dataKind([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[9]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_locationType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_locationType([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[10]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_addressSection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_addressSection([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[11]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_addressOffset" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_addressOffset([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[12]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_relativeVirtualAddress" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[13]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_virtualAddress" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, ulong*, int>)(lpVtbl[14]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_registerId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_registerId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[15]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_offset" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_offset([NativeTypeName("LONG *")] int* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, int*, int>)(lpVtbl[16]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_length" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_length([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, ulong*, int>)(lpVtbl[17]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_slot" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_slot([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[18]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_volatileType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_volatileType(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[19]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_constType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_constType(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[20]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_unalignedType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_unalignedType(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[21]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_access" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_access([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[22]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_libraryName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_libraryName([NativeTypeName("BSTR *")] char** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, char**, int>)(lpVtbl[23]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_platform" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_platform([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[24]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_language" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_language([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[25]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_editAndContinueEnabled" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_editAndContinueEnabled(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[26]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_frontEndMajor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_frontEndMajor([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[27]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_frontEndMinor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_frontEndMinor([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[28]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_frontEndBuild" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_frontEndBuild([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[29]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_backEndMajor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_backEndMajor([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[30]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_backEndMinor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_backEndMinor([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[31]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_backEndBuild" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_backEndBuild([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[32]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_sourceFileName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_sourceFileName([NativeTypeName("BSTR *")] char** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, char**, int>)(lpVtbl[33]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_unused" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_unused([NativeTypeName("BSTR *")] char** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, char**, int>)(lpVtbl[34]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_thunkOrdinal" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_thunkOrdinal([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[35]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_thisAdjust" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_thisAdjust([NativeTypeName("LONG *")] int* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, int*, int>)(lpVtbl[36]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_virtualBaseOffset" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_virtualBaseOffset([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[37]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_virtual" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_virtual(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[38]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_intro" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_intro(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[39]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_pure" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_pure(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[40]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_callingConvention" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_callingConvention([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[41]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_value" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_value(VARIANT* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, VARIANT*, int>)(lpVtbl[42]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_baseType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_baseType([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[43]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_token" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_token([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[44]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_timeStamp" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_timeStamp([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[45]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_guid" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_guid(Guid* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, Guid*, int>)(lpVtbl[46]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_symbolsFileName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_symbolsFileName([NativeTypeName("BSTR *")] char** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, char**, int>)(lpVtbl[47]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_reference" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_reference(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[48]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_count" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_count([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[49]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_bitPosition" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_bitPosition([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[50]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_arrayIndexType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_arrayIndexType(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaSymbol**, int>)(lpVtbl[51]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_packed" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_packed(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[52]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_constructor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_constructor(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[53]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_overloadedOperator" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_overloadedOperator(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[54]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_nested" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_nested(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[55]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hasNestedTypes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_hasNestedTypes(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[56]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hasAssignmentOperator" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_hasAssignmentOperator(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[57]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hasCastOperator" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_hasCastOperator(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[58]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_scoped" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_scoped(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[59]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_virtualBaseClass" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_virtualBaseClass(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[60]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_indirectVirtualBaseClass" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT get_indirectVirtualBaseClass(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[61]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_virtualBasePointerOffset" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_virtualBasePointerOffset([NativeTypeName("LONG *")] int* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, int*, int>)(lpVtbl[62]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_virtualTableShape" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_virtualTableShape(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaSymbol**, int>)(lpVtbl[63]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_lexicalParentId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT get_lexicalParentId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[64]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_classParentId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT get_classParentId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[65]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_typeId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT get_typeId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[66]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_arrayIndexTypeId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT get_arrayIndexTypeId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[67]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_virtualTableShapeId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT get_virtualTableShapeId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[68]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_code" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT get_code(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[69]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_function" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT get_function(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[70]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_managed" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT get_managed(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[71]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_msil" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT get_msil(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[72]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_virtualBaseDispIndex" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT get_virtualBaseDispIndex([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[73]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_undecoratedName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT get_undecoratedName([NativeTypeName("BSTR *")] char** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, char**, int>)(lpVtbl[74]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_age" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT get_age([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[75]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_signature" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT get_signature([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[76]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_compilerGenerated" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT get_compilerGenerated(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[77]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_addressTaken" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT get_addressTaken(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[78]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_rank" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT get_rank([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[79]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_lowerBound" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT get_lowerBound(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaSymbol**, int>)(lpVtbl[80]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_upperBound" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT get_upperBound(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaSymbol**, int>)(lpVtbl[81]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_lowerBoundId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT get_lowerBoundId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[82]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_upperBoundId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT get_upperBoundId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[83]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_dataBytes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT get_dataBytes([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint, uint*, byte*, int>)(lpVtbl[84]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), cbData, pcbData, pbData);
    }

    /// <inheritdoc cref="IDiaSymbol.findChildren" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT findChildren([NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] char* name, [NativeTypeName("DWORD")] uint compareFlags, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, SymTagEnum, char*, uint, IDiaEnumSymbols**, int>)(lpVtbl[85]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), symtag, name, compareFlags, ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.findChildrenEx" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT findChildrenEx([NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] char* name, [NativeTypeName("DWORD")] uint compareFlags, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, SymTagEnum, char*, uint, IDiaEnumSymbols**, int>)(lpVtbl[86]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), symtag, name, compareFlags, ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.findChildrenExByAddr" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT findChildrenExByAddr([NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] char* name, [NativeTypeName("DWORD")] uint compareFlags, [NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, SymTagEnum, char*, uint, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[87]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), symtag, name, compareFlags, isect, offset, ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.findChildrenExByVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT findChildrenExByVA([NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] char* name, [NativeTypeName("DWORD")] uint compareFlags, [NativeTypeName("ULONGLONG")] ulong va, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, SymTagEnum, char*, uint, ulong, IDiaEnumSymbols**, int>)(lpVtbl[88]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), symtag, name, compareFlags, va, ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.findChildrenExByRVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT findChildrenExByRVA([NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] char* name, [NativeTypeName("DWORD")] uint compareFlags, [NativeTypeName("DWORD")] uint rva, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, SymTagEnum, char*, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[89]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), symtag, name, compareFlags, rva, ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.get_targetSection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT get_targetSection([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[90]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_targetOffset" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT get_targetOffset([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[91]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_targetRelativeVirtualAddress" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT get_targetRelativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[92]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_targetVirtualAddress" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT get_targetVirtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, ulong*, int>)(lpVtbl[93]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_machineType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT get_machineType([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[94]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_oemId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT get_oemId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[95]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_oemSymbolId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT get_oemSymbolId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[96]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_types" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT get_types([NativeTypeName("DWORD")] uint cTypes, [NativeTypeName("DWORD *")] uint* pcTypes, IDiaSymbol** pTypes)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint, uint*, IDiaSymbol**, int>)(lpVtbl[97]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), cTypes, pcTypes, pTypes);
    }

    /// <inheritdoc cref="IDiaSymbol.get_typeIds" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT get_typeIds([NativeTypeName("DWORD")] uint cTypeIds, [NativeTypeName("DWORD *")] uint* pcTypeIds, [NativeTypeName("DWORD *")] uint* pdwTypeIds)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint, uint*, uint*, int>)(lpVtbl[98]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), cTypeIds, pcTypeIds, pdwTypeIds);
    }

    /// <inheritdoc cref="IDiaSymbol.get_objectPointerType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT get_objectPointerType(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaSymbol**, int>)(lpVtbl[99]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_udtKind" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT get_udtKind([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[100]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_undecoratedNameEx" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT get_undecoratedNameEx([NativeTypeName("DWORD")] uint undecorateOptions, [NativeTypeName("BSTR *")] char** name)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint, char**, int>)(lpVtbl[101]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), undecorateOptions, name);
    }

    /// <inheritdoc cref="IDiaSymbol.get_noReturn" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT get_noReturn(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[102]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_customCallingConvention" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT get_customCallingConvention(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[103]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_noInline" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT get_noInline(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[104]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_optimizedCodeDebugInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HRESULT get_optimizedCodeDebugInfo(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[105]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_notReached" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HRESULT get_notReached(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[106]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_interruptReturn" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public HRESULT get_interruptReturn(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[107]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_farReturn" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HRESULT get_farReturn(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[108]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isStatic" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public HRESULT get_isStatic(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[109]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hasDebugInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public HRESULT get_hasDebugInfo(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[110]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isLTCG" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public HRESULT get_isLTCG(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[111]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isDataAligned" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public HRESULT get_isDataAligned(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[112]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hasSecurityChecks" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(113)]
    public HRESULT get_hasSecurityChecks(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[113]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_compilerName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(114)]
    public HRESULT get_compilerName([NativeTypeName("BSTR *")] char** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, char**, int>)(lpVtbl[114]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hasAlloca" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(115)]
    public HRESULT get_hasAlloca(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[115]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hasSetJump" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(116)]
    public HRESULT get_hasSetJump(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[116]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hasLongJump" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(117)]
    public HRESULT get_hasLongJump(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[117]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hasInlAsm" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(118)]
    public HRESULT get_hasInlAsm(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[118]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hasEH" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(119)]
    public HRESULT get_hasEH(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[119]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hasSEH" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(120)]
    public HRESULT get_hasSEH(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[120]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hasEHa" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(121)]
    public HRESULT get_hasEHa(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[121]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isNaked" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(122)]
    public HRESULT get_isNaked(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[122]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isAggregated" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(123)]
    public HRESULT get_isAggregated(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[123]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isSplitted" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(124)]
    public HRESULT get_isSplitted(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[124]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_container" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(125)]
    public HRESULT get_container(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaSymbol**, int>)(lpVtbl[125]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_inlSpec" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(126)]
    public HRESULT get_inlSpec(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[126]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_noStackOrdering" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(127)]
    public HRESULT get_noStackOrdering(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[127]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_virtualBaseTableType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(128)]
    public HRESULT get_virtualBaseTableType(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaSymbol**, int>)(lpVtbl[128]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hasManagedCode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(129)]
    public HRESULT get_hasManagedCode(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[129]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isHotpatchable" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(130)]
    public HRESULT get_isHotpatchable(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[130]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isCVTCIL" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(131)]
    public HRESULT get_isCVTCIL(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[131]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isMSILNetmodule" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(132)]
    public HRESULT get_isMSILNetmodule(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[132]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isCTypes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(133)]
    public HRESULT get_isCTypes(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[133]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isStripped" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(134)]
    public HRESULT get_isStripped(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[134]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_frontEndQFE" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(135)]
    public HRESULT get_frontEndQFE([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[135]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_backEndQFE" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(136)]
    public HRESULT get_backEndQFE([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[136]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_wasInlined" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(137)]
    public HRESULT get_wasInlined(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[137]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_strictGSCheck" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(138)]
    public HRESULT get_strictGSCheck(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[138]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isCxxReturnUdt" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(139)]
    public HRESULT get_isCxxReturnUdt(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[139]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isConstructorVirtualBase" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(140)]
    public HRESULT get_isConstructorVirtualBase(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[140]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_RValueReference" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(141)]
    public HRESULT get_RValueReference(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[141]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_unmodifiedType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(142)]
    public HRESULT get_unmodifiedType(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaSymbol**, int>)(lpVtbl[142]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_framePointerPresent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(143)]
    public HRESULT get_framePointerPresent(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[143]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isSafeBuffers" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(144)]
    public HRESULT get_isSafeBuffers(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[144]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_intrinsic" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(145)]
    public HRESULT get_intrinsic(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[145]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_sealed" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(146)]
    public HRESULT get_sealed(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[146]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hfaFloat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(147)]
    public HRESULT get_hfaFloat(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[147]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hfaDouble" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(148)]
    public HRESULT get_hfaDouble(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[148]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_liveRangeStartAddressSection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(149)]
    public HRESULT get_liveRangeStartAddressSection([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[149]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_liveRangeStartAddressOffset" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(150)]
    public HRESULT get_liveRangeStartAddressOffset([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[150]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_liveRangeStartRelativeVirtualAddress" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(151)]
    public HRESULT get_liveRangeStartRelativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[151]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_countLiveRanges" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(152)]
    public HRESULT get_countLiveRanges([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[152]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_liveRangeLength" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(153)]
    public HRESULT get_liveRangeLength([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, ulong*, int>)(lpVtbl[153]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_offsetInUdt" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(154)]
    public HRESULT get_offsetInUdt([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[154]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_paramBasePointerRegisterId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(155)]
    public HRESULT get_paramBasePointerRegisterId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[155]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_localBasePointerRegisterId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(156)]
    public HRESULT get_localBasePointerRegisterId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[156]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isLocationControlFlowDependent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(157)]
    public HRESULT get_isLocationControlFlowDependent(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[157]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_stride" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(158)]
    public HRESULT get_stride([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[158]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_numberOfRows" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(159)]
    public HRESULT get_numberOfRows([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[159]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_numberOfColumns" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(160)]
    public HRESULT get_numberOfColumns([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[160]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isMatrixRowMajor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(161)]
    public HRESULT get_isMatrixRowMajor(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[161]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_numericProperties" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(162)]
    public HRESULT get_numericProperties([NativeTypeName("DWORD")] uint cnt, [NativeTypeName("DWORD *")] uint* pcnt, [NativeTypeName("DWORD *")] uint* pProperties)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint, uint*, uint*, int>)(lpVtbl[162]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), cnt, pcnt, pProperties);
    }

    /// <inheritdoc cref="IDiaSymbol.get_modifierValues" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(163)]
    public HRESULT get_modifierValues([NativeTypeName("DWORD")] uint cnt, [NativeTypeName("DWORD *")] uint* pcnt, [NativeTypeName("WORD *")] ushort* pModifiers)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint, uint*, ushort*, int>)(lpVtbl[163]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), cnt, pcnt, pModifiers);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isReturnValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(164)]
    public HRESULT get_isReturnValue(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[164]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isOptimizedAway" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(165)]
    public HRESULT get_isOptimizedAway(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[165]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_builtInKind" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(166)]
    public HRESULT get_builtInKind([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[166]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_registerType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(167)]
    public HRESULT get_registerType([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[167]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_baseDataSlot" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(168)]
    public HRESULT get_baseDataSlot([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[168]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_baseDataOffset" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(169)]
    public HRESULT get_baseDataOffset([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[169]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_textureSlot" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(170)]
    public HRESULT get_textureSlot([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[170]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_samplerSlot" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(171)]
    public HRESULT get_samplerSlot([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[171]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_uavSlot" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(172)]
    public HRESULT get_uavSlot([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[172]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_sizeInUdt" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(173)]
    public HRESULT get_sizeInUdt([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[173]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_memorySpaceKind" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(174)]
    public HRESULT get_memorySpaceKind([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[174]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_unmodifiedTypeId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(175)]
    public HRESULT get_unmodifiedTypeId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[175]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_subTypeId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(176)]
    public HRESULT get_subTypeId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[176]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_subType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(177)]
    public HRESULT get_subType(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaSymbol**, int>)(lpVtbl[177]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_numberOfModifiers" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(178)]
    public HRESULT get_numberOfModifiers([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[178]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_numberOfRegisterIndices" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(179)]
    public HRESULT get_numberOfRegisterIndices([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[179]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isHLSLData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(180)]
    public HRESULT get_isHLSLData(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[180]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isPointerToDataMember" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(181)]
    public HRESULT get_isPointerToDataMember(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[181]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isPointerToMemberFunction" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(182)]
    public HRESULT get_isPointerToMemberFunction(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[182]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isSingleInheritance" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(183)]
    public HRESULT get_isSingleInheritance(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[183]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isMultipleInheritance" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(184)]
    public HRESULT get_isMultipleInheritance(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[184]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isVirtualInheritance" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(185)]
    public HRESULT get_isVirtualInheritance(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[185]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_restrictedType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(186)]
    public HRESULT get_restrictedType(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[186]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isPointerBasedOnSymbolValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(187)]
    public HRESULT get_isPointerBasedOnSymbolValue(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[187]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_baseSymbol" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(188)]
    public HRESULT get_baseSymbol(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaSymbol**, int>)(lpVtbl[188]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_baseSymbolId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(189)]
    public HRESULT get_baseSymbolId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[189]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_objectFileName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(190)]
    public HRESULT get_objectFileName([NativeTypeName("BSTR *")] char** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, char**, int>)(lpVtbl[190]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isAcceleratorGroupSharedLocal" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(191)]
    public HRESULT get_isAcceleratorGroupSharedLocal(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[191]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isAcceleratorPointerTagLiveRange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(192)]
    public HRESULT get_isAcceleratorPointerTagLiveRange(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[192]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isAcceleratorStubFunction" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(193)]
    public HRESULT get_isAcceleratorStubFunction(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[193]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_numberOfAcceleratorPointerTags" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(194)]
    public HRESULT get_numberOfAcceleratorPointerTags([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[194]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isSdl" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(195)]
    public HRESULT get_isSdl(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[195]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isWinRTPointer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(196)]
    public HRESULT get_isWinRTPointer(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[196]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isRefUdt" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(197)]
    public HRESULT get_isRefUdt(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[197]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isValueUdt" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(198)]
    public HRESULT get_isValueUdt(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[198]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isInterfaceUdt" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(199)]
    public HRESULT get_isInterfaceUdt(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[199]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.findInlineFramesByAddr" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(200)]
    public HRESULT findInlineFramesByAddr([NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[200]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), isect, offset, ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.findInlineFramesByRVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(201)]
    public HRESULT findInlineFramesByRVA([NativeTypeName("DWORD")] uint rva, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint, IDiaEnumSymbols**, int>)(lpVtbl[201]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), rva, ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.findInlineFramesByVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(202)]
    public HRESULT findInlineFramesByVA([NativeTypeName("ULONGLONG")] ulong va, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, ulong, IDiaEnumSymbols**, int>)(lpVtbl[202]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), va, ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.findInlineeLines" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(203)]
    public HRESULT findInlineeLines(IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaEnumLineNumbers**, int>)(lpVtbl[203]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.findInlineeLinesByAddr" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(204)]
    public HRESULT findInlineeLinesByAddr([NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[204]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), isect, offset, length, ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.findInlineeLinesByRVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(205)]
    public HRESULT findInlineeLinesByRVA([NativeTypeName("DWORD")] uint rva, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[205]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), rva, length, ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.findInlineeLinesByVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(206)]
    public HRESULT findInlineeLinesByVA([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, ulong, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[206]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), va, length, ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.findSymbolsForAcceleratorPointerTag" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(207)]
    public HRESULT findSymbolsForAcceleratorPointerTag([NativeTypeName("DWORD")] uint tagValue, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint, IDiaEnumSymbols**, int>)(lpVtbl[207]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), tagValue, ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.findSymbolsByRVAForAcceleratorPointerTag" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(208)]
    public HRESULT findSymbolsByRVAForAcceleratorPointerTag([NativeTypeName("DWORD")] uint tagValue, [NativeTypeName("DWORD")] uint rva, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[208]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), tagValue, rva, ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.get_acceleratorPointerTags" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(209)]
    public HRESULT get_acceleratorPointerTags([NativeTypeName("DWORD")] uint cnt, [NativeTypeName("DWORD *")] uint* pcnt, [NativeTypeName("DWORD *")] uint* pPointerTags)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint, uint*, uint*, int>)(lpVtbl[209]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), cnt, pcnt, pPointerTags);
    }

    /// <inheritdoc cref="IDiaSymbol.getSrcLineOnTypeDefn" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(210)]
    public HRESULT getSrcLineOnTypeDefn(IDiaLineNumber** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaLineNumber**, int>)(lpVtbl[210]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isPGO" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(211)]
    public HRESULT get_isPGO(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[211]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hasValidPGOCounts" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(212)]
    public HRESULT get_hasValidPGOCounts(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[212]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_isOptimizedForSpeed" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(213)]
    public HRESULT get_isOptimizedForSpeed(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[213]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_PGOEntryCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(214)]
    public HRESULT get_PGOEntryCount([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[214]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_PGOEdgeCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(215)]
    public HRESULT get_PGOEdgeCount([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[215]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_PGODynamicInstructionCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(216)]
    public HRESULT get_PGODynamicInstructionCount([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, ulong*, int>)(lpVtbl[216]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_staticSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(217)]
    public HRESULT get_staticSize([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[217]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_finalLiveStaticSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(218)]
    public HRESULT get_finalLiveStaticSize([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[218]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_phaseName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(219)]
    public HRESULT get_phaseName([NativeTypeName("BSTR *")] char** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, char**, int>)(lpVtbl[219]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_hasControlFlowCheck" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(220)]
    public HRESULT get_hasControlFlowCheck(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[220]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_constantExport" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(221)]
    public HRESULT get_constantExport(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[221]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_dataExport" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(222)]
    public HRESULT get_dataExport(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[222]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_privateExport" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(223)]
    public HRESULT get_privateExport(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[223]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_noNameExport" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(224)]
    public HRESULT get_noNameExport(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[224]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_exportHasExplicitlyAssignedOrdinal" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(225)]
    public HRESULT get_exportHasExplicitlyAssignedOrdinal(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[225]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_exportIsForwarder" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(226)]
    public HRESULT get_exportIsForwarder(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[226]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_ordinal" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(227)]
    public HRESULT get_ordinal([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[227]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_frameSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(228)]
    public HRESULT get_frameSize([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[228]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_exceptionHandlerAddressSection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(229)]
    public HRESULT get_exceptionHandlerAddressSection([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[229]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_exceptionHandlerAddressOffset" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(230)]
    public HRESULT get_exceptionHandlerAddressOffset([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[230]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_exceptionHandlerRelativeVirtualAddress" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(231)]
    public HRESULT get_exceptionHandlerRelativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[231]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_exceptionHandlerVirtualAddress" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(232)]
    public HRESULT get_exceptionHandlerVirtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, ulong*, int>)(lpVtbl[232]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.findInputAssemblyFile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(233)]
    public HRESULT findInputAssemblyFile(IDiaInputAssemblyFile** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaInputAssemblyFile**, int>)(lpVtbl[233]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <inheritdoc cref="IDiaSymbol.get_characteristics" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(234)]
    public HRESULT get_characteristics([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[234]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_coffGroup" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(235)]
    public HRESULT get_coffGroup(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaSymbol**, int>)(lpVtbl[235]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_bindID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(236)]
    public HRESULT get_bindID([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[236]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_bindSpace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(237)]
    public HRESULT get_bindSpace([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[237]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol.get_bindSlot" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(238)]
    public HRESULT get_bindSlot([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[238]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol2.get_isObjCClass" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(239)]
    public HRESULT get_isObjCClass(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[239]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol2.get_isObjCCategory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(240)]
    public HRESULT get_isObjCCategory(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[240]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol2.get_isObjCProtocol" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(241)]
    public HRESULT get_isObjCProtocol(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[241]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol3.get_inlinee" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(242)]
    public HRESULT get_inlinee(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, IDiaSymbol**, int>)(lpVtbl[242]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol3.get_inlineeId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(243)]
    public HRESULT get_inlineeId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, uint*, int>)(lpVtbl[243]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSymbol4.get_noexcept" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(244)]
    public HRESULT get_noexcept(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[244]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSymbol5.xml' path='doc/member[@name="IDiaSymbol5.get_hasAbsoluteAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(245)]
    public HRESULT get_hasAbsoluteAddress(BOOL* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSymbol5*, BOOL*, int>)(lpVtbl[245]))((IDiaSymbol5*)Unsafe.AsPointer(ref this), pRetVal);
    }

    public interface Interface : IDiaSymbol4.Interface
    {
        [VtblIndex(245)]
        HRESULT get_hasAbsoluteAddress(BOOL* pRetVal);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_symIndexId;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_symTag;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_name;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_lexicalParent;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_classParent;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_type;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_dataKind;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_locationType;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_addressSection;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_addressOffset;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_relativeVirtualAddress;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_virtualAddress;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_registerId;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_offset;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_length;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_slot;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_volatileType;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_constType;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_unalignedType;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_access;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_libraryName;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_platform;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_language;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_editAndContinueEnabled;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_frontEndMajor;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_frontEndMinor;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_frontEndBuild;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_backEndMajor;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_backEndMinor;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_backEndBuild;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_sourceFileName;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_unused;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_thunkOrdinal;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_thisAdjust;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_virtualBaseOffset;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_virtual;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_intro;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_pure;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_callingConvention;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, VARIANT*, int> get_value;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_baseType;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_token;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_timeStamp;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> get_guid;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_symbolsFileName;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_reference;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_count;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_bitPosition;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_arrayIndexType;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_packed;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_constructor;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_overloadedOperator;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_nested;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasNestedTypes;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasAssignmentOperator;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasCastOperator;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_scoped;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_virtualBaseClass;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_indirectVirtualBaseClass;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_virtualBasePointerOffset;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_virtualTableShape;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_lexicalParentId;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_classParentId;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_typeId;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_arrayIndexTypeId;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_virtualTableShapeId;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_code;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_function;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_managed;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_msil;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_virtualBaseDispIndex;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_undecoratedName;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_age;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_signature;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_compilerGenerated;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_addressTaken;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_rank;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_lowerBound;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_upperBound;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_lowerBoundId;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_upperBoundId;

        [NativeTypeName("HRESULT (DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, byte*, int> get_dataBytes;

        [NativeTypeName("HRESULT (enum SymTagEnum, LPCOLESTR, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SymTagEnum, char*, uint, IDiaEnumSymbols**, int> findChildren;

        [NativeTypeName("HRESULT (enum SymTagEnum, LPCOLESTR, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SymTagEnum, char*, uint, IDiaEnumSymbols**, int> findChildrenEx;

        [NativeTypeName("HRESULT (enum SymTagEnum, LPCOLESTR, DWORD, DWORD, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SymTagEnum, char*, uint, uint, uint, IDiaEnumSymbols**, int> findChildrenExByAddr;

        [NativeTypeName("HRESULT (enum SymTagEnum, LPCOLESTR, DWORD, ULONGLONG, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SymTagEnum, char*, uint, ulong, IDiaEnumSymbols**, int> findChildrenExByVA;

        [NativeTypeName("HRESULT (enum SymTagEnum, LPCOLESTR, DWORD, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SymTagEnum, char*, uint, uint, IDiaEnumSymbols**, int> findChildrenExByRVA;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_targetSection;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_targetOffset;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_targetRelativeVirtualAddress;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_targetVirtualAddress;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_machineType;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_oemId;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_oemSymbolId;

        [NativeTypeName("HRESULT (DWORD, DWORD *, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, IDiaSymbol**, int> get_types;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, int> get_typeIds;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_objectPointerType;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_udtKind;

        [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char**, int> get_undecoratedNameEx;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_noReturn;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_customCallingConvention;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_noInline;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_optimizedCodeDebugInfo;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_notReached;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_interruptReturn;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_farReturn;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isStatic;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasDebugInfo;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isLTCG;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isDataAligned;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasSecurityChecks;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_compilerName;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasAlloca;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasSetJump;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasLongJump;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasInlAsm;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasEH;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasSEH;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasEHa;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isNaked;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isAggregated;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isSplitted;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_container;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_inlSpec;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_noStackOrdering;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_virtualBaseTableType;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasManagedCode;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isHotpatchable;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isCVTCIL;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isMSILNetmodule;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isCTypes;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isStripped;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_frontEndQFE;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_backEndQFE;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_wasInlined;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_strictGSCheck;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isCxxReturnUdt;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isConstructorVirtualBase;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_RValueReference;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_unmodifiedType;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_framePointerPresent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isSafeBuffers;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_intrinsic;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_sealed;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hfaFloat;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hfaDouble;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_liveRangeStartAddressSection;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_liveRangeStartAddressOffset;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_liveRangeStartRelativeVirtualAddress;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_countLiveRanges;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_liveRangeLength;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_offsetInUdt;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_paramBasePointerRegisterId;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_localBasePointerRegisterId;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isLocationControlFlowDependent;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_stride;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_numberOfRows;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_numberOfColumns;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isMatrixRowMajor;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, int> get_numericProperties;

        [NativeTypeName("HRESULT (DWORD, DWORD *, WORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, ushort*, int> get_modifierValues;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isReturnValue;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isOptimizedAway;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_builtInKind;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_registerType;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_baseDataSlot;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_baseDataOffset;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_textureSlot;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_samplerSlot;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_uavSlot;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_sizeInUdt;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_memorySpaceKind;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_unmodifiedTypeId;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_subTypeId;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_subType;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_numberOfModifiers;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_numberOfRegisterIndices;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isHLSLData;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isPointerToDataMember;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isPointerToMemberFunction;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isSingleInheritance;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isMultipleInheritance;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isVirtualInheritance;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_restrictedType;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isPointerBasedOnSymbolValue;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_baseSymbol;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_baseSymbolId;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_objectFileName;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isAcceleratorGroupSharedLocal;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isAcceleratorPointerTagLiveRange;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isAcceleratorStubFunction;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_numberOfAcceleratorPointerTags;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isSdl;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isWinRTPointer;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isRefUdt;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isValueUdt;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isInterfaceUdt;

        [NativeTypeName("HRESULT (DWORD, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IDiaEnumSymbols**, int> findInlineFramesByAddr;

        [NativeTypeName("HRESULT (DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDiaEnumSymbols**, int> findInlineFramesByRVA;

        [NativeTypeName("HRESULT (ULONGLONG, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, IDiaEnumSymbols**, int> findInlineFramesByVA;

        [NativeTypeName("HRESULT (IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaEnumLineNumbers**, int> findInlineeLines;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, IDiaEnumLineNumbers**, int> findInlineeLinesByAddr;

        [NativeTypeName("HRESULT (DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IDiaEnumLineNumbers**, int> findInlineeLinesByRVA;

        [NativeTypeName("HRESULT (ULONGLONG, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, uint, IDiaEnumLineNumbers**, int> findInlineeLinesByVA;

        [NativeTypeName("HRESULT (DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDiaEnumSymbols**, int> findSymbolsForAcceleratorPointerTag;

        [NativeTypeName("HRESULT (DWORD, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IDiaEnumSymbols**, int> findSymbolsByRVAForAcceleratorPointerTag;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, int> get_acceleratorPointerTags;

        [NativeTypeName("HRESULT (IDiaLineNumber **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaLineNumber**, int> getSrcLineOnTypeDefn;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isPGO;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasValidPGOCounts;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isOptimizedForSpeed;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_PGOEntryCount;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_PGOEdgeCount;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_PGODynamicInstructionCount;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_staticSize;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_finalLiveStaticSize;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> get_phaseName;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasControlFlowCheck;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_constantExport;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_dataExport;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_privateExport;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_noNameExport;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_exportHasExplicitlyAssignedOrdinal;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_exportIsForwarder;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ordinal;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_frameSize;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_exceptionHandlerAddressSection;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_exceptionHandlerAddressOffset;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_exceptionHandlerRelativeVirtualAddress;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_exceptionHandlerVirtualAddress;

        [NativeTypeName("HRESULT (IDiaInputAssemblyFile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaInputAssemblyFile**, int> findInputAssemblyFile;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_characteristics;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_coffGroup;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_bindID;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_bindSpace;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_bindSlot;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isObjCClass;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isObjCCategory;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_isObjCProtocol;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_inlinee;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_inlineeId;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_noexcept;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> get_hasAbsoluteAddress;
    }
}
