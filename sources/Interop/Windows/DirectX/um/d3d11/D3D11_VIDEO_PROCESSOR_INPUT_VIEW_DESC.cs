// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX
{
    [SupportedOSPlatform("windows8.0")]
    public partial struct D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC
    {
        public uint FourCC;

        public D3D11_VPIV_DIMENSION ViewDimension;

        [NativeTypeName("D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/d3d11.h:11814:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref D3D11_TEX2D_VPIV Texture2D
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Texture2D, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D11_TEX2D_VPIV Texture2D;
        }
    }
}
