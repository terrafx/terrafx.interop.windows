// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000013A-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IPropertySetStorage : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPropertySetStorage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertySetStorage*, Guid*, void**, int>)(lpVtbl[0]))((IPropertySetStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertySetStorage*, uint>)(lpVtbl[1]))((IPropertySetStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertySetStorage*, uint>)(lpVtbl[2]))((IPropertySetStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Create([NativeTypeName("const IID &")] Guid* rfmtid, [NativeTypeName("const CLSID *")] Guid* pclsid, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("DWORD")] uint grfMode, IPropertyStorage** ppprstg)
        {
            return ((delegate* unmanaged<IPropertySetStorage*, Guid*, Guid*, uint, uint, IPropertyStorage**, int>)(lpVtbl[3]))((IPropertySetStorage*)Unsafe.AsPointer(ref this), rfmtid, pclsid, grfFlags, grfMode, ppprstg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Open([NativeTypeName("const IID &")] Guid* rfmtid, [NativeTypeName("DWORD")] uint grfMode, IPropertyStorage** ppprstg)
        {
            return ((delegate* unmanaged<IPropertySetStorage*, Guid*, uint, IPropertyStorage**, int>)(lpVtbl[4]))((IPropertySetStorage*)Unsafe.AsPointer(ref this), rfmtid, grfMode, ppprstg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Delete([NativeTypeName("const IID &")] Guid* rfmtid)
        {
            return ((delegate* unmanaged<IPropertySetStorage*, Guid*, int>)(lpVtbl[5]))((IPropertySetStorage*)Unsafe.AsPointer(ref this), rfmtid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Enum(IEnumSTATPROPSETSTG** ppenum)
        {
            return ((delegate* unmanaged<IPropertySetStorage*, IEnumSTATPROPSETSTG**, int>)(lpVtbl[6]))((IPropertySetStorage*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
