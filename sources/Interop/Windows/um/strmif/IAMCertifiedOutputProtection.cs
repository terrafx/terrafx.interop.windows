// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6FEDED3E-0FF1-4901-A2F1-43F7012C8515")]
    [NativeTypeName("struct IAMCertifiedOutputProtection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMCertifiedOutputProtection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMCertifiedOutputProtection*, Guid*, void**, int>)(lpVtbl[0]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMCertifiedOutputProtection*, uint>)(lpVtbl[1]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMCertifiedOutputProtection*, uint>)(lpVtbl[2]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT KeyExchange([NativeTypeName("GUID *")] Guid* pRandom, [NativeTypeName("BYTE **")] byte** VarLenCertGH, [NativeTypeName("DWORD *")] uint* pdwLengthCertGH)
        {
            return ((delegate* unmanaged<IAMCertifiedOutputProtection*, Guid*, byte**, uint*, int>)(lpVtbl[3]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this), pRandom, VarLenCertGH, pdwLengthCertGH);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SessionSequenceStart(AMCOPPSignature* pSig)
        {
            return ((delegate* unmanaged<IAMCertifiedOutputProtection*, AMCOPPSignature*, int>)(lpVtbl[4]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this), pSig);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ProtectionCommand([NativeTypeName("const AMCOPPCommand *")] AMCOPPCommand* cmd)
        {
            return ((delegate* unmanaged<IAMCertifiedOutputProtection*, AMCOPPCommand*, int>)(lpVtbl[5]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this), cmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ProtectionStatus([NativeTypeName("const AMCOPPStatusInput *")] AMCOPPStatusInput* pStatusInput, AMCOPPStatusOutput* pStatusOutput)
        {
            return ((delegate* unmanaged<IAMCertifiedOutputProtection*, AMCOPPStatusInput*, AMCOPPStatusOutput*, int>)(lpVtbl[6]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this), pStatusInput, pStatusOutput);
        }
    }
}
