﻿/*
 *  Pkcs11Interop - Open-source .NET wrapper for unmanaged PKCS#11 libraries
 *  Copyright (C) 2012 Jaroslav Imrich <jimrich(at)jimrich(dot)sk>
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License version 3
 *  as published by the Free Software Foundation.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
 *  If this license does not suit your needs you can purchase a commercial
 *  license from Pkcs11Interop author.
 */

using System;
using System.Runtime.InteropServices;

namespace Net.Pkcs11Interop.LowLevelAPI.MechanismParams
{
    /// <summary>
    /// Structure that provides the parameters to the CKM_WTLS_SERVER_KEY_AND_MAC_DERIVE and the CKM_WTLS_CLIENT_KEY_AND_MAC_DERIVE mechanisms
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public struct CK_WTLS_KEY_MAT_PARAMS
    {
        /// <summary>
        /// The digest mechanism to be used (CKM)
        /// </summary>
        public uint DigestMechanism;

        /// <summary>
        /// The length (in bits) of the MACing key agreed upon during the protocol handshake phase
        /// </summary>
        public uint MacSizeInBits;

        /// <summary>
        /// The length (in bits) of the secret key agreed upon during the handshake phase
        /// </summary>
        public uint KeySizeInBits;

        /// <summary>
        /// The length (in bits) of the IV agreed upon during the handshake phase or if no IV is required, the length should be set to 0
        /// </summary>
        public uint IVSizeInBits;

        /// <summary>
        /// The current sequence number used for records sent by the client and server respectively
        /// </summary>
        public uint SequenceNumber;

        /// <summary>
        /// Flag which indicates whether the keys have to be derived for an export version of the protocol
        /// </summary>
        public bool IsExport;

        /// <summary>
        /// Client's and server's random data information
        /// </summary>
        public CK_WTLS_RANDOM_DATA RandomInfo;

        /// <summary>
        /// Points to a CK_WTLS_KEY_MAT_OUT structure which receives the handles for the keys generated and the IV
        /// </summary>
        public IntPtr ReturnedKeyMaterial;
    }
}
