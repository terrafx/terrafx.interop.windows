// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct D3D12_ROOT_PARAMETER1
    {
        #region Fields
        public D3D12_ROOT_PARAMETER_TYPE ParameterType;

        public _Anonymous_e__Union Anonymous;

        public D3D12_SHADER_VISIBILITY ShaderVisibility;
        #endregion

        #region Structs
        [StructLayout(LayoutKind.Explicit)]
        [Unmanaged]
        public struct _Anonymous_e__Union
        {
            #region Fields
            [FieldOffset(0)]
            public D3D12_ROOT_DESCRIPTOR_TABLE1 DescriptorTable;

            [FieldOffset(0)]
            public D3D12_ROOT_CONSTANTS Constants;

            [FieldOffset(0)]
            public D3D12_ROOT_DESCRIPTOR1 Descriptor;
            #endregion
        }
        #endregion
    }
}
