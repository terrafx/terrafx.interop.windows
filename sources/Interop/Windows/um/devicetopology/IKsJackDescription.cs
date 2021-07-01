// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4509F757-2D46-4637-8E62-CE7DB944F57B")]
    [NativeTypeName("struct IKsJackDescription : IUnknown")]
    public unsafe partial struct IKsJackDescription
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IKsJackDescription*, Guid*, void**, int>)(lpVtbl[0]))((IKsJackDescription*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKsJackDescription*, uint>)(lpVtbl[1]))((IKsJackDescription*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKsJackDescription*, uint>)(lpVtbl[2]))((IKsJackDescription*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetJackCount([NativeTypeName("UINT *")] uint* pcJacks)
        {
            return ((delegate* unmanaged<IKsJackDescription*, uint*, int>)(lpVtbl[3]))((IKsJackDescription*)Unsafe.AsPointer(ref this), pcJacks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetJackDescription([NativeTypeName("UINT")] uint nJack, KSJACK_DESCRIPTION* pDescription)
        {
            return ((delegate* unmanaged<IKsJackDescription*, uint, KSJACK_DESCRIPTION*, int>)(lpVtbl[4]))((IKsJackDescription*)Unsafe.AsPointer(ref this), nJack, pDescription);
        }
    }
}
