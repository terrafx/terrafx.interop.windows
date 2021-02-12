// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C7A6F54F-B180-416F-B2BF-7BF2E4683D7B")]
    [NativeTypeName("struct ITfIntegratableCandidateListUIElement : IUnknown")]
    public unsafe partial struct ITfIntegratableCandidateListUIElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, Guid*, void**, int>)(lpVtbl[0]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, uint>)(lpVtbl[1]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, uint>)(lpVtbl[2]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIntegrationStyle([NativeTypeName("GUID")] Guid guidIntegrationStyle)
        {
            return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, Guid, int>)(lpVtbl[3]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this), guidIntegrationStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelectionStyle([NativeTypeName("TfIntegratableCandidateListSelectionStyle *")] TfIntegratableCandidateListSelectionStyle* ptfSelectionStyle)
        {
            return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, TfIntegratableCandidateListSelectionStyle*, int>)(lpVtbl[4]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this), ptfSelectionStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnKeyDown([NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("BOOL *")] int* pfEaten)
        {
            return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, nuint, nint, int*, int>)(lpVtbl[5]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this), wParam, lParam, pfEaten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShowCandidateNumbers([NativeTypeName("BOOL *")] int* pfShow)
        {
            return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, int*, int>)(lpVtbl[6]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this), pfShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FinalizeExactCompositionString()
        {
            return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, int>)(lpVtbl[7]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this));
        }
    }
}
