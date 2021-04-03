// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2C941FDC-975B-59BE-A960-9A2A262853A5")]
    [NativeTypeName("struct IFsiDirectoryItem : IFsiItem")]
    public unsafe partial struct IFsiDirectoryItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, Guid*, void**, int>)(lpVtbl[0]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, uint>)(lpVtbl[1]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, uint>)(lpVtbl[2]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, uint*, int>)(lpVtbl[3]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, ushort**, int>)(lpVtbl[7]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FullPath([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, ushort**, int>)(lpVtbl[8]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CreationTime([NativeTypeName("DATE *")] double* pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, double*, int>)(lpVtbl[9]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CreationTime([NativeTypeName("DATE")] double newVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, double, int>)(lpVtbl[10]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LastAccessedTime([NativeTypeName("DATE *")] double* pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, double*, int>)(lpVtbl[11]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_LastAccessedTime([NativeTypeName("DATE")] double newVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, double, int>)(lpVtbl[12]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LastModifiedTime([NativeTypeName("DATE *")] double* pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, double*, int>)(lpVtbl[13]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_LastModifiedTime([NativeTypeName("DATE")] double newVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, double, int>)(lpVtbl[14]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsHidden([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, short*, int>)(lpVtbl[15]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_IsHidden([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, short, int>)(lpVtbl[16]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FileSystemName(FsiFileSystems fileSystem, [NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, FsiFileSystems, ushort**, int>)(lpVtbl[17]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), fileSystem, pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FileSystemPath(FsiFileSystems fileSystem, [NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, FsiFileSystems, ushort**, int>)(lpVtbl[18]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), fileSystem, pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get__NewEnum(IEnumVARIANT** NewEnum)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, IEnumVARIANT**, int>)(lpVtbl[19]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), NewEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Item([NativeTypeName("BSTR")] ushort* path, IFsiItem** item)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, ushort*, IFsiItem**, int>)(lpVtbl[20]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), path, item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Count([NativeTypeName("LONG *")] int* Count)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, int*, int>)(lpVtbl[21]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_EnumFsiItems(IEnumFsiItems** NewEnum)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, IEnumFsiItems**, int>)(lpVtbl[22]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), NewEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddDirectory([NativeTypeName("BSTR")] ushort* path)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, ushort*, int>)(lpVtbl[23]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), path);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddFile([NativeTypeName("BSTR")] ushort* path, IStream* fileData)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, ushort*, IStream*, int>)(lpVtbl[24]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), path, fileData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddTree([NativeTypeName("BSTR")] ushort* sourceDirectory, [NativeTypeName("VARIANT_BOOL")] short includeBaseDirectory)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, ushort*, short, int>)(lpVtbl[25]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), sourceDirectory, includeBaseDirectory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Add(IFsiItem* item)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, IFsiItem*, int>)(lpVtbl[26]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Remove([NativeTypeName("BSTR")] ushort* path)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, ushort*, int>)(lpVtbl[27]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), path);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveTree([NativeTypeName("BSTR")] ushort* path)
        {
            return ((delegate* unmanaged<IFsiDirectoryItem*, ushort*, int>)(lpVtbl[28]))((IFsiDirectoryItem*)Unsafe.AsPointer(ref this), path);
        }
    }
}
