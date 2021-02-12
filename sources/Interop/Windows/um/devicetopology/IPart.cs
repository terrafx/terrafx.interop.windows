// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE2DE0E4-5BCA-4F2D-AA46-5D13F8FDB3A9")]
    [NativeTypeName("struct IPart : IUnknown")]
    public unsafe partial struct IPart
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPart*, Guid*, void**, int>)(lpVtbl[0]))((IPart*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPart*, uint>)(lpVtbl[1]))((IPart*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPart*, uint>)(lpVtbl[2]))((IPart*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetName([NativeTypeName("LPWSTR *")] ushort** ppwstrName)
        {
            return ((delegate* unmanaged<IPart*, ushort**, int>)(lpVtbl[3]))((IPart*)Unsafe.AsPointer(ref this), ppwstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocalId([NativeTypeName("UINT *")] uint* pnId)
        {
            return ((delegate* unmanaged<IPart*, uint*, int>)(lpVtbl[4]))((IPart*)Unsafe.AsPointer(ref this), pnId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlobalId([NativeTypeName("LPWSTR *")] ushort** ppwstrGlobalId)
        {
            return ((delegate* unmanaged<IPart*, ushort**, int>)(lpVtbl[5]))((IPart*)Unsafe.AsPointer(ref this), ppwstrGlobalId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPartType([NativeTypeName("PartType *")] PartType* pPartType)
        {
            return ((delegate* unmanaged<IPart*, PartType*, int>)(lpVtbl[6]))((IPart*)Unsafe.AsPointer(ref this), pPartType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSubType([NativeTypeName("GUID *")] Guid* pSubType)
        {
            return ((delegate* unmanaged<IPart*, Guid*, int>)(lpVtbl[7]))((IPart*)Unsafe.AsPointer(ref this), pSubType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetControlInterfaceCount([NativeTypeName("UINT *")] uint* pCount)
        {
            return ((delegate* unmanaged<IPart*, uint*, int>)(lpVtbl[8]))((IPart*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetControlInterface([NativeTypeName("UINT")] uint nIndex, [NativeTypeName("IControlInterface **")] IControlInterface** ppInterfaceDesc)
        {
            return ((delegate* unmanaged<IPart*, uint, IControlInterface**, int>)(lpVtbl[9]))((IPart*)Unsafe.AsPointer(ref this), nIndex, ppInterfaceDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumPartsIncoming([NativeTypeName("IPartsList **")] IPartsList** ppParts)
        {
            return ((delegate* unmanaged<IPart*, IPartsList**, int>)(lpVtbl[10]))((IPart*)Unsafe.AsPointer(ref this), ppParts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumPartsOutgoing([NativeTypeName("IPartsList **")] IPartsList** ppParts)
        {
            return ((delegate* unmanaged<IPart*, IPartsList**, int>)(lpVtbl[11]))((IPart*)Unsafe.AsPointer(ref this), ppParts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTopologyObject([NativeTypeName("IDeviceTopology **")] IDeviceTopology** ppTopology)
        {
            return ((delegate* unmanaged<IPart*, IDeviceTopology**, int>)(lpVtbl[12]))((IPart*)Unsafe.AsPointer(ref this), ppTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* refiid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPart*, uint, Guid*, void**, int>)(lpVtbl[13]))((IPart*)Unsafe.AsPointer(ref this), dwClsContext, refiid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterControlChangeCallback([NativeTypeName("const GUID &")] Guid* riid, [NativeTypeName("IControlChangeNotify *")] IControlChangeNotify* pNotify)
        {
            return ((delegate* unmanaged<IPart*, Guid*, IControlChangeNotify*, int>)(lpVtbl[14]))((IPart*)Unsafe.AsPointer(ref this), riid, pNotify);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterControlChangeCallback([NativeTypeName("IControlChangeNotify *")] IControlChangeNotify* pNotify)
        {
            return ((delegate* unmanaged<IPart*, IControlChangeNotify*, int>)(lpVtbl[15]))((IPart*)Unsafe.AsPointer(ref this), pNotify);
        }
    }
}
