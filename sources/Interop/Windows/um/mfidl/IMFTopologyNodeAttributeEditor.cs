// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("676AA6DD-238A-410D-BB99-65668D01605A")]
    [NativeTypeName("struct IMFTopologyNodeAttributeEditor : IUnknown")]
    public unsafe partial struct IMFTopologyNodeAttributeEditor
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFTopologyNodeAttributeEditor*, Guid*, void**, int>)(lpVtbl[0]))((IMFTopologyNodeAttributeEditor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFTopologyNodeAttributeEditor*, uint>)(lpVtbl[1]))((IMFTopologyNodeAttributeEditor*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFTopologyNodeAttributeEditor*, uint>)(lpVtbl[2]))((IMFTopologyNodeAttributeEditor*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateNodeAttributes([NativeTypeName("TOPOID")] ulong TopoId, [NativeTypeName("DWORD")] uint cUpdates, [NativeTypeName("MFTOPONODE_ATTRIBUTE_UPDATE *")] MFTOPONODE_ATTRIBUTE_UPDATE* pUpdates)
        {
            return ((delegate* stdcall<IMFTopologyNodeAttributeEditor*, ulong, uint, MFTOPONODE_ATTRIBUTE_UPDATE*, int>)(lpVtbl[3]))((IMFTopologyNodeAttributeEditor*)Unsafe.AsPointer(ref this), TopoId, cUpdates, pUpdates);
        }
    }
}
