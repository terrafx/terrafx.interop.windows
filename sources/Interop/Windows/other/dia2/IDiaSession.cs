// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2F609EE1-D1C8-4E24-8288-3326BADCD211")]
    [NativeTypeName("struct IDiaSession : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaSession
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaSession*, Guid*, void**, int>)(lpVtbl[0]))((IDiaSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaSession*, uint>)(lpVtbl[1]))((IDiaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaSession*, uint>)(lpVtbl[2]))((IDiaSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int get_loadAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaSession*, ulong*, int>)(lpVtbl[3]))((IDiaSession*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int put_loadAddress([NativeTypeName("ULONGLONG")] ulong NewVal)
        {
            return ((delegate* unmanaged<IDiaSession*, ulong, int>)(lpVtbl[4]))((IDiaSession*)Unsafe.AsPointer(ref this), NewVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int get_globalScope(IDiaSymbol** pRetVal)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol**, int>)(lpVtbl[5]))((IDiaSession*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int getEnumTables(IDiaEnumTables** ppEnumTables)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaEnumTables**, int>)(lpVtbl[6]))((IDiaSession*)Unsafe.AsPointer(ref this), ppEnumTables);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int getSymbolsByAddr(IDiaEnumSymbolsByAddr** ppEnumbyAddr)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaEnumSymbolsByAddr**, int>)(lpVtbl[7]))((IDiaSession*)Unsafe.AsPointer(ref this), ppEnumbyAddr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int findChildren(IDiaSymbol* parent, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, SymTagEnum, ushort*, uint, IDiaEnumSymbols**, int>)(lpVtbl[8]))((IDiaSession*)Unsafe.AsPointer(ref this), parent, symtag, name, compareFlags, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int findChildrenEx(IDiaSymbol* parent, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, SymTagEnum, ushort*, uint, IDiaEnumSymbols**, int>)(lpVtbl[9]))((IDiaSession*)Unsafe.AsPointer(ref this), parent, symtag, name, compareFlags, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int findChildrenExByAddr(IDiaSymbol* parent, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, [NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, SymTagEnum, ushort*, uint, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[10]))((IDiaSession*)Unsafe.AsPointer(ref this), parent, symtag, name, compareFlags, isect, offset, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int findChildrenExByVA(IDiaSymbol* parent, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, [NativeTypeName("ULONGLONG")] ulong va, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, SymTagEnum, ushort*, uint, ulong, IDiaEnumSymbols**, int>)(lpVtbl[11]))((IDiaSession*)Unsafe.AsPointer(ref this), parent, symtag, name, compareFlags, va, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int findChildrenExByRVA(IDiaSymbol* parent, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, [NativeTypeName("DWORD")] uint rva, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, SymTagEnum, ushort*, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[12]))((IDiaSession*)Unsafe.AsPointer(ref this), parent, symtag, name, compareFlags, rva, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int findSymbolByAddr([NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, IDiaSymbol** ppSymbol)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, uint, SymTagEnum, IDiaSymbol**, int>)(lpVtbl[13]))((IDiaSession*)Unsafe.AsPointer(ref this), isect, offset, symtag, ppSymbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int findSymbolByRVA([NativeTypeName("DWORD")] uint rva, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, IDiaSymbol** ppSymbol)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, SymTagEnum, IDiaSymbol**, int>)(lpVtbl[14]))((IDiaSession*)Unsafe.AsPointer(ref this), rva, symtag, ppSymbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int findSymbolByVA([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, IDiaSymbol** ppSymbol)
        {
            return ((delegate* unmanaged<IDiaSession*, ulong, SymTagEnum, IDiaSymbol**, int>)(lpVtbl[15]))((IDiaSession*)Unsafe.AsPointer(ref this), va, symtag, ppSymbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int findSymbolByToken([NativeTypeName("ULONG")] uint token, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, IDiaSymbol** ppSymbol)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, SymTagEnum, IDiaSymbol**, int>)(lpVtbl[16]))((IDiaSession*)Unsafe.AsPointer(ref this), token, symtag, ppSymbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int symsAreEquiv(IDiaSymbol* symbolA, IDiaSymbol* symbolB)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, IDiaSymbol*, int>)(lpVtbl[17]))((IDiaSession*)Unsafe.AsPointer(ref this), symbolA, symbolB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int symbolById([NativeTypeName("DWORD")] uint id, IDiaSymbol** ppSymbol)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, IDiaSymbol**, int>)(lpVtbl[18]))((IDiaSession*)Unsafe.AsPointer(ref this), id, ppSymbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int findSymbolByRVAEx([NativeTypeName("DWORD")] uint rva, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, IDiaSymbol** ppSymbol, [NativeTypeName("long *")] int* displacement)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, SymTagEnum, IDiaSymbol**, int*, int>)(lpVtbl[19]))((IDiaSession*)Unsafe.AsPointer(ref this), rva, symtag, ppSymbol, displacement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int findSymbolByVAEx([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("enum SymTagEnum")] SymTagEnum symtag, IDiaSymbol** ppSymbol, [NativeTypeName("long *")] int* displacement)
        {
            return ((delegate* unmanaged<IDiaSession*, ulong, SymTagEnum, IDiaSymbol**, int*, int>)(lpVtbl[20]))((IDiaSession*)Unsafe.AsPointer(ref this), va, symtag, ppSymbol, displacement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int findFile(IDiaSymbol* pCompiland, [NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint compareFlags, IDiaEnumSourceFiles** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, ushort*, uint, IDiaEnumSourceFiles**, int>)(lpVtbl[21]))((IDiaSession*)Unsafe.AsPointer(ref this), pCompiland, name, compareFlags, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int findFileById([NativeTypeName("DWORD")] uint uniqueId, IDiaSourceFile** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, IDiaSourceFile**, int>)(lpVtbl[22]))((IDiaSession*)Unsafe.AsPointer(ref this), uniqueId, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int findLines(IDiaSymbol* compiland, IDiaSourceFile* file, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, IDiaSourceFile*, IDiaEnumLineNumbers**, int>)(lpVtbl[23]))((IDiaSession*)Unsafe.AsPointer(ref this), compiland, file, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int findLinesByAddr([NativeTypeName("DWORD")] uint seg, [NativeTypeName("DWORD")] uint offset, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[24]))((IDiaSession*)Unsafe.AsPointer(ref this), seg, offset, length, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int findLinesByRVA([NativeTypeName("DWORD")] uint rva, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[25]))((IDiaSession*)Unsafe.AsPointer(ref this), rva, length, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int findLinesByVA([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, ulong, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[26]))((IDiaSession*)Unsafe.AsPointer(ref this), va, length, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int findLinesByLinenum(IDiaSymbol* compiland, IDiaSourceFile* file, [NativeTypeName("DWORD")] uint linenum, [NativeTypeName("DWORD")] uint column, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, IDiaSourceFile*, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[27]))((IDiaSession*)Unsafe.AsPointer(ref this), compiland, file, linenum, column, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int findInjectedSource([NativeTypeName("LPCOLESTR")] ushort* srcFile, IDiaEnumInjectedSources** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, ushort*, IDiaEnumInjectedSources**, int>)(lpVtbl[28]))((IDiaSession*)Unsafe.AsPointer(ref this), srcFile, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int getEnumDebugStreams(IDiaEnumDebugStreams** ppEnumDebugStreams)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaEnumDebugStreams**, int>)(lpVtbl[29]))((IDiaSession*)Unsafe.AsPointer(ref this), ppEnumDebugStreams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineFramesByAddr(IDiaSymbol* parent, [NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[30]))((IDiaSession*)Unsafe.AsPointer(ref this), parent, isect, offset, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineFramesByRVA(IDiaSymbol* parent, [NativeTypeName("DWORD")] uint rva, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, uint, IDiaEnumSymbols**, int>)(lpVtbl[31]))((IDiaSession*)Unsafe.AsPointer(ref this), parent, rva, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineFramesByVA(IDiaSymbol* parent, [NativeTypeName("ULONGLONG")] ulong va, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, ulong, IDiaEnumSymbols**, int>)(lpVtbl[32]))((IDiaSession*)Unsafe.AsPointer(ref this), parent, va, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineeLines(IDiaSymbol* parent, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, IDiaEnumLineNumbers**, int>)(lpVtbl[33]))((IDiaSession*)Unsafe.AsPointer(ref this), parent, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineeLinesByAddr(IDiaSymbol* parent, [NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, uint, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[34]))((IDiaSession*)Unsafe.AsPointer(ref this), parent, isect, offset, length, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineeLinesByRVA(IDiaSymbol* parent, [NativeTypeName("DWORD")] uint rva, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[35]))((IDiaSession*)Unsafe.AsPointer(ref this), parent, rva, length, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineeLinesByVA(IDiaSymbol* parent, [NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, ulong, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[36]))((IDiaSession*)Unsafe.AsPointer(ref this), parent, va, length, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineeLinesByLinenum(IDiaSymbol* compiland, IDiaSourceFile* file, [NativeTypeName("DWORD")] uint linenum, [NativeTypeName("DWORD")] uint column, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, IDiaSourceFile*, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[37]))((IDiaSession*)Unsafe.AsPointer(ref this), compiland, file, linenum, column, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int findInlineesByName([NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint option, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, ushort*, uint, IDiaEnumSymbols**, int>)(lpVtbl[38]))((IDiaSession*)Unsafe.AsPointer(ref this), name, option, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int findAcceleratorInlineeLinesByLinenum(IDiaSymbol* parent, IDiaSourceFile* file, [NativeTypeName("DWORD")] uint linenum, [NativeTypeName("DWORD")] uint column, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, IDiaSourceFile*, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[39]))((IDiaSession*)Unsafe.AsPointer(ref this), parent, file, linenum, column, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int findSymbolsForAcceleratorPointerTag(IDiaSymbol* parent, [NativeTypeName("DWORD")] uint tagValue, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, uint, IDiaEnumSymbols**, int>)(lpVtbl[40]))((IDiaSession*)Unsafe.AsPointer(ref this), parent, tagValue, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int findSymbolsByRVAForAcceleratorPointerTag(IDiaSymbol* parent, [NativeTypeName("DWORD")] uint tagValue, [NativeTypeName("DWORD")] uint rva, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, uint, uint, IDiaEnumSymbols**, int>)(lpVtbl[41]))((IDiaSession*)Unsafe.AsPointer(ref this), parent, tagValue, rva, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int findAcceleratorInlineesByName([NativeTypeName("LPCOLESTR")] ushort* name, [NativeTypeName("DWORD")] uint option, IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, ushort*, uint, IDiaEnumSymbols**, int>)(lpVtbl[42]))((IDiaSession*)Unsafe.AsPointer(ref this), name, option, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int addressForVA([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD *")] uint* pISect, [NativeTypeName("DWORD *")] uint* pOffset)
        {
            return ((delegate* unmanaged<IDiaSession*, ulong, uint*, uint*, int>)(lpVtbl[43]))((IDiaSession*)Unsafe.AsPointer(ref this), va, pISect, pOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int addressForRVA([NativeTypeName("DWORD")] uint rva, [NativeTypeName("DWORD *")] uint* pISect, [NativeTypeName("DWORD *")] uint* pOffset)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, uint*, uint*, int>)(lpVtbl[44]))((IDiaSession*)Unsafe.AsPointer(ref this), rva, pISect, pOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int findILOffsetsByAddr([NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[45]))((IDiaSession*)Unsafe.AsPointer(ref this), isect, offset, length, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int findILOffsetsByRVA([NativeTypeName("DWORD")] uint rva, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[46]))((IDiaSession*)Unsafe.AsPointer(ref this), rva, length, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int findILOffsetsByVA([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint length, IDiaEnumLineNumbers** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, ulong, uint, IDiaEnumLineNumbers**, int>)(lpVtbl[47]))((IDiaSession*)Unsafe.AsPointer(ref this), va, length, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int findInputAssemblyFiles(IDiaEnumInputAssemblyFiles** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaEnumInputAssemblyFiles**, int>)(lpVtbl[48]))((IDiaSession*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int findInputAssembly([NativeTypeName("DWORD")] uint index, IDiaInputAssemblyFile** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, IDiaInputAssemblyFile**, int>)(lpVtbl[49]))((IDiaSession*)Unsafe.AsPointer(ref this), index, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int findInputAssemblyById([NativeTypeName("DWORD")] uint uniqueId, IDiaInputAssemblyFile** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, IDiaInputAssemblyFile**, int>)(lpVtbl[50]))((IDiaSession*)Unsafe.AsPointer(ref this), uniqueId, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int getFuncMDTokenMapSize([NativeTypeName("DWORD *")] uint* pcb)
        {
            return ((delegate* unmanaged<IDiaSession*, uint*, int>)(lpVtbl[51]))((IDiaSession*)Unsafe.AsPointer(ref this), pcb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int getFuncMDTokenMap([NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD *")] uint* pcb, [NativeTypeName("BYTE *")] byte* pb)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, uint*, byte*, int>)(lpVtbl[52]))((IDiaSession*)Unsafe.AsPointer(ref this), cb, pcb, pb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int getTypeMDTokenMapSize([NativeTypeName("DWORD *")] uint* pcb)
        {
            return ((delegate* unmanaged<IDiaSession*, uint*, int>)(lpVtbl[53]))((IDiaSession*)Unsafe.AsPointer(ref this), pcb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int getTypeMDTokenMap([NativeTypeName("DWORD")] uint cb, [NativeTypeName("DWORD *")] uint* pcb, [NativeTypeName("BYTE *")] byte* pb)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, uint*, byte*, int>)(lpVtbl[54]))((IDiaSession*)Unsafe.AsPointer(ref this), cb, pcb, pb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int getNumberOfFunctionFragments_VA([NativeTypeName("ULONGLONG")] ulong vaFunc, [NativeTypeName("DWORD")] uint cbFunc, [NativeTypeName("DWORD *")] uint* pNumFragments)
        {
            return ((delegate* unmanaged<IDiaSession*, ulong, uint, uint*, int>)(lpVtbl[55]))((IDiaSession*)Unsafe.AsPointer(ref this), vaFunc, cbFunc, pNumFragments);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int getNumberOfFunctionFragments_RVA([NativeTypeName("DWORD")] uint rvaFunc, [NativeTypeName("DWORD")] uint cbFunc, [NativeTypeName("DWORD *")] uint* pNumFragments)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, uint, uint*, int>)(lpVtbl[56]))((IDiaSession*)Unsafe.AsPointer(ref this), rvaFunc, cbFunc, pNumFragments);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int getFunctionFragments_VA([NativeTypeName("ULONGLONG")] ulong vaFunc, [NativeTypeName("DWORD")] uint cbFunc, [NativeTypeName("DWORD")] uint cFragments, [NativeTypeName("ULONGLONG *")] ulong* pVaFragment, [NativeTypeName("DWORD *")] uint* pLenFragment)
        {
            return ((delegate* unmanaged<IDiaSession*, ulong, uint, uint, ulong*, uint*, int>)(lpVtbl[57]))((IDiaSession*)Unsafe.AsPointer(ref this), vaFunc, cbFunc, cFragments, pVaFragment, pLenFragment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int getFunctionFragments_RVA([NativeTypeName("DWORD")] uint rvaFunc, [NativeTypeName("DWORD")] uint cbFunc, [NativeTypeName("DWORD")] uint cFragments, [NativeTypeName("DWORD *")] uint* pRvaFragment, [NativeTypeName("DWORD *")] uint* pLenFragment)
        {
            return ((delegate* unmanaged<IDiaSession*, uint, uint, uint, uint*, uint*, int>)(lpVtbl[58]))((IDiaSession*)Unsafe.AsPointer(ref this), rvaFunc, cbFunc, cFragments, pRvaFragment, pLenFragment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int getExports(IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaEnumSymbols**, int>)(lpVtbl[59]))((IDiaSession*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int getHeapAllocationSites(IDiaEnumSymbols** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaEnumSymbols**, int>)(lpVtbl[60]))((IDiaSession*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int findInputAssemblyFile(IDiaSymbol* pSymbol, IDiaInputAssemblyFile** ppResult)
        {
            return ((delegate* unmanaged<IDiaSession*, IDiaSymbol*, IDiaInputAssemblyFile**, int>)(lpVtbl[61]))((IDiaSession*)Unsafe.AsPointer(ref this), pSymbol, ppResult);
        }
    }
}
