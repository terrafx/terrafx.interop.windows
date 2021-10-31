// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D25F6D6-4B2A-433C-9184-7C33AD35D001")]
    [NativeTypeName("struct IDataObjectProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDataObjectProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDataObjectProvider*, Guid*, void**, int>)(lpVtbl[0]))((IDataObjectProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDataObjectProvider*, uint>)(lpVtbl[1]))((IDataObjectProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDataObjectProvider*, uint>)(lpVtbl[2]))((IDataObjectProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDataObject(IDataObject** dataObject)
        {
            return ((delegate* unmanaged<IDataObjectProvider*, IDataObject**, int>)(lpVtbl[3]))((IDataObjectProvider*)Unsafe.AsPointer(ref this), dataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetDataObject(IDataObject* dataObject)
        {
            return ((delegate* unmanaged<IDataObjectProvider*, IDataObject*, int>)(lpVtbl[4]))((IDataObjectProvider*)Unsafe.AsPointer(ref this), dataObject);
        }
    }
}
