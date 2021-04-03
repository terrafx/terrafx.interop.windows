// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4F03DC02-5E6E-4653-8F72-A030C123D598")]
    [NativeTypeName("struct IAudioInputSelector : IUnknown")]
    public unsafe partial struct IAudioInputSelector
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioInputSelector*, Guid*, void**, int>)(lpVtbl[0]))((IAudioInputSelector*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioInputSelector*, uint>)(lpVtbl[1]))((IAudioInputSelector*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioInputSelector*, uint>)(lpVtbl[2]))((IAudioInputSelector*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelection([NativeTypeName("UINT *")] uint* pnIdSelected)
        {
            return ((delegate* unmanaged<IAudioInputSelector*, uint*, int>)(lpVtbl[3]))((IAudioInputSelector*)Unsafe.AsPointer(ref this), pnIdSelected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSelection([NativeTypeName("UINT")] uint nIdSelect, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioInputSelector*, uint, Guid*, int>)(lpVtbl[4]))((IAudioInputSelector*)Unsafe.AsPointer(ref this), nIdSelect, pguidEventContext);
        }
    }
}
