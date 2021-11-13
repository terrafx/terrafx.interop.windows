// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("AE2DE0E4-5BCA-4F2D-AA46-5D13F8FDB3A9")]
    [NativeTypeName("struct IPart : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPart : IPart.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPart*, Guid*, void**, int>)(lpVtbl[0]))((IPart*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPart*, uint>)(lpVtbl[1]))((IPart*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPart*, uint>)(lpVtbl[2]))((IPart*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppwstrName)
        {
            return ((delegate* unmanaged<IPart*, ushort**, int>)(lpVtbl[3]))((IPart*)Unsafe.AsPointer(ref this), ppwstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetLocalId(uint* pnId)
        {
            return ((delegate* unmanaged<IPart*, uint*, int>)(lpVtbl[4]))((IPart*)Unsafe.AsPointer(ref this), pnId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetGlobalId([NativeTypeName("LPWSTR *")] ushort** ppwstrGlobalId)
        {
            return ((delegate* unmanaged<IPart*, ushort**, int>)(lpVtbl[5]))((IPart*)Unsafe.AsPointer(ref this), ppwstrGlobalId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetPartType(PartType* pPartType)
        {
            return ((delegate* unmanaged<IPart*, PartType*, int>)(lpVtbl[6]))((IPart*)Unsafe.AsPointer(ref this), pPartType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetSubType(Guid* pSubType)
        {
            return ((delegate* unmanaged<IPart*, Guid*, int>)(lpVtbl[7]))((IPart*)Unsafe.AsPointer(ref this), pSubType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetControlInterfaceCount(uint* pCount)
        {
            return ((delegate* unmanaged<IPart*, uint*, int>)(lpVtbl[8]))((IPart*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetControlInterface(uint nIndex, IControlInterface** ppInterfaceDesc)
        {
            return ((delegate* unmanaged<IPart*, uint, IControlInterface**, int>)(lpVtbl[9]))((IPart*)Unsafe.AsPointer(ref this), nIndex, ppInterfaceDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT EnumPartsIncoming(IPartsList** ppParts)
        {
            return ((delegate* unmanaged<IPart*, IPartsList**, int>)(lpVtbl[10]))((IPart*)Unsafe.AsPointer(ref this), ppParts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT EnumPartsOutgoing(IPartsList** ppParts)
        {
            return ((delegate* unmanaged<IPart*, IPartsList**, int>)(lpVtbl[11]))((IPart*)Unsafe.AsPointer(ref this), ppParts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetTopologyObject(IDeviceTopology** ppTopology)
        {
            return ((delegate* unmanaged<IPart*, IDeviceTopology**, int>)(lpVtbl[12]))((IPart*)Unsafe.AsPointer(ref this), ppTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Activate([NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* refiid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPart*, uint, Guid*, void**, int>)(lpVtbl[13]))((IPart*)Unsafe.AsPointer(ref this), dwClsContext, refiid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT RegisterControlChangeCallback([NativeTypeName("const GUID &")] Guid* riid, IControlChangeNotify* pNotify)
        {
            return ((delegate* unmanaged<IPart*, Guid*, IControlChangeNotify*, int>)(lpVtbl[14]))((IPart*)Unsafe.AsPointer(ref this), riid, pNotify);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT UnregisterControlChangeCallback(IControlChangeNotify* pNotify)
        {
            return ((delegate* unmanaged<IPart*, IControlChangeNotify*, int>)(lpVtbl[15]))((IPart*)Unsafe.AsPointer(ref this), pNotify);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** ppwstrName);

            [VtblIndex(4)]
            HRESULT GetLocalId(uint* pnId);

            [VtblIndex(5)]
            HRESULT GetGlobalId([NativeTypeName("LPWSTR *")] ushort** ppwstrGlobalId);

            [VtblIndex(6)]
            HRESULT GetPartType(PartType* pPartType);

            [VtblIndex(7)]
            HRESULT GetSubType(Guid* pSubType);

            [VtblIndex(8)]
            HRESULT GetControlInterfaceCount(uint* pCount);

            [VtblIndex(9)]
            HRESULT GetControlInterface(uint nIndex, IControlInterface** ppInterfaceDesc);

            [VtblIndex(10)]
            HRESULT EnumPartsIncoming(IPartsList** ppParts);

            [VtblIndex(11)]
            HRESULT EnumPartsOutgoing(IPartsList** ppParts);

            [VtblIndex(12)]
            HRESULT GetTopologyObject(IDeviceTopology** ppTopology);

            [VtblIndex(13)]
            HRESULT Activate([NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* refiid, void** ppvObject);

            [VtblIndex(14)]
            HRESULT RegisterControlChangeCallback([NativeTypeName("const GUID &")] Guid* riid, IControlChangeNotify* pNotify);

            [VtblIndex(15)]
            HRESULT UnregisterControlChangeCallback(IControlChangeNotify* pNotify);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, uint> Release;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, ushort**, int> GetName;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, uint*, int> GetLocalId;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, ushort**, int> GetGlobalId;

            [NativeTypeName("HRESULT (PartType *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, PartType*, int> GetPartType;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, Guid*, int> GetSubType;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, uint*, int> GetControlInterfaceCount;

            [NativeTypeName("HRESULT (UINT, IControlInterface **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, uint, IControlInterface**, int> GetControlInterface;

            [NativeTypeName("HRESULT (IPartsList **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, IPartsList**, int> EnumPartsIncoming;

            [NativeTypeName("HRESULT (IPartsList **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, IPartsList**, int> EnumPartsOutgoing;

            [NativeTypeName("HRESULT (IDeviceTopology **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, IDeviceTopology**, int> GetTopologyObject;

            [NativeTypeName("HRESULT (DWORD, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, uint, Guid*, void**, int> Activate;

            [NativeTypeName("HRESULT (const GUID &, IControlChangeNotify *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, Guid*, IControlChangeNotify*, int> RegisterControlChangeCallback;

            [NativeTypeName("HRESULT (IControlChangeNotify *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPart*, IControlChangeNotify*, int> UnregisterControlChangeCallback;
        }
    }
}
