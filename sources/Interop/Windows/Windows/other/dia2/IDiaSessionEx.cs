// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaSessionEx.xml' path='doc/member[@name="IDiaSessionEx"]/*' />
[Guid("CD24EED5-5FEA-4742-A320-6254C920E78B")]
[NativeTypeName("struct IDiaSessionEx : IDiaSession")]
[NativeInheritance("IDiaSession")]
public unsafe partial struct IDiaSessionEx : IDiaSessionEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaSessionEx));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, Guid*, void**, int>)(lpVtbl[0]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint>)(lpVtbl[1]))((IDiaSessionEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint>)(lpVtbl[2]))((IDiaSessionEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDiaSession.get_loadAddress" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_loadAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, ulong*, int>)(lpVtbl[3]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSession.put_loadAddress" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_loadAddress([NativeTypeName("ULONGLONG")] ulong NewVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, ulong, int>)(lpVtbl[4]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), NewVal);
    }

    /// <inheritdoc cref="IDiaSession.get_globalScope" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_globalScope(IDiaSymbol** pRetVal)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol**, int>)(lpVtbl[5]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref="IDiaSession.getEnumTables" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT getEnumTables(IDiaEnumTables** ppEnumTables)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaEnumTables**, int>)(lpVtbl[6]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), ppEnumTables);
    }

    /// <inheritdoc cref="IDiaSession.getSymbolsByAddr" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT getSymbolsByAddr(IDiaEnumSymbolsByAddr** ppEnumbyAddr)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaEnumSymbolsByAddr**, int>)(lpVtbl[7]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), ppEnumbyAddr);
    }

    /// <inheritdoc cref="IDiaSession.findChildren" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT findChildren(IDiaSymbol* parent, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] char* name, [NativeTypeName("DWORD")] uint compareFlags, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, SymTagEnum, char*, uint, IDiaEnumSymbols**, int>)(lpVtbl[8]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, symtag, name, compareFlags, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findChildrenEx" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT findChildrenEx(IDiaSymbol* parent, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] char* name, [NativeTypeName("DWORD")] uint compareFlags, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, SymTagEnum, char*, uint, IDiaEnumSymbols**, int>)(lpVtbl[9]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, symtag, name, compareFlags, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findChildrenExByAddr" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT findChildrenExByAddr(IDiaSymbol* parent, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] char* name, [NativeTypeName("DWORD")] uint compareFlags, [NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, SymTagEnum, char*, uint, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[10]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, symtag, name, compareFlags, isect, offset, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findChildrenExByVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT findChildrenExByVA(IDiaSymbol* parent, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] char* name, [NativeTypeName("DWORD")] uint compareFlags, [NativeTypeName("ULONGLONG")] ulong va, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, SymTagEnum, char*, uint, ulong, IDiaEnumSymbols**, int>)(lpVtbl[11]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, symtag, name, compareFlags, va, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findChildrenExByRVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT findChildrenExByRVA(IDiaSymbol* parent, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] char* name, [NativeTypeName("DWORD")] uint compareFlags, [NativeTypeName("DWORD")] uint rva, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, SymTagEnum, char*, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[12]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, symtag, name, compareFlags, rva, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findSymbolByAddr" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT findSymbolByAddr([NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, IDiaSymbol** ppSymbol)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, uint, SymTagEnum, IDiaSymbol**, int>)(lpVtbl[13]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), isect, offset, symtag, ppSymbol);
    }

    /// <inheritdoc cref="IDiaSession.findSymbolByRVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT findSymbolByRVA([NativeTypeName("DWORD")] uint rva, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, IDiaSymbol** ppSymbol)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, SymTagEnum, IDiaSymbol**, int>)(lpVtbl[14]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), rva, symtag, ppSymbol);
    }

    /// <inheritdoc cref="IDiaSession.findSymbolByVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT findSymbolByVA([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, IDiaSymbol** ppSymbol)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, ulong, SymTagEnum, IDiaSymbol**, int>)(lpVtbl[15]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), va, symtag, ppSymbol);
    }

    /// <inheritdoc cref="IDiaSession.findSymbolByToken" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT findSymbolByToken([NativeTypeName("ULONG")] uint token, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, IDiaSymbol** ppSymbol)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, SymTagEnum, IDiaSymbol**, int>)(lpVtbl[16]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), token, symtag, ppSymbol);
    }

    /// <inheritdoc cref="IDiaSession.symsAreEquiv" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT symsAreEquiv(IDiaSymbol* symbolA, IDiaSymbol* symbolB)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, IDiaSymbol*, int>)(lpVtbl[17]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), symbolA, symbolB);
    }

    /// <inheritdoc cref="IDiaSession.symbolById" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT symbolById([NativeTypeName("DWORD")] uint id, IDiaSymbol** ppSymbol)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, IDiaSymbol**, int>)(lpVtbl[18]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), id, ppSymbol);
    }

    /// <inheritdoc cref="IDiaSession.findSymbolByRVAEx" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT findSymbolByRVAEx([NativeTypeName("DWORD")] uint rva, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, IDiaSymbol** ppSymbol, [NativeTypeName("long *")] int* displacement)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, SymTagEnum, IDiaSymbol**, int*, int>)(lpVtbl[19]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), rva, symtag, ppSymbol, displacement);
    }

    /// <inheritdoc cref="IDiaSession.findSymbolByVAEx" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT findSymbolByVAEx([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, IDiaSymbol** ppSymbol, [NativeTypeName("long *")] int* displacement)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, ulong, SymTagEnum, IDiaSymbol**, int*, int>)(lpVtbl[20]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), va, symtag, ppSymbol, displacement);
    }

    /// <inheritdoc cref="IDiaSession.findFile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT findFile(IDiaSymbol* pCompiland, [NativeTypeName("LPCOLESTR")] char* name, [NativeTypeName("DWORD")] uint compareFlags, IDiaEnumSourceFiles** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, char*, uint, IDiaEnumSourceFiles**, int>)(lpVtbl[21]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), pCompiland, name, compareFlags, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findFileById" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT findFileById([NativeTypeName("DWORD")] uint uniqueId, IDiaSourceFile** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, IDiaSourceFile**, int>)(lpVtbl[22]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), uniqueId, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findLines" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT findLines(IDiaSymbol* compiland, IDiaSourceFile* file, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, IDiaSourceFile*, IDiaEnumLineNumbers**, int>)(lpVtbl[23]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), compiland, file, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findLinesByAddr" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT findLinesByAddr([NativeTypeName("DWORD")] uint seg, [NativeTypeName("DWORD")] uint offset, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[24]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), seg, offset, length, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findLinesByRVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT findLinesByRVA([NativeTypeName("DWORD")] uint rva, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[25]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), rva, length, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findLinesByVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT findLinesByVA([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, ulong, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[26]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), va, length, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findLinesByLinenum" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT findLinesByLinenum(IDiaSymbol* compiland, IDiaSourceFile* file, [NativeTypeName("DWORD")] uint linenum, [NativeTypeName("DWORD")] uint column, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, IDiaSourceFile*, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[27]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), compiland, file, linenum, column, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findInjectedSource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT findInjectedSource([NativeTypeName("LPCOLESTR")] char* srcFile, IDiaEnumInjectedSources** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, char*, IDiaEnumInjectedSources**, int>)(lpVtbl[28]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), srcFile, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.getEnumDebugStreams" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT getEnumDebugStreams(IDiaEnumDebugStreams** ppEnumDebugStreams)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaEnumDebugStreams**, int>)(lpVtbl[29]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), ppEnumDebugStreams);
    }

    /// <inheritdoc cref="IDiaSession.findInlineFramesByAddr" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT findInlineFramesByAddr(IDiaSymbol* parent, [NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[30]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, isect, offset, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findInlineFramesByRVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT findInlineFramesByRVA(IDiaSymbol* parent, [NativeTypeName("DWORD")] uint rva, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, uint, IDiaEnumSymbols**, int>)(lpVtbl[31]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, rva, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findInlineFramesByVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT findInlineFramesByVA(IDiaSymbol* parent, [NativeTypeName("ULONGLONG")] ulong va, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, ulong, IDiaEnumSymbols**, int>)(lpVtbl[32]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, va, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findInlineeLines" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT findInlineeLines(IDiaSymbol* parent, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, IDiaEnumLineNumbers**, int>)(lpVtbl[33]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findInlineeLinesByAddr" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT findInlineeLinesByAddr(IDiaSymbol* parent, [NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, uint, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[34]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, isect, offset, length, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findInlineeLinesByRVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT findInlineeLinesByRVA(IDiaSymbol* parent, [NativeTypeName("DWORD")] uint rva, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[35]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, rva, length, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findInlineeLinesByVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT findInlineeLinesByVA(IDiaSymbol* parent, [NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, ulong, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[36]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, va, length, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findInlineeLinesByLinenum" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT findInlineeLinesByLinenum(IDiaSymbol* compiland, IDiaSourceFile* file, [NativeTypeName("DWORD")] uint linenum, [NativeTypeName("DWORD")] uint column, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, IDiaSourceFile*, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[37]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), compiland, file, linenum, column, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findInlineesByName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT findInlineesByName([NativeTypeName("LPCOLESTR")] char* name, [NativeTypeName("DWORD")] uint option, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, char*, uint, IDiaEnumSymbols**, int>)(lpVtbl[38]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), name, option, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findAcceleratorInlineeLinesByLinenum" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT findAcceleratorInlineeLinesByLinenum(IDiaSymbol* parent, IDiaSourceFile* file, [NativeTypeName("DWORD")] uint linenum, [NativeTypeName("DWORD")] uint column, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, IDiaSourceFile*, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[39]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, file, linenum, column, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findSymbolsForAcceleratorPointerTag" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT findSymbolsForAcceleratorPointerTag(IDiaSymbol* parent, [NativeTypeName("DWORD")] uint tagValue, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, uint, IDiaEnumSymbols**, int>)(lpVtbl[40]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, tagValue, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findSymbolsByRVAForAcceleratorPointerTag" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT findSymbolsByRVAForAcceleratorPointerTag(IDiaSymbol* parent, [NativeTypeName("DWORD")] uint tagValue, [NativeTypeName("DWORD")] uint rva, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[41]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, tagValue, rva, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findAcceleratorInlineesByName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT findAcceleratorInlineesByName([NativeTypeName("LPCOLESTR")] char* name, [NativeTypeName("DWORD")] uint option, IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, char*, uint, IDiaEnumSymbols**, int>)(lpVtbl[42]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), name, option, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.addressForVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT addressForVA([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD *")] uint* pISect, [NativeTypeName("DWORD *")] uint* pOffset)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, ulong, uint*, uint*, int>)(lpVtbl[43]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), va, pISect, pOffset);
    }

    /// <inheritdoc cref="IDiaSession.addressForRVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT addressForRVA([NativeTypeName("DWORD")] uint rva, [NativeTypeName("DWORD *")] uint* pISect, [NativeTypeName("DWORD *")] uint* pOffset)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, uint*, uint*, int>)(lpVtbl[44]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), rva, pISect, pOffset);
    }

    /// <inheritdoc cref="IDiaSession.findILOffsetsByAddr" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT findILOffsetsByAddr([NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[45]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), isect, offset, length, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findILOffsetsByRVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT findILOffsetsByRVA([NativeTypeName("DWORD")] uint rva, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[46]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), rva, length, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findILOffsetsByVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT findILOffsetsByVA([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, ulong, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[47]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), va, length, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findInputAssemblyFiles" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT findInputAssemblyFiles(IDiaEnumInputAssemblyFiles** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaEnumInputAssemblyFiles**, int>)(lpVtbl[48]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findInputAssembly" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT findInputAssembly([NativeTypeName("DWORD")] uint index, IDiaInputAssemblyFile** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, IDiaInputAssemblyFile**, int>)(lpVtbl[49]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), index, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findInputAssemblyById" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT findInputAssemblyById([NativeTypeName("DWORD")] uint uniqueId, IDiaInputAssemblyFile** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, IDiaInputAssemblyFile**, int>)(lpVtbl[50]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), uniqueId, ppResult);
    }

    /// <inheritdoc cref="IDiaSession.getFuncMDTokenMapSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT getFuncMDTokenMapSize([NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint*, int>)(lpVtbl[51]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), pcb);
    }

    /// <inheritdoc cref="IDiaSession.getFuncMDTokenMap" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT getFuncMDTokenMap([NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD *")] uint* pcb, byte* pb)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, uint*, byte*, int>)(lpVtbl[52]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), cb, pcb, pb);
    }

    /// <inheritdoc cref="IDiaSession.getTypeMDTokenMapSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT getTypeMDTokenMapSize([NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint*, int>)(lpVtbl[53]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), pcb);
    }

    /// <inheritdoc cref="IDiaSession.getTypeMDTokenMap" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT getTypeMDTokenMap([NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD *")] uint* pcb, byte* pb)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, uint*, byte*, int>)(lpVtbl[54]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), cb, pcb, pb);
    }

    /// <inheritdoc cref="IDiaSession.getNumberOfFunctionFragments_VA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT getNumberOfFunctionFragments_VA([NativeTypeName("ULONGLONG")] ulong vaFunc, [NativeTypeName("DWORD")] uint cbFunc, [NativeTypeName("DWORD *")] uint* pNumFragments)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, ulong, uint, uint*, int>)(lpVtbl[55]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), vaFunc, cbFunc, pNumFragments);
    }

    /// <inheritdoc cref="IDiaSession.getNumberOfFunctionFragments_RVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT getNumberOfFunctionFragments_RVA([NativeTypeName("DWORD")] uint rvaFunc, [NativeTypeName("DWORD")] uint cbFunc, [NativeTypeName("DWORD *")] uint* pNumFragments)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, uint, uint*, int>)(lpVtbl[56]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), rvaFunc, cbFunc, pNumFragments);
    }

    /// <inheritdoc cref="IDiaSession.getFunctionFragments_VA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT getFunctionFragments_VA([NativeTypeName("ULONGLONG")] ulong vaFunc, [NativeTypeName("DWORD")] uint cbFunc, [NativeTypeName("DWORD")] uint cFragments, [NativeTypeName("ULONGLONG *")] ulong* pVaFragment, [NativeTypeName("DWORD *")] uint* pLenFragment)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, ulong, uint, uint, ulong*, uint*, int>)(lpVtbl[57]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), vaFunc, cbFunc, cFragments, pVaFragment, pLenFragment);
    }

    /// <inheritdoc cref="IDiaSession.getFunctionFragments_RVA" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT getFunctionFragments_RVA([NativeTypeName("DWORD")] uint rvaFunc, [NativeTypeName("DWORD")] uint cbFunc, [NativeTypeName("DWORD")] uint cFragments, [NativeTypeName("DWORD *")] uint* pRvaFragment, [NativeTypeName("DWORD *")] uint* pLenFragment)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, uint, uint, uint, uint*, uint*, int>)(lpVtbl[58]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), rvaFunc, cbFunc, cFragments, pRvaFragment, pLenFragment);
    }

    /// <inheritdoc cref="IDiaSession.getExports" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT getExports(IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaEnumSymbols**, int>)(lpVtbl[59]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <inheritdoc cref="IDiaSession.getHeapAllocationSites" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT getHeapAllocationSites(IDiaEnumSymbols** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaEnumSymbols**, int>)(lpVtbl[60]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <inheritdoc cref="IDiaSession.findInputAssemblyFile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT findInputAssemblyFile(IDiaSymbol* pSymbol, IDiaInputAssemblyFile** ppResult)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, IDiaInputAssemblyFile**, int>)(lpVtbl[61]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), pSymbol, ppResult);
    }

    /// <include file='IDiaSessionEx.xml' path='doc/member[@name="IDiaSessionEx.isFastLinkPDB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT isFastLinkPDB(BOOL* pfFastLinkPDB)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, BOOL*, int>)(lpVtbl[62]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), pfFastLinkPDB);
    }

    /// <include file='IDiaSessionEx.xml' path='doc/member[@name="IDiaSessionEx.isPortablePDB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT isPortablePDB(BOOL* pfPortablePDB)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, BOOL*, int>)(lpVtbl[63]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), pfPortablePDB);
    }

    /// <include file='IDiaSessionEx.xml' path='doc/member[@name="IDiaSessionEx.getSourceLinkInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT getSourceLinkInfo(IDiaSymbol* parent, IDiaEnumSourceLink** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiaSessionEx*, IDiaSymbol*, IDiaEnumSourceLink**, int>)(lpVtbl[64]))((IDiaSessionEx*)Unsafe.AsPointer(ref this), parent, ppenum);
    }

    public interface Interface : IDiaSession.Interface
    {
        [VtblIndex(62)]
        HRESULT isFastLinkPDB(BOOL* pfFastLinkPDB);

        [VtblIndex(63)]
        HRESULT isPortablePDB(BOOL* pfPortablePDB);

        [VtblIndex(64)]
        HRESULT getSourceLinkInfo(IDiaSymbol* parent, IDiaEnumSourceLink** ppenum);
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

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong*, int> get_loadAddress;

        [NativeTypeName("HRESULT (ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, int> put_loadAddress;

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol**, int> get_globalScope;

        [NativeTypeName("HRESULT (IDiaEnumTables **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaEnumTables**, int> getEnumTables;

        [NativeTypeName("HRESULT (IDiaEnumSymbolsByAddr **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaEnumSymbolsByAddr**, int> getSymbolsByAddr;

        [NativeTypeName("HRESULT (IDiaSymbol *, enum SymTagEnum, LPCOLESTR, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, SymTagEnum, char*, uint, IDiaEnumSymbols**, int> findChildren;

        [NativeTypeName("HRESULT (IDiaSymbol *, enum SymTagEnum, LPCOLESTR, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, SymTagEnum, char*, uint, IDiaEnumSymbols**, int> findChildrenEx;

        [NativeTypeName("HRESULT (IDiaSymbol *, enum SymTagEnum, LPCOLESTR, DWORD, DWORD, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, SymTagEnum, char*, uint, uint, uint, IDiaEnumSymbols**, int> findChildrenExByAddr;

        [NativeTypeName("HRESULT (IDiaSymbol *, enum SymTagEnum, LPCOLESTR, DWORD, ULONGLONG, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, SymTagEnum, char*, uint, ulong, IDiaEnumSymbols**, int> findChildrenExByVA;

        [NativeTypeName("HRESULT (IDiaSymbol *, enum SymTagEnum, LPCOLESTR, DWORD, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, SymTagEnum, char*, uint, uint, IDiaEnumSymbols**, int> findChildrenExByRVA;

        [NativeTypeName("HRESULT (DWORD, DWORD, enum SymTagEnum, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, SymTagEnum, IDiaSymbol**, int> findSymbolByAddr;

        [NativeTypeName("HRESULT (DWORD, enum SymTagEnum, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, SymTagEnum, IDiaSymbol**, int> findSymbolByRVA;

        [NativeTypeName("HRESULT (ULONGLONG, enum SymTagEnum, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, SymTagEnum, IDiaSymbol**, int> findSymbolByVA;

        [NativeTypeName("HRESULT (ULONG, enum SymTagEnum, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, SymTagEnum, IDiaSymbol**, int> findSymbolByToken;

        [NativeTypeName("HRESULT (IDiaSymbol *, IDiaSymbol *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, IDiaSymbol*, int> symsAreEquiv;

        [NativeTypeName("HRESULT (DWORD, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDiaSymbol**, int> symbolById;

        [NativeTypeName("HRESULT (DWORD, enum SymTagEnum, IDiaSymbol **, long *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, SymTagEnum, IDiaSymbol**, int*, int> findSymbolByRVAEx;

        [NativeTypeName("HRESULT (ULONGLONG, enum SymTagEnum, IDiaSymbol **, long *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, SymTagEnum, IDiaSymbol**, int*, int> findSymbolByVAEx;

        [NativeTypeName("HRESULT (IDiaSymbol *, LPCOLESTR, DWORD, IDiaEnumSourceFiles **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, char*, uint, IDiaEnumSourceFiles**, int> findFile;

        [NativeTypeName("HRESULT (DWORD, IDiaSourceFile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDiaSourceFile**, int> findFileById;

        [NativeTypeName("HRESULT (IDiaSymbol *, IDiaSourceFile *, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, IDiaSourceFile*, IDiaEnumLineNumbers**, int> findLines;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, IDiaEnumLineNumbers**, int> findLinesByAddr;

        [NativeTypeName("HRESULT (DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IDiaEnumLineNumbers**, int> findLinesByRVA;

        [NativeTypeName("HRESULT (ULONGLONG, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, uint, IDiaEnumLineNumbers**, int> findLinesByVA;

        [NativeTypeName("HRESULT (IDiaSymbol *, IDiaSourceFile *, DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, IDiaSourceFile*, uint, uint, IDiaEnumLineNumbers**, int> findLinesByLinenum;

        [NativeTypeName("HRESULT (LPCOLESTR, IDiaEnumInjectedSources **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IDiaEnumInjectedSources**, int> findInjectedSource;

        [NativeTypeName("HRESULT (IDiaEnumDebugStreams **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaEnumDebugStreams**, int> getEnumDebugStreams;

        [NativeTypeName("HRESULT (IDiaSymbol *, DWORD, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, uint, uint, IDiaEnumSymbols**, int> findInlineFramesByAddr;

        [NativeTypeName("HRESULT (IDiaSymbol *, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, uint, IDiaEnumSymbols**, int> findInlineFramesByRVA;

        [NativeTypeName("HRESULT (IDiaSymbol *, ULONGLONG, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, ulong, IDiaEnumSymbols**, int> findInlineFramesByVA;

        [NativeTypeName("HRESULT (IDiaSymbol *, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, IDiaEnumLineNumbers**, int> findInlineeLines;

        [NativeTypeName("HRESULT (IDiaSymbol *, DWORD, DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, uint, uint, uint, IDiaEnumLineNumbers**, int> findInlineeLinesByAddr;

        [NativeTypeName("HRESULT (IDiaSymbol *, DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, uint, uint, IDiaEnumLineNumbers**, int> findInlineeLinesByRVA;

        [NativeTypeName("HRESULT (IDiaSymbol *, ULONGLONG, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, ulong, uint, IDiaEnumLineNumbers**, int> findInlineeLinesByVA;

        [NativeTypeName("HRESULT (IDiaSymbol *, IDiaSourceFile *, DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, IDiaSourceFile*, uint, uint, IDiaEnumLineNumbers**, int> findInlineeLinesByLinenum;

        [NativeTypeName("HRESULT (LPCOLESTR, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, IDiaEnumSymbols**, int> findInlineesByName;

        [NativeTypeName("HRESULT (IDiaSymbol *, IDiaSourceFile *, DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, IDiaSourceFile*, uint, uint, IDiaEnumLineNumbers**, int> findAcceleratorInlineeLinesByLinenum;

        [NativeTypeName("HRESULT (IDiaSymbol *, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, uint, IDiaEnumSymbols**, int> findSymbolsForAcceleratorPointerTag;

        [NativeTypeName("HRESULT (IDiaSymbol *, DWORD, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, uint, uint, IDiaEnumSymbols**, int> findSymbolsByRVAForAcceleratorPointerTag;

        [NativeTypeName("HRESULT (LPCOLESTR, DWORD, IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, IDiaEnumSymbols**, int> findAcceleratorInlineesByName;

        [NativeTypeName("HRESULT (ULONGLONG, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, uint*, uint*, int> addressForVA;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, int> addressForRVA;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, IDiaEnumLineNumbers**, int> findILOffsetsByAddr;

        [NativeTypeName("HRESULT (DWORD, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IDiaEnumLineNumbers**, int> findILOffsetsByRVA;

        [NativeTypeName("HRESULT (ULONGLONG, DWORD, IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, uint, IDiaEnumLineNumbers**, int> findILOffsetsByVA;

        [NativeTypeName("HRESULT (IDiaEnumInputAssemblyFiles **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaEnumInputAssemblyFiles**, int> findInputAssemblyFiles;

        [NativeTypeName("HRESULT (DWORD, IDiaInputAssemblyFile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDiaInputAssemblyFile**, int> findInputAssembly;

        [NativeTypeName("HRESULT (DWORD, IDiaInputAssemblyFile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDiaInputAssemblyFile**, int> findInputAssemblyById;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> getFuncMDTokenMapSize;

        [NativeTypeName("HRESULT (DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, byte*, int> getFuncMDTokenMap;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> getTypeMDTokenMapSize;

        [NativeTypeName("HRESULT (DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, byte*, int> getTypeMDTokenMap;

        [NativeTypeName("HRESULT (ULONGLONG, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, uint, uint*, int> getNumberOfFunctionFragments_VA;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint*, int> getNumberOfFunctionFragments_RVA;

        [NativeTypeName("HRESULT (ULONGLONG, DWORD, DWORD, ULONGLONG *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, uint, uint, ulong*, uint*, int> getFunctionFragments_VA;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, uint*, uint*, int> getFunctionFragments_RVA;

        [NativeTypeName("HRESULT (IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaEnumSymbols**, int> getExports;

        [NativeTypeName("HRESULT (IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaEnumSymbols**, int> getHeapAllocationSites;

        [NativeTypeName("HRESULT (IDiaSymbol *, IDiaInputAssemblyFile **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, IDiaInputAssemblyFile**, int> findInputAssemblyFile;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> isFastLinkPDB;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> isPortablePDB;

        [NativeTypeName("HRESULT (IDiaSymbol *, IDiaEnumSourceLink **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDiaSymbol*, IDiaEnumSourceLink**, int> getSourceLinkInfo;
    }
}
