// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8DED7393-5DB1-475C-9E71-A39111B0FF67")]
    [NativeTypeName("struct ITfDisplayAttributeMgr : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfDisplayAttributeMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfDisplayAttributeMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfDisplayAttributeMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfDisplayAttributeMgr*, uint>)(lpVtbl[1]))((ITfDisplayAttributeMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfDisplayAttributeMgr*, uint>)(lpVtbl[2]))((ITfDisplayAttributeMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnUpdateInfo()
        {
            return ((delegate* unmanaged<ITfDisplayAttributeMgr*, int>)(lpVtbl[3]))((ITfDisplayAttributeMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT EnumDisplayAttributeInfo(IEnumTfDisplayAttributeInfo** ppEnum)
        {
            return ((delegate* unmanaged<ITfDisplayAttributeMgr*, IEnumTfDisplayAttributeInfo**, int>)(lpVtbl[4]))((ITfDisplayAttributeMgr*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetDisplayAttributeInfo([NativeTypeName("const GUID &")] Guid* guid, ITfDisplayAttributeInfo** ppInfo, [NativeTypeName("CLSID *")] Guid* pclsidOwner)
        {
            return ((delegate* unmanaged<ITfDisplayAttributeMgr*, Guid*, ITfDisplayAttributeInfo**, Guid*, int>)(lpVtbl[5]))((ITfDisplayAttributeMgr*)Unsafe.AsPointer(ref this), guid, ppInfo, pclsidOwner);
        }
    }
}
