// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D25C30F9-4087-4366-9E24-E55BE286424B")]
    [NativeTypeName("struct DFileSystemImageImportEvents : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct DFileSystemImageImportEvents
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<DFileSystemImageImportEvents*, Guid*, void**, int>)(lpVtbl[0]))((DFileSystemImageImportEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<DFileSystemImageImportEvents*, uint>)(lpVtbl[1]))((DFileSystemImageImportEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<DFileSystemImageImportEvents*, uint>)(lpVtbl[2]))((DFileSystemImageImportEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<DFileSystemImageImportEvents*, uint*, int>)(lpVtbl[3]))((DFileSystemImageImportEvents*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<DFileSystemImageImportEvents*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((DFileSystemImageImportEvents*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<DFileSystemImageImportEvents*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((DFileSystemImageImportEvents*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<DFileSystemImageImportEvents*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((DFileSystemImageImportEvents*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT UpdateImport(IDispatch* @object, FsiFileSystems fileSystem, [NativeTypeName("BSTR")] ushort* currentItem, [NativeTypeName("LONG")] int importedDirectoryItems, [NativeTypeName("LONG")] int totalDirectoryItems, [NativeTypeName("LONG")] int importedFileItems, [NativeTypeName("LONG")] int totalFileItems)
        {
            return ((delegate* unmanaged<DFileSystemImageImportEvents*, IDispatch*, FsiFileSystems, ushort*, int, int, int, int, int>)(lpVtbl[7]))((DFileSystemImageImportEvents*)Unsafe.AsPointer(ref this), @object, fileSystem, currentItem, importedDirectoryItems, totalDirectoryItems, importedFileItems, totalFileItems);
        }
    }
}
