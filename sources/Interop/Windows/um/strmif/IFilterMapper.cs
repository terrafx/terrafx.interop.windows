// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868A3-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IFilterMapper : IUnknown")]
    public unsafe partial struct IFilterMapper
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IFilterMapper*, Guid*, void**, int>)(lpVtbl[0]))((IFilterMapper*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IFilterMapper*, uint>)(lpVtbl[1]))((IFilterMapper*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IFilterMapper*, uint>)(lpVtbl[2]))((IFilterMapper*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterFilter([NativeTypeName("CLSID")] Guid clsid, [NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("DWORD")] uint dwMerit)
        {
            return ((delegate* stdcall<IFilterMapper*, Guid, ushort*, uint, int>)(lpVtbl[3]))((IFilterMapper*)Unsafe.AsPointer(ref this), clsid, Name, dwMerit);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterFilterInstance([NativeTypeName("CLSID")] Guid clsid, [NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("CLSID *")] Guid* MRId)
        {
            return ((delegate* stdcall<IFilterMapper*, Guid, ushort*, Guid*, int>)(lpVtbl[4]))((IFilterMapper*)Unsafe.AsPointer(ref this), clsid, Name, MRId);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterPin([NativeTypeName("CLSID")] Guid Filter, [NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("BOOL")] int bRendered, [NativeTypeName("BOOL")] int bOutput, [NativeTypeName("BOOL")] int bZero, [NativeTypeName("BOOL")] int bMany, [NativeTypeName("CLSID")] Guid ConnectsToFilter, [NativeTypeName("LPCWSTR")] ushort* ConnectsToPin)
        {
            return ((delegate* stdcall<IFilterMapper*, Guid, ushort*, int, int, int, int, Guid, ushort*, int>)(lpVtbl[5]))((IFilterMapper*)Unsafe.AsPointer(ref this), Filter, Name, bRendered, bOutput, bZero, bMany, ConnectsToFilter, ConnectsToPin);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterPinType([NativeTypeName("CLSID")] Guid clsFilter, [NativeTypeName("LPCWSTR")] ushort* strName, [NativeTypeName("CLSID")] Guid clsMajorType, [NativeTypeName("CLSID")] Guid clsSubType)
        {
            return ((delegate* stdcall<IFilterMapper*, Guid, ushort*, Guid, Guid, int>)(lpVtbl[6]))((IFilterMapper*)Unsafe.AsPointer(ref this), clsFilter, strName, clsMajorType, clsSubType);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterFilter([NativeTypeName("CLSID")] Guid Filter)
        {
            return ((delegate* stdcall<IFilterMapper*, Guid, int>)(lpVtbl[7]))((IFilterMapper*)Unsafe.AsPointer(ref this), Filter);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterFilterInstance([NativeTypeName("CLSID")] Guid MRId)
        {
            return ((delegate* stdcall<IFilterMapper*, Guid, int>)(lpVtbl[8]))((IFilterMapper*)Unsafe.AsPointer(ref this), MRId);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterPin([NativeTypeName("CLSID")] Guid Filter, [NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* stdcall<IFilterMapper*, Guid, ushort*, int>)(lpVtbl[9]))((IFilterMapper*)Unsafe.AsPointer(ref this), Filter, Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumMatchingFilters([NativeTypeName("IEnumRegFilters **")] IEnumRegFilters** ppEnum, [NativeTypeName("DWORD")] uint dwMerit, [NativeTypeName("BOOL")] int bInputNeeded, [NativeTypeName("CLSID")] Guid clsInMaj, [NativeTypeName("CLSID")] Guid clsInSub, [NativeTypeName("BOOL")] int bRender, [NativeTypeName("BOOL")] int bOututNeeded, [NativeTypeName("CLSID")] Guid clsOutMaj, [NativeTypeName("CLSID")] Guid clsOutSub)
        {
            return ((delegate* stdcall<IFilterMapper*, IEnumRegFilters**, uint, int, Guid, Guid, int, int, Guid, Guid, int>)(lpVtbl[10]))((IFilterMapper*)Unsafe.AsPointer(ref this), ppEnum, dwMerit, bInputNeeded, clsInMaj, clsInSub, bRender, bOututNeeded, clsOutMaj, clsOutSub);
        }
    }
}
