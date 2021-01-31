// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

#pragma warning disable CS0465

using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public unsafe partial struct PathData
    {
        public void Finalize()
        {
            if (Points != null)
            {
                free(Points);
            }

            if (Types != null)
            {
                free(Types);
            }
        }
    }
}
