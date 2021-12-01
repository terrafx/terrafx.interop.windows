// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='BasicType.xml' path='doc/member[@name="BasicType"]/*' />
public enum BasicType
{
    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btNoType"]/*' />
    btNoType = 0,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btVoid"]/*' />
    btVoid = 1,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btChar"]/*' />
    btChar = 2,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btWChar"]/*' />
    btWChar = 3,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btInt"]/*' />
    btInt = 6,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btUInt"]/*' />
    btUInt = 7,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btFloat"]/*' />
    btFloat = 8,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btBCD"]/*' />
    btBCD = 9,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btBool"]/*' />
    btBool = 10,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btLong"]/*' />
    btLong = 13,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btULong"]/*' />
    btULong = 14,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btCurrency"]/*' />
    btCurrency = 25,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btDate"]/*' />
    btDate = 26,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btVariant"]/*' />
    btVariant = 27,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btComplex"]/*' />
    btComplex = 28,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btBit"]/*' />
    btBit = 29,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btBSTR"]/*' />
    btBSTR = 30,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btHresult"]/*' />
    btHresult = 31,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btChar16"]/*' />
    btChar16 = 32,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btChar32"]/*' />
    btChar32 = 33,

    /// <include file='BasicType.xml' path='doc/member[@name="BasicType.btChar8"]/*' />
    btChar8 = 34,
}
