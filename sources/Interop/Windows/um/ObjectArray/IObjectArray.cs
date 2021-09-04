// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjectArray.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("92CA9DCD-5622-4BBA-A805-5E9F541BD8C9")]
    [NativeTypeName("struct IObjectArray : IUnknown")]
    public unsafe partial struct IObjectArray
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IObjectArray*, Guid*, void**, int>)(lpVtbl[0]))((IObjectArray*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IObjectArray*, uint>)(lpVtbl[1]))((IObjectArray*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IObjectArray*, uint>)(lpVtbl[2]))((IObjectArray*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* pcObjects)
        {
            return ((delegate* unmanaged<IObjectArray*, uint*, int>)(lpVtbl[3]))((IObjectArray*)Unsafe.AsPointer(ref this), pcObjects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAt([NativeTypeName("UINT")] uint uiIndex, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IObjectArray*, uint, Guid*, void**, int>)(lpVtbl[4]))((IObjectArray*)Unsafe.AsPointer(ref this), uiIndex, riid, ppv);
        }
    }
}
